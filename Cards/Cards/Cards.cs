using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/***************************************************************
* Name        : Cards
* Author      : Kabrina Brady
* Created     : 9/25/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : User clicks on an item from the listbox, which displays the corresponding image when the button is clicked
*               Input:  Button click
*               Output: Image appearing
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace Cards
{
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }
        
        //ShowCard method
        private void ShowCard(string card)
        {
            switch (card)
            {
                case "Ace of Spades":
                    ShowAceSpades();
                    break;
                case "10 of Hearts":
                    ShowTenHearts();
                    break;
                case "King of Clubs":
                    ShowKingClubs();
                    break;
            }
        }

        //ShowAceSpades method makes Ace of Spades visible and other cards invisible
        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        //ShowTenHearts method makes Ten of Hearts visible and other cards invisible
        private void ShowTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }

        //ShowKingClubs method makes King of Clubs visible and other cards invisible
        private void ShowKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }

        private void ShowCardButton_Click(object sender, EventArgs e)
        {
            //if card is selected in listbox, display it
            if (cardListBox.SelectedIndex != -1)
            {
                ShowCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a card from the list box.");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }
    }
}
