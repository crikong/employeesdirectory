using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace gigs.data
{
    //Describes objects encapaulating data on a person (employee) working for a given company
    public class Employee
    {

      //Unique identifier (in data store) for the company 
        public int id { set; get; }
      //Property storing employee name
        public string name { set; get; }
     

      //Instantiates an Employee object
        public Employee()
        {
            this.id = 0;
            this.name = "";
        }

      //Instantiates an Employee object
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }


    }
}