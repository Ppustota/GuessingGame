using GuessingGame.manager;
using System;
using System.IO;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GuessingGame : Form
    {
        #region Private members

        private static string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\images\\";
        private bool buttonClicked;
        private GameManager gameManager;    
        
        #endregion

        #region Default constructor
         public GuessingGame()
        {
            InitializeComponent();
            gameManager = new GameManager(personList: PersonUtils.FillPersonList(currentDirectory, ".jpg"), 
                                          pictureBox: pictureBox1, 
                                          playAgain: playAgainButton, 
                                          pointsBox: pointsBox); 
        }

        #endregion

        #region Event handlers
        private void GuessingGame_Load(object sender, EventArgs e) 
        {
            gameManager.NewGame();
        }

        private void pictureChange_Tick(object sender, EventArgs e)
        {
            if (buttonClicked)
            {
                buttonClicked = false;
                return;
            }
            gameManager.LoadNextPicture();
        }

        private void pictureMove_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y + 9); 
        }

        private void JapaneseButton_Click(object sender, EventArgs e)
        {
            gameManager.OnUsersAnswer(JapaneseButton, ref buttonClicked);
        }


        private void ChineseButton_Click(object sender, EventArgs e)
        {
            gameManager.OnUsersAnswer(ChineseButton, ref buttonClicked);
        }

        private void KoreanButton_Click(object sender, EventArgs e)
        {
            gameManager.OnUsersAnswer(KoreanButton, ref buttonClicked);
        }

        private void ThaiButton_Click(object sender, EventArgs e)
        {
            gameManager.OnUsersAnswer(ThaiButton, ref buttonClicked);
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            gameManager.NewGame();
        }
        #endregion

    }
}