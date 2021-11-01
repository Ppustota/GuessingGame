using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    static class PersonUtils
    {
        
        //Fills list of persons with images and country code
        public static List<Person> FillPersonList(string directory, string format)
        {
            List<Person> list = new List<Person>();
            string[] images = Directory.GetFiles(directory, "*" + format);
            Random random = new Random();
            images = images.OrderBy(x => random.Next()).ToArray();
            foreach (var image in images)
            {
                //CountryCode holds the info about nationality of the person on the picture
                //which is dependent on the name of the image
                string countryCode = image.Replace(directory, "");

                list.Add(new Person
                {
                    Country = countryCode,
                    Image = new Bitmap(image)
                });
            }
            return list;
        }
   
    }
}
