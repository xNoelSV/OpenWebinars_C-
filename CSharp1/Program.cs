﻿using System;
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

            Song song = new Song();

            song.Title = "Dark side of the moon";
            song.Seconds = 500;

            song.Position = new ShelvePosition(0,0);
            song.play();

            Console.ReadKey();

        }
    }
}
