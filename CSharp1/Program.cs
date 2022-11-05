using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // SONG 1 
            Song song = new Song();

            song.Title = "Dark side of the moon";
            song.Seconds = 500;

            song.Position = new ShelvePosition(0,0);
            Console.WriteLine(song.ToString());

            //SONG2
            Song song2 = new Song();

            song2.Title = "Dark side of the moon 2";
            song2.Seconds = 350;

            song2.Position = new ShelvePosition();
            Console.WriteLine(song2.ToString()); 

            Console.ReadKey();

        }
    }
}
