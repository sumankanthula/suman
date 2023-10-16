Imports System
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq
Imports System.Web

Namespace WebApplication1.Entities
	Public Class NorthwindContext
		Inherits DbContext

		Public Property Products() As DbSet(Of Product)
	End Class
End Namespace
