Imports System.Web.Http
Imports System.Web.Http.Cors

Namespace WebApplication1
	Public Module WebApiConfig
		Public Sub Register(ByVal config As HttpConfiguration)
			' Web API configuration and services
			Dim cors = New EnableCorsAttribute("*", "*", "*")
			config.EnableCors(cors)

			' Web API routes
			config.MapHttpAttributeRoutes()
			config.Routes.MapHttpRoute(name:= "DefaultApi", routeTemplate:= "api/{controller}/{action}/{id}", defaults:= New With {Key .id = RouteParameter.Optional})
			config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(Function(t) t.MediaType = "application/xml"))
		End Sub
	End Module
End Namespace
