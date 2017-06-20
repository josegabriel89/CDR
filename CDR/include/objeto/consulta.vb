
Imports System.Data
Imports System.Data.SqlClient

Public Class Consulta
    Dim str_conexion As String = "Data Source=JOSEHELL\SQLEXPRESS;Initial Catalog=CDR;Integrated Security=True"
    'La cadena de conexion obviamente la tienen que cambiar por la de ustedes.
    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand
    Dim Logger As New log

    Public Sub New()
    End Sub

    Public Property srt_conexion() As String
        Get
            Return Me.str_conexion
        End Get
        Set(ByVal str As String)
            Me.str_conexion = str
        End Set
    End Property

    Public Sub New(ByVal str As String)
        Me.str_conexion = str
    End Sub

    Public Function consulta_non_query(ByVal consulta As String) As Boolean

        'Este metodo recibe como parametro la consulta completa y sirve para hacer INSERT, UPDATE Y DELETE
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()
        Try
            cmd.ExecuteNonQuery()
            'MsgBox("La operacion se realizo con exito!", MsgBoxStyle.Information, "Operacion exitosa!")
        Catch ex As Exception
            Logger.Nivel = Logger.TipoMensaje.LERROR
            Logger.e("Error de consulta_non_querry", ex)
            Return False
            'MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        If (consulta.Substring(0, 6) = "INSERT") Then
            Logger.Nivel = Logger.TipoMensaje.INFO
            Logger.i("Se han insertado datos en la base de datos. Consulta: " + consulta)
        End If
        Return True
        conexion.Close()
    End Function

    Public Function consulta_reader(ByVal consulta As String) As DataTable

        'Este metodo recibe como parametro la consulta completa y sirve para hacer SELECT
        Dim dt As New DataTable
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
            Logger.Nivel = Logger.TipoMensaje.LERROR
            Logger.e("Error al realizar una consulta. Consulta: " + consulta, ex)
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        conexion.Close()
        Return dt

    End Function

    Public Sub cargar_lista(ByRef lista As ListBox, ByVal consulta As String, ByVal valueMember As String, ByVal displayMember As String)
        Dim dt As New Data.DataTable
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()
        Try
            dt.Load(cmd.ExecuteReader())
            lista.DataSource = dt
            lista.ValueMember = valueMember
            lista.DisplayMember = displayMember
        Catch ex As Exception
            Logger.Nivel = Logger.TipoMensaje.LERROR
            Logger.e("Error al operar con la base de datos! ", ex)
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")

        End Try
        conexion.Close()
    End Sub

    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal consulta As String, ByVal valueMember As String, ByVal displayMember As String)
        Dim dt As New DataTable
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()
        Try
            dt.Load(cmd.ExecuteReader())
            combo.DataSource = dt
            combo.ValueMember = valueMember
            combo.DisplayMember = displayMember
        Catch ex As Exception
            Logger.Nivel = Logger.TipoMensaje.LERROR
            Logger.e("Error al operar con la base de datos! ", ex)
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        conexion.Close()
    End Sub

    Public Function verificar_existencia(ByVal consulta As String) As Boolean
        'Devuelve true si existe, entonces no grabamos, o devuelve false si no existe entoinces debemos grabar.
        Dim dt As New DataTable
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
            Logger.Nivel = Logger.TipoMensaje.LERROR
            Logger.e("Error al obtener la excistencia. Consulta: " + consulta, ex)
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        conexion.Close()
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function nuevonumero() As Integer

        'Devuelve el proximo numero de socio de los miembros
        Dim dt As New DataTable
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand("SELECT MAX(nsocio) FROM miembros;", conexion)
        conexion.Open()
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
            Logger.Nivel = Logger.TipoMensaje.LERROR
            Logger.e("Error al obtener un nuevo numero de socio", ex)
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        conexion.Close()
        Dim numerotext As String
        Dim numero As Integer
        numerotext = dt.Rows.Item(0).Item(0).ToString
        If numerotext = "" Then numerotext = "0"
        numero = Convert.ToInt64(numerotext)
        numero = numero + 1
        Return numero
    End Function

End Class
