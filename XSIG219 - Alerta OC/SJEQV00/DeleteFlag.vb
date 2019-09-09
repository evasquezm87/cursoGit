Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoServFlag
    Public Class DeleteFlag
        Inherits SolomonDataObject



        < _
        DataBinding(PropertyIndex:=0, StringSize:=1) _
        > _
        Public Property Yes_No() As String
            Get
                Return Me.GetPropertyValue("Yes_No")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Yes_No", setval)
            End Set
        End Property
    End Class

    Public bDeleteFlag As DeleteFlag = New DeleteFlag, nDeleteFlag As DeleteFlag = New DeleteFlag
    Public CSR_DeleteFlag As Short

    Sub Init_DeleteFlag(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
        Call SetAddr(x_Level, "bDeleteFlag", bDeleteFlag, nDeleteFlag)
        If x_Cursor = True Then
            Call SqlCursorEx(CSR_DeleteFlag, x_Level, "CSR_DeleteFlag", "DeleteFlag", "")
        End If
    End Sub
End Module
