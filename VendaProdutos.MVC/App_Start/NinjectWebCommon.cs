using VendaProdutos.Aplicacao;
using VendaProdutos.Aplicacao.Interface;
using VendaProdutos.Dominio.Interfaces.IRepositories;
using VendaProdutos.Dominio.Interfaces.Services;
using VendaProdutos.Dominio.Servicos;
using VendaProdutos.Infraestrutura.Dados.Repositorios;


[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(VendaProdutos.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(VendaProdutos.MVC.App_Start.NinjectWebCommon), "Stop")]


namespace VendaProdutos.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            //var kernel = new StandardKernel();
            //RegisterServices(kernel);
            //return kernel;

            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            #region Servico de Aplicacao

            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind(typeof(IVendaAppService)).To(typeof(VendaAppService));
            kernel.Bind(typeof(IProdutoAppService)).To(typeof(ProdutoAppService));
            kernel.Bind(typeof(IItemVendaAppService)).To(typeof(ItemVendaAppService));


            #endregion

            #region Servico

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind(typeof(IVendaService)).To(typeof(VendaService));
            kernel.Bind(typeof(IProdutoService)).To(typeof(ProdutoService));
            kernel.Bind(typeof(IItemVendaService)).To(typeof(ItemVendaService));


            #endregion

            #region Repositorio

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind(typeof(IRepositoriodeVenda)).To(typeof(RepositoriodeVenda));
            kernel.Bind(typeof(IRepositoriodeProduto)).To(typeof(RepositoriodeProduto));
            kernel.Bind(typeof(IRepositoriodeItemVenda)).To(typeof(RepositoriodeItemVenda));


            #endregion


        }
    }
}