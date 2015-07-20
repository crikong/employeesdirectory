using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using gigs.data;

namespace gigs.bal
{
  /// <summary>
  ///   Describes objects able to perform CRUD operations on companies data
  /// </summary>
    public class CompanyEngine
    {

      /// <summary>
      ///   Instantiates a CompanyEngine object
      /// </summary>
        public CompanyEngine()
        {

        }



      /// <summary>
      ///   Retrieves data on a company with a given id
      /// </summary>
      /// <param name="CompanyId"></param>
      /// <returns></returns>
        public static Company GetCompanyById(int CompanyId)
        {
            Company SelectedCompany = null;

            try
            {
              //We retrieve data on all the companies and attempt to locate the one that has the id that was passed in
                List<Company> Companies = GetCompanies(true);
                SelectedCompany = Companies.Find(x => x.id == CompanyId);
            }
            catch(Exception exception)
            {
                HandleException(exception);
            }

            return (SelectedCompany);
        }

      /// <summary>
      ///   Retrieves data on all the companies with or without their employees data. This depends on the value of 
      ///   the parameter ShowEmployees. If it is true, the employees data are returned. Otherwise only the company
      ///   data are sent back to the caller
      /// </summary>
      /// <returns></returns>
        public static List<Company> GetCompanies(bool ShowEmployees)
        {
            List<Company> Companies = new List<Company>();

            try
            {
              //For the purpose of this example we simply instantiate the companies here. However, it is easy to see 
              //that the instantiation could be replaced by a database call

                if(ShowEmployees == true)
                {
                    Companies = new List<Company>()
                    {
                        new Company
                        (
                            1, "Bafiasoft, LLC", new List<Employee>() { 
                            new Employee(1, "Christian"), new Employee(2, "Michael"), 
                            new Employee(3, "Taleah"), new Employee(4, "Yannick"), new Employee(5, "Yapseu") } 
                        ) ,

                        new Company
                        (
                            2, "Apple Computer", new List<Employee>() { 
                            new Employee(1, "Steve Jobs"), new Employee(2, "Steve Wozniak"), 
                            new Employee(3, "Yohan Rolof"), new Employee(4, "Zouli Hooli") } 
                        )
                    };
                }
                else
                {
                    Companies = new List<Company>()
                    {
                        new Company
                        (
                            1, "Bafiasoft, LLC", new List<Employee>()
                        ) ,

                        new Company
                        (
                            2, "Apple Computer", new List<Employee>()
                        )
                    };
                }
            }
            catch(Exception exception)
            {
                HandleException(exception);
            }

            return (Companies);
        }

      /// <summary>
      ///   Logs an exception that might have occured 
      /// </summary>
      /// <param name="exception"></param>
      /// <returns></returns>
        private static bool HandleException(Exception ApplicationException)
        {
            bool Handled = false;

            try
            {
                string ExceptionSource = ApplicationException.Source;
                string ExceptionMessage = ApplicationException.Message;
                string ExceptionStackTrace = ApplicationException.StackTrace;

                Handled = true;
            }
            catch (Exception exception)
            {
                string Message = exception.Message;
                string StackTrace = exception.StackTrace;
            }
           
            return (Handled);
        }

    }
}
