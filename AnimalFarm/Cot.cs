using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm {
    class Cot : ISpeak {

        ISpeak speak;

        public void Speak() {
            speak.Speak();
        }

        public Cot(ISpeak speak) {
            this.speak = speak;
        }
    }
}
