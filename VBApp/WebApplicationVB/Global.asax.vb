Imports System.Web.Http
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace WebApplication1
	Public Class WebApiApplication
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start()
			AreaRegistration.RegisterAllAreas()
			GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
			RouteConfig.RegisterRoutes(RouteTable.Routes)
		   ' BundleConfig.RegisterBundles(BundleTable.Bundles);
		End Sub
	End Class
End Namespace
