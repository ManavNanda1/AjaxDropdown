using AjaxDropdown.Model.Context;
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
    }
}
