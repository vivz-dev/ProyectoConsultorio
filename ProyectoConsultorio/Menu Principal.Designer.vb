<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buscar = New System.Windows.Forms.Button()
        Me.crear = New System.Windows.Forms.Button()
        Me.agenda = New System.Windows.Forms.Button()
        Me.pacientes = New System.Windows.Forms.Button()
        Me.configuracion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.configuracion)
        Me.Panel1.Controls.Add(Me.pacientes)
        Me.Panel1.Controls.Add(Me.agenda)
        Me.Panel1.Controls.Add(Me.crear)
        Me.Panel1.Controls.Add(Me.buscar)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 501)
        Me.Panel1.TabIndex = 0
        '
        'buscar
        '
        Me.buscar.AllowDrop = True
        Me.buscar.BackColor = System.Drawing.SystemColors.Highlight
        Me.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buscar.Location = New System.Drawing.Point(0, 126)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(189, 47)
        Me.buscar.TabIndex = 0
        Me.buscar.Text = "Buscar paciente"
        Me.buscar.UseVisualStyleBackColor = False
        '
        'crear
        '
        Me.crear.AllowDrop = True
        Me.crear.BackColor = System.Drawing.SystemColors.Highlight
        Me.crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crear.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.crear.Location = New System.Drawing.Point(0, 172)
        Me.crear.Name = "crear"
        Me.crear.Size = New System.Drawing.Size(189, 47)
        Me.crear.TabIndex = 1
        Me.crear.Text = "Nuevo paciente"
        Me.crear.UseVisualStyleBackColor = False
        '
        'agenda
        '
        Me.agenda.AllowDrop = True
        Me.agenda.BackColor = System.Drawing.SystemColors.Highlight
        Me.agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agenda.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agenda.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.agenda.Location = New System.Drawing.Point(0, 218)
        Me.agenda.Name = "agenda"
        Me.agenda.Size = New System.Drawing.Size(189, 47)
        Me.agenda.TabIndex = 2
        Me.agenda.Text = "Agenda"
        Me.agenda.UseVisualStyleBackColor = False
        '
        'pacientes
        '
        Me.pacientes.AllowDrop = True
        Me.pacientes.BackColor = System.Drawing.SystemColors.Highlight
        Me.pacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pacientes.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pacientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pacientes.Location = New System.Drawing.Point(0, 264)
        Me.pacientes.Name = "pacientes"
        Me.pacientes.Size = New System.Drawing.Size(189, 47)
        Me.pacientes.TabIndex = 3
        Me.pacientes.Text = "Pacientes"
        Me.pacientes.UseVisualStyleBackColor = False
        '
        'configuracion
        '
        Me.configuracion.AllowDrop = True
        Me.configuracion.BackColor = System.Drawing.SystemColors.Highlight
        Me.configuracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.configuracion.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.configuracion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.configuracion.Location = New System.Drawing.Point(0, 310)
        Me.configuracion.Name = "configuracion"
        Me.configuracion.Size = New System.Drawing.Size(189, 47)
        Me.configuracion.TabIndex = 4
        Me.configuracion.Text = "Configuracion"
        Me.configuracion.UseVisualStyleBackColor = False
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 512)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Menu_Principal"
        Me.Text = "Agenda"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents buscar As Button
    Friend WithEvents configuracion As Button
    Friend WithEvents pacientes As Button
    Friend WithEvents agenda As Button
    Friend WithEvents crear As Button
End Class
