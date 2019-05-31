using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using VendaProdutos.Aplicacao.Interface;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.MVC.ViewModels;

namespace VendaProdutos.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoController(IProdutoAppService produtoApp)
        {
            _produtoAppService = produtoApp;
        }

        // GET: Produto
        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoVM>>(_produtoAppService.GetAll());

            return View(produtoViewModel);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            var produto = _produtoAppService.GetById(id);
            var produtoVm = Mapper.Map<Produto, ProdutoVM>(produto);

            return View(produtoVm);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoVM produtoVm)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoVM, Produto>(produtoVm);
                _produtoAppService.Add(produtoDomain);

                return RedirectToAction("Index");
            }

            return View(produtoVm);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoAppService.GetById(id);
            var produtoVm = Mapper.Map<Produto, ProdutoVM>(produto);

            return View(produtoVm);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoVM produtoVm)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoVM, Produto>(produtoVm);
                _produtoAppService.Update(produtoDomain);
            }

            return View(produtoVm);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoAppService.GetById(id);
            var produtoVm = Mapper.Map<Produto, ProdutoVM>(produto);

            return View(produtoVm);
        }

        // POST: Produto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ProdutoVM produtoVm)
        {
            var objeto = _produtoAppService.GetById(produtoVm.Id);
            _produtoAppService.Remove(objeto);
            //if (ModelState.IsValid)
            //{
            //    var produtoDomain = Mapper.Map<ProdutoVM, Produto>(produtoVm);
            //    _produtoAppService.Remove(produtoDomain);

            //    return RedirectToAction("Index");
            //}

            return RedirectToAction("Index");
        }
    }
}
