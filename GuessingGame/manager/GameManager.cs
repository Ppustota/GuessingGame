using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GuessingGame.manager
{
    class GameManager
    {
        public int Index { get; set; }
        public int Points { get; set; }
        public bool EndGame { get; set; }
        public List<Person> PersonList{get; set;}
        public PictureBox PictureBox { get; set;}
        public Button PlayAgain { get; set; }
        public TextBox PointsBox { get; set; }

       
        public GameManager(List<Person> personList, PictureBox pictureBox, Button playAgain, TextBox pointsBox)
        {
            Index = 0;
            Points = 0;
            PersonList = personList;
            PictureBox = pictureBox;
            PlayAgain = playAgain;
            PointsBox = pointsBox;
        }
        //Starts new game
        public void NewGame()
        {
            PlayAgain.Visible = false;
            PointsBox.Text = String.Empty;
            EndGame = false;
            Index = 0;
            Points = 0;
            LoadNextPicture();
        }

        //Loads next picture from list or ends game if last picture was already loaded
        public void LoadNextPicture()
        {
            if (Index < PersonList.Count)
            {
                PictureBox.Location = new System.Drawing.Point(244, 1);
                PictureBox.Image = PersonList[Index].Image;
                Index++;
            }
            else
            {

                PointsBox.Text = $"You have {Points} Points";
                PlayAgain.Visible = true;
                PictureBox.Image = null;
                EndGame = true;
                return;
            }
        }
        //Responses to users answers
        public void OnButtonClick(Button button, ref bool clicked)
        {
            if (EndGame)
                return;
            clicked = true;
            this.ResolvePoints(button);
        }

        //Manages Points system
        private void ResolvePoints(Button button)
        {
            if (this.Index == PersonList.Count)
            {
                //compares persons nationality and buttons tag to check if answer is correct
                if (PersonList[Index - 1].Nationality.Equals(button.Tag.ToString(), StringComparison.Ordinal))
                {
                    Points += 20;
                    PointsBox.Text = $"You have {Points} Points";
                    LoadNextPicture();
                }
                else
                {
                    Points -= 5;
                    PointsBox.Text = $"You have {Points} Points";
                    LoadNextPicture();
                }
                PictureBox.Image = null;
                PlayAgain.Visible = true;
                EndGame = true;
                return;
            }


            if (PersonList[Index - 1].Nationality.Equals(button.Tag.ToString(), StringComparison.Ordinal))
            {
                Points += 20;
                PointsBox.Text = $"You have {Points} Points";
                LoadNextPicture();
            }
            else
            {
                Points -= 5;
                PointsBox.Text = $"You have {Points} Points";
                LoadNextPicture();
            }
        }
    }
}
