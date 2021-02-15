using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class Person
    {
        private string birthday;
        private string name;
        private List<Person> parents;
        private List<Person> childen;


        public Person(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        
        public List<Person> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public List<Person> Children
        {
            get { return childen; }
            set { childen = value; }
        }

    }
}
