using System;
using System.Collections.Generic;

namespace Proyecto
{
    [Serializable]
    public class Person
    {
        public string Name;
        public List<string> Professions;
        public int Age;

        public Person(string name, List<string> professions, int age)
        {
            Name = name;
            Professions = professions;
            Age = age;
        }
    }
}
