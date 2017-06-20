<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class crearparcela
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TBrefernciacatastral = New System.Windows.Forms.TextBox()
        Me.Ltituloparcela = New System.Windows.Forms.Label()
        Me.Lrefernciacatastral = New System.Windows.Forms.Label()
        Me.Pdatosparcela = New System.Windows.Forms.Panel()
        Me.Ltitularcatastral = New System.Windows.Forms.Label()
        Me.Bactualizartitular = New System.Windows.Forms.Button()
        Me.TBtitulardni = New System.Windows.Forms.TextBox()
        Me.Ltitulardni = New System.Windows.Forms.Label()
        Me.Ltitularnombre = New System.Windows.Forms.Label()
        Me.TBparcela = New System.Windows.Forms.TextBox()
        Me.TBpoligono = New System.Windows.Forms.TextBox()
        Me.TBnumeroparcelamunicipio = New System.Windows.Forms.TextBox()
        Me.TBnumeroparcelaprovincia = New System.Windows.Forms.TextBox()
        Me.Lparcela = New System.Windows.Forms.Label()
        Me.Lpoligono = New System.Windows.Forms.Label()
        Me.TBnombreparcelamunicipio = New System.Windows.Forms.TextBox()
        Me.Lparcelamunicipio = New System.Windows.Forms.Label()
        Me.TBnombreparcelaprovincia = New System.Windows.Forms.TextBox()
        Me.Lparcelaprovincia = New System.Windows.Forms.Label()
        Me.Panelarrendatario = New System.Windows.Forms.Panel()
        Me.Bactualizararrendatario = New System.Windows.Forms.Button()
        Me.Larrenda = New System.Windows.Forms.Label()
        Me.TBarrendatariodni = New System.Windows.Forms.TextBox()
        Me.Larrendatariodni = New System.Windows.Forms.Label()
        Me.TBarrendatarionumero = New System.Windows.Forms.TextBox()
        Me.Larrendatarionumero = New System.Windows.Forms.Label()
        Me.Larrendatarionombre = New System.Windows.Forms.Label()
        Me.Ltitularnumero = New System.Windows.Forms.Label()
        Me.TBtitularnumero = New System.Windows.Forms.TextBox()
        Me.Lsuperficie = New System.Windows.Forms.Label()
        Me.TBsuperficie = New System.Windows.Forms.TextBox()
        Me.Lpago = New System.Windows.Forms.Label()
        Me.TBpago = New System.Windows.Forms.TextBox()
        Me.Lobservacionesparcela = New System.Windows.Forms.Label()
        Me.TBobservacionesparcela = New System.Windows.Forms.TextBox()
        Me.Bimagensatelite = New System.Windows.Forms.Button()
        Me.Bcrearparcela = New System.Windows.Forms.Button()
        Me.Pdatosparcela.SuspendLayout()
        Me.Panelarrendatario.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBrefernciacatastral
        '
        Me.TBrefernciacatastral.Location = New System.Drawing.Point(112, 6)
        Me.TBrefernciacatastral.Name = "TBrefernciacatastral"
        Me.TBrefernciacatastral.Size = New System.Drawing.Size(200, 20)
        Me.TBrefernciacatastral.TabIndex = 10
        '
        'Ltituloparcela
        '
        Me.Ltituloparcela.AutoSize = True
        Me.Ltituloparcela.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltituloparcela.Location = New System.Drawing.Point(12, 9)
        Me.Ltituloparcela.Name = "Ltituloparcela"
        Me.Ltituloparcela.Size = New System.Drawing.Size(156, 18)
        Me.Ltituloparcela.TabIndex = 1
        Me.Ltituloparcela.Text = "CREAR PARCELA"
        '
        'Lrefernciacatastral
        '
        Me.Lrefernciacatastral.AutoSize = True
        Me.Lrefernciacatastral.Location = New System.Drawing.Point(3, 9)
        Me.Lrefernciacatastral.Name = "Lrefernciacatastral"
        Me.Lrefernciacatastral.Size = New System.Drawing.Size(103, 13)
        Me.Lrefernciacatastral.TabIndex = 2
        Me.Lrefernciacatastral.Text = "Referencia Catastral"
        '
        'Pdatosparcela
        '
        Me.Pdatosparcela.Controls.Add(Me.Ltitularcatastral)
        Me.Pdatosparcela.Controls.Add(Me.Bactualizartitular)
        Me.Pdatosparcela.Controls.Add(Me.TBtitulardni)
        Me.Pdatosparcela.Controls.Add(Me.Ltitulardni)
        Me.Pdatosparcela.Controls.Add(Me.Ltitularnombre)
        Me.Pdatosparcela.Controls.Add(Me.TBparcela)
        Me.Pdatosparcela.Controls.Add(Me.TBpoligono)
        Me.Pdatosparcela.Controls.Add(Me.TBnumeroparcelamunicipio)
        Me.Pdatosparcela.Controls.Add(Me.TBnumeroparcelaprovincia)
        Me.Pdatosparcela.Controls.Add(Me.Lparcela)
        Me.Pdatosparcela.Controls.Add(Me.Lpoligono)
        Me.Pdatosparcela.Controls.Add(Me.TBnombreparcelamunicipio)
        Me.Pdatosparcela.Controls.Add(Me.Lparcelamunicipio)
        Me.Pdatosparcela.Controls.Add(Me.TBnombreparcelaprovincia)
        Me.Pdatosparcela.Controls.Add(Me.Lparcelaprovincia)
        Me.Pdatosparcela.Controls.Add(Me.Panelarrendatario)
        Me.Pdatosparcela.Controls.Add(Me.Ltitularnumero)
        Me.Pdatosparcela.Controls.Add(Me.TBtitularnumero)
        Me.Pdatosparcela.Controls.Add(Me.Lrefernciacatastral)
        Me.Pdatosparcela.Controls.Add(Me.TBrefernciacatastral)
        Me.Pdatosparcela.Location = New System.Drawing.Point(12, 35)
        Me.Pdatosparcela.Name = "Pdatosparcela"
        Me.Pdatosparcela.Size = New System.Drawing.Size(721, 160)
        Me.Pdatosparcela.TabIndex = 5
        '
        'Ltitularcatastral
        '
        Me.Ltitularcatastral.AutoSize = True
        Me.Ltitularcatastral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltitularcatastral.Location = New System.Drawing.Point(331, 9)
        Me.Ltitularcatastral.Name = "Ltitularcatastral"
        Me.Ltitularcatastral.Size = New System.Drawing.Size(97, 13)
        Me.Ltitularcatastral.TabIndex = 47
        Me.Ltitularcatastral.Text = "Titular Catastral"
        '
        'Bactualizartitular
        '
        Me.Bactualizartitular.Location = New System.Drawing.Point(623, 30)
        Me.Bactualizartitular.Name = "Bactualizartitular"
        Me.Bactualizartitular.Size = New System.Drawing.Size(75, 23)
        Me.Bactualizartitular.TabIndex = 39
        Me.Bactualizartitular.Text = "Buscar"
        Me.Bactualizartitular.UseVisualStyleBackColor = True
        '
        'TBtitulardni
        '
        Me.TBtitulardni.Location = New System.Drawing.Point(500, 32)
        Me.TBtitulardni.Name = "TBtitulardni"
        Me.TBtitulardni.Size = New System.Drawing.Size(116, 20)
        Me.TBtitulardni.TabIndex = 16
        '
        'Ltitulardni
        '
        Me.Ltitulardni.AutoSize = True
        Me.Ltitulardni.Location = New System.Drawing.Point(468, 35)
        Me.Ltitulardni.Name = "Ltitulardni"
        Me.Ltitulardni.Size = New System.Drawing.Size(26, 13)
        Me.Ltitulardni.TabIndex = 37
        Me.Ltitulardni.Text = "DNI"
        '
        'Ltitularnombre
        '
        Me.Ltitularnombre.AutoSize = True
        Me.Ltitularnombre.Location = New System.Drawing.Point(392, 57)
        Me.Ltitularnombre.Name = "Ltitularnombre"
        Me.Ltitularnombre.Size = New System.Drawing.Size(0, 13)
        Me.Ltitularnombre.TabIndex = 35
        '
        'TBparcela
        '
        Me.TBparcela.Location = New System.Drawing.Point(93, 126)
        Me.TBparcela.Name = "TBparcela"
        Me.TBparcela.Size = New System.Drawing.Size(31, 20)
        Me.TBparcela.TabIndex = 14
        '
        'TBpoligono
        '
        Me.TBpoligono.Location = New System.Drawing.Point(93, 99)
        Me.TBpoligono.Name = "TBpoligono"
        Me.TBpoligono.Size = New System.Drawing.Size(31, 20)
        Me.TBpoligono.TabIndex = 13
        '
        'TBnumeroparcelamunicipio
        '
        Me.TBnumeroparcelamunicipio.Location = New System.Drawing.Point(93, 74)
        Me.TBnumeroparcelamunicipio.Name = "TBnumeroparcelamunicipio"
        Me.TBnumeroparcelamunicipio.Size = New System.Drawing.Size(31, 20)
        Me.TBnumeroparcelamunicipio.TabIndex = 12
        '
        'TBnumeroparcelaprovincia
        '
        Me.TBnumeroparcelaprovincia.Location = New System.Drawing.Point(93, 47)
        Me.TBnumeroparcelaprovincia.Name = "TBnumeroparcelaprovincia"
        Me.TBnumeroparcelaprovincia.Size = New System.Drawing.Size(31, 20)
        Me.TBnumeroparcelaprovincia.TabIndex = 11
        '
        'Lparcela
        '
        Me.Lparcela.AutoSize = True
        Me.Lparcela.Location = New System.Drawing.Point(6, 130)
        Me.Lparcela.Name = "Lparcela"
        Me.Lparcela.Size = New System.Drawing.Size(43, 13)
        Me.Lparcela.TabIndex = 29
        Me.Lparcela.Text = "Parcela"
        '
        'Lpoligono
        '
        Me.Lpoligono.AutoSize = True
        Me.Lpoligono.Location = New System.Drawing.Point(6, 103)
        Me.Lpoligono.Name = "Lpoligono"
        Me.Lpoligono.Size = New System.Drawing.Size(48, 13)
        Me.Lpoligono.TabIndex = 27
        Me.Lpoligono.Text = "Poligono"
        '
        'TBnombreparcelamunicipio
        '
        Me.TBnombreparcelamunicipio.Location = New System.Drawing.Point(130, 74)
        Me.TBnombreparcelamunicipio.Name = "TBnombreparcelamunicipio"
        Me.TBnombreparcelamunicipio.Size = New System.Drawing.Size(182, 20)
        Me.TBnombreparcelamunicipio.TabIndex = 11
        '
        'Lparcelamunicipio
        '
        Me.Lparcelamunicipio.AutoSize = True
        Me.Lparcelamunicipio.Location = New System.Drawing.Point(6, 77)
        Me.Lparcelamunicipio.Name = "Lparcelamunicipio"
        Me.Lparcelamunicipio.Size = New System.Drawing.Size(52, 13)
        Me.Lparcelamunicipio.TabIndex = 25
        Me.Lparcelamunicipio.Text = "Municipio"
        '
        'TBnombreparcelaprovincia
        '
        Me.TBnombreparcelaprovincia.Location = New System.Drawing.Point(130, 47)
        Me.TBnombreparcelaprovincia.Name = "TBnombreparcelaprovincia"
        Me.TBnombreparcelaprovincia.Size = New System.Drawing.Size(182, 20)
        Me.TBnombreparcelaprovincia.TabIndex = 10
        '
        'Lparcelaprovincia
        '
        Me.Lparcelaprovincia.AutoSize = True
        Me.Lparcelaprovincia.Location = New System.Drawing.Point(6, 50)
        Me.Lparcelaprovincia.Name = "Lparcelaprovincia"
        Me.Lparcelaprovincia.Size = New System.Drawing.Size(51, 13)
        Me.Lparcelaprovincia.TabIndex = 23
        Me.Lparcelaprovincia.Text = "Provincia"
        '
        'Panelarrendatario
        '
        Me.Panelarrendatario.Controls.Add(Me.Bactualizararrendatario)
        Me.Panelarrendatario.Controls.Add(Me.Larrenda)
        Me.Panelarrendatario.Controls.Add(Me.TBarrendatariodni)
        Me.Panelarrendatario.Controls.Add(Me.Larrendatariodni)
        Me.Panelarrendatario.Controls.Add(Me.TBarrendatarionumero)
        Me.Panelarrendatario.Controls.Add(Me.Larrendatarionumero)
        Me.Panelarrendatario.Controls.Add(Me.Larrendatarionombre)
        Me.Panelarrendatario.Location = New System.Drawing.Point(318, 77)
        Me.Panelarrendatario.Name = "Panelarrendatario"
        Me.Panelarrendatario.Size = New System.Drawing.Size(396, 73)
        Me.Panelarrendatario.TabIndex = 22
        '
        'Bactualizararrendatario
        '
        Me.Bactualizararrendatario.Location = New System.Drawing.Point(305, 22)
        Me.Bactualizararrendatario.Name = "Bactualizararrendatario"
        Me.Bactualizararrendatario.Size = New System.Drawing.Size(75, 23)
        Me.Bactualizararrendatario.TabIndex = 3
        Me.Bactualizararrendatario.Text = "Buscar"
        Me.Bactualizararrendatario.UseVisualStyleBackColor = True
        '
        'Larrenda
        '
        Me.Larrenda.AutoSize = True
        Me.Larrenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Larrenda.Location = New System.Drawing.Point(13, 4)
        Me.Larrenda.Name = "Larrenda"
        Me.Larrenda.Size = New System.Drawing.Size(76, 13)
        Me.Larrenda.TabIndex = 9
        Me.Larrenda.Text = "Arrendatario"
        '
        'TBarrendatariodni
        '
        Me.TBarrendatariodni.Location = New System.Drawing.Point(182, 24)
        Me.TBarrendatariodni.Name = "TBarrendatariodni"
        Me.TBarrendatariodni.Size = New System.Drawing.Size(116, 20)
        Me.TBarrendatariodni.TabIndex = 1
        '
        'Larrendatariodni
        '
        Me.Larrendatariodni.AutoSize = True
        Me.Larrendatariodni.Location = New System.Drawing.Point(150, 27)
        Me.Larrendatariodni.Name = "Larrendatariodni"
        Me.Larrendatariodni.Size = New System.Drawing.Size(26, 13)
        Me.Larrendatariodni.TabIndex = 44
        Me.Larrendatariodni.Text = "DNI"
        '
        'TBarrendatarionumero
        '
        Me.TBarrendatarionumero.Location = New System.Drawing.Point(74, 24)
        Me.TBarrendatarionumero.Name = "TBarrendatarionumero"
        Me.TBarrendatarionumero.Size = New System.Drawing.Size(70, 20)
        Me.TBarrendatarionumero.TabIndex = 0
        '
        'Larrendatarionumero
        '
        Me.Larrendatarionumero.AutoSize = True
        Me.Larrendatarionumero.Location = New System.Drawing.Point(24, 27)
        Me.Larrendatarionumero.Name = "Larrendatarionumero"
        Me.Larrendatarionumero.Size = New System.Drawing.Size(44, 13)
        Me.Larrendatarionumero.TabIndex = 41
        Me.Larrendatarionumero.Text = "Numero"
        '
        'Larrendatarionombre
        '
        Me.Larrendatarionombre.AutoSize = True
        Me.Larrendatarionombre.Location = New System.Drawing.Point(74, 49)
        Me.Larrendatarionombre.Name = "Larrendatarionombre"
        Me.Larrendatarionombre.Size = New System.Drawing.Size(0, 13)
        Me.Larrendatarionombre.TabIndex = 42
        '
        'Ltitularnumero
        '
        Me.Ltitularnumero.AutoSize = True
        Me.Ltitularnumero.Location = New System.Drawing.Point(342, 35)
        Me.Ltitularnumero.Name = "Ltitularnumero"
        Me.Ltitularnumero.Size = New System.Drawing.Size(44, 13)
        Me.Ltitularnumero.TabIndex = 21
        Me.Ltitularnumero.Text = "Numero"
        '
        'TBtitularnumero
        '
        Me.TBtitularnumero.Location = New System.Drawing.Point(392, 32)
        Me.TBtitularnumero.Name = "TBtitularnumero"
        Me.TBtitularnumero.Size = New System.Drawing.Size(70, 20)
        Me.TBtitularnumero.TabIndex = 15
        '
        'Lsuperficie
        '
        Me.Lsuperficie.AutoSize = True
        Me.Lsuperficie.Location = New System.Drawing.Point(18, 209)
        Me.Lsuperficie.Name = "Lsuperficie"
        Me.Lsuperficie.Size = New System.Drawing.Size(54, 13)
        Me.Lsuperficie.TabIndex = 21
        Me.Lsuperficie.Text = "Superficie"
        '
        'TBsuperficie
        '
        Me.TBsuperficie.Location = New System.Drawing.Point(78, 206)
        Me.TBsuperficie.Name = "TBsuperficie"
        Me.TBsuperficie.Size = New System.Drawing.Size(145, 20)
        Me.TBsuperficie.TabIndex = 0
        '
        'Lpago
        '
        Me.Lpago.AutoSize = True
        Me.Lpago.Location = New System.Drawing.Point(236, 209)
        Me.Lpago.Name = "Lpago"
        Me.Lpago.Size = New System.Drawing.Size(32, 13)
        Me.Lpago.TabIndex = 23
        Me.Lpago.Text = "Pago"
        '
        'TBpago
        '
        Me.TBpago.Location = New System.Drawing.Point(274, 206)
        Me.TBpago.Name = "TBpago"
        Me.TBpago.Size = New System.Drawing.Size(145, 20)
        Me.TBpago.TabIndex = 1
        '
        'Lobservacionesparcela
        '
        Me.Lobservacionesparcela.AutoSize = True
        Me.Lobservacionesparcela.Location = New System.Drawing.Point(18, 244)
        Me.Lobservacionesparcela.Name = "Lobservacionesparcela"
        Me.Lobservacionesparcela.Size = New System.Drawing.Size(78, 13)
        Me.Lobservacionesparcela.TabIndex = 27
        Me.Lobservacionesparcela.Text = "Observaciones"
        '
        'TBobservacionesparcela
        '
        Me.TBobservacionesparcela.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBobservacionesparcela.Location = New System.Drawing.Point(15, 260)
        Me.TBobservacionesparcela.Multiline = True
        Me.TBobservacionesparcela.Name = "TBobservacionesparcela"
        Me.TBobservacionesparcela.Size = New System.Drawing.Size(708, 80)
        Me.TBobservacionesparcela.TabIndex = 2
        '
        'Bimagensatelite
        '
        Me.Bimagensatelite.Location = New System.Drawing.Point(597, 209)
        Me.Bimagensatelite.Name = "Bimagensatelite"
        Me.Bimagensatelite.Size = New System.Drawing.Size(125, 23)
        Me.Bimagensatelite.TabIndex = 28
        Me.Bimagensatelite.Text = "imagen satelite"
        Me.Bimagensatelite.UseVisualStyleBackColor = True
        '
        'Bcrearparcela
        '
        Me.Bcrearparcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bcrearparcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcrearparcela.Location = New System.Drawing.Point(622, 346)
        Me.Bcrearparcela.Name = "Bcrearparcela"
        Me.Bcrearparcela.Size = New System.Drawing.Size(100, 36)
        Me.Bcrearparcela.TabIndex = 3
        Me.Bcrearparcela.Text = "Crear"
        Me.Bcrearparcela.UseVisualStyleBackColor = True
        '
        'crearparcela
        '
        Me.ClientSize = New System.Drawing.Size(743, 388)
        Me.Controls.Add(Me.Bcrearparcela)
        Me.Controls.Add(Me.Bimagensatelite)
        Me.Controls.Add(Me.Lobservacionesparcela)
        Me.Controls.Add(Me.TBobservacionesparcela)
        Me.Controls.Add(Me.Lpago)
        Me.Controls.Add(Me.TBpago)
        Me.Controls.Add(Me.Lsuperficie)
        Me.Controls.Add(Me.Ltituloparcela)
        Me.Controls.Add(Me.TBsuperficie)
        Me.Controls.Add(Me.Pdatosparcela)
        Me.Name = "crearparcela"
        Me.Text = "Crear parcela"
        Me.Pdatosparcela.ResumeLayout(False)
        Me.Pdatosparcela.PerformLayout()
        Me.Panelarrendatario.ResumeLayout(False)
        Me.Panelarrendatario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBrefernciacatastral As TextBox
    Friend WithEvents Ltituloparcela As Label
    Friend WithEvents Lrefernciacatastral As Label
    Friend WithEvents Pdatosparcela As Panel
    Friend WithEvents Lsuperficie As Label
    Friend WithEvents TBsuperficie As TextBox
    Friend WithEvents Lpago As Label
    Friend WithEvents TBpago As TextBox
    Friend WithEvents Lobservacionesparcela As Label
    Friend WithEvents TBobservacionesparcela As TextBox
    Friend WithEvents TBparcela As TextBox
    Friend WithEvents TBpoligono As TextBox
    Friend WithEvents TBnumeroparcelamunicipio As TextBox
    Friend WithEvents TBnumeroparcelaprovincia As TextBox
    Friend WithEvents Lparcela As Label
    Friend WithEvents Lpoligono As Label
    Friend WithEvents TBnombreparcelamunicipio As TextBox
    Friend WithEvents Lparcelamunicipio As Label
    Friend WithEvents TBnombreparcelaprovincia As TextBox
    Friend WithEvents Lparcelaprovincia As Label
    Friend WithEvents Panelarrendatario As Panel
    Friend WithEvents Larrenda As Label
    Friend WithEvents Ltitularnumero As Label
    Friend WithEvents TBtitularnumero As TextBox
    Friend WithEvents Bimagensatelite As Button
    Friend WithEvents Bcrearparcela As Button
    Friend WithEvents Ltitularnombre As Label
    Friend WithEvents Ltitulardni As Label
    Friend WithEvents TBtitulardni As TextBox
    Friend WithEvents Bactualizartitular As Button
    Friend WithEvents Ltitularcatastral As Label
    Friend WithEvents Bactualizararrendatario As Button
    Friend WithEvents TBarrendatariodni As TextBox
    Friend WithEvents Larrendatariodni As Label
    Friend WithEvents TBarrendatarionumero As TextBox
    Friend WithEvents Larrendatarionumero As Label
    Friend WithEvents Larrendatarionombre As Label
End Class
