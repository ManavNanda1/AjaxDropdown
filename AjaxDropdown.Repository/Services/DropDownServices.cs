using AjaxDropdown.Helper.Helper;
using AjaxDropdown.Model.Context;
using AjaxDropdown.Model.Model;
using AjaxDropdown.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxDropdown.Repository.Services
{
    public class DropDownServices : IDropDown
    {
        Manav_SchoolMgmt_42Entities Context = new Manav_SchoolMgmt_42Entities();
        public List<Country> CountryDropdown()
        {
            try
            {
                List<Country> CountryList = Context.Countries.ToList();
                return CountryList;
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public List<State> StateDropdown()
        {
            try
            {
                List<State> StateList = Context.States.ToList();
                return StateList;
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public List<City> CityDropdown()
        {
            try
            {
                List<City> CityList = Context.Cities.ToList();
                return CityList;
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public void AddEmpData(CSCModel EmpData)
        {
            try
            {
                EmpHelper HelperObj = new EmpHelper();
                var data = HelperObj.AddUseInDb(EmpData);
                Context.Emps.Add(data);
                Context.SaveChanges();
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public List<department> DeptDropdown()
        {
            try
            {
                List<department> DepartmentList = Context.departments.ToList();
                return DepartmentList;
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public List<Sp_GetEmployees_Result> AllEmployees()
        {
            try
            {
                List<Sp_GetEmployees_Result> EmployeeList = Context.Sp_GetEmployees().ToList();
                return EmployeeList;
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}
