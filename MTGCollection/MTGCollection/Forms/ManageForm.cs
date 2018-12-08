using MTGCollection.Forms;
using MTGCollection.Model;
using MTGCollection.Persistent;
using System;
using System.Windows.Forms;

namespace MTGCollection
{
    public partial class ManageForm : Form
    {
        public MainForm mf { get; set; }
        public RemoveConfirmationForm removeConfirm;


        public ManageForm()
        {
            InitializeComponent();
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            Card c = bakeCard();
            bool flag = checkCardExistence(c);

            if (flag)
            {
                MessageBox.Show("Card already exists!");
            }
            else
            {
                AddCard(c);
            }

        }

        private Card bakeCard()
        {
            string _name, _color;
            int _quantity;
            string _type = "";
            Card ret = new Card();


            _name = addNameTxtBox.Text;
            _quantity = (int)quantityNumericAdd.Value;
            _color = "";


            CheckBox[] colorBoxes = new CheckBox[] { addwhiteCheckBox, addgreenCheckBox, addredCheckBox, addblackCheckBox, addblueCheckBox,
            addcolorlessCheckBox };

            CheckBox[] typeBoxes = new CheckBox[] {addlandCheckBox,addcreatureCheckBox,addartifactCheckBox,addenchantmentCheckBox,
            addplaneswalkerCheckBox, addinstantCheckBox,addspellCheckBox,addotherTypeCheckBox};

            foreach (CheckBox colorBox in colorBoxes)
            {
                if (colorBox.Checked)
                {
                    switch (colorBox.Name)
                    {
                        case "addwhiteCheckBox":
                            _color += "W";
                            break;
                        case "addgreenCheckBox":
                            _color += "G";
                            break;
                        case "addredCheckBox":
                            _color += "R";
                            break;
                        case "addblackCheckBox":
                            _color += "B";
                            break;
                        case "addblueCheckBox":
                            _color += "U";
                            break;
                        case "addcolorlessCheckBox":
                            _color += "C";
                            break;
                        default:
                            break;
                    }
                }

            }
            // MessageBox.Show(_color);

            foreach (CheckBox typeBox in typeBoxes)
            {
                if (typeBox.Checked)
                {
                    _type = (typeBox.Text) + "|";

                    //MessageBox.Show(typeBox.Text);
                }


            }


            ret.Nome = _name;
            ret.Quantidade = _quantity;
            ret.Cor = _color;
            ret.Tipo = _type;

            return ret;

        }

        private bool checkCardExistence(Card card)
        {
            cardDAL DAL = new cardDAL();

            if (DAL.getCardByName(card.Nome) != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void AddCard(Card newCard)
        {
            cardDAL DAL = new cardDAL();

            DAL.addCard(newCard);

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(removeIDtxt.Text) && removeQntSelector.Value > 0)
            {
                removeConfirm = new RemoveConfirmationForm(int.Parse(removeIDtxt.Text), (int)removeQntSelector.Value);

            }
            else
            {
                MessageBox.Show("Inser a valid ID and amount to remove.");
            }
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {

        }
    }
}



