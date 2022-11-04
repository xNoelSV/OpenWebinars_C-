using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class Song : Media
    {

        public long Seconds { get; set; }

        public override void play()
        {
            Console.WriteLine("Increase volume");
            base.play();
        }

        public ShelvePosition Position { get; set; }

        
    }
}
