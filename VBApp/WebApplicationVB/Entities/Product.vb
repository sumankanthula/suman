Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace WebApplication1.Entities
	Public Class Product
		Public Property ProductId() As Integer
		Public Property ProductName() As String
		Public Property SupplierID() As Integer
		Public Property CategoryID() As Integer
		Public Property QuantityPerUnit() As String
		Public Property UnitPrice() As Decimal
		Public Property UnitsInStock() As Int16
		Public Property UnitsOnOrder() As Int16
		Public Property ReorderLevel() As Int16
		Public Property Discontinued() As Boolean
	End Class
End Namespace
