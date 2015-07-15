using System;

namespace AutoPropertyIntializers
{
    public class Employee
    {
        public Guid Id {get;set;}= Guid.NewGuid();
        public string FirstName {get;set;}
        public string LastName {get;set;}
    }
}