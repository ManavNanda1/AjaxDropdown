using AjaxDropdown.Model.Model;
using AjaxDropdown.Repository.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDropdown.Controllers
{
    public class HomeController : Controller
    {
        IDropDown DropDownObj;

        public HomeController(IDropDown RefObj)
        {
            DropDownObj = RefObj;
        }
        public ActionResult Index()
        {
            try
            {
               ViewBag.CountryList = DropDownObj.CountryDropdown();
                ViewBag.DeptList = DropDownObj.DeptDropdown();
            return View();
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult Index (CSCModel Empdata , FormCollection FormData)
        {
            try
            {
                string DeptId = FormData["Department"];
                Empdata.Department = DeptId;

                DropDownObj.AddEmpData(Empdata);
                return RedirectToAction("Index");
            }
            catch(Exception E){
                throw E;
            }
        }

        public ActionResult AllEmployees()
        {
            try
            {
            return View(DropDownObj.AllEmployees());
            }
            catch(Exception E)
            {
                throw E;
            }

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult StateDpd(int id)
        {
            try
            {
                var StateList = from a in (DropDownObj.StateDropdown().Where(x => x.CountryId == id).ToList()) select new { 
                Id = a.Id,
                StateName = a.StateName
                };
                
                return Json(StateList, JsonRequestBehavior.AllowGet);
            }   
            catch(Exception E)
            {
                throw E;
            }
        }

        public JsonResult CityDpd (int id)
        {
            try
            {
                var CityList = from a in (DropDownObj.CityDropdown().Where(x => x.StateId == id).ToList())
                               select new
                               {
                                   Id = a.Id,
                                   Name = a.CityName
                               };
                return Json(CityList , JsonRequestBehavior.AllowGet);
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}