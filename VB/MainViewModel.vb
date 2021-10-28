Imports DevExpress.Mvvm
Imports System.Collections.Generic
Imports System.Linq

Namespace NewItemRow

    Public Class Item

        Public Property Text As String

        Public Property Number As Integer

        Public Property [Boolean] As Boolean
    End Class

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Items As List(Of Item)
            Get
                Return GetValue(Of List(Of Item))()
            End Get

            Set(ByVal value As List(Of Item))
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            Items = GetData()
        End Sub

        Private Shared Function GetData() As List(Of Item)
            Return Enumerable.Range(0, 5).[Select](Function(x) New Item With {.Text = "Text" & x, .Number = x, .[Boolean] = x Mod 2 = 0}).ToList()
        End Function
    End Class
End Namespace
