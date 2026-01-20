using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_29
{
    public class Human
    {
        string name;
        int mood;
        int satiety;
        int iq; 

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "") name = value;
                else name = "Human1";
            }
        } 

        public int Mood
        {
            get
            {
                return mood;
            }
            set
            {
                if (value < 0) mood = 0;
                else
                if (value > 10) mood = 10;
                else mood = value;
            }
        }

        public int Satiety
        {
            get
            {
                return satiety;
            }
            set
            {
                if (value < 0) satiety = 0;
                else
                if (value > 10) satiety = 10;
                else satiety = value;
            }
        }

        public int Iq
        {
            get
            {
                return iq;
            }
            set
            {
                if (value < 0) iq = 0;
                else
                if (value > 10) iq = 10;
                else iq = value;
            }
        }

        public void Eat()
        {
            Mood += 2;
            Satiety += 5;
        }

        public void Relax()
        {
            Mood += 3;
            Satiety -= 2;
            Iq -= 10;
        }

        public void Work()
        {
            Mood -= 5;
            Satiety -= 3;
            Iq += 3;
        }

        public void Leran()
        {
            Satiety -= 3;
            Iq += 5;
        }

        public Human()
        {

        }
    }
}