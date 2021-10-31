using System;
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

        private readonly string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\images\\";
        private int currenIndex = 0;
        private int currentPoints = 0;
        private bool buttonClicked;

        #endregion

        #region Default constructor
        public GuessingGame()
        {
            InitializeComponent();
            AddImagesToList();
            NewGame(ref currentPoints);
        }

        #endregion

        #region Custom methods

        // Starts a new game and clears old results
        private void NewGame(ref int points)
        {
            playAgainButton.Visible = false;
            currenIndex = 0;
            currentPoints = 0;
            pointsBox.Text = String.Empty;
            LoadNextPicture(ref currenIndex);
        }

        // Adds Pictures to image list and shuffles them
        private void AddImagesToList()
        {
            string[] images = Directory.GetFiles(currentDirectory, "*.jpg");
            Random random = new Random();
            images = images.OrderBy(x => random.Next()).ToArray();
            foreach (var image in images)
            {
                //key holds the info about nationality of the person on the picture
                //which is dependent on the name of the image
                string key = image.Replace(currentDirectory, "").Replace(".jpg", "");
                imageList1.Images.Add(key, new Bitmap(image));
            }
        }
   
        // Loads next picture from image list or ends game if last picture was already loaded
        private void LoadNextPicture(ref int index)
        {
            if (index < imageList1.Images.Count)
            {
                pictureBox1.Location = new System.Drawing.Point(244, 1);
                pictureBox1.Image = imageList1.Images[index];
                index++;
            }
            else
            {
                pointsBox.Text = $"You have {currentPoints} Points";
                pictureBox1.Image = null;
                playAgainButton.Visible = true;
                return;
            }
        }
        
        // Manages point system
        private void ResolvePoints(ref int index, Button button)
        {
            if (index == imageList1.Images.Count)
            {       
                    //compares images key and buttons tag to check if answer is correct
                    //tags contain first letter of the country they represent, exmpl: 'J' for Japan
                if (imageList1.Images.Keys[index - 1].Substring(0, 1).Equals(button.Tag.ToString(), StringComparison.Ordinal))
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
                return;
            }


            if (imageList1.Images.Keys[index - 1].Substring(0, 1).Equals(button.Tag.ToString(), StringComparison.Ordinal))
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
        private void GuessingGame_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            playAgainButton.Visible = false;

        }

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
            buttonClicked = true;
            ResolvePoints(ref currenIndex, JapaneseButton);
        }
        

        private void ChineseButton_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            ResolvePoints(ref currenIndex, ChineseButton);
        }

        private void KoreanButton_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            ResolvePoints(ref currenIndex, KoreanButton);
        }

        private void ThaiButton_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            ResolvePoints(ref currenIndex, ThaiButton);
        }

        
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            NewGame(ref currentPoints);
        }
        #endregion

    }
}