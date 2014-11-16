using System;
using System.Reflection;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace POP3
{
	public class FileDoesNotExist : Exception { }

	public abstract class Model<T> : IModel where T:Model<T> 
	{
		protected Guid id = Guid.Empty;
		protected static IList<T> ModelContainer = null;

		protected static String Filename {
			get {
				// Get the name of the current instance type
				String type = typeof(T).Name;

				// Return the instance class name with json extension
				return type + ".json";
			}
		}

		public Guid Id { 
			get { return this.id; }
			set { this.id = value; }
		}

		public Model ()
		{
			// Check if the instance identifier has not been created
			if (this.id == Guid.Empty) {
				// Create a new Id for the instance
				this.id = Guid.NewGuid ();
			} 

			// Check if the model container exists
			if (Model<T>.ModelContainer == null) {
				// Create a new model container
				Model<T>.ModelContainer = new List<T> ();
			}

			// Add the new instance to the model container
			Model<T>.ModelContainer.Add ((T) this);
		}

		/// <summary>
		/// Serialize this instance.
		/// </summary>
		public String Serialize ()
		{
			// Return the current instance as a serialized as a json object
			return JsonConvert.SerializeObject (this);
		}
			
		/// <summary>
		/// Deserialize the specified data.
		/// 
		/// NOTE: Since Xamarin does not support dynamic typing.
		/// </summary>
		/// <param name="data">Data.</param>
		public static T Deserialize (String data)
		{
			// Return a new instance for the type
			return (T) JsonConvert.DeserializeObject (data, typeof(T));
		}

		public static void Save () {
			// Get the filename (base on the actual type name)
			String target = Model<T>.Filename;

			// Serialize the instances of the actual model
			String data = JsonConvert.SerializeObject (Model<T>.getInstances (), Formatting.Indented);

			// Write the serialization into the target file
			System.IO.File.WriteAllText (target, data);

			// TODO: Create seralization specifications
		}

		public static void Load ()
		{
			// Get the filename (base on the actual type name)
			String target = Model<T>.Filename;

			// Check if the file indeed exists
			if (! System.IO.File.Exists (Model<T>.Filename)) {
				// Throw that the file do not exists exception
				throw new FileDoesNotExist ();
			}

			// Read the file seralized list of objects
			String serializedData = System.IO.File.ReadAllText (Model<T>.Filename);

			IList<T> instancesList = JsonConvert.DeserializeObject<IList<T>> (serializedData);

			Model<T>.setInstances (instancesList); 
			// TODO: Loop through the list and deseralize each data
			// TODO: Create deseralization specifications
		}

		public static IList<T> getInstances ()
		{
			if (Model<T>.ModelContainer == null) {
				return new List<T> ();
			}

			return Model<T>.ModelContainer;
		}

		public static void setInstances (IList<T> instancesList) 
		{
			Model<T>.ModelContainer = instancesList;
		}

		public static T GetBy (String filter, Object value)
		{
			foreach (T instance in Model<T>.getInstances()) {
				if (instance.GetType ().GetProperty (filter).GetValue (instance, null).Equals (value)) {
					return instance;
				}
			}

			return null;
		}

        public static IList<T> FilterBy(String filter, Object value)
        {
            // Initialize the result as an empty list of instances.
            IList<T> result = new List<T> ();

            // For each instance in the instances list for the current model.
            foreach (T instance in Model<T>.getInstances()) {
                // Check if the instances filtered by attribute equals to the required value.
                if (instance.GetType().GetProperty(filter).GetValue(instance, null).Equals(value)) {
                    // Append the instance to the result list.
                    result.Add (instance);
                }
            }

            // Return the result list.
            return result;
        }

        public static IList<T> FilterBy(Dictionary<String, Object> filterBy)
        {
            // Initialize the result as an empty list of instances.
            IList<T> result = new List<T>();

            // For each instance in the instances list for the current model.
            foreach (T instance in Model<T>.getInstances()) {
                foreach (KeyValuePair<String, Object> filter in filterBy) {
                    // Check if the instances filtered by attribute equals to the required value.
                    if (instance.GetType().GetProperty(filter.Key).GetValue(instance, null).Equals(filter.Value)) {
                        // Append the instance to the result list.
                        result.Add(instance);
                    }    
                }
            }

            // Return the result list.
            return result;
        }
	}
}

