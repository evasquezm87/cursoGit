Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoXCONFIGMAIL

    Public Class XConfigMail
        Inherits SolomonDataObject
        <DataBinding(PropertyIndex:=0, StringSize:=30)> Public Property tipo() As String

            Get
                Return Me.GetPropertyValue("tipo")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("tipo", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=1, StringSize:=30)> Public Property emailEnvio() As String

            Get
                Return Me.GetPropertyValue("emailEnvio")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("emailEnvio", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=2, StringSize:=30)> Public Property usuario() As String

            Get
                Return Me.GetPropertyValue("usuario")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("usuario", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=3, StringSize:=30)> Public Property password() As String

            Get
                Return Me.GetPropertyValue("password")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("password", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=4, StringSize:=60)> Public Property name() As String

            Get
                Return Me.GetPropertyValue("name")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("name", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=5, StringSize:=100)> Public Property asunto() As String

            Get
                Return Me.GetPropertyValue("asunto")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("asunto", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=6, StringSize:=100)> Public Property mensaje() As String

            Get
                Return Me.GetPropertyValue("mensaje")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("mensaje", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=7, StringSize:=4)> Public Property puerto() As String

            Get
                Return Me.GetPropertyValue("puerto")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("puerto", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=8, StringSize:=30)> Public Property host() As String

            Get
                Return Me.GetPropertyValue("host")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("host", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=9, StringSize:=100)> Public Property rutaOrigen() As String

            Get
                Return Me.GetPropertyValue("rutaOrigen")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("rutaOrigen", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=10, StringSize:=100)> Public Property rutaDestino() As String

            Get
                Return Me.GetPropertyValue("rutaDestino")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("rutaDestino", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=11, StringSize:=30)> Public Property User1() As String

            Get
                Return Me.GetPropertyValue("User1")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User1", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=12, StringSize:=30)> Public Property User2() As String

            Get
                Return Me.GetPropertyValue("User2")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User2", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=13)> Public Property User3() As Double

            Get
                Return Me.GetPropertyValue("User3")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("User3", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=14)> Public Property User4() As Double

            Get
                Return Me.GetPropertyValue("User4")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("User4", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=15, StringSize:=10)> Public Property User5() As String

            Get
                Return Me.GetPropertyValue("User5")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User5", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=16, StringSize:=10)> Public Property User6() As String

            Get
                Return Me.GetPropertyValue("User6")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User6", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=17)> Public Property User7() As Integer

            Get
                Return Me.GetPropertyValue("User7")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User7", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=18)> Public Property User8() As Integer

            Get
                Return Me.GetPropertyValue("User8")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User8", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=19, StringSize:=45)> Public Property User9() As String

            Get
                Return Me.GetPropertyValue("User9")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User9", setval)
            End Set

        End Property

        <DataBinding(PropertyIndex:=20, StringSize:=30)> Public Property User10() As String

            Get
                Return Me.GetPropertyValue("User10")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("User10", setval)
            End Set

        End Property

    End Class
    Public bXConfigMail As XConfigMail = New XConfigMail, nXConfigMail As XConfigMail = New XConfigMail
    Public csr_XConfigMail As Integer
End Module

'Prueba de cambio'