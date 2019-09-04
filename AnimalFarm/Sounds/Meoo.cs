using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Sounds {
    class Meoo : ISpeak {
        public void Speak() {
            Console.WriteLine("Meoo!");
        }
    }
}
