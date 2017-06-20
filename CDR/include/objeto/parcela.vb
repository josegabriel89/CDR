Imports CDR
Imports CDR.crearparcela

Public Class parcela

    Private referenciacatastral As String
    Private provincia As Integer
    Private municipio As Integer
    Private poligono As Integer
    Private parcela As Integer
    Private arrendatario As Integer
    Private titularcatastral As Integer
    Private superficie As Double
    Private pago As Integer
    Private imagensatelite As Image
    Private observaciones As String
    Private colelineas As List(Of parcela)

#Region "Property"

    Public Property Referenciacatastral1 As String
        Get
            Return referenciacatastral
        End Get
        Set(value As String)
            referenciacatastral = value
        End Set
    End Property

    Public Property Provincia1 As Integer
        Get
            Return provincia
        End Get
        Set(value As Integer)
            provincia = value
        End Set
    End Property

    Public Property Municipio1 As Integer
        Get
            Return municipio
        End Get
        Set(value As Integer)
            municipio = value
        End Set
    End Property

    Public Property Poligono1 As Integer
        Get
            Return poligono
        End Get
        Set(value As Integer)
            poligono = value
        End Set
    End Property

    Public Property Parcela1 As Integer
        Get
            Return parcela
        End Get
        Set(value As Integer)
            parcela = value
        End Set
    End Property

    Public Property Arrendatario1 As Integer
        Get
            Return arrendatario
        End Get
        Set(value As Integer)
            arrendatario = value
        End Set
    End Property

    Public Property Titularcatastraldni1 As Integer
        Get
            Return titularcatastral
        End Get
        Set(value As Integer)
            titularcatastral = value
        End Set
    End Property

    Public Property Superficie1 As Double
        Get
            Return superficie
        End Get
        Set(value As Double)
            superficie = value
        End Set
    End Property

    Public Property Pago1 As Integer
        Get
            Return pago
        End Get
        Set(value As Integer)
            pago = value
        End Set
    End Property

    Public Property Imagensatelite1 As Image
        Get
            Return imagensatelite
        End Get
        Set(value As Image)
            imagensatelite = value
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

    Public Property Colelineas1 As List(Of parcela)
        Get
            Return colelineas
        End Get
        Set(value As List(Of parcela))
            colelineas = value
        End Set
    End Property
#End Region


#Region "Constructores"
    Public Sub New()
        Me.referenciacatastral = Replace(CDR.crearparcela.TBrefernciacatastral.Text, " ", "")
        Me.provincia = Convert.ToInt64(CDR.crearparcela.TBnumeroparcelaprovincia.Text)
        Me.municipio = Convert.ToInt64(CDR.crearparcela.TBnumeroparcelamunicipio.Text)
        Me.poligono = Convert.ToInt64(CDR.crearparcela.TBpoligono.Text)
        Me.parcela = Convert.ToInt64(CDR.crearparcela.TBparcela.Text)
        Me.titularcatastral = Convert.ToInt64(CDR.crearparcela.TBtitularnumero.Text)
        Me.arrendatario = Convert.ToInt64(CDR.crearparcela.TBarrendatarionumero.Text)
        Me.superficie = Convert.ToInt64(Replace(CDR.crearparcela.TBsuperficie.Text, " ", ""))
        Me.pago = Convert.ToDouble(CDR.crearparcela.TBpago.Text)
        Me.observaciones = CDR.crearparcela.TBobservacionesparcela.Text
    End Sub

    Public Sub New(ByVal valreferenciacatastral, ByVal valprovincia, ByVal valmunicipio, ByVal valpoligono, ByVal valparcela, ByVal valtitularcatastral, ByVal valarrendatario, ByVal valsuperficie, ByVal valpago, ByVal valobservaciones)
        Me.referenciacatastral = valreferenciacatastral
        If valprovincia <> "" Then Me.provincia = Convert.ToInt64(valprovincia)
        If valmunicipio <> "" Then Me.municipio = Convert.ToInt64(valmunicipio)
        If valpoligono <> "" Then Me.poligono = Convert.ToInt64(valpoligono)
        If valparcela <> "" Then Me.parcela = Convert.ToInt64(valparcela)
        If valtitularcatastral <> "" Then Me.titularcatastral = Convert.ToInt64(valtitularcatastral)
        If valarrendatario <> "" Then Me.arrendatario = Convert.ToInt64(valarrendatario)
        If valsuperficie <> "" Then Me.superficie = Convert.ToDouble(valsuperficie)
        If valpago <> "" Then Me.pago = Convert.ToInt64(valpago)
        Me.observaciones = valobservaciones
    End Sub
#End Region

#Region "Clases publicas"
    Public Function crearparcela() As Boolean
        Dim respuesta As Boolean
        respuesta = guardarparcela(Me.referenciacatastral, Me.provincia, Me.municipio, Me.poligono, Me.parcela, Me.arrendatario, Me.titularcatastral, Me.superficie, Me.pago, Me.observaciones)
        Return respuesta
    End Function

    Public Function guardarparcela(ByVal valreferenciacatastral, ByVal valprovincia, ByVal valmunicipio, ByVal valpoligono, ByVal valparcela, ByVal valarrendatario, ByVal valtitularcatastral, ByVal valsuperficie, ByVal valpago, ByVal valobservaciones)
        Dim sql As String
        sql = "INSERT INTO parcelas (referenciacatastral , provincia , municipio , poligono , parcela , arrendatario , titularcatastral , superficie , pago , observaciones) VALUES ('"
        sql += Convert.ToString(valreferenciacatastral) + "','"
        sql += Convert.ToString(valprovincia) + "','"
        sql += Convert.ToString(valmunicipio) + "','"
        sql += Convert.ToString(valpoligono) + "','"
        sql += Convert.ToString(valparcela) + "','"
        sql += Convert.ToString(valarrendatario) + "','"
        sql += Convert.ToString(valtitularcatastral) + "','"
        sql += Convert.ToString(valsuperficie) + "','"
        sql += Convert.ToString(valpago) + "','"
        sql += Convert.ToString(valobservaciones)
        sql += "');"
        Dim bd As New Consulta
        If bd.consulta_non_query(sql) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub editarparcela()

    End Sub

    Public Sub borrarparcela()

    End Sub


#End Region

End Class
