using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utp.Models;
namespace Utp.Controllers
{
    public class UbigeoController : Controller
    {
        //
        // GET: /Ubigeo/
        public ActionResult Index()
        {
        
            UbigeoNegocio neg = new UbigeoNegocio();

            DataTable dtDepartamento = neg.Listar();                   

            List<SelectListItem> li = new List<SelectListItem>();

            for (int i = 0; i <= dtDepartamento.Rows.Count - 1; i++)
            {
                string nombre = dtDepartamento.Rows[i]["Departamento"].ToString();
                string valor = dtDepartamento.Rows[i]["CodigoDepartamento"].ToString();

                SelectListItem item = new SelectListItem() { Text = nombre, Value = valor };

                li.Add(item);

            }
            ViewData["Ubigeo"] = li;
            return View();     
           
        }

        public JsonResult GetStates(string idDepartamento)
        {
            UbigeoNegocio neg = new UbigeoNegocio();

            DataTable dtProvincia = neg.BuscarProvincias(idDepartamento);   

            List<SelectListItem> li = new List<SelectListItem>();

            for (int i = 0; i <= dtProvincia.Rows.Count - 1; i++)
            {
                string nombre = dtProvincia.Rows[i]["Provincia"].ToString();
                string valor = dtProvincia.Rows[i]["CodigoProvincia"].ToString();

                SelectListItem item = new SelectListItem() { Text = nombre, Value = valor };

                li.Add(item);

            }                               

            return Json(new SelectList(li, "Value", "Text"));
        }

        public JsonResult GetCity(string idDepartamento, string idProvincia)
        {
            UbigeoNegocio neg = new UbigeoNegocio();

            DataTable dtDistritos = neg.BuscarDistritos(idDepartamento, idProvincia);

            List<SelectListItem> li = new List<SelectListItem>();

            for (int i = 0; i <= dtDistritos.Rows.Count - 1; i++)
            {
                string nombre = dtDistritos.Rows[i]["Distrito"].ToString();
                string valor = dtDistritos.Rows[i]["CodigoDistrito"].ToString();

                SelectListItem item = new SelectListItem() { Text = nombre, Value = valor };

                li.Add(item);

            }

            return Json(new SelectList(li, "Value", "Text"));
        }


      


           
        }        

        }

       


	

