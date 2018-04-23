Imports System
Imports System.ComponentModel
Imports System.Windows

Namespace NewItemRow

    Partial Public Class Window1
        Inherits Window

        Private list As BindingList(Of TestData)

        Public Sub New()
            InitializeComponent()

'            #Region "Fill the GridControl with data"
            list = New BindingList(Of TestData)()
            For i As Integer = 0 To 4
                list.Add(New TestData() With {.Text1 = Guid.NewGuid().ToString(), .Text2 = "text2 " & i, .Text3 = "text3 " & i})
            Next i
            grid.ItemsSource = list
'            #End Region
        End Sub
    End Class

    #Region "Test data"
    Public Class TestData
        Public Property Text1() As String
        Public Property Text2() As String
        Public Property Text3() As String
    End Class
    #End Region

End Namespace
