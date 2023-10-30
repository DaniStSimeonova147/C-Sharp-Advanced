using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repository
{
    class Repository
    {
        private Dictionary<int, Person> data;

        private int id;

        public int Count
        {
            get
            {
                return data.Count;
            }
        }
        public Repository()
        {
            data = new Dictionary<int, Person>();
            id = 0;
        }

        public void Add(Person person)
        {
            data.Add(id, person);
            id++;
        }
        public Person Get(int id)
        {
            return data[id];
        }

        public bool Update(int id, Person newPerson)
        {
            bool isValid = true;

            if (!data.ContainsKey(id))
            {
                isValid = false;
            }
            else
            {
                data.Remove(id);
                data[id] = newPerson;
            }

            return isValid;
        }

        public bool Delete(int id)
        {
            bool check = true;

            if (!data.ContainsKey(id))
            {
                check = false;
            }
            else
            {
                data.Remove(id);
            }


            return check;
        }
    }
}
