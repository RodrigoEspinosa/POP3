﻿using System;
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

        // The functions start here.

        /// <summary>
        /// Set the default pictures to the picture boxes.
        /// </summary>
        private void SetDefaultPictures()
        {
            //Set the default picture to an initial image.
            propertyPictureBox.Image = propertyPictureBox.InitialImage;
            clientPictureBox.Image = clientPictureBox.InitialImage;
            galleryCustomPictureBox.Image = galleryCustomPictureBox.InitialImage;
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
            try
            {
                country = LocationAux.GetLocationName(locCountryComboBox, locCountryTextBox);
                state = LocationAux.GetLocationName(locStateComboBox, locStateTextBox);
                city = LocationAux.GetLocationName(locCityComboBox, locCityTextBox);
                
                if (!LocationAux.TextBoxIsEmpty(locNeighborhoodTextBox))
                {
                    new Neighborhood(locNeighborhoodTextBox.Text,
                                    new City(city,
                                    new State(state,
                                    new Country(country)
                                    )));
                    MessageBox.Show("Location successfuly created!");
                    
                    Neighborhood.Save();
                    City.Save();
                    State.Save();
                    Country.Save();
                    
                    countryToogle.Value = 0;
                    stateToogle.Value = 0;
                    cityToogle.Value = 0;
                    RefreshComboBoxes();
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
        }

        /// <summary>
        /// Creates a client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientFinishButton_Click(object sender, EventArgs e)
        {
            CreateClients();
        }

        /// <summary>
        /// Controls a posible Format Exception.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modHouseDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("The input isn't in the right format...");
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
        /// Refresh the combo boxes 
        /// with the new data.
        /// </summary>
        private void RefreshComboBoxes()
        {
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
        }

        /// <summary>
        /// Fills combo boxes.
        /// </summary>
        private void FillComboBoxes()
        {
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

        private void cityToogle_ValueChanged(object sender, EventArgs e)
        {
            LocationAux.ShowHideLocationControls(locCityComboBox, locCityTextBox, cityToogle);
        }

        private void countryToogle_ValueChanged(object sender, EventArgs e)
        {
            LocationAux.ShowHideLocationControls(locCountryComboBox, locCountryTextBox, countryToogle);
        }

        private void stateToogle_ValueChanged(object sender, EventArgs e)
        {
            LocationAux.ShowHideLocationControls(locStateComboBox, locStateTextBox, stateToogle);
        }

        private void CreateProperty()
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


            try
            {
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
                                               forRentCheckBox.Checked,
                                               forSaleCheckBox.Checked,
                                               Sort.GetNeighborhoodByName(neighborhoodComboBox, Model<Neighborhood>.getInstances()),
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
                    if (houseDataFilled)
                    {
                        new House(Int32.Parse(bedroomComboBox.SelectedItem.ToString()),
                                               Int32.Parse(bathroomComboBox.SelectedItem.ToString()),
                                               Int32.Parse(builtYearComboBox.SelectedItem.ToString()),
                                               Int32.Parse(squareMeterTextBox.Text),
                                               mainStreetTextBox.Text,
                                               sideStreetTextBox.Text,
                                               doorNumberTextBox.Text,
                                               forRentCheckBox.Checked,
                                               forSaleCheckBox.Checked,
                                               Sort.GetNeighborhoodByName(neighborhoodComboBox, Model<Neighborhood>.getInstances()),
                                               galleryGarageCheckBox.Checked);
                    }
                    MessageBox.Show("House succesifully created!");
                    House.Save();
                }
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
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please check input fields...");
                return;
            }
        }

        private void CreateClients()
        {
            if (clientNameTextBox.Text != "" &&
                clientNeighborhoodComboBox.SelectedIndex != -1 &&
                clientIdTextBox.Text != "" &&
                clientPhoneTextBox.Text != "" &&
                Verify.Email(clientEmailTextBox))
            {
                new Client(clientNameTextBox.Text,
                                          clientEmailTextBox.Text,
                                          clientPhoneTextBox.Text,
                                          clientIdTextBox.Text,
                                          clientSellHisPropertyCheck.Checked,
                                          clientRentHisPropertyCheck.Checked,
                                          clientRentPropertyCheck.Checked,
                                          clientBuyPropertyCheck.Checked,
                                          clientPictureBox.Image);

                MessageBox.Show("Client successfuly created! ");
                //Client.Save();
                RefreshComboBoxes();
                clientNameTextBox.Refresh();
                clientIdTextBox.Refresh();
                clientPhoneTextBox.Refresh();
                clientEmailTextBox.Refresh();
                clientPictureBox.Refresh();
                clientBuyPropertyCheck.Checked = false;
                clientRentPropertyCheck.Checked = false;
                clientSellHisPropertyCheck.Checked = false;
                clientRentHisPropertyCheck.Checked = false;

            }
            else
            {
                MessageBox.Show("Client not created.\nPlease check input fields.");
            }
        }
    }
}
