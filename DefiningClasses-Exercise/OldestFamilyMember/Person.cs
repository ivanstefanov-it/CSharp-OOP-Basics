﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OldestFamilyMember
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }
        public Person(int age) : this()
        {
            this.name = "No name";
            this.age = age;
        }
        public Person(string name, int age) : this(age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
