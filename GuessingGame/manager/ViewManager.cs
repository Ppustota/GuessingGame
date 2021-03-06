using System.IO;
using System.Windows.Forms;

namespace GuessingGame.manager
{
    class ViewManager
    {
        private PictureBox PictureBox { get; set; }
        private Button PlayAgain { get; set; }
        private TextBox PointsBox { get; set; }

        private GameManager gameManager;

        private string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\images\\";
        public ViewManager(PictureBox pictureBox, Button playAgain, TextBox pointsBox)
        {
            gameManager = new GameManager(PersonUtils.FillPersonList(currentDirectory, ".jpg"));
            PictureBox = pictureBox;
            PlayAgain = playAgain;
            PointsBox = pointsBox;
        }
        //Displays next picture or ends game if last picture was displayed
        public void ShowNextPicture()
        {
            PictureBox.Location = new System.Drawing.Point(250, 0);
            System.Drawing.Image image = gameManager.GetNextPicture();
            if (image != null)
            {
                PictureBox.Image = image;
            }
            else
            {
                PointsBox.Text = $"You have {gameManager.Points} Points";
                PlayAgain.Visible = true;
                PictureBox.Image = null;
            }
        }
        //Shows current points of user
        public void ShowPoints(Button button)
        {
            PictureBox.Location = new System.Drawing.Point(250, 0);
            System.Drawing.Image image = gameManager.OnUsersAnswer(button);
            PictureBox.Image = image;
            PointsBox.Text = $"You have {gameManager.Points} Points";
            if (image == null)
                PlayAgain.Visible = true;
        }
        public void MovePictureBox()
        {
            PictureBox.Location = new System.Drawing.Point(PictureBox.Location.X, PictureBox.Location.Y + 9);
        }
        //Prepares environement to start new game 
        public void StartGame()
        {
            PlayAgain.Visible = false;
            PointsBox.Text = string.Empty;
            PictureBox.Location = new System.Drawing.Point(250, 0);
            PictureBox.Image = gameManager.NewGame();
        }
    }
}
