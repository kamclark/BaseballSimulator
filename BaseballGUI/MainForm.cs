using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BaseballLibrary;


namespace BaseballGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonSwing_Click(object sender, EventArgs e)
        {
            AtBatResultModel swing = new AtBatResultModel();
            swing.NewAtBat();
            textBoxCommentary.Text = swing.AtBatResult.ToString(); // update commentary based on swings random result

            //TODO --- Update commentary from AtBatCommentaryModel strings  

            //TODO --- Update statistics for player model based on NewAtBat() 
        }

        private void ButtonAddPlayer_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) // once form is validated as true
            {
                PlayerModel player1 = new PlayerModel // new model populated from batter info group
                {
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Nickname = textBoxNickname.Text,
                    Id = 1
                };

                textBoxFirstName.Enabled = false; // batter info fields locked
                textBoxLastName.Enabled = false;
                textBoxNickname.Enabled = false;

                buttonSwing.Enabled = true; // swing button is now enabled

                textBoxCommentary.Text = ("Hello Mr. " +player1.LastName); // begin commentary feed
            }

        }

        private bool ValidateForm()
        {
            bool valid = true; // form is defaulted to being valid

            if (!Regex.IsMatch(textBoxFirstName.Text, @"^[a-zA-Z]+$")) // if anything not alpha detected 
            {
                valid = false;
                //TODO -- Error for FirstName textbox not containing alpha
            }

            if (!Regex.IsMatch(textBoxLastName.Text, @"^[a-zA-Z]+$"))
            {
                valid = false;
                //TODO -- Error for LastName textbox not containing alpha
            }

            if (!Regex.IsMatch(textBoxNickname.Text, @"^[a-zA-Z]+$")
                && textBoxNickname.Text.Length > 0)
            {
                valid = false;
                //TODO -- Error for Nickname textbox not containing alpha AND not being empty
            }

            if (textBoxFirstName.Text.Length <= 0) // if textbox is empty
            {
                valid = false;
                //TODO -- Error for FirstName textbox containing nothing
            }

            if (textBoxLastName.Text.Length <= 0)
            {
                valid = false;
                //TODO -- Error for LastName textbox containing nothing
            }

            return valid;
        }
    }
}
