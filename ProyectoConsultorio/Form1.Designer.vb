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
        Me.agregarRadiografia = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.tomografiasListView = New System.Windows.Forms.ListView()
        Me.agregarTomografia = New System.Windows.Forms.Button()
        Me.radiografiasDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.radiografiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage2.Controls.Add(Me.tomografiasListView)
        Me.TabPage2.Controls.Add(Me.agregarTomografia)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(50, 75, 50, 25)
        Me.TabPage2.Size = New System.Drawing.Size(693, 360)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tomografías"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'tomografiasListView
        '
        Me.tomografiasListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tomografiasListView.FullRowSelect = True
        Me.tomografiasListView.GridLines = True
        Me.tomografiasListView.HideSelection = False
        Me.tomografiasListView.Location = New System.Drawing.Point(50, 75)
        Me.tomografiasListView.MultiSelect = False
        Me.tomografiasListView.Name = "tomografiasListView"
        Me.tomografiasListView.Size = New System.Drawing.Size(593, 260)
        Me.tomografiasListView.TabIndex = 7
        Me.tomografiasListView.UseCompatibleStateImageBehavior = False
        Me.tomografiasListView.View = System.Windows.Forms.View.Details
        '
        'agregarTomografia
        '
        Me.agregarTomografia.BackColor = System.Drawing.SystemColors.Desktop
        Me.agregarTomografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.agregarTomografia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregarTomografia.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.agregarTomografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarTomografia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregarTomografia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.agregarTomografia.Image = CType(resources.GetObject("agregarTomografia.Image"), System.Drawing.Image)
        Me.agregarTomografia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.agregarTomografia.Location = New System.Drawing.Point(477, 27)
        Me.agregarTomografia.Name = "agregarTomografia"
        Me.agregarTomografia.Padding = New System.Windows.Forms.Padding(5)
        Me.agregarTomografia.Size = New System.Drawing.Size(166, 40)
        Me.agregarTomografia.TabIndex = 6
        Me.agregarTomografia.Text = "Agregar Tomografía"
        Me.agregarTomografia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.agregarTomografia.UseVisualStyleBackColor = False
        '
        'radiografiasDataGridView
        '
        Me.radiografiasDataGridView.AllowUserToAddRows = False
        Me.radiografiasDataGridView.AllowUserToDeleteRows = False
        Me.radiografiasDataGridView.AllowUserToResizeColumns = False
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.radiografiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tomografiasListView As ListView
    Friend WithEvents agregarTomografia As Button
    Friend WithEvents radiografiasDataGridView As DataGridView
End Class
