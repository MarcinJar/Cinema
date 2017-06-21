[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CinemaReservation.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(CinemaReservation.App_Start.NinjectWebCommon), "Stop")]

namespace CinemaReservation.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Core.DataLogic.IDataLogic;
    using Core.DataLogic;
    using InterfaceDataAccess;
    using DataAccess;

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
            kernel.Bind<ICinemaLogic>().To<CinemaLogic>();
            kernel.Bind<ICinemaRepository>().To<CinemaRepository>();
            kernel.Bind <IPersonLogic>().To<PersonLogic>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();
            kernel.Bind<IMovieLogic>().To<MovieLogic>();
            kernel.Bind<IMovieRepository>().To<MovieRepository>();
            kernel.Bind<IReservationLogic>().To<ReservationLogic>();
            kernel.Bind<IReservationRepository>().To<ReservationRepository>();
        }        
    }
}
