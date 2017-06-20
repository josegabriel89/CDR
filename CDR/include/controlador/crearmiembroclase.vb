Imports CDR.crearmiembros

Public Class crearmiembroclase
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

#Region "propierty"
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
#End Region

    Public Sub New()
        Nsocio1 = CDR.crearmiembros.TBnmiembro.Text
        dni = CDR.crearmiembros.TBdni.Text
        nombre = CDR.crearmiembros.TBnombre.Text
        apellidos = CDR.crearmiembros.TBapellidos.Text
        direccion = CDR.crearmiembros.TBdireccion.Text
        cp = CDR.crearmiembros.TBcodigopostal.Text
        localidad = CDR.crearmiembros.TBlocalidad.Text
        provincia = CDR.crearmiembros.TBprovincia.Text
        telefono1 = CDR.crearmiembros.TBtelefono1.Text
        telefono2 = CDR.crearmiembros.TBtelefono2.Text
        pagoinicial = CDR.crearmiembros.TBpagoinicial.Text
        pagoinicialefectuado = CDR.crearmiembros.TBpagoinicialefectuado.Text
        cuota = CDR.crearmiembros.TBcuota.Text
        observaciones = CDR.crearmiembros.TBobservaciones.Text
    End Sub

    Public Sub New(ByVal n As String, ByVal ed As Single)

    End Sub
End Class
