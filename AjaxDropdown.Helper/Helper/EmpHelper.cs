using AjaxDropdown.Model.Context;
using AjaxDropdown.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxDropdown.Helper.Helper
{
    public class EmpHelper
    {
        public Emp AddUseInDb(CSCModel Empdata)
        {
            Emp MainObj = new Emp();
            MainObj.Id = Empdata.Id;
            MainObj.Name = Empdata.Name;
            MainObj.Email = Empdata.Email;
            MainObj.Department = Empdata.Department;
            MainObj.Country = Empdata.CountryId;
            MainObj.State = Empdata.StateId;
            MainObj.City = Empdata.CityId;

            return MainObj;
      
        }
    }
}
