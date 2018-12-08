namespace MTGCollection
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.colorlessCheckBox = new System.Windows.Forms.CheckBox();
            this.otherTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.spellCheckBox = new System.Windows.Forms.CheckBox();
            this.instantCheckBox = new System.Windows.Forms.CheckBox();
            this.planeswalkerCheckBox = new System.Windows.Forms.CheckBox();
            this.enchantmentCheckBox = new System.Windows.Forms.CheckBox();
            this.artifactCheckBox = new System.Windows.Forms.CheckBox();
            this.creatureCheckBox = new System.Windows.Forms.CheckBox();
            this.landCheckBox = new System.Windows.Forms.CheckBox();
            this.blueCheckBox = new System.Windows.Forms.CheckBox();
            this.redCheckBox = new System.Windows.Forms.CheckBox();
            this.greenCheckBox = new System.Windows.Forms.CheckBox();
            this.blackCheckBox = new System.Windows.Forms.CheckBox();
            this.whiteCheckBox = new System.Windows.Forms.CheckBox();
            this.cardNameTxtBox = new System.Windows.Forms.TextBox();
            this.cardTypeLabel = new System.Windows.Forms.Label();
            this.cardColorLabel = new System.Windows.Forms.Label();
            this.collectionIDLabel = new System.Windows.Forms.Label();
            this.collectionIDTxtBox = new System.Windows.Forms.TextBox();
            this.cardNameLabel = new System.Windows.Forms.Label();
            this.makeSearchButton = new System.Windows.Forms.Button();
            this.cancelSearchButton = new System.Windows.Forms.Button();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.colorlessCheckBox);
            this.searchGroupBox.Controls.Add(this.otherTypeCheckBox);
            this.searchGroupBox.Controls.Add(this.spellCheckBox);
            this.searchGroupBox.Controls.Add(this.instantCheckBox);
            this.searchGroupBox.Controls.Add(this.planeswalkerCheckBox);
            this.searchGroupBox.Controls.Add(this.enchantmentCheckBox);
            this.searchGroupBox.Controls.Add(this.artifactCheckBox);
            this.searchGroupBox.Controls.Add(this.creatureCheckBox);
            this.searchGroupBox.Controls.Add(this.landCheckBox);
            this.searchGroupBox.Controls.Add(this.blueCheckBox);
            this.searchGroupBox.Controls.Add(this.redCheckBox);
            this.searchGroupBox.Controls.Add(this.greenCheckBox);
            this.searchGroupBox.Controls.Add(this.blackCheckBox);
            this.searchGroupBox.Controls.Add(this.whiteCheckBox);
            this.searchGroupBox.Controls.Add(this.cardNameTxtBox);
            this.searchGroupBox.Controls.Add(this.cardTypeLabel);
            this.searchGroupBox.Controls.Add(this.cardColorLabel);
            this.searchGroupBox.Controls.Add(this.collectionIDLabel);
            this.searchGroupBox.Controls.Add(this.collectionIDTxtBox);
            this.searchGroupBox.Controls.Add(this.cardNameLabel);
            this.searchGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(455, 187);
            this.searchGroupBox.TabIndex = 0;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // colorlessCheckBox
            // 
            this.colorlessCheckBox.AutoSize = true;
            this.colorlessCheckBox.Location = new System.Drawing.Point(373, 100);
            this.colorlessCheckBox.Name = "colorlessCheckBox";
            this.colorlessCheckBox.Size = new System.Drawing.Size(68, 17);
            this.colorlessCheckBox.TabIndex = 19;
            this.colorlessCheckBox.Text = "Colorless";
            this.colorlessCheckBox.UseVisualStyleBackColor = true;
            // 
            // otherTypeCheckBox
            // 
            this.otherTypeCheckBox.AutoSize = true;
            this.otherTypeCheckBox.Location = new System.Drawing.Point(292, 160);
            this.otherTypeCheckBox.Name = "otherTypeCheckBox";
            this.otherTypeCheckBox.Size = new System.Drawing.Size(52, 17);
            this.otherTypeCheckBox.TabIndex = 18;
            this.otherTypeCheckBox.Text = "Other";
            this.otherTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // spellCheckBox
            // 
            this.spellCheckBox.AutoSize = true;
            this.spellCheckBox.Location = new System.Drawing.Point(240, 160);
            this.spellCheckBox.Name = "spellCheckBox";
            this.spellCheckBox.Size = new System.Drawing.Size(49, 17);
            this.spellCheckBox.TabIndex = 17;
            this.spellCheckBox.Text = "Spell";
            this.spellCheckBox.UseVisualStyleBackColor = true;
            // 
            // instantCheckBox
            // 
            this.instantCheckBox.AutoSize = true;
            this.instantCheckBox.Location = new System.Drawing.Point(178, 160);
            this.instantCheckBox.Name = "instantCheckBox";
            this.instantCheckBox.Size = new System.Drawing.Size(58, 17);
            this.instantCheckBox.TabIndex = 16;
            this.instantCheckBox.Text = "Instant";
            this.instantCheckBox.UseVisualStyleBackColor = true;
            // 
            // planeswalkerCheckBox
            // 
            this.planeswalkerCheckBox.AutoSize = true;
            this.planeswalkerCheckBox.Location = new System.Drawing.Point(86, 160);
            this.planeswalkerCheckBox.Name = "planeswalkerCheckBox";
            this.planeswalkerCheckBox.Size = new System.Drawing.Size(89, 17);
            this.planeswalkerCheckBox.TabIndex = 15;
            this.planeswalkerCheckBox.Text = "Planeswalker";
            this.planeswalkerCheckBox.UseVisualStyleBackColor = true;
            // 
            // enchantmentCheckBox
            // 
            this.enchantmentCheckBox.AutoSize = true;
            this.enchantmentCheckBox.Location = new System.Drawing.Point(273, 136);
            this.enchantmentCheckBox.Name = "enchantmentCheckBox";
            this.enchantmentCheckBox.Size = new System.Drawing.Size(89, 17);
            this.enchantmentCheckBox.TabIndex = 14;
            this.enchantmentCheckBox.Text = "Enchantment";
            this.enchantmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // artifactCheckBox
            // 
            this.artifactCheckBox.AutoSize = true;
            this.artifactCheckBox.Location = new System.Drawing.Point(208, 136);
            this.artifactCheckBox.Name = "artifactCheckBox";
            this.artifactCheckBox.Size = new System.Drawing.Size(59, 17);
            this.artifactCheckBox.TabIndex = 13;
            this.artifactCheckBox.Text = "Artifact";
            this.artifactCheckBox.UseVisualStyleBackColor = true;
            // 
            // creatureCheckBox
            // 
            this.creatureCheckBox.AutoSize = true;
            this.creatureCheckBox.Location = new System.Drawing.Point(142, 136);
            this.creatureCheckBox.Name = "creatureCheckBox";
            this.creatureCheckBox.Size = new System.Drawing.Size(66, 17);
            this.creatureCheckBox.TabIndex = 12;
            this.creatureCheckBox.Text = "Creature";
            this.creatureCheckBox.UseVisualStyleBackColor = true;
            // 
            // landCheckBox
            // 
            this.landCheckBox.AutoSize = true;
            this.landCheckBox.Location = new System.Drawing.Point(86, 136);
            this.landCheckBox.Name = "landCheckBox";
            this.landCheckBox.Size = new System.Drawing.Size(50, 17);
            this.landCheckBox.TabIndex = 11;
            this.landCheckBox.Text = "Land";
            this.landCheckBox.UseVisualStyleBackColor = true;
            // 
            // blueCheckBox
            // 
            this.blueCheckBox.AutoSize = true;
            this.blueCheckBox.Location = new System.Drawing.Point(320, 100);
            this.blueCheckBox.Name = "blueCheckBox";
            this.blueCheckBox.Size = new System.Drawing.Size(47, 17);
            this.blueCheckBox.TabIndex = 10;
            this.blueCheckBox.Text = "Blue";
            this.blueCheckBox.UseVisualStyleBackColor = true;
            // 
            // redCheckBox
            // 
            this.redCheckBox.AutoSize = true;
            this.redCheckBox.Location = new System.Drawing.Point(208, 100);
            this.redCheckBox.Name = "redCheckBox";
            this.redCheckBox.Size = new System.Drawing.Size(46, 17);
            this.redCheckBox.TabIndex = 9;
            this.redCheckBox.Text = "Red";
            this.redCheckBox.UseVisualStyleBackColor = true;
            // 
            // greenCheckBox
            // 
            this.greenCheckBox.AutoSize = true;
            this.greenCheckBox.Location = new System.Drawing.Point(146, 100);
            this.greenCheckBox.Name = "greenCheckBox";
            this.greenCheckBox.Size = new System.Drawing.Size(55, 17);
            this.greenCheckBox.TabIndex = 8;
            this.greenCheckBox.Text = "Green";
            this.greenCheckBox.UseVisualStyleBackColor = true;
            // 
            // blackCheckBox
            // 
            this.blackCheckBox.AutoSize = true;
            this.blackCheckBox.Location = new System.Drawing.Point(260, 100);
            this.blackCheckBox.Name = "blackCheckBox";
            this.blackCheckBox.Size = new System.Drawing.Size(53, 17);
            this.blackCheckBox.TabIndex = 7;
            this.blackCheckBox.Text = "Black";
            this.blackCheckBox.UseVisualStyleBackColor = true;
            // 
            // whiteCheckBox
            // 
            this.whiteCheckBox.AutoSize = true;
            this.whiteCheckBox.Location = new System.Drawing.Point(86, 100);
            this.whiteCheckBox.Name = "whiteCheckBox";
            this.whiteCheckBox.Size = new System.Drawing.Size(54, 17);
            this.whiteCheckBox.TabIndex = 6;
            this.whiteCheckBox.Text = "White";
            this.whiteCheckBox.UseVisualStyleBackColor = true;
            // 
            // cardNameTxtBox
            // 
            this.cardNameTxtBox.Location = new System.Drawing.Point(86, 61);
            this.cardNameTxtBox.Name = "cardNameTxtBox";
            this.cardNameTxtBox.Size = new System.Drawing.Size(211, 20);
            this.cardNameTxtBox.TabIndex = 5;
            // 
            // cardTypeLabel
            // 
            this.cardTypeLabel.AutoSize = true;
            this.cardTypeLabel.Location = new System.Drawing.Point(13, 136);
            this.cardTypeLabel.Name = "cardTypeLabel";
            this.cardTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.cardTypeLabel.TabIndex = 4;
            this.cardTypeLabel.Text = "Card Type";
            // 
            // cardColorLabel
            // 
            this.cardColorLabel.AutoSize = true;
            this.cardColorLabel.Location = new System.Drawing.Point(13, 101);
            this.cardColorLabel.Name = "cardColorLabel";
            this.cardColorLabel.Size = new System.Drawing.Size(56, 13);
            this.cardColorLabel.TabIndex = 3;
            this.cardColorLabel.Text = "Card Color";
            // 
            // collectionIDLabel
            // 
            this.collectionIDLabel.AutoSize = true;
            this.collectionIDLabel.Location = new System.Drawing.Point(13, 29);
            this.collectionIDLabel.Name = "collectionIDLabel";
            this.collectionIDLabel.Size = new System.Drawing.Size(67, 13);
            this.collectionIDLabel.TabIndex = 2;
            this.collectionIDLabel.Text = "Collection ID";
            // 
            // collectionIDTxtBox
            // 
            this.collectionIDTxtBox.Location = new System.Drawing.Point(86, 25);
            this.collectionIDTxtBox.Name = "collectionIDTxtBox";
            this.collectionIDTxtBox.Size = new System.Drawing.Size(55, 20);
            this.collectionIDTxtBox.TabIndex = 1;
            // 
            // cardNameLabel
            // 
            this.cardNameLabel.AutoSize = true;
            this.cardNameLabel.Location = new System.Drawing.Point(13, 65);
            this.cardNameLabel.Name = "cardNameLabel";
            this.cardNameLabel.Size = new System.Drawing.Size(60, 13);
            this.cardNameLabel.TabIndex = 0;
            this.cardNameLabel.Text = "Card Name";
            // 
            // makeSearchButton
            // 
            this.makeSearchButton.Location = new System.Drawing.Point(392, 205);
            this.makeSearchButton.Name = "makeSearchButton";
            this.makeSearchButton.Size = new System.Drawing.Size(75, 23);
            this.makeSearchButton.TabIndex = 19;
            this.makeSearchButton.Text = "Search";
            this.makeSearchButton.UseVisualStyleBackColor = true;
            this.makeSearchButton.Click += new System.EventHandler(this.makeSearchButton_Click);
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.Location = new System.Drawing.Point(12, 205);
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSearchButton.TabIndex = 20;
            this.cancelSearchButton.Text = "Cancel";
            this.cancelSearchButton.UseVisualStyleBackColor = true;
            this.cancelSearchButton.Click += new System.EventHandler(this.cancelSearchButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(481, 238);
            this.Controls.Add(this.cancelSearchButton);
            this.Controls.Add(this.makeSearchButton);
            this.Controls.Add(this.searchGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 277);
            this.MinimumSize = new System.Drawing.Size(497, 277);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Options";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label cardNameLabel;
        private System.Windows.Forms.Label cardTypeLabel;
        private System.Windows.Forms.Label cardColorLabel;
        private System.Windows.Forms.Label collectionIDLabel;
        private System.Windows.Forms.TextBox collectionIDTxtBox;
        private System.Windows.Forms.CheckBox blackCheckBox;
        private System.Windows.Forms.CheckBox whiteCheckBox;
        private System.Windows.Forms.TextBox cardNameTxtBox;
        private System.Windows.Forms.CheckBox greenCheckBox;
        private System.Windows.Forms.CheckBox blueCheckBox;
        private System.Windows.Forms.CheckBox redCheckBox;
        private System.Windows.Forms.CheckBox otherTypeCheckBox;
        private System.Windows.Forms.CheckBox spellCheckBox;
        private System.Windows.Forms.CheckBox instantCheckBox;
        private System.Windows.Forms.CheckBox planeswalkerCheckBox;
        private System.Windows.Forms.CheckBox enchantmentCheckBox;
        private System.Windows.Forms.CheckBox artifactCheckBox;
        private System.Windows.Forms.CheckBox creatureCheckBox;
        private System.Windows.Forms.CheckBox landCheckBox;
        private System.Windows.Forms.Button makeSearchButton;
        private System.Windows.Forms.Button cancelSearchButton;
        private System.Windows.Forms.CheckBox colorlessCheckBox;
    }
}