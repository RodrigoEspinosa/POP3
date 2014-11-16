using POP3;
using System.Collections.Generic;

namespace POP3
{
    public partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.galleryFilterGoButton = new MetroFramework.Controls.MetroButton();
            this.galleryMaxPriceComboBox = new POP3.CustomComboBox();
            this.galleryMinPriceComboBox = new POP3.CustomComboBox();
            this.galleryPriceRangeCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.galleryCountryComboBox = new POP3.CustomComboBox();
            this.galleryCountryCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.galleryNeighborhoodComboBox = new POP3.CustomComboBox();
            this.galleryNeighborhoodCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.galleryDormitoryComboBox = new POP3.CustomComboBox();
            this.galleryDormitoryCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.galleryGarageComboBox = new POP3.CustomComboBox();
            this.galleryGarageCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.galleryHouseCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.galleryForRentCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.galleryForSaleCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.galleryApartamentCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.galleryCustomPictureBox = new POP3.CustomPictureBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.createPropertyFinishButton = new MetroFramework.Controls.MetroButton();
            this.floorsTextBox = new POP3.CustomTextBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.floorsLabel = new MetroFramework.Controls.MetroLabel();
            this.gardenCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.apartamentNumber = new POP3.CustomTextBox();
            this.garageComboBox = new POP3.CustomComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.selectImageButton = new MetroFramework.Controls.MetroButton();
            this.finishButton = new MetroFramework.Controls.MetroButton();
            this.conditionComboBox = new POP3.CustomComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.forRentCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.forSaleCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.ownerComboBox = new POP3.CustomComboBox();
            this.bathroomComboBox = new POP3.CustomComboBox();
            this.bedroomComboBox = new POP3.CustomComboBox();
            this.neighborhoodComboBox = new POP3.CustomComboBox();
            this.propertyTypeComboBox = new POP3.CustomComboBox();
            this.builtYearComboBox = new POP3.CustomComboBox();
            this.squareMeterTextBox = new POP3.CustomTextBox();
            this.doorNumberTextBox = new POP3.CustomTextBox();
            this.sideStreetTextBox = new POP3.CustomTextBox();
            this.mainStreetTextBox = new POP3.CustomTextBox();
            this.propertyPictureBox = new POP3.CustomPictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ownerLabel = new MetroFramework.Controls.MetroLabel();
            this.bathroomsLabel = new MetroFramework.Controls.MetroLabel();
            this.bedroomLabel = new MetroFramework.Controls.MetroLabel();
            this.squareMetersLabel = new MetroFramework.Controls.MetroLabel();
            this.builtYearLabel = new MetroFramework.Controls.MetroLabel();
            this.neighborhoodLabel = new MetroFramework.Controls.MetroLabel();
            this.streetLabel = new MetroFramework.Controls.MetroLabel();
            this.doorNumberLabel = new MetroFramework.Controls.MetroLabel();
            this.selectPropertyTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.locationTab = new MetroFramework.Controls.MetroTabPage();
            this.createLocationButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.cityToogle = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.stateToogle = new MetroFramework.Controls.MetroTrackBar();
            this.gardenLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.countryToogle = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.locCityComboBox = new POP3.CustomComboBox();
            this.locStateComboBox = new POP3.CustomComboBox();
            this.locCountryComboBox = new POP3.CustomComboBox();
            this.locNeighborhoodTextBox = new POP3.CustomTextBox();
            this.locCityTextBox = new POP3.CustomTextBox();
            this.locStateTextBox = new POP3.CustomTextBox();
            this.locCountryTextBox = new POP3.CustomTextBox();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.clientRentHisPropertyCheck = new MetroFramework.Controls.MetroCheckBox();
            this.clientSellHisPropertyCheck = new MetroFramework.Controls.MetroCheckBox();
            this.clientRentPropertyCheck = new MetroFramework.Controls.MetroCheckBox();
            this.clientBuyPropertyCheck = new MetroFramework.Controls.MetroCheckBox();
            this.clientNeighborhoodComboBox = new POP3.CustomComboBox();
            this.clientFinishButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.selectClientAvatar = new MetroFramework.Controls.MetroButton();
            this.clientEmailTextBox = new POP3.CustomTextBox();
            this.clientPhoneTextBox = new POP3.CustomTextBox();
            this.clientIdTextBox = new POP3.CustomTextBox();
            this.clientNameTextBox = new POP3.CustomTextBox();
            this.clientPictureBox = new POP3.CustomPictureBox();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.modApartamentDataGrid = new MetroFramework.Controls.MetroGrid();
            this.Bedrooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modHouseDataGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.modificationsComboBox = new POP3.CustomComboBox();
            this.modificationsGrid = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.addClientMetroTile = new MetroFramework.Controls.MetroTile();
            this.addPropertyMetroTile = new MetroFramework.Controls.MetroTile();
            this.welcomeLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryCustomPictureBox)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyPictureBox)).BeginInit();
            this.locationTab.SuspendLayout();
            this.metroTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPictureBox)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modApartamentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modHouseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificationsGrid)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.galleryFilterGoButton);
            this.metroTabPage3.Controls.Add(this.galleryMaxPriceComboBox);
            this.metroTabPage3.Controls.Add(this.galleryMinPriceComboBox);
            this.metroTabPage3.Controls.Add(this.galleryPriceRangeCheckBox);
            this.metroTabPage3.Controls.Add(this.galleryCountryComboBox);
            this.metroTabPage3.Controls.Add(this.galleryCountryCheckBox);
            this.metroTabPage3.Controls.Add(this.galleryNeighborhoodComboBox);
            this.metroTabPage3.Controls.Add(this.galleryNeighborhoodCheckBox);
            this.metroTabPage3.Controls.Add(this.galleryDormitoryComboBox);
            this.metroTabPage3.Controls.Add(this.galleryDormitoryCheckBox);
            this.metroTabPage3.Controls.Add(this.galleryGarageComboBox);
            this.metroTabPage3.Controls.Add(this.galleryGarageCheckBox);
            this.metroTabPage3.Controls.Add(this.galleryHouseCheckBox);
            this.metroTabPage3.Controls.Add(this.galleryForRentCheckBox);
            this.metroTabPage3.Controls.Add(this.galleryForSaleCheckBox);
            this.metroTabPage3.Controls.Add(this.galleryApartamentCheckBox);
            this.metroTabPage3.Controls.Add(this.galleryCustomPictureBox);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1002, 645);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Search";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // galleryFilterGoButton
            // 
            this.galleryFilterGoButton.Location = new System.Drawing.Point(65, 373);
            this.galleryFilterGoButton.Name = "galleryFilterGoButton";
            this.galleryFilterGoButton.Size = new System.Drawing.Size(75, 23);
            this.galleryFilterGoButton.TabIndex = 18;
            this.galleryFilterGoButton.Text = "Filter";
            this.galleryFilterGoButton.UseSelectable = true;
            // 
            // galleryMaxPriceComboBox
            // 
            this.galleryMaxPriceComboBox.DropDownHeight = 60;
            this.galleryMaxPriceComboBox.FormattingEnabled = true;
            this.galleryMaxPriceComboBox.IntegralHeight = false;
            this.galleryMaxPriceComboBox.ItemHeight = 23;
            this.galleryMaxPriceComboBox.Location = new System.Drawing.Point(114, 299);
            this.galleryMaxPriceComboBox.Name = "galleryMaxPriceComboBox";
            this.galleryMaxPriceComboBox.PromptText = "Value...";
            this.galleryMaxPriceComboBox.Size = new System.Drawing.Size(99, 29);
            this.galleryMaxPriceComboBox.TabIndex = 17;
            this.galleryMaxPriceComboBox.UseSelectable = true;
            this.galleryMaxPriceComboBox.Visible = false;
            // 
            // galleryMinPriceComboBox
            // 
            this.galleryMinPriceComboBox.DropDownHeight = 60;
            this.galleryMinPriceComboBox.FormattingEnabled = true;
            this.galleryMinPriceComboBox.IntegralHeight = false;
            this.galleryMinPriceComboBox.ItemHeight = 23;
            this.galleryMinPriceComboBox.Location = new System.Drawing.Point(114, 264);
            this.galleryMinPriceComboBox.Name = "galleryMinPriceComboBox";
            this.galleryMinPriceComboBox.PromptText = "Value...";
            this.galleryMinPriceComboBox.Size = new System.Drawing.Size(99, 29);
            this.galleryMinPriceComboBox.TabIndex = 16;
            this.galleryMinPriceComboBox.UseSelectable = true;
            this.galleryMinPriceComboBox.Visible = false;
            // 
            // galleryPriceRangeCheckBox
            // 
            this.galleryPriceRangeCheckBox.AutoSize = true;
            this.galleryPriceRangeCheckBox.Location = new System.Drawing.Point(3, 272);
            this.galleryPriceRangeCheckBox.Name = "galleryPriceRangeCheckBox";
            this.galleryPriceRangeCheckBox.Size = new System.Drawing.Size(85, 15);
            this.galleryPriceRangeCheckBox.TabIndex = 15;
            this.galleryPriceRangeCheckBox.Text = "Price Range";
            this.galleryPriceRangeCheckBox.UseSelectable = true;
            this.galleryPriceRangeCheckBox.CheckedChanged += new System.EventHandler(this.IsPriceRangeFilter_Cheked);
            // 
            // galleryCountryComboBox
            // 
            this.galleryCountryComboBox.DropDownHeight = 60;
            this.galleryCountryComboBox.FormattingEnabled = true;
            this.galleryCountryComboBox.IntegralHeight = false;
            this.galleryCountryComboBox.ItemHeight = 23;
            this.galleryCountryComboBox.Location = new System.Drawing.Point(114, 194);
            this.galleryCountryComboBox.Name = "galleryCountryComboBox";
            this.galleryCountryComboBox.Size = new System.Drawing.Size(99, 29);
            this.galleryCountryComboBox.TabIndex = 14;
            this.galleryCountryComboBox.UseSelectable = true;
            this.galleryCountryComboBox.Visible = false;
            // 
            // galleryCountryCheckBox
            // 
            this.galleryCountryCheckBox.AutoSize = true;
            this.galleryCountryCheckBox.Location = new System.Drawing.Point(3, 202);
            this.galleryCountryCheckBox.Name = "galleryCountryCheckBox";
            this.galleryCountryCheckBox.Size = new System.Drawing.Size(66, 15);
            this.galleryCountryCheckBox.TabIndex = 13;
            this.galleryCountryCheckBox.Text = "Country";
            this.galleryCountryCheckBox.UseSelectable = true;
            this.galleryCountryCheckBox.CheckedChanged += new System.EventHandler(this.IsCountryFilter_Cheked);
            // 
            // galleryNeighborhoodComboBox
            // 
            this.galleryNeighborhoodComboBox.DropDownHeight = 60;
            this.galleryNeighborhoodComboBox.FormattingEnabled = true;
            this.galleryNeighborhoodComboBox.IntegralHeight = false;
            this.galleryNeighborhoodComboBox.ItemHeight = 23;
            this.galleryNeighborhoodComboBox.Location = new System.Drawing.Point(114, 229);
            this.galleryNeighborhoodComboBox.Name = "galleryNeighborhoodComboBox";
            this.galleryNeighborhoodComboBox.Size = new System.Drawing.Size(99, 29);
            this.galleryNeighborhoodComboBox.TabIndex = 12;
            this.galleryNeighborhoodComboBox.UseSelectable = true;
            this.galleryNeighborhoodComboBox.Visible = false;
            // 
            // galleryNeighborhoodCheckBox
            // 
            this.galleryNeighborhoodCheckBox.AutoSize = true;
            this.galleryNeighborhoodCheckBox.Location = new System.Drawing.Point(3, 237);
            this.galleryNeighborhoodCheckBox.Name = "galleryNeighborhoodCheckBox";
            this.galleryNeighborhoodCheckBox.Size = new System.Drawing.Size(101, 15);
            this.galleryNeighborhoodCheckBox.TabIndex = 11;
            this.galleryNeighborhoodCheckBox.Text = "Neighborhood";
            this.galleryNeighborhoodCheckBox.UseSelectable = true;
            this.galleryNeighborhoodCheckBox.CheckedChanged += new System.EventHandler(this.IsNeighborhoodFilter_Cheked);
            // 
            // galleryDormitoryComboBox
            // 
            this.galleryDormitoryComboBox.FormattingEnabled = true;
            this.galleryDormitoryComboBox.ItemHeight = 23;
            this.galleryDormitoryComboBox.Location = new System.Drawing.Point(114, 159);
            this.galleryDormitoryComboBox.Name = "galleryDormitoryComboBox";
            this.galleryDormitoryComboBox.Size = new System.Drawing.Size(99, 29);
            this.galleryDormitoryComboBox.TabIndex = 10;
            this.galleryDormitoryComboBox.UseSelectable = true;
            this.galleryDormitoryComboBox.Visible = false;
            // 
            // galleryDormitoryCheckBox
            // 
            this.galleryDormitoryCheckBox.AutoSize = true;
            this.galleryDormitoryCheckBox.Location = new System.Drawing.Point(3, 167);
            this.galleryDormitoryCheckBox.Name = "galleryDormitoryCheckBox";
            this.galleryDormitoryCheckBox.Size = new System.Drawing.Size(85, 15);
            this.galleryDormitoryCheckBox.TabIndex = 9;
            this.galleryDormitoryCheckBox.Text = "Dormitories";
            this.galleryDormitoryCheckBox.UseSelectable = true;
            this.galleryDormitoryCheckBox.CheckedChanged += new System.EventHandler(this.IsDormitoriyFilter_Cheked);
            // 
            // galleryGarageComboBox
            // 
            this.galleryGarageComboBox.FormattingEnabled = true;
            this.galleryGarageComboBox.ItemHeight = 23;
            this.galleryGarageComboBox.Location = new System.Drawing.Point(114, 124);
            this.galleryGarageComboBox.Name = "galleryGarageComboBox";
            this.galleryGarageComboBox.Size = new System.Drawing.Size(99, 29);
            this.galleryGarageComboBox.TabIndex = 8;
            this.galleryGarageComboBox.UseSelectable = true;
            this.galleryGarageComboBox.Visible = false;
            // 
            // galleryGarageCheckBox
            // 
            this.galleryGarageCheckBox.AutoSize = true;
            this.galleryGarageCheckBox.Location = new System.Drawing.Point(3, 133);
            this.galleryGarageCheckBox.Name = "galleryGarageCheckBox";
            this.galleryGarageCheckBox.Size = new System.Drawing.Size(60, 15);
            this.galleryGarageCheckBox.TabIndex = 7;
            this.galleryGarageCheckBox.Text = "Garage";
            this.galleryGarageCheckBox.UseSelectable = true;
            this.galleryGarageCheckBox.CheckedChanged += new System.EventHandler(this.IsGarageFilter_Check);
            // 
            // galleryHouseCheckBox
            // 
            this.galleryHouseCheckBox.AutoSize = true;
            this.galleryHouseCheckBox.Location = new System.Drawing.Point(116, 71);
            this.galleryHouseCheckBox.Name = "galleryHouseCheckBox";
            this.galleryHouseCheckBox.Size = new System.Drawing.Size(57, 15);
            this.galleryHouseCheckBox.TabIndex = 6;
            this.galleryHouseCheckBox.Text = "House";
            this.galleryHouseCheckBox.UseSelectable = true;
            // 
            // galleryForRentCheckBox
            // 
            this.galleryForRentCheckBox.AutoSize = true;
            this.galleryForRentCheckBox.Location = new System.Drawing.Point(116, 101);
            this.galleryForRentCheckBox.Name = "galleryForRentCheckBox";
            this.galleryForRentCheckBox.Size = new System.Drawing.Size(67, 15);
            this.galleryForRentCheckBox.TabIndex = 5;
            this.galleryForRentCheckBox.Text = "For Rent";
            this.galleryForRentCheckBox.UseSelectable = true;
            // 
            // galleryForSaleCheckBox
            // 
            this.galleryForSaleCheckBox.AutoSize = true;
            this.galleryForSaleCheckBox.Location = new System.Drawing.Point(3, 101);
            this.galleryForSaleCheckBox.Name = "galleryForSaleCheckBox";
            this.galleryForSaleCheckBox.Size = new System.Drawing.Size(64, 15);
            this.galleryForSaleCheckBox.TabIndex = 4;
            this.galleryForSaleCheckBox.Text = "For Sale";
            this.galleryForSaleCheckBox.UseSelectable = true;
            // 
            // galleryApartamentCheckBox
            // 
            this.galleryApartamentCheckBox.AutoSize = true;
            this.galleryApartamentCheckBox.Location = new System.Drawing.Point(3, 71);
            this.galleryApartamentCheckBox.Name = "galleryApartamentCheckBox";
            this.galleryApartamentCheckBox.Size = new System.Drawing.Size(86, 15);
            this.galleryApartamentCheckBox.TabIndex = 3;
            this.galleryApartamentCheckBox.Text = "Apartament";
            this.galleryApartamentCheckBox.UseSelectable = true;
            // 
            // galleryCustomPictureBox
            // 
            this.galleryCustomPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("galleryCustomPictureBox.InitialImage")));
            this.galleryCustomPictureBox.Location = new System.Drawing.Point(371, 16);
            this.galleryCustomPictureBox.Name = "galleryCustomPictureBox";
            this.galleryCustomPictureBox.Size = new System.Drawing.Size(503, 392);
            this.galleryCustomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.galleryCustomPictureBox.TabIndex = 2;
            this.galleryCustomPictureBox.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroTabControl2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1002, 645);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Create/Edit";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage6);
            this.metroTabControl2.Controls.Add(this.locationTab);
            this.metroTabControl2.Controls.Add(this.metroTabPage7);
            this.metroTabControl2.Controls.Add(this.metroTabPage4);
            this.metroTabControl2.Location = new System.Drawing.Point(-4, 8);
            this.metroTabControl2.Multiline = true;
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 2;
            this.metroTabControl2.Size = new System.Drawing.Size(1010, 582);
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.Controls.Add(this.createPropertyFinishButton);
            this.metroTabPage6.Controls.Add(this.floorsTextBox);
            this.metroTabPage6.Controls.Add(this.metroProgressBar1);
            this.metroTabPage6.Controls.Add(this.floorsLabel);
            this.metroTabPage6.Controls.Add(this.gardenCheckBox);
            this.metroTabPage6.Controls.Add(this.metroLabel17);
            this.metroTabPage6.Controls.Add(this.apartamentNumber);
            this.metroTabPage6.Controls.Add(this.garageComboBox);
            this.metroTabPage6.Controls.Add(this.metroLabel5);
            this.metroTabPage6.Controls.Add(this.selectImageButton);
            this.metroTabPage6.Controls.Add(this.finishButton);
            this.metroTabPage6.Controls.Add(this.conditionComboBox);
            this.metroTabPage6.Controls.Add(this.metroLabel4);
            this.metroTabPage6.Controls.Add(this.forRentCheckBox);
            this.metroTabPage6.Controls.Add(this.forSaleCheckBox);
            this.metroTabPage6.Controls.Add(this.ownerComboBox);
            this.metroTabPage6.Controls.Add(this.bathroomComboBox);
            this.metroTabPage6.Controls.Add(this.bedroomComboBox);
            this.metroTabPage6.Controls.Add(this.neighborhoodComboBox);
            this.metroTabPage6.Controls.Add(this.propertyTypeComboBox);
            this.metroTabPage6.Controls.Add(this.builtYearComboBox);
            this.metroTabPage6.Controls.Add(this.squareMeterTextBox);
            this.metroTabPage6.Controls.Add(this.doorNumberTextBox);
            this.metroTabPage6.Controls.Add(this.sideStreetTextBox);
            this.metroTabPage6.Controls.Add(this.mainStreetTextBox);
            this.metroTabPage6.Controls.Add(this.propertyPictureBox);
            this.metroTabPage6.Controls.Add(this.metroLabel1);
            this.metroTabPage6.Controls.Add(this.ownerLabel);
            this.metroTabPage6.Controls.Add(this.bathroomsLabel);
            this.metroTabPage6.Controls.Add(this.bedroomLabel);
            this.metroTabPage6.Controls.Add(this.squareMetersLabel);
            this.metroTabPage6.Controls.Add(this.builtYearLabel);
            this.metroTabPage6.Controls.Add(this.neighborhoodLabel);
            this.metroTabPage6.Controls.Add(this.streetLabel);
            this.metroTabPage6.Controls.Add(this.doorNumberLabel);
            this.metroTabPage6.Controls.Add(this.selectPropertyTypeLabel);
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(1002, 540);
            this.metroTabPage6.TabIndex = 0;
            this.metroTabPage6.Text = "Property";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // createPropertyFinishButton
            // 
            this.createPropertyFinishButton.Location = new System.Drawing.Point(869, 423);
            this.createPropertyFinishButton.Name = "createPropertyFinishButton";
            this.createPropertyFinishButton.Size = new System.Drawing.Size(75, 23);
            this.createPropertyFinishButton.TabIndex = 276;
            this.createPropertyFinishButton.Text = "Finish";
            this.createPropertyFinishButton.UseSelectable = true;
            this.createPropertyFinishButton.Click += new System.EventHandler(this.createPropertyFinishButton_Click);
            // 
            // floorsTextBox
            // 
            this.floorsTextBox.Lines = new string[0];
            this.floorsTextBox.Location = new System.Drawing.Point(164, 423);
            this.floorsTextBox.MaxLength = 32767;
            this.floorsTextBox.Name = "floorsTextBox";
            this.floorsTextBox.PasswordChar = '\0';
            this.floorsTextBox.PromptText = "The number of floors...";
            this.floorsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.floorsTextBox.SelectedText = "";
            this.floorsTextBox.Size = new System.Drawing.Size(215, 23);
            this.floorsTextBox.TabIndex = 275;
            this.floorsTextBox.UseSelectable = true;
            this.floorsTextBox.Visible = false;
            this.floorsTextBox.TextChanged += new System.EventHandler(this.floorsTextBox_TextChanged);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(44, 545);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(793, 10);
            this.metroProgressBar1.TabIndex = 274;
            // 
            // floorsLabel
            // 
            this.floorsLabel.AutoSize = true;
            this.floorsLabel.Location = new System.Drawing.Point(44, 423);
            this.floorsLabel.Name = "floorsLabel";
            this.floorsLabel.Size = new System.Drawing.Size(45, 19);
            this.floorsLabel.TabIndex = 273;
            this.floorsLabel.Text = "Floors";
            this.floorsLabel.Visible = false;
            // 
            // gardenCheckBox
            // 
            this.gardenCheckBox.AutoSize = true;
            this.gardenCheckBox.Location = new System.Drawing.Point(164, 427);
            this.gardenCheckBox.Name = "gardenCheckBox";
            this.gardenCheckBox.Size = new System.Drawing.Size(68, 15);
            this.gardenCheckBox.TabIndex = 272;
            this.gardenCheckBox.Text = "Yes / No";
            this.gardenCheckBox.UseSelectable = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(42, 423);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(52, 19);
            this.metroLabel17.TabIndex = 271;
            this.metroLabel17.Text = "Garden";
            // 
            // apartamentNumber
            // 
            this.apartamentNumber.Lines = new string[0];
            this.apartamentNumber.Location = new System.Drawing.Point(406, 115);
            this.apartamentNumber.MaxLength = 32767;
            this.apartamentNumber.Name = "apartamentNumber";
            this.apartamentNumber.PasswordChar = '\0';
            this.apartamentNumber.PromptText = "The Apt. number...";
            this.apartamentNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apartamentNumber.SelectedText = "";
            this.apartamentNumber.Size = new System.Drawing.Size(111, 23);
            this.apartamentNumber.TabIndex = 270;
            this.apartamentNumber.UseSelectable = true;
            this.apartamentNumber.Visible = false;
            this.apartamentNumber.TextChanged += new System.EventHandler(this.apartamentNumber_TextChanged);
            // 
            // garageComboBox
            // 
            this.garageComboBox.DropDownHeight = 100;
            this.garageComboBox.FormattingEnabled = true;
            this.garageComboBox.IntegralHeight = false;
            this.garageComboBox.ItemHeight = 23;
            this.garageComboBox.Location = new System.Drawing.Point(164, 312);
            this.garageComboBox.Name = "garageComboBox";
            this.garageComboBox.PromptText = "Select number of garages";
            this.garageComboBox.Size = new System.Drawing.Size(215, 29);
            this.garageComboBox.TabIndex = 269;
            this.garageComboBox.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(41, 316);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 268;
            this.metroLabel5.Text = "Garage";
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(716, 336);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(75, 23);
            this.selectImageButton.TabIndex = 265;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.UseSelectable = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(883, 540);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(79, 23);
            this.finishButton.TabIndex = 16;
            this.finishButton.Text = "Finish";
            this.finishButton.UseSelectable = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.DropDownHeight = 100;
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.IntegralHeight = false;
            this.conditionComboBox.ItemHeight = 23;
            this.conditionComboBox.Location = new System.Drawing.Point(164, 347);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.PromptText = "Select the property condition";
            this.conditionComboBox.Size = new System.Drawing.Size(215, 29);
            this.conditionComboBox.TabIndex = 264;
            this.conditionComboBox.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(41, 354);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 263;
            this.metroLabel4.Text = "Condition";
            // 
            // forRentCheckBox
            // 
            this.forRentCheckBox.AutoSize = true;
            this.forRentCheckBox.Location = new System.Drawing.Point(429, 89);
            this.forRentCheckBox.Name = "forRentCheckBox";
            this.forRentCheckBox.Size = new System.Drawing.Size(67, 15);
            this.forRentCheckBox.TabIndex = 14;
            this.forRentCheckBox.Text = "For Rent";
            this.forRentCheckBox.UseSelectable = true;
            // 
            // forSaleCheckBox
            // 
            this.forSaleCheckBox.AutoSize = true;
            this.forSaleCheckBox.Location = new System.Drawing.Point(429, 59);
            this.forSaleCheckBox.Name = "forSaleCheckBox";
            this.forSaleCheckBox.Size = new System.Drawing.Size(64, 15);
            this.forSaleCheckBox.TabIndex = 13;
            this.forSaleCheckBox.Text = "For Sale";
            this.forSaleCheckBox.UseSelectable = true;
            // 
            // ownerComboBox
            // 
            this.ownerComboBox.DropDownHeight = 100;
            this.ownerComboBox.FormattingEnabled = true;
            this.ownerComboBox.IntegralHeight = false;
            this.ownerComboBox.ItemHeight = 23;
            this.ownerComboBox.Location = new System.Drawing.Point(164, 383);
            this.ownerComboBox.Name = "ownerComboBox";
            this.ownerComboBox.PromptText = "Select the owner";
            this.ownerComboBox.Size = new System.Drawing.Size(215, 29);
            this.ownerComboBox.TabIndex = 11;
            this.ownerComboBox.UseSelectable = true;
            // 
            // bathroomComboBox
            // 
            this.bathroomComboBox.DropDownHeight = 100;
            this.bathroomComboBox.FormattingEnabled = true;
            this.bathroomComboBox.IntegralHeight = false;
            this.bathroomComboBox.ItemHeight = 23;
            this.bathroomComboBox.Location = new System.Drawing.Point(164, 277);
            this.bathroomComboBox.Name = "bathroomComboBox";
            this.bathroomComboBox.PromptText = "Select number of bathrooms";
            this.bathroomComboBox.Size = new System.Drawing.Size(215, 29);
            this.bathroomComboBox.TabIndex = 10;
            this.bathroomComboBox.UseSelectable = true;
            // 
            // bedroomComboBox
            // 
            this.bedroomComboBox.DropDownHeight = 100;
            this.bedroomComboBox.FormattingEnabled = true;
            this.bedroomComboBox.IntegralHeight = false;
            this.bedroomComboBox.ItemHeight = 23;
            this.bedroomComboBox.Location = new System.Drawing.Point(164, 245);
            this.bedroomComboBox.Name = "bedroomComboBox";
            this.bedroomComboBox.PromptText = "Select number of bedrooms";
            this.bedroomComboBox.Size = new System.Drawing.Size(215, 29);
            this.bedroomComboBox.TabIndex = 9;
            this.bedroomComboBox.UseSelectable = true;
            // 
            // neighborhoodComboBox
            // 
            this.neighborhoodComboBox.DropDownHeight = 100;
            this.neighborhoodComboBox.FormattingEnabled = true;
            this.neighborhoodComboBox.IntegralHeight = false;
            this.neighborhoodComboBox.ItemHeight = 23;
            this.neighborhoodComboBox.Location = new System.Drawing.Point(164, 143);
            this.neighborhoodComboBox.Name = "neighborhoodComboBox";
            this.neighborhoodComboBox.PromptText = "Select the neighborhood";
            this.neighborhoodComboBox.Size = new System.Drawing.Size(215, 29);
            this.neighborhoodComboBox.TabIndex = 5;
            this.neighborhoodComboBox.UseSelectable = true;
            // 
            // propertyTypeComboBox
            // 
            this.propertyTypeComboBox.DropDownHeight = 100;
            this.propertyTypeComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.propertyTypeComboBox.FormattingEnabled = true;
            this.propertyTypeComboBox.IntegralHeight = false;
            this.propertyTypeComboBox.ItemHeight = 19;
            this.propertyTypeComboBox.Location = new System.Drawing.Point(164, 19);
            this.propertyTypeComboBox.Name = "propertyTypeComboBox";
            this.propertyTypeComboBox.PromptText = "Select the type of property";
            this.propertyTypeComboBox.Size = new System.Drawing.Size(215, 25);
            this.propertyTypeComboBox.TabIndex = 1;
            this.propertyTypeComboBox.UseSelectable = true;
            this.propertyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.propertyTypeComboBox_SelectionChangeCommitted);
            this.propertyTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.propertyTypeComboBox_SelectionChangeCommitted);
            // 
            // builtYearComboBox
            // 
            this.builtYearComboBox.DropDownHeight = 100;
            this.builtYearComboBox.FormattingEnabled = true;
            this.builtYearComboBox.IntegralHeight = false;
            this.builtYearComboBox.ItemHeight = 23;
            this.builtYearComboBox.Location = new System.Drawing.Point(164, 181);
            this.builtYearComboBox.Name = "builtYearComboBox";
            this.builtYearComboBox.PromptText = "Select the year of built";
            this.builtYearComboBox.Size = new System.Drawing.Size(215, 29);
            this.builtYearComboBox.TabIndex = 7;
            this.builtYearComboBox.UseSelectable = true;
            // 
            // squareMeterTextBox
            // 
            this.squareMeterTextBox.Lines = new string[0];
            this.squareMeterTextBox.Location = new System.Drawing.Point(164, 216);
            this.squareMeterTextBox.MaxLength = 32767;
            this.squareMeterTextBox.Name = "squareMeterTextBox";
            this.squareMeterTextBox.PasswordChar = '\0';
            this.squareMeterTextBox.PromptText = "The square meters...";
            this.squareMeterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.squareMeterTextBox.SelectedText = "";
            this.squareMeterTextBox.Size = new System.Drawing.Size(215, 23);
            this.squareMeterTextBox.TabIndex = 8;
            this.squareMeterTextBox.UseSelectable = true;
            this.squareMeterTextBox.TextChanged += new System.EventHandler(this.squareMeterTextBox_TextChanged);
            // 
            // doorNumberTextBox
            // 
            this.doorNumberTextBox.Lines = new string[0];
            this.doorNumberTextBox.Location = new System.Drawing.Point(164, 114);
            this.doorNumberTextBox.MaxLength = 32767;
            this.doorNumberTextBox.Name = "doorNumberTextBox";
            this.doorNumberTextBox.PasswordChar = '\0';
            this.doorNumberTextBox.PromptText = "The door number...";
            this.doorNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.doorNumberTextBox.SelectedText = "";
            this.doorNumberTextBox.Size = new System.Drawing.Size(215, 23);
            this.doorNumberTextBox.TabIndex = 4;
            this.doorNumberTextBox.UseSelectable = true;
            this.doorNumberTextBox.TextChanged += new System.EventHandler(this.doorNumberTextBox_TextChanged);
            // 
            // sideStreetTextBox
            // 
            this.sideStreetTextBox.Lines = new string[0];
            this.sideStreetTextBox.Location = new System.Drawing.Point(164, 84);
            this.sideStreetTextBox.MaxLength = 32767;
            this.sideStreetTextBox.Name = "sideStreetTextBox";
            this.sideStreetTextBox.PasswordChar = '\0';
            this.sideStreetTextBox.PromptText = "The name of the street...";
            this.sideStreetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sideStreetTextBox.SelectedText = "";
            this.sideStreetTextBox.Size = new System.Drawing.Size(215, 23);
            this.sideStreetTextBox.TabIndex = 3;
            this.sideStreetTextBox.UseSelectable = true;
            this.sideStreetTextBox.TextChanged += new System.EventHandler(this.sideStreetTextBox_TextChanged);
            // 
            // mainStreetTextBox
            // 
            this.mainStreetTextBox.Lines = new string[0];
            this.mainStreetTextBox.Location = new System.Drawing.Point(164, 54);
            this.mainStreetTextBox.MaxLength = 32767;
            this.mainStreetTextBox.Name = "mainStreetTextBox";
            this.mainStreetTextBox.PasswordChar = '\0';
            this.mainStreetTextBox.PromptText = "The name of the street...";
            this.mainStreetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mainStreetTextBox.SelectedText = "";
            this.mainStreetTextBox.Size = new System.Drawing.Size(215, 23);
            this.mainStreetTextBox.TabIndex = 262;
            this.mainStreetTextBox.UseSelectable = true;
            this.mainStreetTextBox.TextChanged += new System.EventHandler(this.mainStreetTextBox_TextChanged);
            // 
            // propertyPictureBox
            // 
            this.propertyPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("propertyPictureBox.InitialImage")));
            this.propertyPictureBox.Location = new System.Drawing.Point(572, 19);
            this.propertyPictureBox.Name = "propertyPictureBox";
            this.propertyPictureBox.Size = new System.Drawing.Size(372, 294);
            this.propertyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.propertyPictureBox.TabIndex = 25;
            this.propertyPictureBox.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 149);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Neighborhood";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(41, 389);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(48, 19);
            this.ownerLabel.TabIndex = 0;
            this.ownerLabel.Text = "Owner";
            // 
            // bathroomsLabel
            // 
            this.bathroomsLabel.AutoSize = true;
            this.bathroomsLabel.Location = new System.Drawing.Point(42, 285);
            this.bathroomsLabel.Name = "bathroomsLabel";
            this.bathroomsLabel.Size = new System.Drawing.Size(73, 19);
            this.bathroomsLabel.TabIndex = 0;
            this.bathroomsLabel.Text = "Bathrooms";
            // 
            // bedroomLabel
            // 
            this.bedroomLabel.AutoSize = true;
            this.bedroomLabel.Location = new System.Drawing.Point(42, 252);
            this.bedroomLabel.Name = "bedroomLabel";
            this.bedroomLabel.Size = new System.Drawing.Size(70, 19);
            this.bedroomLabel.TabIndex = 0;
            this.bedroomLabel.Text = "Bedrooms";
            // 
            // squareMetersLabel
            // 
            this.squareMetersLabel.AutoSize = true;
            this.squareMetersLabel.Location = new System.Drawing.Point(42, 219);
            this.squareMetersLabel.Name = "squareMetersLabel";
            this.squareMetersLabel.Size = new System.Drawing.Size(94, 19);
            this.squareMetersLabel.TabIndex = 0;
            this.squareMetersLabel.Text = "Square Meters";
            // 
            // builtYearLabel
            // 
            this.builtYearLabel.AutoSize = true;
            this.builtYearLabel.Location = new System.Drawing.Point(42, 187);
            this.builtYearLabel.Name = "builtYearLabel";
            this.builtYearLabel.Size = new System.Drawing.Size(63, 19);
            this.builtYearLabel.TabIndex = 0;
            this.builtYearLabel.Text = "Built Year";
            // 
            // neighborhoodLabel
            // 
            this.neighborhoodLabel.AutoSize = true;
            this.neighborhoodLabel.Location = new System.Drawing.Point(42, 85);
            this.neighborhoodLabel.Name = "neighborhoodLabel";
            this.neighborhoodLabel.Size = new System.Drawing.Size(72, 19);
            this.neighborhoodLabel.TabIndex = 0;
            this.neighborhoodLabel.Text = "Side Street";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(42, 55);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(76, 19);
            this.streetLabel.TabIndex = 0;
            this.streetLabel.Text = "Main Street";
            // 
            // doorNumberLabel
            // 
            this.doorNumberLabel.AutoSize = true;
            this.doorNumberLabel.Location = new System.Drawing.Point(41, 116);
            this.doorNumberLabel.Name = "doorNumberLabel";
            this.doorNumberLabel.Size = new System.Drawing.Size(58, 19);
            this.doorNumberLabel.TabIndex = 0;
            this.doorNumberLabel.Text = "Door N°";
            // 
            // selectPropertyTypeLabel
            // 
            this.selectPropertyTypeLabel.AutoSize = true;
            this.selectPropertyTypeLabel.Location = new System.Drawing.Point(3, 23);
            this.selectPropertyTypeLabel.Name = "selectPropertyTypeLabel";
            this.selectPropertyTypeLabel.Size = new System.Drawing.Size(144, 19);
            this.selectPropertyTypeLabel.TabIndex = 0;
            this.selectPropertyTypeLabel.Text = "Select type of property";
            // 
            // locationTab
            // 
            this.locationTab.Controls.Add(this.createLocationButton);
            this.locationTab.Controls.Add(this.metroLabel13);
            this.locationTab.Controls.Add(this.metroLabel14);
            this.locationTab.Controls.Add(this.cityToogle);
            this.locationTab.Controls.Add(this.metroLabel11);
            this.locationTab.Controls.Add(this.metroLabel12);
            this.locationTab.Controls.Add(this.stateToogle);
            this.locationTab.Controls.Add(this.gardenLabel);
            this.locationTab.Controls.Add(this.metroLabel9);
            this.locationTab.Controls.Add(this.countryToogle);
            this.locationTab.Controls.Add(this.metroLabel8);
            this.locationTab.Controls.Add(this.metroLabel7);
            this.locationTab.Controls.Add(this.metroLabel6);
            this.locationTab.Controls.Add(this.metroLabel3);
            this.locationTab.Controls.Add(this.metroLabel2);
            this.locationTab.Controls.Add(this.locCityComboBox);
            this.locationTab.Controls.Add(this.locStateComboBox);
            this.locationTab.Controls.Add(this.locCountryComboBox);
            this.locationTab.Controls.Add(this.locNeighborhoodTextBox);
            this.locationTab.Controls.Add(this.locCityTextBox);
            this.locationTab.Controls.Add(this.locStateTextBox);
            this.locationTab.Controls.Add(this.locCountryTextBox);
            this.locationTab.HorizontalScrollbarBarColor = true;
            this.locationTab.HorizontalScrollbarHighlightOnWheel = false;
            this.locationTab.HorizontalScrollbarSize = 10;
            this.locationTab.Location = new System.Drawing.Point(4, 38);
            this.locationTab.Name = "locationTab";
            this.locationTab.Size = new System.Drawing.Size(1002, 540);
            this.locationTab.TabIndex = 2;
            this.locationTab.Text = "Location";
            this.locationTab.VerticalScrollbarBarColor = true;
            this.locationTab.VerticalScrollbarHighlightOnWheel = false;
            this.locationTab.VerticalScrollbarSize = 10;
            // 
            // createLocationButton
            // 
            this.createLocationButton.Location = new System.Drawing.Point(640, 325);
            this.createLocationButton.Name = "createLocationButton";
            this.createLocationButton.Size = new System.Drawing.Size(75, 23);
            this.createLocationButton.TabIndex = 27;
            this.createLocationButton.Text = "Create";
            this.createLocationButton.UseSelectable = true;
            this.createLocationButton.Click += new System.EventHandler(this.createLocationButton_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(327, 246);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(38, 19);
            this.metroLabel13.TabIndex = 26;
            this.metroLabel13.Text = "Input";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(239, 246);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(43, 19);
            this.metroLabel14.TabIndex = 25;
            this.metroLabel14.Text = "Select";
            // 
            // cityToogle
            // 
            this.cityToogle.BackColor = System.Drawing.Color.Transparent;
            this.cityToogle.Location = new System.Drawing.Point(288, 246);
            this.cityToogle.Maximum = 1;
            this.cityToogle.Name = "cityToogle";
            this.cityToogle.Size = new System.Drawing.Size(33, 23);
            this.cityToogle.TabIndex = 24;
            this.cityToogle.Text = "metroTrackBar3";
            this.cityToogle.Value = 0;
            this.cityToogle.ValueChanged += new System.EventHandler(this.cityToogle_ValueChanged);
            this.cityToogle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.locCityToogle_Scroll);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(695, 88);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(38, 19);
            this.metroLabel11.TabIndex = 23;
            this.metroLabel11.Text = "Input";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(607, 88);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(43, 19);
            this.metroLabel12.TabIndex = 22;
            this.metroLabel12.Text = "Select";
            // 
            // stateToogle
            // 
            this.stateToogle.BackColor = System.Drawing.Color.Transparent;
            this.stateToogle.Location = new System.Drawing.Point(656, 88);
            this.stateToogle.Maximum = 1;
            this.stateToogle.Name = "stateToogle";
            this.stateToogle.Size = new System.Drawing.Size(33, 23);
            this.stateToogle.TabIndex = 21;
            this.stateToogle.Text = "metroTrackBar2";
            this.stateToogle.Value = 0;
            this.stateToogle.ValueChanged += new System.EventHandler(this.stateToogle_ValueChanged);
            this.stateToogle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.locStateToogle_Scroll);
            // 
            // gardenLabel
            // 
            this.gardenLabel.AutoSize = true;
            this.gardenLabel.Location = new System.Drawing.Point(327, 88);
            this.gardenLabel.Name = "gardenLabel";
            this.gardenLabel.Size = new System.Drawing.Size(38, 19);
            this.gardenLabel.TabIndex = 20;
            this.gardenLabel.Text = "Input";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(227, 88);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(43, 19);
            this.metroLabel9.TabIndex = 19;
            this.metroLabel9.Text = "Select";
            // 
            // countryToogle
            // 
            this.countryToogle.BackColor = System.Drawing.Color.Transparent;
            this.countryToogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countryToogle.LargeChange = 0;
            this.countryToogle.Location = new System.Drawing.Point(288, 88);
            this.countryToogle.Maximum = 1;
            this.countryToogle.MouseWheelBarPartitions = 1;
            this.countryToogle.Name = "countryToogle";
            this.countryToogle.Size = new System.Drawing.Size(33, 23);
            this.countryToogle.TabIndex = 18;
            this.countryToogle.Text = "metroTrackBar1";
            this.countryToogle.Value = 0;
            this.countryToogle.ValueChanged += new System.EventHandler(this.countryToogle_ValueChanged);
            this.countryToogle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.countryToogle_Scroll);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(227, 27);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(493, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "To create a location please choose from the created members or input new ones ..." +
    "";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(449, 246);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(124, 25);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Neighborhood";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(132, 246);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 25);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "City";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(449, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 25);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "State";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(132, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 25);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Country";
            // 
            // locCityComboBox
            // 
            this.locCityComboBox.FormattingEnabled = true;
            this.locCityComboBox.ItemHeight = 23;
            this.locCityComboBox.Location = new System.Drawing.Point(211, 272);
            this.locCityComboBox.Name = "locCityComboBox";
            this.locCityComboBox.Size = new System.Drawing.Size(179, 29);
            this.locCityComboBox.TabIndex = 7;
            this.locCityComboBox.UseSelectable = true;
            // 
            // locStateComboBox
            // 
            this.locStateComboBox.FormattingEnabled = true;
            this.locStateComboBox.ItemHeight = 23;
            this.locStateComboBox.Location = new System.Drawing.Point(588, 117);
            this.locStateComboBox.Name = "locStateComboBox";
            this.locStateComboBox.Size = new System.Drawing.Size(179, 29);
            this.locStateComboBox.TabIndex = 6;
            this.locStateComboBox.UseSelectable = true;
            // 
            // locCountryComboBox
            // 
            this.locCountryComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Uruguay",
            "Uganda",
            "Universal",
            "Unagui",
            "Nicaragua"});
            this.locCountryComboBox.DropDownHeight = 110;
            this.locCountryComboBox.FormattingEnabled = true;
            this.locCountryComboBox.IntegralHeight = false;
            this.locCountryComboBox.ItemHeight = 23;
            this.locCountryComboBox.Location = new System.Drawing.Point(211, 117);
            this.locCountryComboBox.Name = "locCountryComboBox";
            this.locCountryComboBox.Size = new System.Drawing.Size(179, 29);
            this.locCountryComboBox.TabIndex = 5;
            this.locCountryComboBox.UseSelectable = true;
            // 
            // locNeighborhoodTextBox
            // 
            this.locNeighborhoodTextBox.Lines = new string[0];
            this.locNeighborhoodTextBox.Location = new System.Drawing.Point(588, 277);
            this.locNeighborhoodTextBox.MaxLength = 32767;
            this.locNeighborhoodTextBox.Name = "locNeighborhoodTextBox";
            this.locNeighborhoodTextBox.PasswordChar = '\0';
            this.locNeighborhoodTextBox.PromptText = "Input neighborhood name...";
            this.locNeighborhoodTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.locNeighborhoodTextBox.SelectedText = "";
            this.locNeighborhoodTextBox.Size = new System.Drawing.Size(179, 23);
            this.locNeighborhoodTextBox.TabIndex = 12;
            this.locNeighborhoodTextBox.UseSelectable = true;
            this.locNeighborhoodTextBox.TextChanged += new System.EventHandler(this.locNeighborhoodTextBox_TextChanged);
            // 
            // locCityTextBox
            // 
            this.locCityTextBox.Lines = new string[0];
            this.locCityTextBox.Location = new System.Drawing.Point(211, 325);
            this.locCityTextBox.MaxLength = 32767;
            this.locCityTextBox.Name = "locCityTextBox";
            this.locCityTextBox.PasswordChar = '\0';
            this.locCityTextBox.PromptText = "Input city name...";
            this.locCityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.locCityTextBox.SelectedText = "";
            this.locCityTextBox.Size = new System.Drawing.Size(179, 23);
            this.locCityTextBox.TabIndex = 11;
            this.locCityTextBox.UseSelectable = true;
            this.locCityTextBox.Visible = false;
            this.locCityTextBox.TextChanged += new System.EventHandler(this.locCityTextBox_TextChanged);
            // 
            // locStateTextBox
            // 
            this.locStateTextBox.Lines = new string[0];
            this.locStateTextBox.Location = new System.Drawing.Point(588, 162);
            this.locStateTextBox.MaxLength = 32767;
            this.locStateTextBox.Name = "locStateTextBox";
            this.locStateTextBox.PasswordChar = '\0';
            this.locStateTextBox.PromptText = "Input state name...";
            this.locStateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.locStateTextBox.SelectedText = "";
            this.locStateTextBox.Size = new System.Drawing.Size(179, 23);
            this.locStateTextBox.TabIndex = 10;
            this.locStateTextBox.UseSelectable = true;
            this.locStateTextBox.Visible = false;
            this.locStateTextBox.TextChanged += new System.EventHandler(this.locStateTextBox_TextChanged);
            // 
            // locCountryTextBox
            // 
            this.locCountryTextBox.Lines = new string[0];
            this.locCountryTextBox.Location = new System.Drawing.Point(211, 162);
            this.locCountryTextBox.MaxLength = 32767;
            this.locCountryTextBox.Name = "locCountryTextBox";
            this.locCountryTextBox.PasswordChar = '\0';
            this.locCountryTextBox.PromptText = "Input country name...";
            this.locCountryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.locCountryTextBox.SelectedText = "";
            this.locCountryTextBox.Size = new System.Drawing.Size(179, 23);
            this.locCountryTextBox.TabIndex = 9;
            this.locCountryTextBox.UseSelectable = true;
            this.locCountryTextBox.Visible = false;
            this.locCountryTextBox.TextChanged += new System.EventHandler(this.locCountryTextBox_TextChanged);
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.Controls.Add(this.clientRentHisPropertyCheck);
            this.metroTabPage7.Controls.Add(this.clientSellHisPropertyCheck);
            this.metroTabPage7.Controls.Add(this.clientRentPropertyCheck);
            this.metroTabPage7.Controls.Add(this.clientBuyPropertyCheck);
            this.metroTabPage7.Controls.Add(this.clientNeighborhoodComboBox);
            this.metroTabPage7.Controls.Add(this.clientFinishButton);
            this.metroTabPage7.Controls.Add(this.metroLabel20);
            this.metroTabPage7.Controls.Add(this.metroLabel19);
            this.metroTabPage7.Controls.Add(this.metroLabel18);
            this.metroTabPage7.Controls.Add(this.metroLabel16);
            this.metroTabPage7.Controls.Add(this.metroLabel10);
            this.metroTabPage7.Controls.Add(this.selectClientAvatar);
            this.metroTabPage7.Controls.Add(this.clientEmailTextBox);
            this.metroTabPage7.Controls.Add(this.clientPhoneTextBox);
            this.metroTabPage7.Controls.Add(this.clientIdTextBox);
            this.metroTabPage7.Controls.Add(this.clientNameTextBox);
            this.metroTabPage7.Controls.Add(this.clientPictureBox);
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(1002, 540);
            this.metroTabPage7.TabIndex = 1;
            this.metroTabPage7.Text = "Client";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // clientRentHisPropertyCheck
            // 
            this.clientRentHisPropertyCheck.AutoSize = true;
            this.clientRentHisPropertyCheck.Location = new System.Drawing.Point(359, 293);
            this.clientRentHisPropertyCheck.Name = "clientRentHisPropertyCheck";
            this.clientRentHisPropertyCheck.Size = new System.Drawing.Size(140, 15);
            this.clientRentHisPropertyCheck.TabIndex = 21;
            this.clientRentHisPropertyCheck.Text = "Rent his/her property?";
            this.clientRentHisPropertyCheck.UseSelectable = true;
            // 
            // clientSellHisPropertyCheck
            // 
            this.clientSellHisPropertyCheck.AutoSize = true;
            this.clientSellHisPropertyCheck.Location = new System.Drawing.Point(359, 272);
            this.clientSellHisPropertyCheck.Name = "clientSellHisPropertyCheck";
            this.clientSellHisPropertyCheck.Size = new System.Drawing.Size(178, 15);
            this.clientSellHisPropertyCheck.TabIndex = 20;
            this.clientSellHisPropertyCheck.Text = "Want to sell his/her property?";
            this.clientSellHisPropertyCheck.UseSelectable = true;
            // 
            // clientRentPropertyCheck
            // 
            this.clientRentPropertyCheck.AutoSize = true;
            this.clientRentPropertyCheck.Location = new System.Drawing.Point(185, 293);
            this.clientRentPropertyCheck.Name = "clientRentPropertyCheck";
            this.clientRentPropertyCheck.Size = new System.Drawing.Size(151, 15);
            this.clientRentPropertyCheck.TabIndex = 19;
            this.clientRentPropertyCheck.Text = "Want to rent a property?";
            this.clientRentPropertyCheck.UseSelectable = true;
            // 
            // clientBuyPropertyCheck
            // 
            this.clientBuyPropertyCheck.AutoSize = true;
            this.clientBuyPropertyCheck.Location = new System.Drawing.Point(185, 272);
            this.clientBuyPropertyCheck.Name = "clientBuyPropertyCheck";
            this.clientBuyPropertyCheck.Size = new System.Drawing.Size(150, 15);
            this.clientBuyPropertyCheck.TabIndex = 18;
            this.clientBuyPropertyCheck.Text = "Want to buy a property?";
            this.clientBuyPropertyCheck.UseSelectable = true;
            // 
            // clientNeighborhoodComboBox
            // 
            this.clientNeighborhoodComboBox.FormattingEnabled = true;
            this.clientNeighborhoodComboBox.ItemHeight = 23;
            this.clientNeighborhoodComboBox.Location = new System.Drawing.Point(288, 92);
            this.clientNeighborhoodComboBox.Name = "clientNeighborhoodComboBox";
            this.clientNeighborhoodComboBox.Size = new System.Drawing.Size(184, 29);
            this.clientNeighborhoodComboBox.TabIndex = 17;
            this.clientNeighborhoodComboBox.UseSelectable = true;
            // 
            // clientFinishButton
            // 
            this.clientFinishButton.Location = new System.Drawing.Point(432, 390);
            this.clientFinishButton.Name = "clientFinishButton";
            this.clientFinishButton.Size = new System.Drawing.Size(75, 23);
            this.clientFinishButton.TabIndex = 16;
            this.clientFinishButton.Text = "Finish";
            this.clientFinishButton.UseSelectable = true;
            this.clientFinishButton.Click += new System.EventHandler(this.clientFinishButton_Click);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(184, 226);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(41, 19);
            this.metroLabel20.TabIndex = 12;
            this.metroLabel20.Text = "Email";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(183, 186);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(46, 19);
            this.metroLabel19.TabIndex = 11;
            this.metroLabel19.Text = "Phone";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(184, 95);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(96, 19);
            this.metroLabel18.TabIndex = 10;
            this.metroLabel18.Text = "Neighborhood";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(184, 146);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(21, 19);
            this.metroLabel16.TabIndex = 7;
            this.metroLabel16.Text = "ID";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(185, 52);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(45, 19);
            this.metroLabel10.TabIndex = 5;
            this.metroLabel10.Text = "Name";
            // 
            // selectClientAvatar
            // 
            this.selectClientAvatar.Location = new System.Drawing.Point(568, 285);
            this.selectClientAvatar.Name = "selectClientAvatar";
            this.selectClientAvatar.Size = new System.Drawing.Size(75, 23);
            this.selectClientAvatar.TabIndex = 3;
            this.selectClientAvatar.Text = "Select";
            this.selectClientAvatar.UseSelectable = true;
            this.selectClientAvatar.Click += new System.EventHandler(this.selectClientAvatar_Click);
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.Lines = new string[0];
            this.clientEmailTextBox.Location = new System.Drawing.Point(288, 226);
            this.clientEmailTextBox.MaxLength = 32767;
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.PasswordChar = '\0';
            this.clientEmailTextBox.PromptText = "The client email...";
            this.clientEmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientEmailTextBox.SelectedText = "";
            this.clientEmailTextBox.Size = new System.Drawing.Size(184, 23);
            this.clientEmailTextBox.TabIndex = 15;
            this.clientEmailTextBox.UseSelectable = true;
            // 
            // clientPhoneTextBox
            // 
            this.clientPhoneTextBox.Lines = new string[0];
            this.clientPhoneTextBox.Location = new System.Drawing.Point(287, 185);
            this.clientPhoneTextBox.MaxLength = 32767;
            this.clientPhoneTextBox.Name = "clientPhoneTextBox";
            this.clientPhoneTextBox.PasswordChar = '\0';
            this.clientPhoneTextBox.PromptText = "The client phone ...";
            this.clientPhoneTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientPhoneTextBox.SelectedText = "";
            this.clientPhoneTextBox.Size = new System.Drawing.Size(184, 23);
            this.clientPhoneTextBox.TabIndex = 14;
            this.clientPhoneTextBox.UseSelectable = true;
            this.clientPhoneTextBox.TextChanged += new System.EventHandler(this.clientPhoneTextBox_TextChanged);
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Lines = new string[0];
            this.clientIdTextBox.Location = new System.Drawing.Point(287, 144);
            this.clientIdTextBox.MaxLength = 32767;
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.PasswordChar = '\0';
            this.clientIdTextBox.PromptText = "The client id...";
            this.clientIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientIdTextBox.SelectedText = "";
            this.clientIdTextBox.Size = new System.Drawing.Size(184, 23);
            this.clientIdTextBox.TabIndex = 13;
            this.clientIdTextBox.UseSelectable = true;
            this.clientIdTextBox.TextChanged += new System.EventHandler(this.clientIdTextBox_TextChanged);
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Lines = new string[0];
            this.clientNameTextBox.Location = new System.Drawing.Point(288, 52);
            this.clientNameTextBox.MaxLength = 32767;
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.PasswordChar = '\0';
            this.clientNameTextBox.PromptText = "The client name...";
            this.clientNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientNameTextBox.SelectedText = "";
            this.clientNameTextBox.Size = new System.Drawing.Size(184, 23);
            this.clientNameTextBox.TabIndex = 4;
            this.clientNameTextBox.UseSelectable = true;
            this.clientNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.clientNameTextBox_KeyUp);
            // 
            // clientPictureBox
            // 
            this.clientPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("clientPictureBox.InitialImage")));
            this.clientPictureBox.Location = new System.Drawing.Point(509, 40);
            this.clientPictureBox.Name = "clientPictureBox";
            this.clientPictureBox.Size = new System.Drawing.Size(208, 225);
            this.clientPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clientPictureBox.TabIndex = 2;
            this.clientPictureBox.TabStop = false;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.modApartamentDataGrid);
            this.metroTabPage4.Controls.Add(this.modHouseDataGrid);
            this.metroTabPage4.Controls.Add(this.metroLabel21);
            this.metroTabPage4.Controls.Add(this.modificationsComboBox);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1002, 540);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Modifications";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // modApartamentDataGrid
            // 
            this.modApartamentDataGrid.AllowUserToAddRows = false;
            this.modApartamentDataGrid.AllowUserToDeleteRows = false;
            this.modApartamentDataGrid.AllowUserToResizeRows = false;
            this.modApartamentDataGrid.BackgroundColor = System.Drawing.Color.Maroon;
            this.modApartamentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modApartamentDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.modApartamentDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modApartamentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.modApartamentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modApartamentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bedrooms,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modApartamentDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.modApartamentDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.modApartamentDataGrid.EnableHeadersVisualStyles = false;
            this.modApartamentDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.modApartamentDataGrid.GridColor = System.Drawing.Color.White;
            this.modApartamentDataGrid.Location = new System.Drawing.Point(164, 93);
            this.modApartamentDataGrid.MultiSelect = false;
            this.modApartamentDataGrid.Name = "modApartamentDataGrid";
            this.modApartamentDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modApartamentDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.modApartamentDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.modApartamentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modApartamentDataGrid.Size = new System.Drawing.Size(718, 310);
            this.modApartamentDataGrid.TabIndex = 5;
            this.modApartamentDataGrid.Visible = false;
            // 
            // Bedrooms
            // 
            this.Bedrooms.HeaderText = "Bedrooms";
            this.Bedrooms.Name = "Bedrooms";
            this.Bedrooms.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bedrooms.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Bedrooms.ToolTipText = "Number of bedrooms...";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // modHouseDataGrid
            // 
            this.modHouseDataGrid.AllowUserToAddRows = false;
            this.modHouseDataGrid.AllowUserToDeleteRows = false;
            this.modHouseDataGrid.AllowUserToResizeRows = false;
            this.modHouseDataGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.modHouseDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modHouseDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.modHouseDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modHouseDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.modHouseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modHouseDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.modHouseDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.modHouseDataGrid.EnableHeadersVisualStyles = false;
            this.modHouseDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.modHouseDataGrid.GridColor = System.Drawing.Color.White;
            this.modHouseDataGrid.Location = new System.Drawing.Point(145, 93);
            this.modHouseDataGrid.MultiSelect = false;
            this.modHouseDataGrid.Name = "modHouseDataGrid";
            this.modHouseDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modHouseDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.modHouseDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.modHouseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modHouseDataGrid.Size = new System.Drawing.Size(718, 310);
            this.modHouseDataGrid.TabIndex = 4;
            this.modHouseDataGrid.Visible = false;
            this.modHouseDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.modHouseDataGrid_DataError);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(0, 20);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(133, 19);
            this.metroLabel21.TabIndex = 3;
            this.metroLabel21.Text = "Select field to modify";
            // 
            // modificationsComboBox
            // 
            this.modificationsComboBox.FormattingEnabled = true;
            this.modificationsComboBox.ItemHeight = 23;
            this.modificationsComboBox.Location = new System.Drawing.Point(193, 15);
            this.modificationsComboBox.Name = "modificationsComboBox";
            this.modificationsComboBox.Size = new System.Drawing.Size(185, 29);
            this.modificationsComboBox.TabIndex = 2;
            this.modificationsComboBox.UseSelectable = true;
            this.modificationsComboBox.SelectionChangeCommitted += new System.EventHandler(this.modificationComboBox_SelectionChangeCommitted);
            // 
            // modificationsGrid
            // 
            this.modificationsGrid.AllowUserToResizeRows = false;
            this.modificationsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modificationsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modificationsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.modificationsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modificationsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modificationsGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.modificationsGrid.EnableHeadersVisualStyles = false;
            this.modificationsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.modificationsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modificationsGrid.Location = new System.Drawing.Point(0, 0);
            this.modificationsGrid.Name = "modificationsGrid";
            this.modificationsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modificationsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.modificationsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.modificationsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modificationsGrid.Size = new System.Drawing.Size(240, 150);
            this.modificationsGrid.TabIndex = 1;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.addClientMetroTile);
            this.metroTabPage1.Controls.Add(this.addPropertyMetroTile);
            this.metroTabPage1.Controls.Add(this.welcomeLabel);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1002, 645);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // addClientMetroTile
            // 
            this.addClientMetroTile.ActiveControl = null;
            this.addClientMetroTile.Location = new System.Drawing.Point(560, 126);
            this.addClientMetroTile.Name = "addClientMetroTile";
            this.addClientMetroTile.Size = new System.Drawing.Size(341, 273);
            this.addClientMetroTile.TabIndex = 4;
            this.addClientMetroTile.Text = "Add client...";
            this.addClientMetroTile.UseSelectable = true;
            // 
            // addPropertyMetroTile
            // 
            this.addPropertyMetroTile.ActiveControl = null;
            this.addPropertyMetroTile.Location = new System.Drawing.Point(104, 126);
            this.addPropertyMetroTile.Name = "addPropertyMetroTile";
            this.addPropertyMetroTile.Size = new System.Drawing.Size(341, 273);
            this.addPropertyMetroTile.TabIndex = 3;
            this.addPropertyMetroTile.Text = "Add property...";
            this.addPropertyMetroTile.UseSelectable = true;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.welcomeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.welcomeLabel.Location = new System.Drawing.Point(408, 53);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(162, 25);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Bienvenido a POP3";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.AllowDrop = true;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1010, 687);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 615);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.modificationsGrid);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "POP3";
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryCustomPictureBox)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage6.ResumeLayout(false);
            this.metroTabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyPictureBox)).EndInit();
            this.locationTab.ResumeLayout(false);
            this.locationTab.PerformLayout();
            this.metroTabPage7.ResumeLayout(false);
            this.metroTabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPictureBox)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modApartamentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modHouseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificationsGrid)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroButton selectImageButton;
        private MetroFramework.Controls.MetroButton finishButton;
        private CustomComboBox conditionComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox forRentCheckBox;
        private MetroFramework.Controls.MetroCheckBox forSaleCheckBox;
        private CustomComboBox ownerComboBox;
        private CustomComboBox bathroomComboBox;
        private CustomComboBox bedroomComboBox;
        private CustomComboBox neighborhoodComboBox;
        private CustomComboBox propertyTypeComboBox;
        private CustomComboBox builtYearComboBox;
        private CustomTextBox squareMeterTextBox;
        private CustomTextBox doorNumberTextBox;
        private CustomTextBox sideStreetTextBox;
        private CustomTextBox mainStreetTextBox;
        private CustomPictureBox propertyPictureBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel ownerLabel;
        private MetroFramework.Controls.MetroLabel bathroomsLabel;
        private MetroFramework.Controls.MetroLabel bedroomLabel;
        private MetroFramework.Controls.MetroLabel squareMetersLabel;
        private MetroFramework.Controls.MetroLabel builtYearLabel;
        private MetroFramework.Controls.MetroLabel neighborhoodLabel;
        private MetroFramework.Controls.MetroLabel streetLabel;
        private MetroFramework.Controls.MetroLabel doorNumberLabel;
        private MetroFramework.Controls.MetroLabel selectPropertyTypeLabel;
        private MetroFramework.Controls.MetroTabPage locationTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel welcomeLabel;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private CustomComboBox garageComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private CustomPictureBox galleryCustomPictureBox;
        private MetroFramework.Controls.MetroCheckBox galleryGarageCheckBox;
        private MetroFramework.Controls.MetroCheckBox galleryHouseCheckBox;
        private MetroFramework.Controls.MetroCheckBox galleryForRentCheckBox;
        private MetroFramework.Controls.MetroCheckBox galleryForSaleCheckBox;
        private MetroFramework.Controls.MetroCheckBox galleryApartamentCheckBox;
        private CustomComboBox galleryGarageComboBox;
        private CustomComboBox galleryDormitoryComboBox;
        private MetroFramework.Controls.MetroCheckBox galleryDormitoryCheckBox;
        private CustomComboBox galleryNeighborhoodComboBox;
        private MetroFramework.Controls.MetroCheckBox galleryNeighborhoodCheckBox;
        private CustomComboBox galleryCountryComboBox;
        private MetroFramework.Controls.MetroCheckBox galleryCountryCheckBox;
        private MetroFramework.Controls.MetroCheckBox galleryPriceRangeCheckBox;
        private CustomComboBox galleryMaxPriceComboBox;
        private CustomComboBox galleryMinPriceComboBox;
        private MetroFramework.Controls.MetroButton galleryFilterGoButton;
        private CustomTextBox locCityTextBox;
        private CustomTextBox locStateTextBox;
        private CustomComboBox locCityComboBox;
        private CustomComboBox locStateComboBox;
        private CustomTextBox locNeighborhoodTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private CustomTextBox locCountryTextBox;
        private CustomComboBox locCountryComboBox;
        private MetroFramework.Controls.MetroTrackBar countryToogle;
        private MetroFramework.Controls.MetroLabel gardenLabel;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTrackBar cityToogle;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTrackBar stateToogle;
        private CustomTextBox apartamentNumber;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroCheckBox gardenCheckBox;
        private MetroFramework.Controls.MetroLabel floorsLabel;
        private CustomPictureBox clientPictureBox;
        private MetroFramework.Controls.MetroButton selectClientAvatar;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private CustomTextBox clientNameTextBox;
        private CustomTextBox clientEmailTextBox;
        private CustomTextBox clientPhoneTextBox;
        private CustomTextBox clientIdTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroButton clientFinishButton;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private CustomComboBox modificationsComboBox;
        private MetroFramework.Controls.MetroGrid modificationsGrid;
        private MetroFramework.Controls.MetroGrid modHouseDataGrid;
        private MetroFramework.Controls.MetroTile addClientMetroTile;
        private MetroFramework.Controls.MetroTile addPropertyMetroTile;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton createLocationButton;
        private MetroFramework.Controls.MetroGrid modApartamentDataGrid;
        private CustomTextBox floorsTextBox;
        private CustomComboBox clientNeighborhoodComboBox;
        private MetroFramework.Controls.MetroCheckBox clientRentHisPropertyCheck;
        private MetroFramework.Controls.MetroCheckBox clientSellHisPropertyCheck;
        private MetroFramework.Controls.MetroCheckBox clientRentPropertyCheck;
        private MetroFramework.Controls.MetroCheckBox clientBuyPropertyCheck;
        private MetroFramework.Controls.MetroButton createPropertyFinishButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bedrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;


    }
}

