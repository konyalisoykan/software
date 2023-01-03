﻿using BackendApps.DesignPaterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Prototype
{
   
    public abstract class Person
    {
        public abstract Person Clone();
        public string? FirstName { get; set; }
        public  string LastName { get; set; }

    }
    public class Customer: Person
    {
        public string  City { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }

    }
    public class Employee : Person
    {
        public string Salary { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }

    }
}
