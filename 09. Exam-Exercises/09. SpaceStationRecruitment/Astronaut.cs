﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStationRecruitment
{
    class Astronaut
    {
       
        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public Astronaut(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public override string ToString()
        {
            //"Astronaut: {name}, {age} ({country})"

            string result = $"Astronaut: {this.Name}, {this.Age} ({this.Country})";

            return result;
        }

    }
}
