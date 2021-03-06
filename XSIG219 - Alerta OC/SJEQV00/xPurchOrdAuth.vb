Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoXPURCHORDAUTH

    Public Class xPurchOrdAuth
        Inherits SolomonDataObject
        <DataBinding(PropertyIndex:=0, StringSize:=10)> Public Property PoNbr() As String

            Get
                Return Me.GetPropertyValue("PoNbr")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("PoNbr", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=1, StringSize:=30)> Public Property Depto() As String

            Get
                Return Me.GetPropertyValue("Depto")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Depto", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=2, StringSize:=30)> Public Property UserId() As String

            Get
                Return Me.GetPropertyValue("UserId")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("UserId", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=3, StringSize:=10)> Public Property Estatus() As String

            Get
                Return Me.GetPropertyValue("Estatus")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Estatus", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=4, StringSize:=30)> Public Property User1() As String

            Get
                Return Me.GetPropertyValue("User1")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User1", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=5, StringSize:=30)> Public Property User2() As String

            Get
                Return Me.GetPropertyValue("User2")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User2", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=6)> Public Property User3() As Double

            Get
                Return Me.GetPropertyValue("User3")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("User3", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=7)> Public Property User4() As Double

            Get
                Return Me.GetPropertyValue("User4")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("User4", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=8, StringSize:=10)> Public Property User5() As String

            Get
                Return Me.GetPropertyValue("User5")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User5", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=9, StringSize:=10)> Public Property User6() As String

            Get
                Return Me.GetPropertyValue("User6")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User6", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=10)> Public Property User7() As Integer

            Get
                Return Me.GetPropertyValue("User7")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User7", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=11)> Public Property User8() As Integer

            Get
                Return Me.GetPropertyValue("User8")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User8", setval)
            End Set

        End Property

    End Class
    Public bxPurchOrdAuth As xPurchOrdAuth = New xPurchOrdAuth, nxPurchOrdAuth As xPurchOrdAuth = New xPurchOrdAuth
    Public csr_xPurchOrdAuth As Integer
End Module