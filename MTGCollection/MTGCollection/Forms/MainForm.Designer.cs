namespace MTGCollection
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openSearchButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.collectionDataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // openSearchButton
            // 
            this.openSearchButton.Location = new System.Drawing.Point(13, 13);
            this.openSearchButton.Name = "openSearchButton";
            this.openSearchButton.Size = new System.Drawing.Size(75, 23);
            this.openSearchButton.TabIndex = 0;
            this.openSearchButton.Text = "Search";
            this.openSearchButton.UseVisualStyleBackColor = true;
            this.openSearchButton.Click += new System.EventHandler(this.openSearchButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.Location = new System.Drawing.Point(107, 13);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(75, 23);
            this.manageButton.TabIndex = 1;
            this.manageButton.Text = "Manage";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // collectionDataGridView
            // 
            this.collectionDataGridView.AllowUserToAddRows = false;
            this.collectionDataGridView.AllowUserToDeleteRows = false;
            this.collectionDataGridView.AllowUserToOrderColumns = true;
            this.collectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.QuantityColumn,
            this.ColorColumn,
            this.CardTypeColumn});
            this.collectionDataGridView.Location = new System.Drawing.Point(13, 43);
            this.collectionDataGridView.Name = "collectionDataGridView";
            this.collectionDataGridView.ReadOnly = true;
            this.collectionDataGridView.Size = new System.Drawing.Size(894, 406);
            this.collectionDataGridView.TabIndex = 2;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Width = 50;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 100;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 300;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            // 
            // ColorColumn
            // 
            this.ColorColumn.HeaderText = "Color";
            this.ColorColumn.Name = "ColorColumn";
            this.ColorColumn.ReadOnly = true;
            this.ColorColumn.Width = 200;
            // 
            // CardTypeColumn
            // 
            this.CardTypeColumn.HeaderText = "Card Type";
            this.CardTypeColumn.Name = "CardTypeColumn";
            this.CardTypeColumn.ReadOnly = true;
            this.CardTypeColumn.Width = 200;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(832, 13);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(920, 461);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.collectionDataGridView);
            this.Controls.Add(this.manageButton);
            this.Controls.Add(this.openSearchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(936, 500);
            this.MinimumSize = new System.Drawing.Size(936, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My MTG Collection";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HandleDestroyed += new System.EventHandler(this.quit);
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openSearchButton;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.DataGridView collectionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardTypeColumn;
        private System.Windows.Forms.Button clearButton;
    }
}