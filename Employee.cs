using System;
using System.Collections.Generic;

namespace classes
{
public class Employee
{
    public Employee(string firstName, string lastName, string title){
        FirstName = firstName;
        LastName = lastName;
        Title = title;
        StartDate = DateTime.Now;
    }

    public string FirstName{get;}
    public string LastName{get;}
    public string Title{get;}
    public DateTime StartDate{get;}
}
}