using MTGCollection.Model;
using MTGCollection.Persistent;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MTGCollection
{
    public partial class MainForm : Form
    {
        public SearchForm searchWindow;
        public ManageForm manageWindow;


        public MainForm()
        {
            InitializeComponent();
            showAll();
        }


        private void showAll()
        {
            cardDAL DAL = new cardDAL();
            List<Card> cardList = new List<Card>();
            cardList = DAL.getAllCards();

            try
            {
                collectionDataGridView.Rows.Clear();

                for (int i = 0; i < cardList.Count; i++)
                {
                    collectionDataGridView.Rows.Add();

                    collectionDataGridView.Rows[i].Cells["IDColumn"].Value = cardList[i].Id;
                    collectionDataGridView.Rows[i].Cells["NameColumn"].Value = cardList[i].Nome;
                    collectionDataGridView.Rows[i].Cells["QuantityColumn"].Value = cardList[i].Quantidade;
                    collectionDataGridView.Rows[i].Cells["ColorColumn"].Value = cardList[i].Cor;
                    collectionDataGridView.Rows[i].Cells["CardTypeColumn"].Value = cardList[i].Tipo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void openSearchButton_Click(object sender, EventArgs e)
        {
            searchWindow = new SearchForm();
            searchWindow.mf = this;
            searchWindow.Show();
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            manageWindow = new ManageForm();
            manageWindow.mf = this;
            manageWindow.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            showAll();
        }

        public void showData(List<Card> cardList)
        {
            collectionDataGridView.Rows.Clear();

            for (int i = 0; i < cardList.Count; i++)
            {
                collectionDataGridView.Rows.Add();

                collectionDataGridView.Rows[i].Cells["IDColumn"].Value = cardList[i].Id;
                collectionDataGridView.Rows[i].Cells["NameColumn"].Value = cardList[i].Nome;
                collectionDataGridView.Rows[i].Cells["QuantityColumn"].Value = cardList[i].Quantidade;
                collectionDataGridView.Rows[i].Cells["ColorColumn"].Value = cardList[i].Cor;
                collectionDataGridView.Rows[i].Cells["CardTypeColumn"].Value = cardList[i].Tipo;

            }

        }

        //Close application when the user closes the Main Form 
        public void quit(object sender, EventArgs e) => Application.Exit();

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
