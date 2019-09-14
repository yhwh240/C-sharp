using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10HomeWork
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public int AgeAfter4Years
        {
            get
            {
                return Age += 4;
            }
        }

        public string Descriprion
        {
            get
            {
                return $"Name: {Name}, Age after 4 years : {AgeAfter4Years}";
            }
        }
    }
}
