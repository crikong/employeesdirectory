using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace gigs.data
{
    //Describes object encapsualting data on a company
    public class Company
    {

      //Unique identifier (in data store) for the company 
        public int id { set; get; }
      //Property storing company name
        public string name { set; get; }
      //Property storing data on all the employees that are in the company
        public List<Employee> employees { set; get; }


        //Instantiates a Company object
        public Company()
        {
            this.id = 0;
            this.name = "";
            this.employees = new List<Employee>();
        }

      //Instantiates a Company object
        public Company(int id, string name, List<data.Employee> employees)
        {
            this.id = id;
            this.name = name;
            this.employees = employees;
        }


    }
}