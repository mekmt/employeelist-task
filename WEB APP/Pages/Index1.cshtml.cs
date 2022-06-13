using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB_APP.Pages
{
    public class Index1Model : PageModel
    {
       static List <Employee> Employeelist = new List<Employee> ();

        public void OnPost()
        {
            var name = Request.Form["Employeename"];
            var surname = Request.Form["Employeesurname"];
            Employee e=new Employee();
            e.name = name; 
            Employeelist.Add(e);
        }
    }
}
