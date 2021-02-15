using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OldestFamilyMember
{
    public class Family
    {
        private List<Person> member;

        public Family()
        {
            this.Members = new List<Person>();
        }

        public List<Person> Members
        {
            get { return this.member; }
            set { this.member = value; }
        }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.Members.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
