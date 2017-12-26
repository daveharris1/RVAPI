using System;
using Unity;
using RVApiHandler.YouTubeHandler;
using RVApiHandler.JsonModelConversionHandler;
using RVApiHandler.YouTubeResponseModelHandler;
using RVApiHandler.SpreadShirtHandler;
using RVApiHandler.XmlModelConversionHandler;
using RVApiHandler.InstagramHandler;
using RVApiHandler.InstagramModelConversionHandler;
using RVApiHandler.RVHttpResponseConversionHandler;
using RVApiHandler.RVFacadeHandler;
using RVApiHandler.HttpHandler;
using Unity.Injection;


namespace RVApi
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();

            container.RegisterType<IRVFacade, RVFacade>();
            container.RegisterType<IHttpCaller, HttpCaller>();
            container.RegisterType<IYTResponseModelHandler, YTResponseModelHandler>();
            container.RegisterType<IJsonModelConverter, JsonModelConverter>();
            container.RegisterType<IYouTubeCaller, YouTubeCaller>();
            container.RegisterType<IXmlModelConvertor, XmlModelConvertor>();
            container.RegisterType<ISpreadShirtCaller, SpreadShirtCaller>();
            container.RegisterType<IInstagramModelHandler, InstagramModelHandler>();
            container.RegisterType<IInstagramCaller, InstagramCaller>();
            container.RegisterType<IRVHttpResponseConvertor, RVHttpResponseConvertor>();
        }
    }
}