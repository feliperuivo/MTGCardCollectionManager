namespace MTGCollection.Forms
{
    partial class RemoveConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveConfirmationForm));
            this.confirmRemoveButton = new System.Windows.Forms.Button();
            this.cancelRemoveButton = new System.Windows.Forms.Button();
            this.confirmRemoveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmRemoveButton
            // 
            this.confirmRemoveButton.ForeColor = System.Drawing.Color.Red;
            this.confirmRemoveButton.Location = new System.Drawing.Point(164, 136);
            this.confirmRemoveButton.Name = "confirmRemoveButton";
            this.confirmRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.confirmRemoveButton.TabIndex = 0;
            this.confirmRemoveButton.Text = "Confirm";
            this.confirmRemoveButton.UseVisualStyleBackColor = true;
            this.confirmRemoveButton.Click += new System.EventHandler(this.confirmRemoveButton_Click);
            // 
            // cancelRemoveButton
            // 
            this.cancelRemoveButton.Location = new System.Drawing.Point(277, 136);
            this.cancelRemoveButton.Name = "cancelRemoveButton";
            this.cancelRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.cancelRemoveButton.TabIndex = 1;
            this.cancelRemoveButton.Text = "Cancel";
            this.cancelRemoveButton.UseVisualStyleBackColor = true;
            this.cancelRemoveButton.Click += new System.EventHandler(this.cancelRemoveButton_Click);
            // 
            // confirmRemoveLabel
            // 
            this.confirmRemoveLabel.AutoSize = true;
            this.confirmRemoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmRemoveLabel.ForeColor = System.Drawing.Color.Snow;
            this.confirmRemoveLabel.Location = new System.Drawing.Point(12, 59);
            this.confirmRemoveLabel.Name = "confirmRemoveLabel";
            this.confirmRemoveLabel.Size = new System.Drawing.Size(173, 25);
            this.confirmRemoveLabel.TabIndex = 2;
            this.confirmRemoveLabel.Text = "Remover x de x?";
            this.confirmRemoveLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RemoveConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(364, 171);
            this.Controls.Add(this.confirmRemoveLabel);
            this.Controls.Add(this.cancelRemoveButton);
            this.Controls.Add(this.confirmRemoveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 210);
            this.Name = "RemoveConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WARNING!";
            this.Load += new System.EventHandler(this.RemoveConfirmationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmRemoveButton;
        private System.Windows.Forms.Button cancelRemoveButton;
        private System.Windows.Forms.Label confirmRemoveLabel;
    }
}