using AjaxDropdown.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxDropdown.Repository.Repository
{
    public interface IDropDown
    {
        List<Country> CountryDropdown();

        List<State> StateDropdown();

        List<City> CityDropdown();
    }
}
