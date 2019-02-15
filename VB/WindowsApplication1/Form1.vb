Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            InitData()
        End Sub
        Public Sub InitData()
            Dim dt = New DataTable()
            dt.Columns.Add("ID", GetType(Int32))
            dt.Columns.Add("Trademark", GetType(String))
            For i As Integer = 0 To 19
                dt.Rows.Add(New Object() { i, "Test" & i })
            Next i
            myGridControl1.DataSource = dt
        End Sub
    End Class
End Namespace