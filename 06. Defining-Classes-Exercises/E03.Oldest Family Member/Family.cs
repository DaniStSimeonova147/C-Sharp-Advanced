using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMember;

        public Family()
        {
            familyMember = new List<Person>();
        }

        public void AddMember(Person member)
        {
            familyMember.Add(member);
        } 

        public Person GetOldestMember()
        {
            Person olderPerson = familyMember.OrderByDescending(p => p.Age).FirstOrDefault();
            return olderPerson;
        }
    }
}
