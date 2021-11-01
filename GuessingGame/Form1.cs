using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GuessingGame : Form
    {
        #region Private members

        private static string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\images\\";
        private int currenIndex = 0;
        private int currentPoints = 0;
        private bool buttonClicked;
        private bool endGame;
        private List<Person> personList = PersonUtils.FillPersonList(currentDirectory, ".jpg");
        #endregion

        #region Default constructor
        public GuessingGame()
        {
            InitializeComponent();
            NewGame();
        }

        #endregion

        #region Custom methods

        // Starts a new game and clears old results
        private void NewGame()
        {
            playAgainButton.Visible = false;
            currenIndex = 0;
            currentPoints = 0;
            pointsBox.Text = String.Empty;
            endGame = false;
            LoadNextPicture(ref currenIndex);
        }
        // Loads next picture from person list or ends game if last picture was already loaded
        private void LoadNextPicture(ref int index)
        {
            if (index < personList.Count)
            {
                pictureBox1.Location = new System.Drawing.Point(244, 1);
                pictureBox1.Image = personList[index].Image;
                index++;
            }
            else
            {
                pointsBox.Text = $"You have {currentPoints} Points";
                pictureBox1.Image = null;
                playAgainButton.Visible = true;
                endGame = true;
                return;
            }
        }
        
        // Manages point system
        private void ResolvePoints(ref int index, Button button)
        {
            if (index == personList.Count)
            {       
                    //compares images country code and buttons tag to check if answer is correct
                    //tag contains first letter of the country it represents, exmpl: 'J' for Japanese button
                if (personList[index-1].Country.Substring(0, 1).Equals(button.Tag.ToString(), StringComparison.Ordinal))
                {
                    currentPoints += 20;
                    pointsBox.Text = $"You have {currentPoints} Points";
                    LoadNextPicture(ref index);
                }
                else
                {
                    currentPoints -= 5;
                    pointsBox.Text = $"You have {currentPoints} Points";
                    LoadNextPicture(ref index);
                }
                pictureBox1.Image = null;
                playAgainButton.Visible = true;
                endGame = true;
                return;
            }


            if (personList[index-1].Country.Substring(0, 1).Equals(button.Tag.ToString(), StringComparison.Ordinal))
            {
                currentPoints += 20;
                pointsBox.Text = $"You have {currentPoints} Points";
                LoadNextPicture(ref index);
            }
            else
            {
                currentPoints -= 5;
                pointsBox.Text = $"You have {currentPoints} Points";
                LoadNextPicture(ref index);
            }
        }

        #endregion

        #region Event handlers
        private void GuessingGame_Load(object sender, EventArgs e) {}

        private void pictureChange_Tick(object sender, EventArgs e)
        {
            if (buttonClicked)
            {
                buttonClicked = false;
                return;
            }
            LoadNextPicture(ref currenIndex);
        }

        private void pictureMove_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y + 9); 
        }

        private void JapaneseButton_Click(object sender, EventArgs e)
        {
            if (endGame)
                return;
            buttonClicked = true;
            ResolvePoints(ref currenIndex, JapaneseButton);
        }
        

        private void ChineseButton_Click(object sender, EventArgs e)
        {
            if (endGame)
                return;
            buttonClicked = true;
            ResolvePoints(ref currenIndex, ChineseButton);
        }

        private void KoreanButton_Click(object sender, EventArgs e)
        {
            if (endGame)
                return;
            buttonClicked = true;
            ResolvePoints(ref currenIndex, KoreanButton);
        }

        private void ThaiButton_Click(object sender, EventArgs e)
        {
            if (endGame)
                return;
            buttonClicked = true;
            ResolvePoints(ref currenIndex, ThaiButton);
        }

        
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        #endregion

    }
}