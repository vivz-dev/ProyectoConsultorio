﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BuscarPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.configuracion = New System.Windows.Forms.Button()
        Me.pacientesButton = New System.Windows.Forms.Button()
        Me.agendaBtn = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPacienteToolStripMenuItem, Me.NuevoPacienteToolStripMenuItem, Me.AgendaToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(158, 70)
        '
        'BuscarPacienteToolStripMenuItem
        '
        Me.BuscarPacienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.BuscarPacienteToolStripMenuItem.Name = "BuscarPacienteToolStripMenuItem"
        Me.BuscarPacienteToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.BuscarPacienteToolStripMenuItem.Text = "Buscar Paciente"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'NuevoPacienteToolStripMenuItem
        '
        Me.NuevoPacienteToolStripMenuItem.Name = "NuevoPacienteToolStripMenuItem"
        Me.NuevoPacienteToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NuevoPacienteToolStripMenuItem.Text = "Nuevo Paciente"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 16)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 665)
        Me.Panel2.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 577)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 564)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 577)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 564)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PC:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(28, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(133, 129)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.configuracion)
        Me.GroupBox1.Controls.Add(Me.pacientesButton)
        Me.GroupBox1.Controls.Add(Me.agendaBtn)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.buscar)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 383)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'configuracion
        '
        Me.configuracion.Dock = System.Windows.Forms.DockStyle.Top
        Me.configuracion.Location = New System.Drawing.Point(3, 108)
        Me.configuracion.Name = "configuracion"
        Me.configuracion.Size = New System.Drawing.Size(191, 23)
        Me.configuracion.TabIndex = 4
        Me.configuracion.Text = "Configuracion"
        Me.configuracion.UseVisualStyleBackColor = True
        '
        'pacientesButton
        '
        Me.pacientesButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.pacientesButton.Location = New System.Drawing.Point(3, 85)
        Me.pacientesButton.Name = "pacientesButton"
        Me.pacientesButton.Size = New System.Drawing.Size(191, 23)
        Me.pacientesButton.TabIndex = 3
        Me.pacientesButton.Text = "Pacientes"
        Me.pacientesButton.UseVisualStyleBackColor = True
        '
        'agendaBtn
        '
        Me.agendaBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.agendaBtn.Location = New System.Drawing.Point(3, 62)
        Me.agendaBtn.Name = "agendaBtn"
        Me.agendaBtn.Size = New System.Drawing.Size(191, 23)
        Me.agendaBtn.TabIndex = 2
        Me.agendaBtn.Text = "Agenda"
        Me.agendaBtn.UseVisualStyleBackColor = True
        '
        'nuevo
        '
        Me.nuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.nuevo.Location = New System.Drawing.Point(3, 39)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(191, 23)
        Me.nuevo.TabIndex = 1
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.buscar.Location = New System.Drawing.Point(3, 16)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(191, 23)
        Me.buscar.TabIndex = 0
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(200, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1064, 665)
        Me.Panel3.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "CENATURE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PACIENTESDataSet As PACIENTESDataSet
    Friend WithEvents PersonasBindingSource As BindingSource
    Friend WithEvents PersonasTableAdapter As PACIENTESDataSetTableAdapters.PersonasTableAdapter
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents BuscarPacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NuevoPacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents configuracion As Button
    Friend WithEvents pacientesButton As Button
    Friend WithEvents agendaBtn As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents buscar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
