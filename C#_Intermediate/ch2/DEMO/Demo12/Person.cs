﻿using System;

namespace Demo12
{
    public class Person
    {
        //prop tab  tab tab tab  enter


        public DateTime Birthdate { get; private set; }


        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }


        }
    }
}
