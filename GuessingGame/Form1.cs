using GuessingGame.manager;
using System;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GuessingGame : Form
    {
        #region Private members

        private bool buttonClicked;
        private ViewManager viewManager;   
        
        #endregion

        #region Default constructor
         public GuessingGame()
        {
            InitializeComponent();
            viewManager = new ViewManager(pictureBox1, playAgainButton, pointsBox); 
        }

        #endregion

        #region Event handlers
        private void GuessingGame_Load(object sender, EventArgs e) 
        {
            viewManager.StartGame();
        }

        private void pictureChange_Tick(object sender, EventArgs e)
        {
           if (buttonClicked)
            {
                buttonClicked = false;
                return;
            } 
            viewManager.ShowNextPicture();
        }

        private void pictureMove_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y + 9); 
        }

        private void JapaneseButton_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            viewManager.ShowPoints(JapaneseButton);
        }


        private void ChineseButton_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            viewManager.ShowPoints(ChineseButton);
        }

        private void KoreanButton_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            viewManager.ShowPoints(KoreanButton);
        }

        private void ThaiButton_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            viewManager.ShowPoints(ThaiButton);
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            viewManager.StartGame();
        }
        #endregion

    }
}