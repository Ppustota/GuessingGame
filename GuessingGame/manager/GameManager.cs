using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GuessingGame.manager
{
    class GameManager
    {
        private int Index { get; set;}
        public int Points { get; private set;}
        private bool EndGame { get; set;}
        private List<Person> PersonList{get; set;}

       
        public GameManager(List<Person> personList)
        {
            Index = 0;
            Points = 0;
            PersonList = personList;
        }
        //Resets variables to start new game
        public Image NewGame()
        {
            EndGame = false;
            Index = 0;
            Points = 0;
            return GetNextPicture();
        }

        //Loads next picture from list or returns null if last picture was already loaded
        public Image GetNextPicture()
        {
            if (Index < PersonList.Count)
            {
                Index++;
                return PersonList[Index-1].Image;
            }
            else
            {
                EndGame = true;
                return null;
            }
        }
        //Responses to users answers
        public Image OnUsersAnswer(Button button)
        {
            if (EndGame)
                return null;
            ResolvePoints(button);
            return GetNextPicture();
        }

        //Manages Points system
        public void ResolvePoints(Button button)
        {
            if (PersonList[Index - 1].Nationality.Equals(button.Tag.ToString(), StringComparison.Ordinal))
            {
                Points += 20;
            }
            else
            {
                Points -= 5;   
            }
        }
    }
}
