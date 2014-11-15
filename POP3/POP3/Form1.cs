using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

using MetroFramework.Forms;
using MetroFramework.Controls;
using POP3.Models;
using POP3;
using POP3.AuxiliaryClases;

namespace POP3
{
    public partial class MainWindow : MetroForm
    {
        List<House> houseList = new List<House>();
        List<Apartament> apartamentList = new List<Apartament>();
        List<Client> clientList = new List<Client>();
        List<Neighborhood> neighborhoodList = new List<Neighborhood>();
        public MainWindow()
        {
            InitializeComponent();

            //fills the combo boxes.
            FillComboBoxes();
            
            //sets the default pictures.
            SetDefaultPictures();
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
            FileExplorer.Open(customPictureBox);
        }

        /// <summary>
        /// Creates the Neigborhood in the Add - Location tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNeigborhoodButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Makes Visible the galleryGarageComboBox if the galleryGarageFilter is cheked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsGarageFilter_Check(object sender, EventArgs e)
        {

            if (galleryGarageCheckBox.Checked)
            {
                galleryGarageComboBox.Visible = true;
            }
            else
            {
                galleryGarageComboBox.Visible = false;
            }
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
        /// Enables/Disable the galleryCountryComboBox depending
        /// on the galleryCountryCheckBox "cheked" state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsCountryFilter_Cheked(object sender, EventArgs e)
        {
            if (galleryCountryCheckBox.Checked)
            {
                galleryCountryComboBox.Visible = true;
            }
            else
            {
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
        /// When summoned fills the comboBoxes.
        /// </summary>
        private void galleryFilterGoButton_Click(object sender, EventArgs e)
        {
            bool filterByApartament = galleryApartamentCheckBox.Checked;
            bool filterByHouse = galleryHouseCheckBox.Checked;
            bool filterByForSale = galleryForSaleCheckBox.Checked;
            bool filterByForRent = galleryForRentCheckBox.Checked;
            bool filterByGarage = galleryGarageCheckBox.Checked;
            bool filteredByDormitory = galleryDormitoryCheckBox.Checked;
            bool filteredByCountry = galleryCountryCheckBox.Checked;
            bool filteredByNeighborhood = galleryNeighborhoodCheckBox.Checked;
        }

        /// <summary>
        /// Show / Hides country ComboBox/Text Box in the
        /// location tab depending on the country toogle value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locCountryToogle_Scroll(object sender, ScrollEventArgs e)
        {
            switch (countryToogle.Value)
            {
                case 0:
                    locCountryComboBox.Enabled = true;
                    locCountryTextBox.Visible = false;
                    locCountryTextBox.Text = "";
                    break;
                case 1:
                    locCountryComboBox.Enabled = false;
                    locCountryTextBox.Visible = true;
                    locCountryComboBox.SelectedIndex = -1;
                    break;
            }
        }

        /// <summary>
        /// Show / Hides state ComboBox/Text Box in the
        /// location tab depending on the state toogle value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locStateToogle_Scroll(object sender, ScrollEventArgs e)
        {
            switch (stateToogle.Value)
            {
                case 0:
                    locStateComboBox.Enabled = true;
                    locStateTextBox.Visible = false;
                    locStateTextBox.Text = "";
                    break;
                case 1:
                    locStateComboBox.Enabled = false;
                    locStateTextBox.Visible = true;
                    locStateComboBox.SelectedIndex = -1;
                    break;
            }
        }

        /// <summary>
        /// Shows/Hides city ComboBox/Text Box in the
        /// location tab depending on the city toogle value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locCityToogle_Scroll(object sender, ScrollEventArgs e)
        {
            switch (cityToogle.Value)
            {
                case 0:
                    locCityComboBox.Enabled = true;
                    locCityTextBox.Visible = false;
                    locCityTextBox.Text = "";
                    break;
                case 1:
                    locCityComboBox.Enabled = false;
                    locCityTextBox.Visible = true;
                    locCityComboBox.SelectedIndex = -1;
                    break;
            }
        }

        /// <summary>
        /// Shows/Hides certain garden/floors label 
        /// depending on the selected value of the 
        /// propertyTypeComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void propertyTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (propertyTypeComboBox.SelectedItem.ToString() == "Apartament")
            {
                apartamentNumber.Visible = true;
                gardenLabel.Visible = false;
                floorsLabel.Visible = true;
                floorsTextBox.Visible = true;
                gardenCheckBox.Checked = false;
            }
            else
            {
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
            if (modificationsComboBox.SelectedItem.ToString() == "House")
            {
                modApartamentDataGrid.Visible = false;
                modHouseDataGrid.Visible = true;
            }
            else if(modificationsComboBox.SelectedItem.ToString() == "Apartament")
            {
                modHouseDataGrid.Visible = false;
                modApartamentDataGrid.Visible = true;
            }
        }

        /// <summary>
        /// Fills combo boxes.
        /// </summary>
        private void FillComboBoxes()
        {
            //Fills the propertyTypeComboBox.
            propertyTypeComboBox.Items.Add("Apartament");
            propertyTypeComboBox.Items.Add("House");

            //Fills the builtYearComboBox
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                builtYearComboBox.Items.Add(i);
            }

            //Fill the comboBoxes.
            for (int i = 0; i < 10; i++)
            {
                bedroomComboBox.Items.Add(i);
                bathroomComboBox.Items.Add(i);
                garageComboBox.Items.Add(i);
                galleryGarageComboBox.Items.Add(i);
                galleryDormitoryComboBox.Items.Add(i);
            }
            //Add a "10+" option to some ComboBoxes.
            bedroomComboBox.Items.Add("10+");
            bathroomComboBox.Items.Add("10+");
            garageComboBox.Items.Add("10+");
            galleryDormitoryComboBox.Items.Add("10+");

            //Add some prices to the Min-Max price ComboBox.
            for (int i = 0; i <= 1000000; i += 50000)
            {
                galleryMinPriceComboBox.Items.Add(i);
                galleryMaxPriceComboBox.Items.Add(i);
            }

            //Creates a list of conditions.
            List<String> listOfConditions = new List<String>(new String[] {"Destroyed",
                                                                            "Bad",
                                                                            "Not that bad",
                                                                            "Normal",
                                                                            "Good",
                                                                            "Very Good",
                                                                            "Excellent"});
            //Fill ComboBox with list of conditions.
            foreach (String condition in listOfConditions)
            {
                conditionComboBox.Items.Add(condition);
            }

            //Fill modificationComboBox with the modificable fields.
            modificationsComboBox.Items.Add("House");
            modificationsComboBox.Items.Add("Apartament");
            modificationsComboBox.Items.Add("Client");
            modificationsComboBox.Items.Add("Location");

            //Fill location Combo Boxes
            locCountryComboBox.Items.Add("Uruguay");
            locStateComboBox.Items.Add("Montevideo");
            locCityComboBox.Items.Add("Montevideo");
        }

        /// <summary>
        /// Set the default pictures to the picture boxes.
        /// </summary>
        private void SetDefaultPictures()
        {
            //Set the default picture to an initial image.
            customPictureBox.Image = customPictureBox.InitialImage;
            clientPictureBox.Image = clientPictureBox.InitialImage;
            galleryCustomPictureBox.Image = galleryCustomPictureBox.InitialImage;
        }

        private void selectClientAvatar_Click(object sender, EventArgs e)
        {
            FileExplorer.Open(clientPictureBox);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createLocationButton_Click(object sender, EventArgs e)
        {
            String country;
            String state;
            String city;
            try
            {
                country = LocationAux.GetLocationName(locCountryComboBox, locCountryTextBox);
                state = LocationAux.GetLocationName(locStateComboBox, locStateTextBox);
                city = LocationAux.GetLocationName(locCityComboBox, locCityTextBox);
                
                if (!LocationAux.TextBoxIsEmpty(locNeighborhoodTextBox))
                {
                    neighborhoodList.Add(new Neighborhood(locNeighborhoodTextBox.Text,
                                    new City(city,
                                    new State(state,
                                    new Country(country)
                                    ))));
                    MessageBox.Show("Location successfuly created!");
                }
                else
                {
                    MessageBox.Show("Please fill all the input fields...");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please check input fields...");
                return;
            }
            foreach (Neighborhood nei in neighborhoodList)
            {
                neighborhoodComboBox.Items.Add(nei);
            }
            foreach (Client client in clientList)
            {
                ownerComboBox.Items.Add(client);
            }
            
        }

        /// <summary>
        /// Creates a client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientFinishButton_Click(object sender, EventArgs e)
        {
            if (clientNameTextBox.Text != "" &&
                clientNeighborhoodComboBox.SelectedIndex != -1 &&
                clientIdTextBox.Text != "" &&
                clientPhoneTextBox.Text != "" &&
                Verify.Email(clientEmailTextBox))
            {
                clientList.Add(new Client(clientNameTextBox.Text,
                                          clientEmailTextBox.Text,
                                          clientPhoneTextBox.Text,
                                          clientIdTextBox.Text,
                                          clientSellHisPropertyCheck.Checked,
                                          clientRentHisPropertyCheck.Checked,
                                          clientRentPropertyCheck.Checked,
                                          clientBuyPropertyCheck.Checked,
                                          clientPictureBox.Image));

                MessageBox.Show("Client successfuly created! ");
            }
            else
            {
                MessageBox.Show("Client not created.\nPlease check input fields.");   
            }
        }

        private void modHouseDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("The input isn't in the right format...");
        }

        private void floorsTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(floorsTextBox);
        }

        private void clientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(clientNameTextBox);
        }

        private void clientIdTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(clientIdTextBox);
        }

        private void clientPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(clientPhoneTextBox);
        }

        private void clientNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Verify.String(clientNameTextBox);
        }

        private void locCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(locCountryTextBox);
        }

        private void locStateTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(locStateTextBox);
        }

        private void locCityTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(locCityTextBox);
        }

        private void locNeighborhoodTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(locNeighborhoodTextBox);
        }

        private void squareMeterTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(squareMeterTextBox);
        }

        private void apartamentNumber_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(apartamentNumber);
        }

        private void doorNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.Int(doorNumberTextBox);
        }

        private void sideStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(sideStreetTextBox);
        }

        private void mainStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            Verify.String(mainStreetTextBox);
        }

        private Neighborhood GetNeighborhoodByName(CustomComboBox comboBox, List<Neighborhood> list)
        {
            Neighborhood nei = null;
            foreach (Neighborhood nei1 in list)
            {
                if (nei1.Name == comboBox.SelectedItem.ToString())
                {
                    nei = nei1;
                }
            }
            return nei;
        }

        private void createPropertyFinishButton_Click(object sender, EventArgs e)
        {
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
                             ownerComboBox.SelectedIndex != -1); 
            


            if (propertyTypeComboBox.SelectedItem.ToString() == "Apartament")
            {
                bool apartamentDataFilled = false;
                apartamentDataFilled = (dataFilled &&
                                   floorsTextBox.Text != "");
                if (apartamentDataFilled)
                {
                    new Apartament(Int32.Parse(bedroomComboBox.SelectedItem.ToString()),
                                           Int32.Parse(bathroomComboBox.SelectedItem.ToString()),
                                           Int32.Parse(builtYearComboBox.SelectedItem.ToString()),
                                           Int32.Parse(squareMeterTextBox.Text),
                                           mainStreetTextBox.Text,
                                           sideStreetTextBox.Text,
                                           doorNumberTextBox.Text,
                                           GetNeighborhoodByName(neighborhoodComboBox, neighborhoodList),
                                           Int32.Parse(floorsTextBox.Text),
                                           Int32.Parse(apartamentNumber.Text));

                }
                MessageBox.Show("Apartament succesifully created!");
                Apartament.Save();
            }
            if (propertyTypeComboBox.SelectedItem.ToString() == "House")
            {
                bool houseDataFilled = false;
                houseDataFilled = (dataFilled &&
                                   gardenCheckBox.Checked);
                if(houseDataFilled)
                {
                    new House(Int32.Parse(bedroomComboBox.SelectedItem.ToString()),
                                           Int32.Parse(bathroomComboBox.SelectedItem.ToString()),
                                           Int32.Parse(builtYearComboBox.SelectedItem.ToString()),
                                           Int32.Parse(squareMeterTextBox.Text),
                                           mainStreetTextBox.Text,
                                           sideStreetTextBox.Text,
                                           doorNumberTextBox.Text,
                                           GetNeighborhoodByName(neighborhoodComboBox,neighborhoodList),
                                           galleryGarageCheckBox.Checked);
                }
                MessageBox.Show("House succesifully created!");
                House.Save();
            }
        }

        private void RefreshComboBoxes()
        {
            //Neighborhood List.
            IList<Neighborhood> neiList = Model<Neighborhood>.getInstances();
            
            //Country List.
            IList<Country> countryList = Model<Country>.getInstances();
            
            //State List.
            IList<State> stateList = Model<State>.getInstances();
            
            //City List.
            IList<City> cityList = Model<City>.getInstances(); 

            //Fill neighborhood combo boxes.
            neighborhoodComboBox.Items.Add(neiList);
            clientNeighborhoodComboBox.Items.Add(neiList);

            //Fill country combo boxes.
            locCountryComboBox.Items.Add(countryList);

            //Fill state combo boxes.
            locStateComboBox.Items.Add(stateList);

            //Fill city combo boxes.
            locCityComboBox.Items.Add(cityList);
        }
    }
}
