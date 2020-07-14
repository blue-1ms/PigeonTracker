namespace Video_Games_APP
{
    partial class frmVGL
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDeveloper = new System.Windows.Forms.TextBox();
            this.comboBoxPlatfom = new System.Windows.Forms.ComboBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.groupBoxRating = new System.Windows.Forms.GroupBox();
            this.radioButtonX = new System.Windows.Forms.RadioButton();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.radioButtonMA = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonPG = new System.Windows.Forms.RadioButton();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.lblGL = new System.Windows.Forms.Label();
            this.listGames = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxRating.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(13, 42);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(53, 12);
            this.lblPlatform.TabIndex = 1;
            this.lblPlatform.Text = "Platform";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(13, 72);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(35, 12);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(187, 42);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(59, 12);
            this.lblDev.TabIndex = 3;
            this.lblDev.Text = "Developer";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(187, 11);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 12);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price (AUD)";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(72, 11);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(113, 21);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(264, 9);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(116, 21);
            this.textBoxPrice.TabIndex = 6;
            // 
            // textBoxDeveloper
            // 
            this.textBoxDeveloper.Location = new System.Drawing.Point(264, 40);
            this.textBoxDeveloper.Name = "textBoxDeveloper";
            this.textBoxDeveloper.Size = new System.Drawing.Size(116, 21);
            this.textBoxDeveloper.TabIndex = 7;
            // 
            // comboBoxPlatfom
            // 
            this.comboBoxPlatfom.FormattingEnabled = true;
            this.comboBoxPlatfom.Items.AddRange(new object[] {
            "PC Games",
            "Xbox One",
            "PS4",
            "Xbox",
            "PS3",
            "PSP",
            "Wii U",
            "Wii",
            "Nintendo DS",
            "iPhone",
            "Mac"});
            this.comboBoxPlatfom.Location = new System.Drawing.Point(72, 42);
            this.comboBoxPlatfom.Name = "comboBoxPlatfom";
            this.comboBoxPlatfom.Size = new System.Drawing.Size(113, 20);
            this.comboBoxPlatfom.TabIndex = 8;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "Action",
            "Kids",
            "Puzzle",
            "Racing",
            "RPG",
            "Shooting",
            "Simulation",
            "Sport"});
            this.comboBoxGenre.Location = new System.Drawing.Point(72, 72);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(113, 20);
            this.comboBoxGenre.TabIndex = 9;
            // 
            // groupBoxRating
            // 
            this.groupBoxRating.Controls.Add(this.radioButtonX);
            this.groupBoxRating.Controls.Add(this.radioButtonR);
            this.groupBoxRating.Controls.Add(this.radioButtonMA);
            this.groupBoxRating.Controls.Add(this.radioButtonM);
            this.groupBoxRating.Controls.Add(this.radioButtonPG);
            this.groupBoxRating.Controls.Add(this.radioButtonG);
            this.groupBoxRating.Location = new System.Drawing.Point(16, 109);
            this.groupBoxRating.Name = "groupBoxRating";
            this.groupBoxRating.Size = new System.Drawing.Size(169, 177);
            this.groupBoxRating.TabIndex = 10;
            this.groupBoxRating.TabStop = false;
            this.groupBoxRating.Text = "Rating";
            // 
            // radioButtonX
            // 
            this.radioButtonX.AutoSize = true;
            this.radioButtonX.Location = new System.Drawing.Point(10, 141);
            this.radioButtonX.Name = "radioButtonX";
            this.radioButtonX.Size = new System.Drawing.Size(107, 16);
            this.radioButtonX.TabIndex = 5;
            this.radioButtonX.TabStop = true;
            this.radioButtonX.Text = "Restricted (X)";
            this.radioButtonX.UseVisualStyleBackColor = true;
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Location = new System.Drawing.Point(10, 120);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(107, 16);
            this.radioButtonR.TabIndex = 4;
            this.radioButtonR.TabStop = true;
            this.radioButtonR.Text = "Restricted (R)";
            this.radioButtonR.UseVisualStyleBackColor = true;
            // 
            // radioButtonMA
            // 
            this.radioButtonMA.AutoSize = true;
            this.radioButtonMA.Location = new System.Drawing.Point(10, 99);
            this.radioButtonMA.Name = "radioButtonMA";
            this.radioButtonMA.Size = new System.Drawing.Size(149, 16);
            this.radioButtonMA.TabIndex = 3;
            this.radioButtonMA.TabStop = true;
            this.radioButtonMA.Text = "Mature Audiences (MA)";
            this.radioButtonMA.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(10, 78);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(83, 16);
            this.radioButtonM.TabIndex = 2;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Mature (M)";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonPG
            // 
            this.radioButtonPG.AutoSize = true;
            this.radioButtonPG.Location = new System.Drawing.Point(10, 56);
            this.radioButtonPG.Name = "radioButtonPG";
            this.radioButtonPG.Size = new System.Drawing.Size(155, 16);
            this.radioButtonPG.TabIndex = 1;
            this.radioButtonPG.TabStop = true;
            this.radioButtonPG.Text = "Parental Guidance (PG)";
            this.radioButtonPG.UseVisualStyleBackColor = true;
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(10, 35);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(89, 16);
            this.radioButtonG.TabIndex = 0;
            this.radioButtonG.TabStop = true;
            this.radioButtonG.Text = "General (G)";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // lblGL
            // 
            this.lblGL.AutoSize = true;
            this.lblGL.Location = new System.Drawing.Point(196, 109);
            this.lblGL.Name = "lblGL";
            this.lblGL.Size = new System.Drawing.Size(59, 12);
            this.lblGL.TabIndex = 11;
            this.lblGL.Text = "Game List";
            // 
            // listGames
            // 
            this.listGames.FormattingEnabled = true;
            this.listGames.ItemHeight = 12;
            this.listGames.Location = new System.Drawing.Point(198, 134);
            this.listGames.Name = "listGames";
            this.listGames.Size = new System.Drawing.Size(181, 256);
            this.listGames.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 21);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(110, 303);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 21);
            this.btnDisplay.TabIndex = 14;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(110, 336);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 21);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(110, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 21);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmVGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 402);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listGames);
            this.Controls.Add(this.lblGL);
            this.Controls.Add(this.groupBoxRating);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.comboBoxPlatfom);
            this.Controls.Add(this.textBoxDeveloper);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lblName);
            this.Name = "frmVGL";
            this.Text = "Video Games Library";
            this.groupBoxRating.ResumeLayout(false);
            this.groupBoxRating.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDeveloper;
        private System.Windows.Forms.ComboBox comboBoxPlatfom;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.GroupBox groupBoxRating;
        private System.Windows.Forms.RadioButton radioButtonX;
        private System.Windows.Forms.RadioButton radioButtonR;
        private System.Windows.Forms.RadioButton radioButtonMA;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonPG;
        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.Label lblGL;
        private System.Windows.Forms.ListBox listGames;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

