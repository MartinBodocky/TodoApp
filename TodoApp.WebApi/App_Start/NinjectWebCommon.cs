[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TodoApp.WebApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(TodoApp.WebApi.App_Start.NinjectWebCommon), "Stop")]

namespace TodoApp.WebApi.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using TodoApp.ApiContracts;
    using TodoApp.Data;
    using TodoApp.OperationContracts;
    using TodoApp.DataContracts.Entities;
    using TodoApp.RequestProcessing;
    using TodoApp.ApiContracts.ServiceContracts.Device;
    using TodoApp.RequestProcessing.Device;

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
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);

                GlobalKernel.SetKernel(kernel);
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
            // contexts
            kernel.Bind<IEntityContext>().To<EntityContext>();
            kernel.Bind<ISupportContext>().To<SupportContext>();

            // managers
            kernel.Bind<IRequestManager>().To<RequestManager>();

            // request processors
            kernel.Bind<IRequestProcessor<RegisterRequest, RegisterResponse>>().To<RegisterDeviceRequestProcessor>();
            
        }        
    }
}