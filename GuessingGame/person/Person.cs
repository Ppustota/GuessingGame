using System.Drawing;

namespace GuessingGame
{
    class Person
    { 
       public string Nationality { get; set; }
       public Image Image { get; set; }
        //Check if person is from specific country
       public bool IsFrom(string country)
        {
            return Nationality.Equals(country);
        }
    }
}
