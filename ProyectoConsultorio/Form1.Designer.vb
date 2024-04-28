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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PersonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESDataSet = New ProyectoConsultorio.PACIENTESDataSet()
        Me.PersonasTableAdapter = New ProyectoConsultorio.PACIENTESDataSetTableAdapters.PersonasTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.radiografiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.agregarRadiografia = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tomografiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.configuracion = New System.Windows.Forms.Button()
        Me.pacientes = New System.Windows.Forms.Button()
        Me.agenda = New System.Windows.Forms.Button()
        Me.crear = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.Button()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.radiografiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.tomografiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(360, 90)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(701, 389)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.radiografiasDataGridView)
        Me.TabPage1.Controls.Add(Me.agregarRadiografia)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(50, 75, 50, 25)
        Me.TabPage1.Size = New System.Drawing.Size(693, 360)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Radiografías"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'radiografiasDataGridView
        '
        Me.radiografiasDataGridView.AllowUserToAddRows = False
        Me.radiografiasDataGridView.AllowUserToDeleteRows = False
        Me.radiografiasDataGridView.AllowUserToResizeRows = False
        Me.radiografiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.radiografiasDataGridView.Cursor = System.Windows.Forms.Cursors.Default
        Me.radiografiasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radiografiasDataGridView.Location = New System.Drawing.Point(50, 75)
        Me.radiografiasDataGridView.MultiSelect = False
        Me.radiografiasDataGridView.Name = "radiografiasDataGridView"
        Me.radiografiasDataGridView.ReadOnly = True
        Me.radiografiasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.radiografiasDataGridView.RowTemplate.DividerHeight = 1
        Me.radiografiasDataGridView.Size = New System.Drawing.Size(593, 260)
        Me.radiografiasDataGridView.TabIndex = 4
        '
        'agregarRadiografia
        '
        Me.agregarRadiografia.BackColor = System.Drawing.SystemColors.Desktop
        Me.agregarRadiografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.agregarRadiografia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregarRadiografia.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.agregarRadiografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarRadiografia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregarRadiografia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.agregarRadiografia.Image = CType(resources.GetObject("agregarRadiografia.Image"), System.Drawing.Image)
        Me.agregarRadiografia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.agregarRadiografia.Location = New System.Drawing.Point(477, 29)
        Me.agregarRadiografia.Name = "agregarRadiografia"
        Me.agregarRadiografia.Padding = New System.Windows.Forms.Padding(5)
        Me.agregarRadiografia.Size = New System.Drawing.Size(166, 40)
        Me.agregarRadiografia.TabIndex = 3
        Me.agregarRadiografia.Text = "Agregar Radiografía"
        Me.agregarRadiografia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.agregarRadiografia.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tomografiasDataGridView)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(50, 75, 50, 25)
        Me.TabPage2.Size = New System.Drawing.Size(693, 360)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tomografías"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tomografiasDataGridView
        '
        Me.tomografiasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.tomografiasDataGridView.Name = "tomografiasDataGridView"
        Me.tomografiasDataGridView.Size = New System.Drawing.Size(240, 150)
        Me.tomografiasDataGridView.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(50, 75, 50, 25)
        Me.TabPage3.Size = New System.Drawing.Size(693, 360)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Resonancias"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(50, 75, 50, 25)
        Me.TabPage4.Size = New System.Drawing.Size(693, 360)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Otros"
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
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.radiografiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.tomografiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PACIENTESDataSet As PACIENTESDataSet
    Friend WithEvents PersonasBindingSource As BindingSource
    Friend WithEvents PersonasTableAdapter As PACIENTESDataSetTableAdapters.PersonasTableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents agregarRadiografia As Button
    Friend WithEvents radiografiasDataGridView As DataGridView
    Friend WithEvents tomografiasDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents configuracion As Button
    Friend WithEvents pacientes As Button
    Friend WithEvents agenda As Button
    Friend WithEvents crear As Button
    Friend WithEvents buscar As Button
End Class
