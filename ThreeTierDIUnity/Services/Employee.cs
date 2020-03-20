using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreeTierDIUnity.Services
{
    public class Employee : IEmployee
    {
        public string GetEmployeeDetails(int EmpID)
        {
            return "Employee details of "+EmpID ;
        }
    }

}