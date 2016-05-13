<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Mode = New System.Windows.Forms.Label
        Me.Point = New System.Windows.Forms.Label
        Me.Time = New System.Windows.Forms.Label
        Me.Out = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Ravie", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(96, 23)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(235, 43)
        Me.Title.TabIndex = 0
        Me.Title.Text = "SUMANÍA!"
        '
        'Mode
        '
        Me.Mode.AutoSize = True
        Me.Mode.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mode.Location = New System.Drawing.Point(138, 112)
        Me.Mode.Name = "Mode"
        Me.Mode.Size = New System.Drawing.Size(156, 20)
        Me.Mode.TabIndex = 1
        Me.Mode.Text = "MODO DE JUEGO:"
        '
        'Point
        '
        Me.Point.AutoSize = True
        Me.Point.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Point.Location = New System.Drawing.Point(170, 168)
        Me.Point.Name = "Point"
        Me.Point.Size = New System.Drawing.Size(85, 20)
        Me.Point.TabIndex = 2
        Me.Point.Text = "PUNTAJE"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(128, 209)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(175, 20)
        Me.Time.TabIndex = 3
        Me.Time.Text = "CONTRA EL TIEMPO"
        '
        'Out
        '
        Me.Out.AutoSize = True
        Me.Out.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Out.Location = New System.Drawing.Point(387, 254)
        Me.Out.Name = "Out"
        Me.Out.Size = New System.Drawing.Size(35, 33)
        Me.Out.TabIndex = 4
        Me.Out.Text = "X"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 296)
        Me.Controls.Add(Me.Out)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Point)
        Me.Controls.Add(Me.Mode)
        Me.Controls.Add(Me.Title)
        Me.Name = "Form1"
        Me.Text = "SUMANIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Mode As System.Windows.Forms.Label
    Friend WithEvents Point As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents Out As System.Windows.Forms.Label

End Class
