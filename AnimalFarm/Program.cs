﻿using System;
using AnimalFarm.Sounds;
namespace AnimalFarm {
    class Program {

        static void Main(string[] args) {
            var cow = new Cow(new Moo());
            cow.Speak();

            var cat = new Cat(new Meow());
            cat.Speak();

            var cot = new Cot(new Meoo());
            cot.Speak();
        }
    }
}
