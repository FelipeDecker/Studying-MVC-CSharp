using AutoMapper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using VendaProdutos.Aplicacao.Interface;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.MVC.ViewModels;

namespace VendaProdutos.MVC.Controllers
{
    [SuppressMessage("ReSharper", "Mvc.ViewNotResolved")]
    public class VendaController : Controller
    {
        private readonly IVendaAppService _vendaAppService;

        public VendaController(IVendaAppService vendaAppRepository)
        {
            _vendaAppService = vendaAppRepository;
        }

        // GET: Venda
        public ActionResult Index()
        {
            var vendaViewModel = Mapper.Map<IEnumerable<Venda>, IEnumerable<VendaVM>>(_vendaAppService.GetAll());
            return View(vendaViewModel);
        }

        // GET: Venda/Details/5
        public ActionResult Details(int id)
        {
            var venda = _vendaAppService.GetById(id);
            var vendaVm = Mapper.Map<Venda, VendaVM>(venda);

            return View(vendaVm);
        }

        // GET: Venda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Venda/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Venda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Venda/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Venda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Venda/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
