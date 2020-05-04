using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Person
    {
        string name;
        List<string> professions;
        int age;

        public Person(string name, List<string> professions, int age)
        {
            this.name = name;
            this.professions = professions;
            this.age = age;
        }
    }
}
