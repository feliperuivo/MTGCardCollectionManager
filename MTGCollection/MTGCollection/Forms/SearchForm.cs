using MTGCollection.Model;
using MTGCollection.Persistent;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MTGCollection
{
    public partial class SearchForm : Form
    {
        public MainForm mf { get; set; }

        public SearchForm()
        {
            InitializeComponent();
        }

        private void makeSearchButton_Click(object sender, EventArgs e)
        {
            #region filters
            int _id;
            string _name, _color;
            string _type;

            int.TryParse(collectionIDTxtBox.Text, out _id);
            _name = cardNameTxtBox.Text;
            _color = "";
            _type = "";

            CheckBox[] colorBoxes = new CheckBox[] { whiteCheckBox, greenCheckBox, redCheckBox, blackCheckBox, blueCheckBox,
            colorlessCheckBox };

            CheckBox[] typeBoxes = new CheckBox[] {landCheckBox,creatureCheckBox,artifactCheckBox,enchantmentCheckBox,
            planeswalkerCheckBox, instantCheckBox,spellCheckBox,otherTypeCheckBox};

            foreach (CheckBox colorBox in colorBoxes)
            {
                if (colorBox.Checked)
                {
                    switch (colorBox.Name)
                    {
                        case "whiteCheckBox":
                            _color += "W";
                            break;
                        case "greenCheckBox":
                            _color += "G";
                            break;
                        case "redCheckBox":
                            _color += "R";
                            break;
                        case "blackCheckBox":
                            _color += "B";
                            break;
                        case "blueCheckBox":
                            _color += "U";
                            break;
                        case "colorlessCheckBox":
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
                    _type += typeBox.Text + "|";
                }


            }


            #endregion

            //MessageBox.Show(buildConnectionStringToSearch(_id, _name, _color, _type));

            #region connection
            cardDAL DAL = new cardDAL();

            List<Card> ret = DAL.getAllCardsFiltered(_id, _name, _color, _type);

            mf.showData(ret);

            this.Close();
            #endregion
        }



        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
