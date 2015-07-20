using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http.Routing;

using gigs.bal;
using gigs.data;



namespace api.Controllers
{
    public class companiesController : Controller
    {
      
     /// <summary>
     ///    Retrieves data on all the companies and their employees
     /// </summary>
     /// <returns></returns>
        public ActionResult Index()
        {
            List<Company> Companies = null;

            try
            {
                Companies = CompanyEngine.GetCompanies(true);
            }
            catch(Exception exception)
            {
                HandleException(exception);
            }

            return (Json(Companies, JsonRequestBehavior.AllowGet));
        }

      /// <summary>
      ///   Retrieves data on a given company and its employees
      /// </summary>
      /// <param name="CompanyId"></param>
      /// <returns></returns>
        public ActionResult company_employees(int CompanyId)
        {
            Company CurrentCompany = null;


            try
            {
                CurrentCompany = CompanyEngine.GetCompanyById(CompanyId);
            }
            catch (Exception exception)
            {
                HandleException(exception);
            }

            return (Json(CurrentCompany, JsonRequestBehavior.AllowGet));
        }

      /// <summary>
      ///   Logs an exception that might have occured 
      /// </summary>
      /// <param name="exception"></param>
      /// <returns></returns>
        private bool HandleException(Exception ApplicationException)
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
