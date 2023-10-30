using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStationRecruitment
{
    class SpaceStation
    {
        private List<Astronaut> data;

        public int Count
        {
            get
            {
                return data.Count;
            }
        }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            this.data = new List<Astronaut>();
        }

        public void Add(Astronaut astronaut)
        {
            if (this.Capacity > 0)
            {
                this.data.Add(astronaut);
                Capacity--;
            }
        }

        public bool Remove(string name)
        {
            bool check = true;

            if (data.FirstOrDefault(n => n.Name == name) != null)
            {
                data.Remove(data.FirstOrDefault(x => x.Name == name));
            }
            else
            {
                check = false;
            }
            return check;
        }

        public Astronaut GetOldestAstronaut()
        {
            int maxAge = data.Max(x => x.Age);

            return data.FirstOrDefault(x => x.Age == maxAge);
        }

        public Astronaut GetAstronaut(string name)
        {
            return data.FirstOrDefault(n => n.Name == name);
        }

        public string Report()
        {
           string result = $"Astronauts working at Space Station {this.Name}:" + Environment.NewLine;

            foreach (var currentAstronaut in data)
            {
                result += currentAstronaut + Environment.NewLine;
            }

            return result.TrimEnd();
        }
    }
}
