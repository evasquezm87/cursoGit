Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoXWEBMAILGROUP

    Public Class XWebMailGroup
        Inherits SolomonDataObject

        <DataBinding(PropertyIndex:=0, StringSize:=30)> Public Property nombre() As String

            Get
                Return Me.GetPropertyValue("nombre")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("nombre", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=1, StringSize:=60)> Public Property email() As String

            Get
                Return Me.GetPropertyValue("email")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("email", setval)
            End Set

        End Property


        <DataBinding(PropertyIndex:=2, StringSize:=60)> Public Property name() As String

            Get
                Return Me.GetPropertyValue("name")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("name", setval)
            End Set

        End Property
    End Class
    Public bXWebMailGroup As XWebMailGroup = New XWebMailGroup, nXWebMailGroup As XWebMailGroup = New XWebMailGroup
    Public csr_XWebMailGroup As Integer
End Module