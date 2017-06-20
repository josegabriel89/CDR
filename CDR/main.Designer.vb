<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bformlistarparcelas = New System.Windows.Forms.Button()
        Me.Bformcrearparcela = New System.Windows.Forms.Button()
        Me.Bformlistarmiembros = New System.Windows.Forms.Button()
        Me.Bformcrearmiembro = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Bformlistarparcelas)
        Me.Panel1.Controls.Add(Me.Bformcrearparcela)
        Me.Panel1.Controls.Add(Me.Bformlistarmiembros)
        Me.Panel1.Controls.Add(Me.Bformcrearmiembro)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 206)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(91, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Comunidad De Regantes"
        '
        'Bformlistarparcelas
        '
        Me.Bformlistarparcelas.Location = New System.Drawing.Point(287, 139)
        Me.Bformlistarparcelas.Name = "Bformlistarparcelas"
        Me.Bformlistarparcelas.Size = New System.Drawing.Size(281, 48)
        Me.Bformlistarparcelas.TabIndex = 4
        Me.Bformlistarparcelas.Text = "Listar Parcelas"
        Me.Bformlistarparcelas.UseVisualStyleBackColor = True
        '
        'Bformcrearparcela
        '
        Me.Bformcrearparcela.Location = New System.Drawing.Point(4, 139)
        Me.Bformcrearparcela.Name = "Bformcrearparcela"
        Me.Bformcrearparcela.Size = New System.Drawing.Size(277, 48)
        Me.Bformcrearparcela.TabIndex = 3
        Me.Bformcrearparcela.Text = "Crear Parcela"
        Me.Bformcrearparcela.UseVisualStyleBackColor = True
        '
        'Bformlistarmiembros
        '
        Me.Bformlistarmiembros.Location = New System.Drawing.Point(287, 76)
        Me.Bformlistarmiembros.Name = "Bformlistarmiembros"
        Me.Bformlistarmiembros.Size = New System.Drawing.Size(281, 57)
        Me.Bformlistarmiembros.TabIndex = 2
        Me.Bformlistarmiembros.Text = "Listar Miembros"
        Me.Bformlistarmiembros.UseVisualStyleBackColor = True
        '
        'Bformcrearmiembro
        '
        Me.Bformcrearmiembro.Location = New System.Drawing.Point(4, 76)
        Me.Bformcrearmiembro.Name = "Bformcrearmiembro"
        Me.Bformcrearmiembro.Size = New System.Drawing.Size(277, 57)
        Me.Bformcrearmiembro.TabIndex = 1
        Me.Bformcrearmiembro.Text = "Crear Miembro"
        Me.Bformcrearmiembro.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 230)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "main"
        Me.Text = "Comunidad de Regantes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bformcrearmiembro As Button
    Friend WithEvents Bformlistarparcelas As Button
    Friend WithEvents Bformcrearparcela As Button
    Friend WithEvents Bformlistarmiembros As Button
    Friend WithEvents Label1 As Label
End Class
