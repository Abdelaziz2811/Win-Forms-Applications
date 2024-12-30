namespace PizzaApp
{
    partial class PizzaOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOptions));
            this.label1 = new System.Windows.Forms.Label();
            this.GBSize = new System.Windows.Forms.GroupBox();
            this.RDBTNLarge = new System.Windows.Forms.RadioButton();
            this.RDBTNMedium = new System.Windows.Forms.RadioButton();
            this.RDBTNSmall = new System.Windows.Forms.RadioButton();
            this.GBCrustType = new System.Windows.Forms.GroupBox();
            this.RDBTNThikCrust = new System.Windows.Forms.RadioButton();
            this.RDBTNThinCrust = new System.Windows.Forms.RadioButton();
            this.GBToppings = new System.Windows.Forms.GroupBox();
            this.CHBGreenPeppers = new System.Windows.Forms.CheckBox();
            this.CHBOlives = new System.Windows.Forms.CheckBox();
            this.CHBOnion = new System.Windows.Forms.CheckBox();
            this.CHBTomatoes = new System.Windows.Forms.CheckBox();
            this.CHBMushroums = new System.Windows.Forms.CheckBox();
            this.CHBExtraChees = new System.Windows.Forms.CheckBox();
            this.GBOrderSummary = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LBTotalPrice = new System.Windows.Forms.Label();
            this.LBWhereToEat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBCrustType = new System.Windows.Forms.Label();
            this.LBSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBToppings = new System.Windows.Forms.Label();
            this.GBWhereToEat = new System.Windows.Forms.GroupBox();
            this.RDBTNHomeDelivery = new System.Windows.Forms.RadioButton();
            this.RDBTNInRestaurant = new System.Windows.Forms.RadioButton();
            this.BTNOrder = new System.Windows.Forms.Button();
            this.BTNReset = new System.Windows.Forms.Button();
            this.GBSize.SuspendLayout();
            this.GBCrustType.SuspendLayout();
            this.GBToppings.SuspendLayout();
            this.GBOrderSummary.SuspendLayout();
            this.GBWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // GBSize
            // 
            this.GBSize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GBSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBSize.BackgroundImage")));
            this.GBSize.Controls.Add(this.RDBTNLarge);
            this.GBSize.Controls.Add(this.RDBTNMedium);
            this.GBSize.Controls.Add(this.RDBTNSmall);
            this.GBSize.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSize.ForeColor = System.Drawing.Color.Tomato;
            this.GBSize.Location = new System.Drawing.Point(38, 82);
            this.GBSize.Name = "GBSize";
            this.GBSize.Size = new System.Drawing.Size(148, 110);
            this.GBSize.TabIndex = 1;
            this.GBSize.TabStop = false;
            this.GBSize.Text = "Size";
            // 
            // RDBTNLarge
            // 
            this.RDBTNLarge.AutoSize = true;
            this.RDBTNLarge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RDBTNLarge.BackgroundImage")));
            this.RDBTNLarge.ForeColor = System.Drawing.SystemColors.Window;
            this.RDBTNLarge.Location = new System.Drawing.Point(6, 75);
            this.RDBTNLarge.Name = "RDBTNLarge";
            this.RDBTNLarge.Size = new System.Drawing.Size(69, 22);
            this.RDBTNLarge.TabIndex = 5;
            this.RDBTNLarge.TabStop = true;
            this.RDBTNLarge.Tag = "40";
            this.RDBTNLarge.Text = "Large";
            this.RDBTNLarge.UseVisualStyleBackColor = true;
            this.RDBTNLarge.CheckedChanged += new System.EventHandler(this.RDBTNLarge_CheckedChanged);
            // 
            // RDBTNMedium
            // 
            this.RDBTNMedium.AutoSize = true;
            this.RDBTNMedium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RDBTNMedium.BackgroundImage")));
            this.RDBTNMedium.ForeColor = System.Drawing.SystemColors.Window;
            this.RDBTNMedium.Location = new System.Drawing.Point(7, 50);
            this.RDBTNMedium.Name = "RDBTNMedium";
            this.RDBTNMedium.Size = new System.Drawing.Size(84, 22);
            this.RDBTNMedium.TabIndex = 4;
            this.RDBTNMedium.TabStop = true;
            this.RDBTNMedium.Tag = "30";
            this.RDBTNMedium.Text = "Medium";
            this.RDBTNMedium.UseVisualStyleBackColor = true;
            this.RDBTNMedium.CheckedChanged += new System.EventHandler(this.RDBTNMedium_CheckedChanged);
            // 
            // RDBTNSmall
            // 
            this.RDBTNSmall.AutoSize = true;
            this.RDBTNSmall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RDBTNSmall.BackgroundImage")));
            this.RDBTNSmall.ForeColor = System.Drawing.SystemColors.Window;
            this.RDBTNSmall.Location = new System.Drawing.Point(6, 25);
            this.RDBTNSmall.Name = "RDBTNSmall";
            this.RDBTNSmall.Size = new System.Drawing.Size(68, 22);
            this.RDBTNSmall.TabIndex = 3;
            this.RDBTNSmall.TabStop = true;
            this.RDBTNSmall.Tag = "20";
            this.RDBTNSmall.Text = "Small";
            this.RDBTNSmall.UseVisualStyleBackColor = true;
            this.RDBTNSmall.CheckedChanged += new System.EventHandler(this.RDBTNSmall_CheckedChanged);
            // 
            // GBCrustType
            // 
            this.GBCrustType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GBCrustType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBCrustType.BackgroundImage")));
            this.GBCrustType.Controls.Add(this.RDBTNThikCrust);
            this.GBCrustType.Controls.Add(this.RDBTNThinCrust);
            this.GBCrustType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCrustType.ForeColor = System.Drawing.Color.Tomato;
            this.GBCrustType.Location = new System.Drawing.Point(38, 215);
            this.GBCrustType.Name = "GBCrustType";
            this.GBCrustType.Size = new System.Drawing.Size(148, 86);
            this.GBCrustType.TabIndex = 2;
            this.GBCrustType.TabStop = false;
            this.GBCrustType.Text = "Crurst Type";
            // 
            // RDBTNThikCrust
            // 
            this.RDBTNThikCrust.AutoSize = true;
            this.RDBTNThikCrust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RDBTNThikCrust.BackgroundImage")));
            this.RDBTNThikCrust.ForeColor = System.Drawing.Color.SeaShell;
            this.RDBTNThikCrust.Location = new System.Drawing.Point(7, 53);
            this.RDBTNThikCrust.Name = "RDBTNThikCrust";
            this.RDBTNThikCrust.Size = new System.Drawing.Size(102, 22);
            this.RDBTNThikCrust.TabIndex = 6;
            this.RDBTNThikCrust.TabStop = true;
            this.RDBTNThikCrust.Tag = "10";
            this.RDBTNThikCrust.Text = "Thik Crust";
            this.RDBTNThikCrust.UseVisualStyleBackColor = true;
            this.RDBTNThikCrust.CheckedChanged += new System.EventHandler(this.RDBTNThinkCrust_CheckedChanged);
            // 
            // RDBTNThinCrust
            // 
            this.RDBTNThinCrust.AutoSize = true;
            this.RDBTNThinCrust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RDBTNThinCrust.BackgroundImage")));
            this.RDBTNThinCrust.ForeColor = System.Drawing.SystemColors.Window;
            this.RDBTNThinCrust.Location = new System.Drawing.Point(7, 25);
            this.RDBTNThinCrust.Name = "RDBTNThinCrust";
            this.RDBTNThinCrust.Size = new System.Drawing.Size(102, 22);
            this.RDBTNThinCrust.TabIndex = 5;
            this.RDBTNThinCrust.TabStop = true;
            this.RDBTNThinCrust.Tag = "0";
            this.RDBTNThinCrust.Text = "Thin Crust";
            this.RDBTNThinCrust.UseVisualStyleBackColor = true;
            this.RDBTNThinCrust.CheckedChanged += new System.EventHandler(this.RDBTNThinCrust_CheckedChanged);
            // 
            // GBToppings
            // 
            this.GBToppings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GBToppings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBToppings.BackgroundImage")));
            this.GBToppings.Controls.Add(this.CHBGreenPeppers);
            this.GBToppings.Controls.Add(this.CHBOlives);
            this.GBToppings.Controls.Add(this.CHBOnion);
            this.GBToppings.Controls.Add(this.CHBTomatoes);
            this.GBToppings.Controls.Add(this.CHBMushroums);
            this.GBToppings.Controls.Add(this.CHBExtraChees);
            this.GBToppings.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBToppings.ForeColor = System.Drawing.Color.Tomato;
            this.GBToppings.Location = new System.Drawing.Point(218, 81);
            this.GBToppings.Name = "GBToppings";
            this.GBToppings.Size = new System.Drawing.Size(314, 110);
            this.GBToppings.TabIndex = 6;
            this.GBToppings.TabStop = false;
            this.GBToppings.Text = "Toppings";
            // 
            // CHBGreenPeppers
            // 
            this.CHBGreenPeppers.AutoSize = true;
            this.CHBGreenPeppers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CHBGreenPeppers.BackgroundImage")));
            this.CHBGreenPeppers.ForeColor = System.Drawing.SystemColors.Window;
            this.CHBGreenPeppers.Location = new System.Drawing.Point(128, 74);
            this.CHBGreenPeppers.Name = "CHBGreenPeppers";
            this.CHBGreenPeppers.Size = new System.Drawing.Size(137, 22);
            this.CHBGreenPeppers.TabIndex = 12;
            this.CHBGreenPeppers.Tag = "5";
            this.CHBGreenPeppers.Text = "Green Peppers";
            this.CHBGreenPeppers.UseVisualStyleBackColor = true;
            this.CHBGreenPeppers.CheckedChanged += new System.EventHandler(this.CHBGreenPeppers_CheckedChanged);
            // 
            // CHBOlives
            // 
            this.CHBOlives.AutoSize = true;
            this.CHBOlives.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CHBOlives.BackgroundImage")));
            this.CHBOlives.ForeColor = System.Drawing.SystemColors.Window;
            this.CHBOlives.Location = new System.Drawing.Point(128, 50);
            this.CHBOlives.Name = "CHBOlives";
            this.CHBOlives.Size = new System.Drawing.Size(75, 22);
            this.CHBOlives.TabIndex = 11;
            this.CHBOlives.Tag = "5";
            this.CHBOlives.Text = "Olives";
            this.CHBOlives.UseVisualStyleBackColor = true;
            this.CHBOlives.CheckedChanged += new System.EventHandler(this.CHBOlives_CheckedChanged);
            // 
            // CHBOnion
            // 
            this.CHBOnion.AutoSize = true;
            this.CHBOnion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CHBOnion.BackgroundImage")));
            this.CHBOnion.ForeColor = System.Drawing.SystemColors.Window;
            this.CHBOnion.Location = new System.Drawing.Point(128, 26);
            this.CHBOnion.Name = "CHBOnion";
            this.CHBOnion.Size = new System.Drawing.Size(71, 22);
            this.CHBOnion.TabIndex = 10;
            this.CHBOnion.Tag = "5";
            this.CHBOnion.Text = "Onion";
            this.CHBOnion.UseVisualStyleBackColor = true;
            this.CHBOnion.CheckedChanged += new System.EventHandler(this.CHBOnion_CheckedChanged);
            // 
            // CHBTomatoes
            // 
            this.CHBTomatoes.AutoSize = true;
            this.CHBTomatoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CHBTomatoes.BackgroundImage")));
            this.CHBTomatoes.ForeColor = System.Drawing.SystemColors.Window;
            this.CHBTomatoes.Location = new System.Drawing.Point(6, 51);
            this.CHBTomatoes.Name = "CHBTomatoes";
            this.CHBTomatoes.Size = new System.Drawing.Size(99, 22);
            this.CHBTomatoes.TabIndex = 9;
            this.CHBTomatoes.Tag = "5";
            this.CHBTomatoes.Text = "Tomatoes";
            this.CHBTomatoes.UseVisualStyleBackColor = true;
            this.CHBTomatoes.CheckedChanged += new System.EventHandler(this.CHBTomatoes_CheckedChanged);
            // 
            // CHBMushroums
            // 
            this.CHBMushroums.AutoSize = true;
            this.CHBMushroums.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CHBMushroums.BackgroundImage")));
            this.CHBMushroums.ForeColor = System.Drawing.SystemColors.Window;
            this.CHBMushroums.Location = new System.Drawing.Point(6, 76);
            this.CHBMushroums.Name = "CHBMushroums";
            this.CHBMushroums.Size = new System.Drawing.Size(112, 22);
            this.CHBMushroums.TabIndex = 8;
            this.CHBMushroums.Tag = "5";
            this.CHBMushroums.Text = "Mushroums";
            this.CHBMushroums.UseVisualStyleBackColor = true;
            this.CHBMushroums.CheckedChanged += new System.EventHandler(this.CHBMushroums_CheckedChanged);
            // 
            // CHBExtraChees
            // 
            this.CHBExtraChees.AutoSize = true;
            this.CHBExtraChees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CHBExtraChees.BackgroundImage")));
            this.CHBExtraChees.ForeColor = System.Drawing.SystemColors.Window;
            this.CHBExtraChees.Location = new System.Drawing.Point(6, 26);
            this.CHBExtraChees.Name = "CHBExtraChees";
            this.CHBExtraChees.Size = new System.Drawing.Size(116, 22);
            this.CHBExtraChees.TabIndex = 7;
            this.CHBExtraChees.Tag = "5";
            this.CHBExtraChees.Text = "Extra Chees";
            this.CHBExtraChees.UseVisualStyleBackColor = true;
            this.CHBExtraChees.CheckedChanged += new System.EventHandler(this.CHBExtraChees_CheckedChanged);
            // 
            // GBOrderSummary
            // 
            this.GBOrderSummary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBOrderSummary.BackgroundImage")));
            this.GBOrderSummary.Controls.Add(this.label7);
            this.GBOrderSummary.Controls.Add(this.LBTotalPrice);
            this.GBOrderSummary.Controls.Add(this.LBWhereToEat);
            this.GBOrderSummary.Controls.Add(this.label6);
            this.GBOrderSummary.Controls.Add(this.label5);
            this.GBOrderSummary.Controls.Add(this.label4);
            this.GBOrderSummary.Controls.Add(this.LBCrustType);
            this.GBOrderSummary.Controls.Add(this.LBSize);
            this.GBOrderSummary.Controls.Add(this.label3);
            this.GBOrderSummary.Controls.Add(this.label2);
            this.GBOrderSummary.Controls.Add(this.LBToppings);
            this.GBOrderSummary.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOrderSummary.ForeColor = System.Drawing.Color.Tomato;
            this.GBOrderSummary.Location = new System.Drawing.Point(218, 213);
            this.GBOrderSummary.Name = "GBOrderSummary";
            this.GBOrderSummary.Size = new System.Drawing.Size(314, 207);
            this.GBOrderSummary.TabIndex = 7;
            this.GBOrderSummary.TabStop = false;
            this.GBOrderSummary.Text = "Order Summary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(141, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "$";
            // 
            // LBTotalPrice
            // 
            this.LBTotalPrice.AutoSize = true;
            this.LBTotalPrice.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.LBTotalPrice.Image = ((System.Drawing.Image)(resources.GetObject("LBTotalPrice.Image")));
            this.LBTotalPrice.Location = new System.Drawing.Point(107, 177);
            this.LBTotalPrice.Name = "LBTotalPrice";
            this.LBTotalPrice.Size = new System.Drawing.Size(28, 18);
            this.LBTotalPrice.TabIndex = 14;
            this.LBTotalPrice.Text = "00";
            // 
            // LBWhereToEat
            // 
            this.LBWhereToEat.AutoSize = true;
            this.LBWhereToEat.ForeColor = System.Drawing.SystemColors.Window;
            this.LBWhereToEat.Image = ((System.Drawing.Image)(resources.GetObject("LBWhereToEat.Image")));
            this.LBWhereToEat.Location = new System.Drawing.Point(128, 152);
            this.LBWhereToEat.Name = "LBWhereToEat";
            this.LBWhereToEat.Size = new System.Drawing.Size(0, 18);
            this.LBWhereToEat.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Where To Eat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Toppings :";
            // 
            // LBCrustType
            // 
            this.LBCrustType.AutoSize = true;
            this.LBCrustType.ForeColor = System.Drawing.SystemColors.Window;
            this.LBCrustType.Image = ((System.Drawing.Image)(resources.GetObject("LBCrustType.Image")));
            this.LBCrustType.Location = new System.Drawing.Point(105, 51);
            this.LBCrustType.Name = "LBCrustType";
            this.LBCrustType.Size = new System.Drawing.Size(0, 18);
            this.LBCrustType.TabIndex = 3;
            // 
            // LBSize
            // 
            this.LBSize.AutoSize = true;
            this.LBSize.ForeColor = System.Drawing.SystemColors.Window;
            this.LBSize.Image = ((System.Drawing.Image)(resources.GetObject("LBSize.Image")));
            this.LBSize.Location = new System.Drawing.Point(61, 27);
            this.LBSize.Name = "LBSize";
            this.LBSize.Size = new System.Drawing.Size(0, 18);
            this.LBSize.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thin Crust :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size :";
            // 
            // LBToppings
            // 
            this.LBToppings.AutoSize = true;
            this.LBToppings.ForeColor = System.Drawing.Color.Snow;
            this.LBToppings.Image = ((System.Drawing.Image)(resources.GetObject("LBToppings.Image")));
            this.LBToppings.Location = new System.Drawing.Point(6, 106);
            this.LBToppings.Name = "LBToppings";
            this.LBToppings.Size = new System.Drawing.Size(100, 18);
            this.LBToppings.TabIndex = 16;
            this.LBToppings.Text = "No Toppings";
            // 
            // GBWhereToEat
            // 
            this.GBWhereToEat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GBWhereToEat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBWhereToEat.BackgroundImage")));
            this.GBWhereToEat.Controls.Add(this.RDBTNHomeDelivery);
            this.GBWhereToEat.Controls.Add(this.RDBTNInRestaurant);
            this.GBWhereToEat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBWhereToEat.ForeColor = System.Drawing.Color.Tomato;
            this.GBWhereToEat.Location = new System.Drawing.Point(38, 324);
            this.GBWhereToEat.Name = "GBWhereToEat";
            this.GBWhereToEat.Size = new System.Drawing.Size(148, 96);
            this.GBWhereToEat.TabIndex = 7;
            this.GBWhereToEat.TabStop = false;
            this.GBWhereToEat.Text = "Where To Eat";
            // 
            // RDBTNHomeDelivery
            // 
            this.RDBTNHomeDelivery.AutoSize = true;
            this.RDBTNHomeDelivery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RDBTNHomeDelivery.BackgroundImage")));
            this.RDBTNHomeDelivery.ForeColor = System.Drawing.Color.SeaShell;
            this.RDBTNHomeDelivery.Location = new System.Drawing.Point(7, 25);
            this.RDBTNHomeDelivery.Name = "RDBTNHomeDelivery";
            this.RDBTNHomeDelivery.Size = new System.Drawing.Size(136, 22);
            this.RDBTNHomeDelivery.TabIndex = 6;
            this.RDBTNHomeDelivery.TabStop = true;
            this.RDBTNHomeDelivery.Tag = "10";
            this.RDBTNHomeDelivery.Text = "Home Delivery";
            this.RDBTNHomeDelivery.UseVisualStyleBackColor = true;
            this.RDBTNHomeDelivery.CheckedChanged += new System.EventHandler(this.RDBTNHomeDelivery_CheckedChanged);
            // 
            // RDBTNInRestaurant
            // 
            this.RDBTNInRestaurant.AutoSize = true;
            this.RDBTNInRestaurant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RDBTNInRestaurant.BackgroundImage")));
            this.RDBTNInRestaurant.ForeColor = System.Drawing.SystemColors.Window;
            this.RDBTNInRestaurant.Location = new System.Drawing.Point(6, 53);
            this.RDBTNInRestaurant.Name = "RDBTNInRestaurant";
            this.RDBTNInRestaurant.Size = new System.Drawing.Size(129, 22);
            this.RDBTNInRestaurant.TabIndex = 5;
            this.RDBTNInRestaurant.TabStop = true;
            this.RDBTNInRestaurant.Tag = "0";
            this.RDBTNInRestaurant.Text = "In Restaurant";
            this.RDBTNInRestaurant.UseVisualStyleBackColor = true;
            this.RDBTNInRestaurant.CheckedChanged += new System.EventHandler(this.RDBTNInRestaurant_CheckedChanged);
            // 
            // BTNOrder
            // 
            this.BTNOrder.BackColor = System.Drawing.Color.LightSalmon;
            this.BTNOrder.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.BTNOrder.FlatAppearance.BorderSize = 2;
            this.BTNOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BTNOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.BTNOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNOrder.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNOrder.Location = new System.Drawing.Point(322, 24);
            this.BTNOrder.Name = "BTNOrder";
            this.BTNOrder.Size = new System.Drawing.Size(75, 35);
            this.BTNOrder.TabIndex = 8;
            this.BTNOrder.Text = "Order";
            this.BTNOrder.UseVisualStyleBackColor = false;
            this.BTNOrder.Click += new System.EventHandler(this.BTNOrder_Click);
            // 
            // BTNReset
            // 
            this.BTNReset.BackColor = System.Drawing.Color.LightSalmon;
            this.BTNReset.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.BTNReset.FlatAppearance.BorderSize = 2;
            this.BTNReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BTNReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.BTNReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNReset.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNReset.Location = new System.Drawing.Point(433, 24);
            this.BTNReset.Name = "BTNReset";
            this.BTNReset.Size = new System.Drawing.Size(75, 35);
            this.BTNReset.TabIndex = 9;
            this.BTNReset.Text = "Reset";
            this.BTNReset.UseVisualStyleBackColor = false;
            this.BTNReset.Click += new System.EventHandler(this.BTNReset_Click);
            // 
            // PizzaOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNReset);
            this.Controls.Add(this.BTNOrder);
            this.Controls.Add(this.GBWhereToEat);
            this.Controls.Add(this.GBOrderSummary);
            this.Controls.Add(this.GBToppings);
            this.Controls.Add(this.GBCrustType);
            this.Controls.Add(this.GBSize);
            this.Controls.Add(this.label1);
            this.Name = "PizzaOptions";
            this.Text = "Pizza Options";
            this.GBSize.ResumeLayout(false);
            this.GBSize.PerformLayout();
            this.GBCrustType.ResumeLayout(false);
            this.GBCrustType.PerformLayout();
            this.GBToppings.ResumeLayout(false);
            this.GBToppings.PerformLayout();
            this.GBOrderSummary.ResumeLayout(false);
            this.GBOrderSummary.PerformLayout();
            this.GBWhereToEat.ResumeLayout(false);
            this.GBWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBSize;
        private System.Windows.Forms.RadioButton RDBTNSmall;
        private System.Windows.Forms.GroupBox GBCrustType;
        private System.Windows.Forms.RadioButton RDBTNLarge;
        private System.Windows.Forms.RadioButton RDBTNMedium;
        private System.Windows.Forms.RadioButton RDBTNThikCrust;
        private System.Windows.Forms.RadioButton RDBTNThinCrust;
        private System.Windows.Forms.GroupBox GBToppings;
        private System.Windows.Forms.CheckBox CHBGreenPeppers;
        private System.Windows.Forms.CheckBox CHBOlives;
        private System.Windows.Forms.CheckBox CHBOnion;
        private System.Windows.Forms.CheckBox CHBTomatoes;
        private System.Windows.Forms.CheckBox CHBMushroums;
        private System.Windows.Forms.CheckBox CHBExtraChees;
        private System.Windows.Forms.GroupBox GBOrderSummary;
        private System.Windows.Forms.GroupBox GBWhereToEat;
        private System.Windows.Forms.RadioButton RDBTNHomeDelivery;
        private System.Windows.Forms.RadioButton RDBTNInRestaurant;
        private System.Windows.Forms.Label LBSize;
        private System.Windows.Forms.Label LBCrustType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBTotalPrice;
        private System.Windows.Forms.Label LBWhereToEat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBToppings;
        private System.Windows.Forms.Button BTNOrder;
        private System.Windows.Forms.Button BTNReset;
    }
}