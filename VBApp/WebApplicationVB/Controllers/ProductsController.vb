Imports System.Net
Imports System.Web.Http
Imports WebApplication1.Entities
Imports System.Web.Http.Description
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Namespace WebApplication1.Controllers
	Public Class ProductsController
		Inherits ApiController

		Private db As New NorthwindContext()
		Public Function GetProducts() As IQueryable(Of Product)
			Return db.Products
		End Function

		' GET: api/Products/5
		<ResponseType(GetType(Product))>
		Public Function GetProduct(ByVal id As Integer) As IHttpActionResult
			Dim product As Product = db.Products.Find(id)
			If product Is Nothing Then
				Return NotFound()
			End If

			Return Ok(product)
		End Function


		' PUT: api/Products/5
		<ResponseType(GetType(Void))>
		Public Function Edit(ByVal id As Integer, ByVal product As Product) As IHttpActionResult
			If Not ModelState.IsValid Then
				Return BadRequest(ModelState)
			End If

			If id <> product.ProductId Then
				Return BadRequest()
			End If

			db.Entry(product).State = EntityState.Modified

			Try
				db.SaveChanges()
			Catch e1 As DbUpdateConcurrencyException
				If Not ProductExists(id) Then
					Return NotFound()
				Else
					Throw
				End If
			End Try

			Return StatusCode(HttpStatusCode.NoContent)
		End Function

		Public Function Search(ByVal product As Product) As IHttpActionResult

			Dim query = db.Products.AsQueryable()

			If product.ProductId > 0 Then
				query = query.Where(Function(p) p.ProductId = product.ProductId)
			End If

			If Not String.IsNullOrEmpty(product.ProductName) Then
				query = query.Where(Function(p) p.ProductName.Contains(product.ProductName))
			End If

			If product.SupplierID > 0 Then
				query = query.Where(Function(p) p.SupplierID = product.SupplierID)
			End If

			If product.CategoryID > 0 Then
				query = query.Where(Function(p) p.CategoryID = product.CategoryID)
			End If

			If Not String.IsNullOrEmpty(product.QuantityPerUnit) Then
				query = query.Where(Function(p) p.QuantityPerUnit = product.QuantityPerUnit)
			End If

			If product.UnitPrice > 0 Then
				query = query.Where(Function(p) p.UnitPrice = product.UnitPrice)
			End If

			If product.UnitsInStock > 0 Then
				query = query.Where(Function(p) p.UnitsInStock = product.UnitsInStock)
			End If

			If product.UnitsOnOrder > 0 Then
				query = query.Where(Function(p) p.UnitsOnOrder = product.UnitsOnOrder)
			End If

			If product.ReorderLevel > 0 Then
				query = query.Where(Function(p) p.ReorderLevel = product.ReorderLevel)
			End If

			query = query.Where(Function(p) p.Discontinued = product.Discontinued)

			Dim result = query.ToList()
			Return Ok(result)
		End Function


		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				db.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Function ProductExists(ByVal id As Integer) As Boolean
			Return db.Products.AsEnumerable().Count(Function(e) e.ProductId = id) > 0
		End Function
	End Class
End Namespace
