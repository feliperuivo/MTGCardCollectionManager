using MTGCollection.Persistent;
using System;
using System.Windows.Forms;

namespace MTGCollection.Forms
{
    public partial class RemoveConfirmationForm : Form
    {

        private int _id, _amount;

        public RemoveConfirmationForm(int id, int amount)
        {
            InitializeComponent();

            _id = id;
            _amount = amount;

            cardDAL DAL = new cardDAL();

            if (DAL.getCardByID(_id) == null)
            {
                MessageBox.Show("This card ID don't exist.");
                this.Close();
            }
            else
            {
                this.Show();
                confirmRemoveLabel.Text = string.Format("REMOVE {0}x ID = {1}?", _amount, DAL.getCardByID(_id).Nome);
            }
        }

        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {
            cardDAL DAL = new cardDAL();

            if (DAL.getCardByID(_id) != null)
            {
                DAL.removeAmountFromID(_id, _amount);
                this.Close();
            }
            else
            {
                MessageBox.Show("This card ID don't exist.");
                this.Close();
            }
        }

        private void RemoveConfirmationForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelRemoveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
