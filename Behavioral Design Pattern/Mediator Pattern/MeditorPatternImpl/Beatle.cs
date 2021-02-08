using System;
using System.Collections.Generic;
using System.Text;

namespace MeditorPatternImpl
{
    class Beatle : Participant
    {
        public Beatle(string name)
          : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}
