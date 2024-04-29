<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.PersonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESDataSet = New ProyectoConsultorio.PACIENTESDataSet()
        Me.PersonasTableAdapter = New ProyectoConsultorio.PACIENTESDataSetTableAdapters.PersonasTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.configuracion = New System.Windows.Forms.Button()
        Me.pacientes = New System.Windows.Forms.Button()
        Me.agenda = New System.Windows.Forms.Button()
        Me.crear = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.Button()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersonasBindingSource
        '
        Me.PersonasBindingSource.DataMember = "Personas"
        Me.PersonasBindingSource.DataSource = Me.PACIENTESDataSet
        '
        'PACIENTESDataSet
        '
        Me.PACIENTESDataSet.DataSetName = "PACIENTESDataSet"
        Me.PACIENTESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonasTableAdapter
        '
        Me.PersonasTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.configuracion)
        Me.Panel1.Controls.Add(Me.pacientes)
        Me.Panel1.Controls.Add(Me.agenda)
        Me.Panel1.Controls.Add(Me.crear)
        Me.Panel1.Controls.Add(Me.buscar)
        Me.Panel1.Location = New System.Drawing.Point(-2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 684)
        Me.Panel1.TabIndex = 5
        '
        'configuracion
        '
        Me.configuracion.AllowDrop = True
        Me.configuracion.BackColor = System.Drawing.SystemColors.Highlight
        Me.configuracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.configuracion.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.configuracion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.configuracion.Location = New System.Drawing.Point(1, 400)
        Me.configuracion.Name = "configuracion"
        Me.configuracion.Size = New System.Drawing.Size(189, 47)
        Me.configuracion.TabIndex = 4
        Me.configuracion.Text = "Configuracion"
        Me.configuracion.UseVisualStyleBackColor = False
        '
        'pacientes
        '
        Me.pacientes.AllowDrop = True
        Me.pacientes.BackColor = System.Drawing.SystemColors.Highlight
        Me.pacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pacientes.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pacientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pacientes.Location = New System.Drawing.Point(1, 354)
        Me.pacientes.Name = "pacientes"
        Me.pacientes.Size = New System.Drawing.Size(189, 47)
        Me.pacientes.TabIndex = 3
        Me.pacientes.Text = "Pacientes"
        Me.pacientes.UseVisualStyleBackColor = False
        '
        'agenda
        '
        Me.agenda.AllowDrop = True
        Me.agenda.BackColor = System.Drawing.SystemColors.Highlight
        Me.agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agenda.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agenda.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.agenda.Location = New System.Drawing.Point(1, 308)
        Me.agenda.Name = "agenda"
        Me.agenda.Size = New System.Drawing.Size(189, 47)
        Me.agenda.TabIndex = 2
        Me.agenda.Text = "Agenda"
        Me.agenda.UseVisualStyleBackColor = False
        '
        'crear
        '
        Me.crear.AllowDrop = True
        Me.crear.BackColor = System.Drawing.SystemColors.Highlight
        Me.crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crear.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.crear.Location = New System.Drawing.Point(1, 262)
        Me.crear.Name = "crear"
        Me.crear.Size = New System.Drawing.Size(189, 47)
        Me.crear.TabIndex = 1
        Me.crear.Text = "Nuevo paciente"
        Me.crear.UseVisualStyleBackColor = False
        '
        'buscar
        '
        Me.buscar.AllowDrop = True
        Me.buscar.BackColor = System.Drawing.SystemColors.Highlight
        Me.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buscar.Location = New System.Drawing.Point(1, 216)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(189, 47)
        Me.buscar.TabIndex = 0
        Me.buscar.Text = "Buscar paciente"
        Me.buscar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PACIENTESDataSet As PACIENTESDataSet
    Friend WithEvents PersonasBindingSource As BindingSource
    Friend WithEvents PersonasTableAdapter As PACIENTESDataSetTableAdapters.PersonasTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents configuracion As Button
    Friend WithEvents pacientes As Button
    Friend WithEvents agenda As Button
    Friend WithEvents crear As Button
    Friend WithEvents buscar As Button
End Class
