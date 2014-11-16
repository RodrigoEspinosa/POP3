using System;

using Newtonsoft.Json;

using POP3;

namespace POP3
{
    public class Visit : Model<Visit>
    {
        private IProperty property;
        private IClient client;

        public Guid PropertyId
        {
            get { return this.property.Id; }
            set
            {
                House tryHouse = Model<House>.GetBy("Id", value);
                if (tryHouse != null) {
                    this.property = tryHouse;
                } else {
                    this.property = Model<Apartament>.GetBy("Id", value);
                }
            }
        }

        [JsonIgnore]
        public IProperty Property
        {
            get { return property; }
            set { property = value; }
        }

        public Guid ClientId
        {
            get { return this.client.Id; }
            set
            {
                this.client = Model<Client>.GetBy("Id", value);
            }
        }

        [JsonIgnore]
        public IClient Client
        {
            get { return client; }
            set { client = value; }
        }
    }
}
