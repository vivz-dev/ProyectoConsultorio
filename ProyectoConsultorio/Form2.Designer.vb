<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", """a"": ""item"""}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", """a"": ""item"""}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", """a"": ""item"""}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", """a"": ""item"""}, -1)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.agregarRadiografia = New System.Windows.Forms.Button()
        Me.radiografiasList = New System.Windows.Forms.ListView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PACIENTESDataSet = New ProyectoConsultorio.PACIENTESDataSet()
        Me.PersonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonasTableAdapter = New ProyectoConsultorio.PACIENTESDataSetTableAdapters.PersonasTableAdapter()
        Me.agregarTomografia = New System.Windows.Forms.Button()
        Me.tomografiasList = New System.Windows.Forms.ListView()
        Me.agregarResonancia = New System.Windows.Forms.Button()
        Me.resonanciasList = New System.Windows.Forms.ListView()
        Me.agregarOtro = New System.Windows.Forms.Button()
        Me.otrosList = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PACIENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(32, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(718, 389)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.agregarRadiografia)
        Me.TabPage1.Controls.Add(Me.radiografiasList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(50, 75, 50, 25)
        Me.TabPage1.Size = New System.Drawing.Size(710, 360)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Radiografías"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'agregarRadiografia
        '
        Me.agregarRadiografia.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.agregarRadiografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.agregarRadiografia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregarRadiografia.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.agregarRadiografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarRadiografia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregarRadiografia.Image = CType(resources.GetObject("agregarRadiografia.Image"), System.Drawing.Image)
        Me.agregarRadiografia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.agregarRadiografia.Location = New System.Drawing.Point(509, 22)
        Me.agregarRadiografia.Name = "agregarRadiografia"
        Me.agregarRadiografia.Padding = New System.Windows.Forms.Padding(5)
        Me.agregarRadiografia.Size = New System.Drawing.Size(151, 40)
        Me.agregarRadiografia.TabIndex = 3
        Me.agregarRadiografia.Text = "Agregar Radiografía"
        Me.agregarRadiografia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.agregarRadiografia.UseVisualStyleBackColor = False
        '
        'radiografiasList
        '
        Me.radiografiasList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.radiografiasList.BackColor = System.Drawing.SystemColors.Window
        Me.radiografiasList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.radiografiasList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radiografiasList.FullRowSelect = True
        Me.radiografiasList.GridLines = True
        Me.radiografiasList.HideSelection = False
        Me.radiografiasList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.radiografiasList.Location = New System.Drawing.Point(50, 75)
        Me.radiografiasList.Margin = New System.Windows.Forms.Padding(10)
        Me.radiografiasList.Name = "radiografiasList"
        Me.radiografiasList.Size = New System.Drawing.Size(610, 260)
        Me.radiografiasList.TabIndex = 0
        Me.radiografiasList.UseCompatibleStateImageBehavior = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.agregarTomografia)
        Me.TabPage2.Controls.Add(Me.tomografiasList)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(50, 75, 50, 25)
        Me.TabPage2.Size = New System.Drawing.Size(710, 360)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tomografías"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.agregarResonancia)
        Me.TabPage3.Controls.Add(Me.resonanciasList)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(50, 75, 50, 25)
        Me.TabPage3.Size = New System.Drawing.Size(710, 360)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Resonancias"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.Controls.Add(Me.agregarOtro)
        Me.TabPage4.Controls.Add(Me.otrosList)
        Me.TabPage4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(50, 75, 50, 25)
        Me.TabPage4.Size = New System.Drawing.Size(710, 360)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Otros"
        '
        'PACIENTESDataSet
        '
        Me.PACIENTESDataSet.DataSetName = "PACIENTESDataSet"
        Me.PACIENTESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonasBindingSource
        '
        Me.PersonasBindingSource.DataMember = "Personas"
        Me.PersonasBindingSource.DataSource = Me.PACIENTESDataSet
        '
        'PersonasTableAdapter
        '
        Me.PersonasTableAdapter.ClearBeforeFill = True
        '
        'agregarTomografia
        '
        Me.agregarTomografia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.agregarTomografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.agregarTomografia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregarTomografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarTomografia.Image = CType(resources.GetObject("agregarTomografia.Image"), System.Drawing.Image)
        Me.agregarTomografia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.agregarTomografia.Location = New System.Drawing.Point(509, 22)
        Me.agregarTomografia.Name = "agregarTomografia"
        Me.agregarTomografia.Padding = New System.Windows.Forms.Padding(5)
        Me.agregarTomografia.Size = New System.Drawing.Size(151, 40)
        Me.agregarTomografia.TabIndex = 5
        Me.agregarTomografia.Text = "Agregar Tomografía"
        Me.agregarTomografia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.agregarTomografia.UseVisualStyleBackColor = False
        '
        'tomografiasList
        '
        Me.tomografiasList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.tomografiasList.BackColor = System.Drawing.SystemColors.Window
        Me.tomografiasList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tomografiasList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tomografiasList.FullRowSelect = True
        Me.tomografiasList.GridLines = True
        Me.tomografiasList.HideSelection = False
        Me.tomografiasList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.tomografiasList.Location = New System.Drawing.Point(50, 75)
        Me.tomografiasList.Margin = New System.Windows.Forms.Padding(10)
        Me.tomografiasList.Name = "tomografiasList"
        Me.tomografiasList.Size = New System.Drawing.Size(610, 260)
        Me.tomografiasList.TabIndex = 4
        Me.tomografiasList.UseCompatibleStateImageBehavior = False
        '
        'agregarResonancia
        '
        Me.agregarResonancia.BackColor = System.Drawing.Color.Transparent
        Me.agregarResonancia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.agregarResonancia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregarResonancia.Image = CType(resources.GetObject("agregarResonancia.Image"), System.Drawing.Image)
        Me.agregarResonancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.agregarResonancia.Location = New System.Drawing.Point(509, 22)
        Me.agregarResonancia.Name = "agregarResonancia"
        Me.agregarResonancia.Padding = New System.Windows.Forms.Padding(5)
        Me.agregarResonancia.Size = New System.Drawing.Size(151, 40)
        Me.agregarResonancia.TabIndex = 7
        Me.agregarResonancia.Text = "Agregar Resonancia"
        Me.agregarResonancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.agregarResonancia.UseVisualStyleBackColor = False
        '
        'resonanciasList
        '
        Me.resonanciasList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.resonanciasList.BackColor = System.Drawing.SystemColors.Window
        Me.resonanciasList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resonanciasList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resonanciasList.FullRowSelect = True
        Me.resonanciasList.GridLines = True
        Me.resonanciasList.HideSelection = False
        Me.resonanciasList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3})
        Me.resonanciasList.Location = New System.Drawing.Point(50, 75)
        Me.resonanciasList.Margin = New System.Windows.Forms.Padding(10)
        Me.resonanciasList.Name = "resonanciasList"
        Me.resonanciasList.Size = New System.Drawing.Size(610, 260)
        Me.resonanciasList.TabIndex = 6
        Me.resonanciasList.UseCompatibleStateImageBehavior = False
        '
        'agregarOtro
        '
        Me.agregarOtro.BackColor = System.Drawing.Color.Transparent
        Me.agregarOtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.agregarOtro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregarOtro.Image = CType(resources.GetObject("agregarOtro.Image"), System.Drawing.Image)
        Me.agregarOtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.agregarOtro.Location = New System.Drawing.Point(507, 22)
        Me.agregarOtro.Name = "agregarOtro"
        Me.agregarOtro.Padding = New System.Windows.Forms.Padding(5)
        Me.agregarOtro.Size = New System.Drawing.Size(151, 40)
        Me.agregarOtro.TabIndex = 7
        Me.agregarOtro.Text = "Agregar Archivo"
        Me.agregarOtro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.agregarOtro.UseVisualStyleBackColor = False
        '
        'otrosList
        '
        Me.otrosList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.otrosList.BackColor = System.Drawing.SystemColors.Window
        Me.otrosList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.otrosList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.otrosList.FullRowSelect = True
        Me.otrosList.GridLines = True
        Me.otrosList.HideSelection = False
        Me.otrosList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4})
        Me.otrosList.Location = New System.Drawing.Point(50, 75)
        Me.otrosList.Margin = New System.Windows.Forms.Padding(10)
        Me.otrosList.Name = "otrosList"
        Me.otrosList.Size = New System.Drawing.Size(610, 260)
        Me.otrosList.TabIndex = 6
        Me.otrosList.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PACIENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PACIENTESDataSet As PACIENTESDataSet
    Friend WithEvents PersonasBindingSource As BindingSource
    Friend WithEvents PersonasTableAdapter As PACIENTESDataSetTableAdapters.PersonasTableAdapter
    Friend WithEvents radiografiasList As ListView
    Friend WithEvents agregarRadiografia As Button
    Friend WithEvents agregarTomografia As Button
    Friend WithEvents tomografiasList As ListView
    Friend WithEvents agregarResonancia As Button
    Friend WithEvents resonanciasList As ListView
    Friend WithEvents agregarOtro As Button
    Friend WithEvents otrosList As ListView
    Friend WithEvents Label1 As Label
End Class
