Imports CDR
Imports System.Data.SqlClient
Imports CDR.crearmiembros

Public Class miembro

    Private nsocio As Integer
    Private dni As String
    Private nombre As String
    Private apellidos As String
    Private direccion As String
    Private cp As Integer
    Private localidad As String
    Private provincia As String
    Private telefono1 As Integer
    Private telefono2 As Integer
    Private pagoinicial As Double
    Private pagoinicialefectuado As Double
    Private cuota As Double
    Private observaciones As String
    Private colelineas As List(Of miembro)

#Region "Property"

    Public Property Nsocio1 As Integer
        Get
            Return nsocio
        End Get
        Set(value As Integer)
            nsocio = value
        End Set
    End Property

    Public Property Dni1 As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellidos1 As String
        Get
            Return apellidos
        End Get
        Set(value As String)
            apellidos = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property Cp1 As Integer
        Get
            Return cp
        End Get
        Set(value As Integer)
            cp = value
        End Set
    End Property

    Public Property Localidad1 As String
        Get
            Return localidad
        End Get
        Set(value As String)
            localidad = value
        End Set
    End Property

    Public Property Provincia1 As String
        Get
            Return provincia
        End Get
        Set(value As String)
            provincia = value
        End Set
    End Property

    Public Property Telefono11 As Integer
        Get
            Return telefono1
        End Get
        Set(value As Integer)
            telefono1 = value
        End Set
    End Property

    Public Property Telefono21 As Integer
        Get
            Return telefono2
        End Get
        Set(value As Integer)
            telefono2 = value
        End Set
    End Property

    Public Property Pagoinicial1 As Double
        Get
            Return pagoinicial
        End Get
        Set(value As Double)
            pagoinicial = value
        End Set
    End Property

    Public Property Pagoinicialefectuado1 As Double
        Get
            Return pagoinicialefectuado
        End Get
        Set(value As Double)
            pagoinicialefectuado = value
        End Set
    End Property

    Public Property Cuota1 As Double
        Get
            Return cuota
        End Get
        Set(value As Double)
            cuota = value
        End Set
    End Property

    Public Property Observaciones1 As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property

    Public Property Colelineas1 As List(Of miembro)
        Get
            Return colelineas
        End Get
        Set(value As List(Of miembro))
            colelineas = value
        End Set
    End Property
#End Region

#Region "Constructores"
    Public Sub New()
        'puf, como que no
        Me.nsocio = Convert.ToInt64(CDR.crearmiembros.TBnmiembro.Text)
        Me.dni = CDR.crearmiembros.TBdni.Text
        Me.nombre = CDR.crearmiembros.TBnombre.Text
        Me.apellidos = CDR.crearmiembros.TBapellidos.Text
        Me.direccion = CDR.crearmiembros.TBdireccion.Text
        Me.cp = Convert.ToInt64(CDR.crearmiembros.TBcodigopostal.Text)
        Me.localidad = CDR.crearmiembros.TBlocalidad.Text
        Me.provincia = CDR.crearmiembros.TBprovincia.Text
        Me.telefono1 = Convert.ToInt64(CDR.crearmiembros.TBtelefono1.Text)
        Me.telefono2 = Convert.ToInt64(CDR.crearmiembros.TBtelefono2.Text)
        Me.pagoinicial = Convert.ToDouble(CDR.crearmiembros.TBpagoinicial.Text)
        Me.pagoinicialefectuado = Convert.ToDouble(CDR.crearmiembros.TBpagoinicialefectuado.Text)
        Me.cuota = Convert.ToDouble(CDR.crearmiembros.TBcuota.Text)
        Me.observaciones = CDR.crearmiembros.TBobservaciones.Text
    End Sub

    Public Sub New(ByVal valnsocio, ByVal valdni, ByVal valnombre, ByVal valapellidos, ByVal valdireccion, ByVal valcp, ByVal vallocalidad, ByVal valprovincia, ByVal valtelefono1, ByVal valtelefono2, ByVal valpagoinicial, ByVal valpagoinicialefectuado, ByVal valcuota, ByVal valobservaciones)
        Me.nsocio = Convert.ToInt64(valnsocio)
        Me.dni = valdni
        Me.nombre = valnombre
        Me.apellidos = valapellidos
        Me.direccion = valdireccion
        If valcp <> "" Then Me.cp = Convert.ToInt64(valcp)
        Me.localidad = vallocalidad
        Me.provincia = valprovincia
        If valtelefono1 <> "" Then Me.telefono1 = Convert.ToInt64(valtelefono1)
        If valtelefono2 <> "" Then Me.telefono2 = Convert.ToInt64(valtelefono2)
        If valpagoinicial <> "" Then Me.pagoinicial = Convert.ToDouble(valpagoinicial)
        If valpagoinicialefectuado <> "" Then Me.pagoinicialefectuado = Convert.ToDouble(valpagoinicialefectuado)
        If valcuota <> "" Then Me.cuota = Convert.ToDouble(valcuota)
        Me.observaciones = valobservaciones
    End Sub
#End Region

#Region "Clases privadas"
    Private Sub btnCreateDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
#End Region

#Region "Clases publicas"
    Public Function crearmiembro() As Boolean
        Dim respuesta As Boolean
        respuesta = guardarmiembro(Me.nsocio, Me.dni, Me.nombre, Me.apellidos, Me.direccion, Me.cp, Me.localidad, Me.provincia, Me.telefono1, Me.telefono2, Me.pagoinicial, Me.pagoinicialefectuado, Me.cuota, Me.observaciones)
        Return respuesta
    End Function

    Public Function guardarmiembro(ByVal valnsocio, ByVal valdni, ByVal valnombre, ByVal valapellidos, ByVal valdireccion, ByVal valcp, ByVal vallocalidad, ByVal valprovincia, ByVal valtelefono1, ByVal valtelefono2, ByVal valpagoinicial, ByVal valpagoinicialefectuado, ByVal valcuota, ByVal valobservaciones) As Boolean
        Dim sql As String
        sql = "INSERT INTO miembros (nsocio, dni, nombre, apellidos, direccion, cp, localidad, provincia, telefono1, telefono2, pagoinicial, pagoinicialefectuado, cuota, observaciones) VALUES ('"
        sql += Convert.ToString(valnsocio) + "','"
        sql += Convert.ToString(valdni) + "','"
        sql += Convert.ToString(valnombre) + "','"
        sql += Convert.ToString(valapellidos) + "','"
        sql += Convert.ToString(valdireccion) + "','"
        sql += Convert.ToString(valcp) + "','"
        sql += Convert.ToString(vallocalidad) + "','"
        sql += Convert.ToString(valprovincia) + "','"
        sql += Convert.ToString(valtelefono1) + "','"
        sql += Convert.ToString(valtelefono2) + "','"
        sql += Convert.ToString(valpagoinicial) + "','"
        sql += Convert.ToString(valpagoinicialefectuado) + "','"
        sql += Convert.ToString(valcuota) + "','"
        sql += Convert.ToString(valobservaciones)
        sql += "');"
        Dim bd As New Consulta
        If bd.consulta_non_query(sql) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub editarmiembro()

    End Sub

    Public Sub borrarmiembro()

    End Sub


#End Region

End Class
