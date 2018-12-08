namespace MTGCollection
{
    partial class ManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageForm));
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.quantityNumericAdd = new System.Windows.Forms.NumericUpDown();
            this.addCardButton = new System.Windows.Forms.Button();
            this.addcolorlessCheckBox = new System.Windows.Forms.CheckBox();
            this.addotherTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.addspellCheckBox = new System.Windows.Forms.CheckBox();
            this.addinstantCheckBox = new System.Windows.Forms.CheckBox();
            this.addplaneswalkerCheckBox = new System.Windows.Forms.CheckBox();
            this.addenchantmentCheckBox = new System.Windows.Forms.CheckBox();
            this.addartifactCheckBox = new System.Windows.Forms.CheckBox();
            this.addcreatureCheckBox = new System.Windows.Forms.CheckBox();
            this.addlandCheckBox = new System.Windows.Forms.CheckBox();
            this.addblueCheckBox = new System.Windows.Forms.CheckBox();
            this.addredCheckBox = new System.Windows.Forms.CheckBox();
            this.addgreenCheckBox = new System.Windows.Forms.CheckBox();
            this.addblackCheckBox = new System.Windows.Forms.CheckBox();
            this.addwhiteCheckBox = new System.Windows.Forms.CheckBox();
            this.addcardTypeLabel = new System.Windows.Forms.Label();
            this.addcardColorLabel = new System.Windows.Forms.Label();
            this.addNameTxtBox = new System.Windows.Forms.TextBox();
            this.addQuantityLabel = new System.Windows.Forms.Label();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.removeCardGroupBox = new System.Windows.Forms.GroupBox();
            this.removeQntLabel = new System.Windows.Forms.Label();
            this.idRemoveLabel = new System.Windows.Forms.Label();
            this.removeQntSelector = new System.Windows.Forms.NumericUpDown();
            this.removeIDtxt = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericAdd)).BeginInit();
            this.removeCardGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeQntSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.quantityNumericAdd);
            this.addGroupBox.Controls.Add(this.addCardButton);
            this.addGroupBox.Controls.Add(this.addcolorlessCheckBox);
            this.addGroupBox.Controls.Add(this.addotherTypeCheckBox);
            this.addGroupBox.Controls.Add(this.addspellCheckBox);
            this.addGroupBox.Controls.Add(this.addinstantCheckBox);
            this.addGroupBox.Controls.Add(this.addplaneswalkerCheckBox);
            this.addGroupBox.Controls.Add(this.addenchantmentCheckBox);
            this.addGroupBox.Controls.Add(this.addartifactCheckBox);
            this.addGroupBox.Controls.Add(this.addcreatureCheckBox);
            this.addGroupBox.Controls.Add(this.addlandCheckBox);
            this.addGroupBox.Controls.Add(this.addblueCheckBox);
            this.addGroupBox.Controls.Add(this.addredCheckBox);
            this.addGroupBox.Controls.Add(this.addgreenCheckBox);
            this.addGroupBox.Controls.Add(this.addblackCheckBox);
            this.addGroupBox.Controls.Add(this.addwhiteCheckBox);
            this.addGroupBox.Controls.Add(this.addcardTypeLabel);
            this.addGroupBox.Controls.Add(this.addcardColorLabel);
            this.addGroupBox.Controls.Add(this.addNameTxtBox);
            this.addGroupBox.Controls.Add(this.addQuantityLabel);
            this.addGroupBox.Controls.Add(this.addNameLabel);
            this.addGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addGroupBox.Location = new System.Drawing.Point(13, 13);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(505, 184);
            this.addGroupBox.TabIndex = 0;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add Card";
            // 
            // quantityNumericAdd
            // 
            this.quantityNumericAdd.Location = new System.Drawing.Point(442, 34);
            this.quantityNumericAdd.Name = "quantityNumericAdd";
            this.quantityNumericAdd.Size = new System.Drawing.Size(43, 20);
            this.quantityNumericAdd.TabIndex = 1;
            // 
            // addCardButton
            // 
            this.addCardButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addCardButton.Location = new System.Drawing.Point(410, 141);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(75, 23);
            this.addCardButton.TabIndex = 36;
            this.addCardButton.Text = "Add";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // addcolorlessCheckBox
            // 
            this.addcolorlessCheckBox.AutoSize = true;
            this.addcolorlessCheckBox.Location = new System.Drawing.Point(372, 78);
            this.addcolorlessCheckBox.Name = "addcolorlessCheckBox";
            this.addcolorlessCheckBox.Size = new System.Drawing.Size(68, 17);
            this.addcolorlessCheckBox.TabIndex = 35;
            this.addcolorlessCheckBox.Text = "Colorless";
            this.addcolorlessCheckBox.UseVisualStyleBackColor = true;
            // 
            // addotherTypeCheckBox
            // 
            this.addotherTypeCheckBox.AutoSize = true;
            this.addotherTypeCheckBox.Location = new System.Drawing.Point(291, 141);
            this.addotherTypeCheckBox.Name = "addotherTypeCheckBox";
            this.addotherTypeCheckBox.Size = new System.Drawing.Size(52, 17);
            this.addotherTypeCheckBox.TabIndex = 34;
            this.addotherTypeCheckBox.Text = "Other";
            this.addotherTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // addspellCheckBox
            // 
            this.addspellCheckBox.AutoSize = true;
            this.addspellCheckBox.Location = new System.Drawing.Point(239, 141);
            this.addspellCheckBox.Name = "addspellCheckBox";
            this.addspellCheckBox.Size = new System.Drawing.Size(49, 17);
            this.addspellCheckBox.TabIndex = 33;
            this.addspellCheckBox.Text = "Spell";
            this.addspellCheckBox.UseVisualStyleBackColor = true;
            // 
            // addinstantCheckBox
            // 
            this.addinstantCheckBox.AutoSize = true;
            this.addinstantCheckBox.Location = new System.Drawing.Point(177, 141);
            this.addinstantCheckBox.Name = "addinstantCheckBox";
            this.addinstantCheckBox.Size = new System.Drawing.Size(58, 17);
            this.addinstantCheckBox.TabIndex = 32;
            this.addinstantCheckBox.Text = "Instant";
            this.addinstantCheckBox.UseVisualStyleBackColor = true;
            // 
            // addplaneswalkerCheckBox
            // 
            this.addplaneswalkerCheckBox.AutoSize = true;
            this.addplaneswalkerCheckBox.Location = new System.Drawing.Point(85, 141);
            this.addplaneswalkerCheckBox.Name = "addplaneswalkerCheckBox";
            this.addplaneswalkerCheckBox.Size = new System.Drawing.Size(89, 17);
            this.addplaneswalkerCheckBox.TabIndex = 31;
            this.addplaneswalkerCheckBox.Text = "Planeswalker";
            this.addplaneswalkerCheckBox.UseVisualStyleBackColor = true;
            // 
            // addenchantmentCheckBox
            // 
            this.addenchantmentCheckBox.AutoSize = true;
            this.addenchantmentCheckBox.Location = new System.Drawing.Point(272, 117);
            this.addenchantmentCheckBox.Name = "addenchantmentCheckBox";
            this.addenchantmentCheckBox.Size = new System.Drawing.Size(89, 17);
            this.addenchantmentCheckBox.TabIndex = 30;
            this.addenchantmentCheckBox.Text = "Enchantment";
            this.addenchantmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // addartifactCheckBox
            // 
            this.addartifactCheckBox.AutoSize = true;
            this.addartifactCheckBox.Location = new System.Drawing.Point(207, 117);
            this.addartifactCheckBox.Name = "addartifactCheckBox";
            this.addartifactCheckBox.Size = new System.Drawing.Size(59, 17);
            this.addartifactCheckBox.TabIndex = 29;
            this.addartifactCheckBox.Text = "Artifact";
            this.addartifactCheckBox.UseVisualStyleBackColor = true;
            // 
            // addcreatureCheckBox
            // 
            this.addcreatureCheckBox.AutoSize = true;
            this.addcreatureCheckBox.Location = new System.Drawing.Point(141, 117);
            this.addcreatureCheckBox.Name = "addcreatureCheckBox";
            this.addcreatureCheckBox.Size = new System.Drawing.Size(66, 17);
            this.addcreatureCheckBox.TabIndex = 28;
            this.addcreatureCheckBox.Text = "Creature";
            this.addcreatureCheckBox.UseVisualStyleBackColor = true;
            // 
            // addlandCheckBox
            // 
            this.addlandCheckBox.AutoSize = true;
            this.addlandCheckBox.Location = new System.Drawing.Point(85, 117);
            this.addlandCheckBox.Name = "addlandCheckBox";
            this.addlandCheckBox.Size = new System.Drawing.Size(50, 17);
            this.addlandCheckBox.TabIndex = 27;
            this.addlandCheckBox.Text = "Land";
            this.addlandCheckBox.UseVisualStyleBackColor = true;
            // 
            // addblueCheckBox
            // 
            this.addblueCheckBox.AutoSize = true;
            this.addblueCheckBox.Location = new System.Drawing.Point(319, 78);
            this.addblueCheckBox.Name = "addblueCheckBox";
            this.addblueCheckBox.Size = new System.Drawing.Size(47, 17);
            this.addblueCheckBox.TabIndex = 26;
            this.addblueCheckBox.Text = "Blue";
            this.addblueCheckBox.UseVisualStyleBackColor = true;
            // 
            // addredCheckBox
            // 
            this.addredCheckBox.AutoSize = true;
            this.addredCheckBox.Location = new System.Drawing.Point(207, 78);
            this.addredCheckBox.Name = "addredCheckBox";
            this.addredCheckBox.Size = new System.Drawing.Size(46, 17);
            this.addredCheckBox.TabIndex = 25;
            this.addredCheckBox.Text = "Red";
            this.addredCheckBox.UseVisualStyleBackColor = true;
            // 
            // addgreenCheckBox
            // 
            this.addgreenCheckBox.AutoSize = true;
            this.addgreenCheckBox.Location = new System.Drawing.Point(145, 78);
            this.addgreenCheckBox.Name = "addgreenCheckBox";
            this.addgreenCheckBox.Size = new System.Drawing.Size(55, 17);
            this.addgreenCheckBox.TabIndex = 24;
            this.addgreenCheckBox.Text = "Green";
            this.addgreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // addblackCheckBox
            // 
            this.addblackCheckBox.AutoSize = true;
            this.addblackCheckBox.Location = new System.Drawing.Point(259, 78);
            this.addblackCheckBox.Name = "addblackCheckBox";
            this.addblackCheckBox.Size = new System.Drawing.Size(53, 17);
            this.addblackCheckBox.TabIndex = 23;
            this.addblackCheckBox.Text = "Black";
            this.addblackCheckBox.UseVisualStyleBackColor = true;
            // 
            // addwhiteCheckBox
            // 
            this.addwhiteCheckBox.AutoSize = true;
            this.addwhiteCheckBox.Location = new System.Drawing.Point(85, 78);
            this.addwhiteCheckBox.Name = "addwhiteCheckBox";
            this.addwhiteCheckBox.Size = new System.Drawing.Size(54, 17);
            this.addwhiteCheckBox.TabIndex = 22;
            this.addwhiteCheckBox.Text = "White";
            this.addwhiteCheckBox.UseVisualStyleBackColor = true;
            // 
            // addcardTypeLabel
            // 
            this.addcardTypeLabel.AutoSize = true;
            this.addcardTypeLabel.Location = new System.Drawing.Point(15, 117);
            this.addcardTypeLabel.Name = "addcardTypeLabel";
            this.addcardTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.addcardTypeLabel.TabIndex = 21;
            this.addcardTypeLabel.Text = "Card Type";
            // 
            // addcardColorLabel
            // 
            this.addcardColorLabel.AutoSize = true;
            this.addcardColorLabel.Location = new System.Drawing.Point(15, 78);
            this.addcardColorLabel.Name = "addcardColorLabel";
            this.addcardColorLabel.Size = new System.Drawing.Size(56, 13);
            this.addcardColorLabel.TabIndex = 20;
            this.addcardColorLabel.Text = "Card Color";
            // 
            // addNameTxtBox
            // 
            this.addNameTxtBox.Location = new System.Drawing.Point(85, 36);
            this.addNameTxtBox.Name = "addNameTxtBox";
            this.addNameTxtBox.Size = new System.Drawing.Size(282, 20);
            this.addNameTxtBox.TabIndex = 4;
            // 
            // addQuantityLabel
            // 
            this.addQuantityLabel.AutoSize = true;
            this.addQuantityLabel.Location = new System.Drawing.Point(390, 36);
            this.addQuantityLabel.Name = "addQuantityLabel";
            this.addQuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.addQuantityLabel.TabIndex = 1;
            this.addQuantityLabel.Text = "Quantity";
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(15, 39);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(60, 13);
            this.addNameLabel.TabIndex = 0;
            this.addNameLabel.Text = "Card Name";
            // 
            // removeCardGroupBox
            // 
            this.removeCardGroupBox.Controls.Add(this.removeQntLabel);
            this.removeCardGroupBox.Controls.Add(this.idRemoveLabel);
            this.removeCardGroupBox.Controls.Add(this.removeQntSelector);
            this.removeCardGroupBox.Controls.Add(this.removeIDtxt);
            this.removeCardGroupBox.Controls.Add(this.removeButton);
            this.removeCardGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeCardGroupBox.Location = new System.Drawing.Point(13, 213);
            this.removeCardGroupBox.Name = "removeCardGroupBox";
            this.removeCardGroupBox.Size = new System.Drawing.Size(505, 115);
            this.removeCardGroupBox.TabIndex = 1;
            this.removeCardGroupBox.TabStop = false;
            this.removeCardGroupBox.Text = "Remove Card";
            // 
            // removeQntLabel
            // 
            this.removeQntLabel.AutoSize = true;
            this.removeQntLabel.Location = new System.Drawing.Point(15, 76);
            this.removeQntLabel.Name = "removeQntLabel";
            this.removeQntLabel.Size = new System.Drawing.Size(46, 13);
            this.removeQntLabel.TabIndex = 4;
            this.removeQntLabel.Text = "Quantity";
            // 
            // idRemoveLabel
            // 
            this.idRemoveLabel.AutoSize = true;
            this.idRemoveLabel.Location = new System.Drawing.Point(15, 36);
            this.idRemoveLabel.Name = "idRemoveLabel";
            this.idRemoveLabel.Size = new System.Drawing.Size(61, 13);
            this.idRemoveLabel.TabIndex = 3;
            this.idRemoveLabel.Text = "Remove ID";
            // 
            // removeQntSelector
            // 
            this.removeQntSelector.Location = new System.Drawing.Point(85, 74);
            this.removeQntSelector.Name = "removeQntSelector";
            this.removeQntSelector.Size = new System.Drawing.Size(43, 20);
            this.removeQntSelector.TabIndex = 2;
            // 
            // removeIDtxt
            // 
            this.removeIDtxt.Location = new System.Drawing.Point(85, 33);
            this.removeIDtxt.Name = "removeIDtxt";
            this.removeIDtxt.Size = new System.Drawing.Size(115, 20);
            this.removeIDtxt.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.ForeColor = System.Drawing.Color.Crimson;
            this.removeButton.Location = new System.Drawing.Point(410, 50);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(534, 347);
            this.Controls.Add(this.removeCardGroupBox);
            this.Controls.Add(this.addGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 386);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericAdd)).EndInit();
            this.removeCardGroupBox.ResumeLayout(false);
            this.removeCardGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeQntSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.TextBox addNameTxtBox;
        private System.Windows.Forms.Label addQuantityLabel;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.CheckBox addcolorlessCheckBox;
        private System.Windows.Forms.CheckBox addotherTypeCheckBox;
        private System.Windows.Forms.CheckBox addspellCheckBox;
        private System.Windows.Forms.CheckBox addinstantCheckBox;
        private System.Windows.Forms.CheckBox addplaneswalkerCheckBox;
        private System.Windows.Forms.CheckBox addenchantmentCheckBox;
        private System.Windows.Forms.CheckBox addartifactCheckBox;
        private System.Windows.Forms.CheckBox addcreatureCheckBox;
        private System.Windows.Forms.CheckBox addlandCheckBox;
        private System.Windows.Forms.CheckBox addblueCheckBox;
        private System.Windows.Forms.CheckBox addredCheckBox;
        private System.Windows.Forms.CheckBox addgreenCheckBox;
        private System.Windows.Forms.CheckBox addblackCheckBox;
        private System.Windows.Forms.CheckBox addwhiteCheckBox;
        private System.Windows.Forms.Label addcardTypeLabel;
        private System.Windows.Forms.Label addcardColorLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericAdd;
        private System.Windows.Forms.GroupBox removeCardGroupBox;
        private System.Windows.Forms.Label idRemoveLabel;
        private System.Windows.Forms.NumericUpDown removeQntSelector;
        private System.Windows.Forms.TextBox removeIDtxt;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label removeQntLabel;
    }
}