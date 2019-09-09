Option Explicit On
Option Strict Off
Imports System.Net.Mail
Imports System.IO
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates

Friend Class Form1
	Inherits System.Windows.Forms.Form
	
	Protected m_IsInitializing As Boolean
	Protected ReadOnly Property IsInitializing() As Boolean
		Get
			Return m_IsInitializing
		End Get
	End Property

    Public mgrid As Integer

    Dim poNbr As String
    Dim proveedor As String
    Dim monto As String
    Dim link As String
    Dim msg As String
    Dim exportacion As String
    Dim attach As String


    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        ' Initialize the application as a Solomon Application
        Call ApplInit()

        Call ScreenInit()

        poNbr = ApplGetParmValue(PRMSECTION_VBRDT, "PoNbr")
        proveedor = ApplGetParmValue(PRMSECTION_VBRDT, "proveedor")
        monto = ApplGetParmValue(PRMSECTION_VBRDT, "monto")
        link = ApplGetParmValue(PRMSECTION_VBRDT, "link")
        msg = ApplGetParmValue(PRMSECTION_VBRDT, "msg")
        exportacion = ApplGetParmValue(PRMSECTION_VBRDT, "exportacion")
        attach = ApplGetParmValue(PRMSECTION_VBRDT, "attach")
        'poNbr = "004136"
        enviarAlerta(poNbr, proveedor, monto, link, msg, exportacion, attach)

        Call ScreenExit("", "")
    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub
    Private Sub enviarAlerta(ByVal poNbr As String, ByVal proveedor As String, ByVal monto As String, ByVal link As String, ByVal msg As String, ByVal export As String, ByVal attach As String)

        SetStatusBarText("Enviando Alerta OC...", "Enviando Alerta OC...")

        enviarCorreoSL(poNbr, proveedor, monto, link, msg, export, attach)

        SetStatusBarText("", "")

    End Sub

    Private Sub enviarCorreoSL(ByVal poNbr As String, ByVal proveedor As String, ByVal monto As String, ByVal link As String, ByVal msg As String, ByVal export As String, ByVal attach As String)

        serr3 = SqlFetch1(csr_XConfigMail, "XSP_GetCnfMail 'PO'", bXConfigMail)
        Dim asunto As String
        Dim mensaje As String = ""
        If serr3 = 0 Then

            asunto = msg
            'mensaje = "Orden de Compra para Autorizar." & vbCrLf & "No. Orden de Compra: " & poNbr
            mensaje = mensaje & "<html>"
            mensaje = mensaje & "<body>"
            mensaje = mensaje & "<br>"
            mensaje = mensaje & "<br>"
            mensaje = mensaje & msg
            mensaje = mensaje & "<br>"
            mensaje = mensaje & "<br>"
            mensaje = mensaje & "<b>No. Orden de Compra: </b>" & poNbr
            mensaje = mensaje & "<br>"
            mensaje = mensaje & "<b>Proveedor: </b>" & proveedor
            mensaje = mensaje & "<br>"
            mensaje = mensaje & "<b>Monto: </b>" & monto
            mensaje = mensaje & "<br>"
            mensaje = mensaje & "<br>"
            'Mensaje solo para OC para autorizar 
            If exportacion = "" Then
                mensaje = mensaje & "<b>Usuarios a Autorizar:</b>"
                mensaje = mensaje & "<br>"

                serr1 = SqlFetch1(csr_XWebMailGroup, "XSP_GetPOeMail " & SParm(poNbr) & "," & SParm(export), bXWebMailGroup)
                Dim id As Integer = 1
                Do While serr1 = 0

                    serr1 = SFetch1(csr_XWebMailGroup, bXWebMailGroup)
                    'Omitir el primer registro, ya que es el usuario que la crea
                    If serr1 = 0 Then
                        mensaje = mensaje & id & ".- " & bXWebMailGroup.name
                        mensaje = mensaje & "<br>"
                        id = id + 1
                    End If
                Loop
            End If

            If exportacion.Trim() = "" Or exportacion.Trim() = "0" Then
                mensaje = mensaje & "<br>"
                mensaje = mensaje & "<br>"
                mensaje = mensaje & "<b>Ruta de Archivos: </b>" & "<a href=""" & link & """>Click Aqui</a>"
                mensaje = mensaje & "<br>"
                mensaje = mensaje & "<br>"
                mensaje = mensaje & "El link solo podra abrirse dentro de la red de signode."
                mensaje = mensaje & "<br>"
                mensaje = mensaje & "Para alguna duda contactar a sistemas"

                mensaje = mensaje & "</body>"
                mensaje = mensaje & "</html>"


                exportacion = ""
            End If

            Try
                enviarCorreo(bXConfigMail.emailEnvio, bXConfigMail.usuario, bXConfigMail.password, bXConfigMail.name, bXConfigMail.host, asunto, mensaje, bXConfigMail.puerto, "", poNbr, export, attach)
            Catch ex As Exception
                writeLog("Error al enviar correo: " & ex.Message.ToString())
            End Try
        Else
            writeLog("Error al enviar correo. No se configuraron parametros de conexón.")
        End If

    End Sub
    Private Sub enviarCorreo(ByVal email As String, ByVal usuario As String, ByVal password As String, ByVal nombre As String, ByVal servidor As String, ByVal asunto As String, ByVal mensaje As String, ByVal puerto As Integer, ByVal para As String, ByVal poNbr As String, ByVal export As String, ByVal attach As String)
        Dim msg As MailMessage = New MailMessage

        serr1 = SqlFetch1(csr_XWebMailGroup, "XSP_GetPOeMail " & SParm(poNbr) & "," & SParm(export), bXWebMailGroup)

        Do While serr1 = 0
            msg.To.Add(Trim(bXWebMailGroup.email))
            serr1 = SFetch1(csr_XWebMailGroup, bXWebMailGroup)
        Loop

        msg.From = New MailAddress(Trim(email), Trim(nombre), System.Text.Encoding.UTF8)
        msg.Subject = Trim(asunto)
        msg.SubjectEncoding = System.Text.Encoding.UTF8
        msg.Body = Trim(mensaje)
        msg.BodyEncoding = System.Text.Encoding.UTF8
        msg.IsBodyHtml = True

        If File.Exists(attach) Then
            Dim dataAttach As Attachment = New Attachment(attach)
            msg.Attachments.Add(dataAttach)
        End If

        Try
            Dim client As SmtpClient = New SmtpClient
            client.UseDefaultCredentials = False 'True
            client.Credentials = New System.Net.NetworkCredential(Trim(usuario), Trim(password))
            client.Port = Trim(puerto)
            client.Host = Trim(servidor) '"smtp.gmail.com" 
            'client.EnableSsl = True
            client.DeliveryMethod = SmtpDeliveryMethod.Network


            Try
                client.Send(msg)
            Catch ex As System.Net.Mail.SmtpException
                writeLog("Error al enviar correo. " & ex.Message.ToString())
            End Try

        Catch ex As Exception
            writeLog("Error al enviar correo. " & ex.Message.ToString())
        End Try

    End Sub
    Private Sub writeLog(ByVal mensaje As String)
        Dim str_archivo As String
        'str_archivo = Application.StartupPath & "\EventLog\Log.log"
        str_archivo = Application.StartupPath & "\EventLog\" & "XS.IG2.19 " & Date.Now.Month & "-" & Date.Now.Day & "-" & Date.Now.Year & " " & Date.Now.Hour & Date.Now.Minute & ".log"

        Using w As StreamWriter = File.AppendText(str_archivo)
            w.Write(mensaje)
        End Using

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

    End Sub
End Class
