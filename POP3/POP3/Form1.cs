using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

using MetroFramework.Forms;
using MetroFramework.Controls;
using POP3;
using POP3.AuxiliaryClases;

namespace POP3
{
    public partial class MainWindow : MetroForm
    {
        public MainWindow()
        {
            // Default initialize.
            InitializeComponent();

            // Fill the combo boxes.
            FillComboBoxes();
            
            // Sets the default pictures.
            SetDefaultPictures();

            // Refresh the combo boxes.
            RefreshComboBoxes();

            //Sort.PopulateGrid(Model<Apartament>.getInstances());
        }
       
        /// <summary>
        /// Creates the property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finishButton_Click(object sender, EventArgs e)
        {
            //Creates the property based on the given information.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Opens a file dialog and make a preview of the select image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectImageButton_Click(object sender, EventArgs e)
        {
            FileExplorer.Open(propertyPictureBox);
        }

        /// <summary>
        /// Enables/Disable the galleryDormitoriyComboBox depending
        /// on the galleryDormitoriyCheckBox "cheked" state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsDormitoriyFilter_Cheked(object sender, EventArgs e)
        {
            if (galleryDormitoryCheckBox.Checked)
            {
                galleryDormitoryComboBox.Visible = true;
            }
            else
            {
                galleryDormitoryComboBox.Visible = false;
            }
        }

        /// <summary>
        /// Enables/Disable the galleryNeighborhoodComboBox depending
        /// on the galleryNeighborhoodCheckBox "cheked" state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsNeighborhoodFilter_Cheked(object sender, EventArgs e)
        {
            if (galleryNeighborhoodCheckBox.Checked)
            {
                galleryNeighborhoodComboBox.Visible = true;
            }
            else
            {
                galleryNeighborhoodComboBox.Visible = false;
            }
        }

        /// <summary>
        /// Makes Visible the galleryGarageComboBox if the galleryGarageFilter is cheked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsGarageFilter_Check(object sender, EventArgs e)
        {

            if (galleryGarageCheckBox.Checked) {
                galleryGarageComboBox.Visible = true;
            } else {
                galleryGarageComboBox.Visible = false;
            }
        }

        /// <summary>
        /// Enables/Disable the galleryCountryComboBox depending
        /// on the galleryCountryCheckBox "cheked" state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsCountryFilter_Cheked(object sender, EventArgs e)
        {
            if (galleryCountryCheckBox.Checked) {
                galleryCountryComboBox.Visible = true;
            } else {
                galleryCountryComboBox.Visible = false;
            }
        }

        /// <summary>
        /// Enable/Disable the visibility of Min-Max Price Combobox depending
        /// on the "Cheked" state of the galleryPriceRangeCheckBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsPriceRangeFilter_Cheked(object sender, EventArgs e)
        {
            if (galleryPriceRangeCheckBox.Checked)
            {
                galleryMinPriceComboBox.Visible = true;
                galleryMaxPriceComboBox.Visible = true;
            }
            else
            {
                galleryMinPriceComboBox.Visible = false;
                galleryMaxPriceComboBox.Visible = false;
            }
        }

        /// <summary>
        /// Show / Hides country ComboBox/Text Box in the
        /// location tab depending on the country toogle value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locCountryToogle_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        /// <summary>
        /// Show / Hides state ComboBox/Text Box in the
        /// location tab depending on the state toogle value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locStateToogle_Scroll(object sender, ScrollEventArgs e)
        {
            LocationAux.ShowHideLocationControls(locStateComboBox, locStateTextBox, stateToogle);
        }

        /// <summary>
        /// Shows/Hides city ComboBox/Text Box in the
        /// location tab depending on the city toogle value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locCityToogle_Scroll(object sender, ScrollEventArgs e)
        {
            LocationAux.ShowHideLocationControls(locCityComboBox, locCityTextBox, cityToogle);
        }

        /// <summary>
        /// Shows/Hides garden/floors label 
        /// depending on the selected value of the 
        /// propertyTypeComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void propertyTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (propertyTypeComboBox.SelectedItem.ToString() == "Apartament") {
                apartamentNumber.Visible = true;
                gardenLabel.Visible = false;
                floorsLabel.Visible = true;
                floorsTextBox.Visible = true;
                gardenCheckBox.Checked = false;
            } else {
                apartamentNumber.Visible = false;
                apartamentNumber.Text = "";
                gardenLabel.Visible = true;
                floorsLabel.Visible = false;
                floorsTextBox.Visible = false;
                floorsTextBox.Text = "";
            }
        }

        /// <summary>
        /// Shows/Hides the house dataGrid modifications tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void modificationComboBox_SelectionChangeCommitted(object sender, EventArgs e)
       {
        
       }

        // The functions start here.

        /// <summary>
        /// Set the default pictures to the picture boxes.
        /// </summary>
        private void SetDefaultPictures()
        {
            //Set the default picture to an initial image.
            propertyPictureBox.Image = propertyPictureBox.InitialImage;
            clientPictureBox.Image = clientPictureBox.InitialImage;
        }

        /// <summary>
        /// Open file explorer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectClientAvatar_Click(object sender, EventArgs e)
        {
            FileExplorer.Open(clientPictureBox);
        }

        /// <summary>
        /// Creates a location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createLocationButton_Click(object sender, EventArgs e)
        {
            String country;
            String state;
            String city;
            
            try {
                country = LocationAux.GetLocationName(locCountryComboBox, locCountryTextBox);
                state = LocationAux.GetLocationName(locStateComboBox, locStateTextBox);
                city = LocationAux.GetLocationName(locCityComboBox, locCityTextBox);
                
                if (!LocationAux.TextBoxIsEmpty(locNeighborhoodTextBox)) {
                    new Neighborhood(
                        locNeighborhoodTextBox.Text,
                        City.GetOrCreate(
                            city,
                            State.GetOrCreate(state, Country.GetOrCreate (country))
                        )
                    );
                    ValidationSuccess.Show("Location successfuly created!");
                    
                    Neighborhood.Save();
                    City.Save();
                    State.Save();
                    Country.Save();
                    
                    countryToogle.Value = 0;
                    stateToogle.Value = 0;
                    cityToogle.Value = 0;
                    RefreshComboBoxes();
                } else {
                    ValidationError.Show(Owner, "Please fill all the input fields.");
                }
                
            } catch (Exception) {
                ValidationError.Show(Owner);
                return;
            }
        }

        /// <summary>
        /// Creates a client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientFinishButton_Click(object sender, EventArgs e)
        {
            CreateClient();
        }

        /// <summary>
        /// Controls a posible Format Exception.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modHouseDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ValidationError.Show("The input isn't in the right format.");
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void floorsTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(floorsTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(clientNameTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientIdTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(clientIdTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(clientPhoneTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Verify.String(clientNameTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(locCountryTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locStateTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(locStateTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locCityTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(locCityTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locNeighborhoodTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(locNeighborhoodTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void squareMeterTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(squareMeterTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void apartamentNumber_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(apartamentNumber);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doorNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(doorNumberTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(sideStreetTextBox);
        }

        /// <summary>
        /// Verify whether the text
        /// is numeric or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(mainStreetTextBox);
        }

        /// <summary>
        /// Creates a Apartament or a House
        /// depending on the case.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPropertyFinishButton_Click(object sender, EventArgs e)
        {
            CreateProperty();
        }

        private void countryToogle_Scroll(object sender, ScrollEventArgs e)
        {
            LocationAux.ShowHideLocationControls(locCountryComboBox, locCountryTextBox, countryToogle);
        }

        /// <summary>
        /// Refresh the combo boxes with the new data.
        /// </summary>
        private void RefreshComboBoxes()
        {
            // Clear every combo box.
            locCountryComboBox.Items.Clear();
            locStateComboBox.Items.Clear();
            locCityComboBox.Items.Clear();
            neighborhoodComboBox.Items.Clear();
            clientNeighborhoodComboBox.Items.Clear();
            ownerComboBox.Items.Clear();

            // Fill country combo boxes.
            foreach (Country country in Model<Country>.getInstances())
            {
                locCountryComboBox.Items.Add(country.Name);
            }

            // Fill state combo boxes.
            foreach (State state in Model<State>.getInstances())
            {
                locStateComboBox.Items.Add(state.Name);
            }

            // Fill the city combo boxes.
            foreach (City city in Model<City>.getInstances())
            {
                locCityComboBox.Items.Add(city.Name);
            }

            // Fill neighborhood combo boxes.
            foreach (Neighborhood nei in Model<Neighborhood>.getInstances())
            {
                neighborhoodComboBox.Items.Add(nei.Name);
                clientNeighborhoodComboBox.Items.Add(nei.Name);
            }

            // Fill the client combo boxes.
            foreach (Client client in Model<Client>.getInstances())
            {
                ownerComboBox.Items.Add(client);
            }
            
        }

        /// <summary>
        /// Fills combo boxes.
        /// </summary>
        private void FillComboBoxes()
        {
            // Fill the visits combo box.
            visitComboBox.Items.Add("Client");
            visitComboBox.Items.Add("Property");

            // Fill the propertyTypeComboBox.
            propertyTypeComboBox.Items.Add("Apartament");
            propertyTypeComboBox.Items.Add("House");

            // Fills the builtYearComboBox
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                builtYearComboBox.Items.Add(i);
            }

            // Fill the comboBoxes.
            for (int i = 0; i < 10; i++)
            {
                bedroomComboBox.Items.Add(i);
                bathroomComboBox.Items.Add(i);
                garageComboBox.Items.Add(i);
                galleryGarageComboBox.Items.Add(i);
                galleryDormitoryComboBox.Items.Add(i);
            }

            // Add a "10+" option to some ComboBoxes.
            bedroomComboBox.Items.Add("10+");
            bathroomComboBox.Items.Add("10+");
            garageComboBox.Items.Add("10+");
            galleryDormitoryComboBox.Items.Add("10+");

            // Add some prices to the Min-Max price ComboBox.
            for (int i = 0; i <= 1000000; i += 50000)
            {
                galleryMinPriceComboBox.Items.Add(i);
                galleryMaxPriceComboBox.Items.Add(i);
            }

            // Creates a list of conditions.
            List<String> listOfConditions = new List<String>(new String[] {"Destroyed",
                                                                            "Bad",
                                                                            "Not that bad",
                                                                            "Normal",
                                                                            "Good",
                                                                            "Very Good",
                                                                            "Excellent"});
            // Fill ComboBox with list of conditions.
            foreach (String condition in listOfConditions)
            {
                conditionComboBox.Items.Add(condition);
            }

            // Fill modificationComboBox with the modificable fields.
            modificationsComboBox.Items.Add("House");
            modificationsComboBox.Items.Add("Apartament");
            modificationsComboBox.Items.Add("Client");
            modificationsComboBox.Items.Add("Location");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cityToogle_ValueChanged(object sender, EventArgs e)
        {
            LocationAux.ShowHideLocationControls(locCityComboBox, locCityTextBox, cityToogle);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countryToogle_ValueChanged(object sender, EventArgs e)
        {
            LocationAux.ShowHideLocationControls(locCountryComboBox, locCountryTextBox, countryToogle);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stateToogle_ValueChanged(object sender, EventArgs e)
        {
            LocationAux.ShowHideLocationControls(locStateComboBox, locStateTextBox, stateToogle);
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshInputs()
        {
            // Refresh the property form inputs.
            mainStreetTextBox.Refresh();
            sideStreetTextBox.Refresh();
            doorNumberTextBox.Refresh();
            apartamentNumber.Refresh();
            neighborhoodComboBox.Refresh();
            builtYearComboBox.Refresh();
            squareMeterTextBox.Refresh();
            bedroomComboBox.Refresh();
            bathroomComboBox.Refresh();
            garageComboBox.Refresh();
            conditionComboBox.Refresh();
            ownerComboBox.Refresh();
            floorsTextBox.Refresh();
            forSaleCheckBox.Checked = false;
            forRentCheckBox.Checked = false;
            gardenCheckBox.Checked = false;

            // Refresh the new client form inputs.
            clientNameTextBox.Refresh();
            clientIdTextBox.Refresh();
            clientPhoneTextBox.Refresh();
            clientEmailTextBox.Refresh();
            clientPictureBox.Image = clientPictureBox.InitialImage;
            clientNeighborhoodComboBox.Refresh();
            clientBuyPropertyCheck.Checked = false;
            clientRentPropertyCheck.Checked = false;
            clientSellHisPropertyCheck.Checked = false;
            clientRentHisPropertyCheck.Checked = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CreateApartament()
        {
            // Create a new instance of apartament.    
            new Apartament(
                Int32.Parse(bedroomComboBox.SelectedItem.ToString()),
                Int32.Parse(bathroomComboBox.SelectedItem.ToString()),
                Int32.Parse(builtYearComboBox.SelectedItem.ToString()),
                Int32.Parse(squareMeterTextBox.Text),
                mainStreetTextBox.Text,
                sideStreetTextBox.Text,
                doorNumberTextBox.Text,
                forRentCheckBox.Checked,
                forSaleCheckBox.Checked,
                Int32.Parse(rentPriceTextBox.Text),
                Int32.Parse(sellPriceTextBox.Text),
                Sort.GetNeighborhoodByName(neighborhoodComboBox, Model<Neighborhood>.getInstances()),
                Int32.Parse(floorsTextBox.Text),
                Int32.Parse(apartamentNumber.Text)
            );

            // Print the success message.
            ValidationSuccess.Show("Apartament succesifully created!");

            // Save the apartaments collection.
            Apartament.Save();

            // Clear the form.
            RefreshInputs();            
        }

        private void CreateHouse()
        {
            // Create a new instance of house.
            new House(
                Int32.Parse(bedroomComboBox.SelectedItem.ToString()),
                Int32.Parse(bathroomComboBox.SelectedItem.ToString()),
                Int32.Parse(builtYearComboBox.SelectedItem.ToString()),
                Int32.Parse(squareMeterTextBox.Text),
                mainStreetTextBox.Text,
                sideStreetTextBox.Text,
                doorNumberTextBox.Text,
                forRentCheckBox.Checked,
                forSaleCheckBox.Checked,
                Int32.Parse(rentPriceTextBox.Text),
                Int32.Parse(sellPriceTextBox.Text),
                Sort.GetNeighborhoodByName(neighborhoodComboBox, Model<Neighborhood>.getInstances()),
                galleryGarageCheckBox.Checked
            );

            // Print the success message.
            ValidationSuccess.Show("House succesifully created!");

            // Save the the houses collection.
            House.Save();

            // Clean the house form.
            RefreshInputs();
        }

        /// <summary>
        /// 
        /// </summary>
        private void CreateProperty()
        {
            // List of inputs thats needs to be filled
            bool dataFilled = (propertyTypeComboBox.SelectedIndex != -1 &&
                               mainStreetTextBox.Text != "" &&
                               sideStreetTextBox.Text != "" &&
                               doorNumberTextBox.Text != "" &&
                               neighborhoodComboBox.SelectedIndex != -1 &&
                               builtYearComboBox.SelectedIndex != -1 &&
                               squareMeterTextBox.Text != "" &&
                               bedroomComboBox.SelectedIndex != -1 &&
                               bathroomComboBox.SelectedIndex != -1 &&
                               garageComboBox.SelectedIndex != -1 &&
                               conditionComboBox.SelectedIndex != -1 &&
                               ownerComboBox.SelectedIndex != -1 &&
                               sellPriceTextBox.Text != "" &&
                               rentPriceTextBox.Text != "");
            try
            {
                // Check if the creation type is for Apartament, House or None (missing data).
                if (propertyTypeComboBox.SelectedItem.ToString() == "Apartament" && floorsTextBox.Text != "" && apartamentNumber.Text != "") {
                    // Create a new apartament.
                    CreateApartament();
                    return;
                } else if (propertyTypeComboBox.SelectedItem.ToString() == "House") {
                    // Create a new house.
                    CreateHouse();
                    return;
                }
            } catch (NullReferenceException) { }
           
            // Display an error message for missing inputs.
            ValidationError.Show("Please check input fields.");
        }

        /// <summary>
        /// 
        /// </summary>
        private void CreateClient()
        {
            if (clientNameTextBox.Text != "" && clientNeighborhoodComboBox.SelectedIndex != -1 &&
                clientIdTextBox.Text != "" && clientPhoneTextBox.Text != "" && Verify.Email(clientEmailTextBox))
            {
                // Console.WriteLine(Directory.GetCurrentDirectory());
                // Console.WriteLine("Images");
                // Console.WriteLine(clientPictureBox.ImageLocation.ToString());
                String origin = clientPictureBox.ImageLocation;
                String imgPath = Path.Combine(Directory.GetCurrentDirectory(), "images", Path.GetFileName(origin));

                // Ensure the directory images exists
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "images"))) {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "images"));
                }
                
                // Copy the original image file to the local images directory.
                System.IO.File.Copy(origin, imgPath);

                // Create the new client instance.
                new Client(
                    clientNameTextBox.Text,
                    clientEmailTextBox.Text,
                    clientPhoneTextBox.Text,
                    clientIdTextBox.Text,
                    clientSellHisPropertyCheck.Checked,
                    clientRentHisPropertyCheck.Checked,
                    clientRentPropertyCheck.Checked,
                    clientBuyPropertyCheck.Checked,
                    imgPath
                );
                
                // Display the success message.
                ValidationSuccess.Show("Client successfuly created.");
                
                // Save the clients collection.
                Client.Save();
                
                // Clear all the forms.
                RefreshComboBoxes();
                RefreshInputs();
            } else {
                // Display the error by wrong inputs message.
                ValidationError.Show("Client not created.\nPlease check input fields.");
            }

        }

        private void sellPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(sellPriceTextBox);
        }

        private void rentPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(rentPriceTextBox);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            PopulateHouseGrid.PopulateGrid(searchGrid, Model<Apartament>.getInstances(), Model<House>.getInstances());
        }

        private void searchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id;
            String aptNum;
            DataGridViewRow row = this.searchGrid.Rows[e.RowIndex];
            id = row.Cells["Id"].Value.ToString();
            //aptNum = row.Cells[""]

        }

        private void galleryFilterGoButton_Click(object sender, EventArgs e)
        {
            Dictionary<String, Object> filterBy = new Dictionary<String, Object> ();

            // if (galleryApartamentCheckBox.Checked) {
            //    filterBy.Add(
            // }

            if (galleryGarageCheckBox.Checked) {
                filterBy.Add("Garage", galleryGarageComboBox.SelectedValue);
            }

            // Get the instances that match the filter
            IList<Apartament> apartaments = Apartament.FilterBy(filterBy);
            
            // Get the instances that match the filter
            IList<House> houses = House.FilterBy(filterBy);

            // Populate the search results grid
            PopulateHouseGrid.PopulateGrid(searchGrid, apartaments, houses);
        }

        private void galleryApartamentCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
