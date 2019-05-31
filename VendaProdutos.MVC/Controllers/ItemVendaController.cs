using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using VendaProdutos.Aplicacao.Interface;
using VendaProdutos.Dominio.Entidades;
using VendaProdutos.MVC.ViewModels;

namespace VendaProdutos.MVC.Controllers
{
    public class ItemVendaController : Controller
    {
        private readonly IItemVendaAppService _itemVendaAppService;
        private readonly IVendaAppService _vendaAppService;
        private readonly IProdutoAppService _produtoAppService;

        public ItemVendaController(IItemVendaAppService itemVendaAppService, IVendaAppService vendaAppService, IProdutoAppService produtoAppService)
        {
            _itemVendaAppService = itemVendaAppService;
            _vendaAppService = vendaAppService;
            _produtoAppService = produtoAppService;
        }

        // GET: ItemVenda
        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<ItemVenda>, IEnumerable<ItemVendaVM>>(_itemVendaAppService.GetAll());

            return View(produtoViewModel);
        }

        // GET: ItemVenda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemVenda/Create
        public ActionResult Create()
        {
            ViewBag.IdProduto = new SelectList(_produtoAppService.GetAll(), "Id", "Descricao");
            //ViewBag.Valor = new SelectList(_produtoAppService.GetAll(), "Valor", "Valor");
            return View();
        }

        // POST: ItemVenda/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemVendaVM itemVendaVm)
        {
            if (ModelState.IsValid)
            {
                //cria uma nova venda
                var venda = new Venda();
                //salva a nova venda no banco
                _vendaAppService.Add(venda);
                //Mapeia os itens da tela 
                var itemVendaDomain = Mapper.Map<ItemVendaVM, ItemVenda>(itemVendaVm);
                //adiciona os produtos la na icollection da venda(mas n quero isso)
                //venda.ItemVenda.Add(itemVendaDomain);
                //adiciona o id do produto no campo produto
                itemVendaDomain.Produto = _produtoAppService.GetById(itemVendaDomain.IdProduto);
                //adiciona o objeto venda no campo Venda
                itemVendaDomain.Venda = venda;
                //itemVendaDomain.IdVenda = venda.Id;
                //_vendaAppService.Update(venda);

                return RedirectToAction("Index");
            }

            return View(itemVendaVm);
        }

        // GET: ItemVenda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemVenda/Edit/5
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

        // GET: ItemVenda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemVenda/Delete/5
        [HttpPost]
        public ActionResult Delete(ItemVendaVM itemVendaVm)
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
