<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Title = New System.Windows.Forms.Label
        Me.Out = New System.Windows.Forms.Label
        Me.Level = New System.Windows.Forms.Label
        Me.Easy = New System.Windows.Forms.Label
        Me.Asian = New System.Windows.Forms.Label
        Me.Back = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Ravie", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(96, 23)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(235, 43)
        Me.Title.TabIndex = 1
        Me.Title.Text = "SUMANÍA!"
        '
        'Out
        '
        Me.Out.AutoSize = True
        Me.Out.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Out.Location = New System.Drawing.Point(387, 254)
        Me.Out.Name = "Out"
        Me.Out.Size = New System.Drawing.Size(35, 33)
        Me.Out.TabIndex = 5
        Me.Out.Text = "X"
        '
        'Level
        '
        Me.Level.AutoSize = True
        Me.Level.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level.Location = New System.Drawing.Point(159, 116)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(119, 20)
        Me.Level.TabIndex = 6
        Me.Level.Text = "DIFICULTAD:"
        '
        'Easy
        '
        Me.Easy.AutoSize = True
        Me.Easy.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Easy.Location = New System.Drawing.Point(182, 157)
        Me.Easy.Name = "Easy"
        Me.Easy.Size = New System.Drawing.Size(57, 20)
        Me.Easy.TabIndex = 7
        Me.Easy.Text = "FACIL"
        '
        'Asian
        '
        Me.Asian.AutoSize = True
        Me.Asian.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Asian.Location = New System.Drawing.Point(169, 194)
        Me.Asian.Name = "Asian"
        Me.Asian.Size = New System.Drawing.Size(98, 20)
        Me.Asian.TabIndex = 9
        Me.Asian.Text = "ASIATICO!"
        '
        'Back
        '
        Me.Back.AutoSize = True
        Me.Back.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(24, 255)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(77, 20)
        Me.Back.TabIndex = 10
        Me.Back.Text = "VOLVER"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 296)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Asian)
        Me.Controls.Add(Me.Easy)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.Out)
        Me.Controls.Add(Me.Title)
        Me.Name = "Form2"
        Me.Text = "SUMANIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Out As System.Windows.Forms.Label
    Friend WithEvents Level As System.Windows.Forms.Label
    Friend WithEvents Easy As System.Windows.Forms.Label
    Friend WithEvents Asian As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Label
End Class
