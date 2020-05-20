<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FACheckBox = New System.Windows.Forms.CheckBox()
        Me.ResultadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Desporto_escolarDataSet = New PAP.Desporto_escolarDataSet()
        Me.FCCheckBox = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.JogosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DesportoEscolarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassificaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VitóriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VitóriasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DerrotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoverOsFiltrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VitoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpatesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DerrotasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodresultadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodjogoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResescolaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResadversarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FADataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CodjogoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganizaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodmodalidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EscalãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GéneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SérieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodescolaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EscolaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultadoTableAdapter = New PAP.Desporto_escolarDataSetTableAdapters.ResultadoTableAdapter()
        Me.JogosTableAdapter = New PAP.Desporto_escolarDataSetTableAdapters.JogosTableAdapter()
        Me.EscolaTableAdapter = New PAP.Desporto_escolarDataSetTableAdapters.EscolaTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ResultadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desporto_escolarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JogosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscolaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FACheckBox
        '
        Me.FACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ResultadoBindingSource, "FA", True))
        Me.FACheckBox.Location = New System.Drawing.Point(28, 325)
        Me.FACheckBox.Name = "FACheckBox"
        Me.FACheckBox.Size = New System.Drawing.Size(175, 24)
        Me.FACheckBox.TabIndex = 60
        Me.FACheckBox.Text = "Falta Administrativa"
        Me.FACheckBox.UseVisualStyleBackColor = True
        '
        'ResultadoBindingSource
        '
        Me.ResultadoBindingSource.DataMember = "Resultado"
        Me.ResultadoBindingSource.DataSource = Me.Desporto_escolarDataSet
        '
        'Desporto_escolarDataSet
        '
        Me.Desporto_escolarDataSet.DataSetName = "Desporto_escolarDataSet"
        Me.Desporto_escolarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FCCheckBox
        '
        Me.FCCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ResultadoBindingSource, "FC", True))
        Me.FCCheckBox.Location = New System.Drawing.Point(28, 295)
        Me.FCCheckBox.Name = "FCCheckBox"
        Me.FCCheckBox.Size = New System.Drawing.Size(175, 24)
        Me.FCCheckBox.TabIndex = 59
        Me.FCCheckBox.Text = "Falta de Comparência"
        Me.FCCheckBox.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ResultadoBindingSource, "codjogo", True))
        Me.ComboBox1.DataSource = Me.JogosBindingSource
        Me.ComboBox1.DisplayMember = "codjogo"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(96, 197)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 58
        Me.ComboBox1.ValueMember = "codjogo"
        '
        'JogosBindingSource
        '
        Me.JogosBindingSource.DataMember = "Jogos"
        Me.JogosBindingSource.DataSource = Me.Desporto_escolarDataSet
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(417, 296)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 80)
        Me.Button7.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.Button7, "Cancelar Registo")
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 17)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "-"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultadoBindingSource, "resadversario", True))
        Me.TextBox3.Location = New System.Drawing.Point(392, 247)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(54, 25)
        Me.TextBox3.TabIndex = 55
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultadoBindingSource, "resescola", True))
        Me.TextBox2.Location = New System.Drawing.Point(297, 247)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(45, 25)
        Me.TextBox2.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(452, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Adversário"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 17)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Escola Secundária Manuel Cargaleiro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Jogo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Resultado"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultadoBindingSource, "codresultado", True))
        Me.TextBox1.Location = New System.Drawing.Point(96, 151)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.TextBox1.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(19, 31)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 93)
        Me.Button1.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.Button1, "Voltar")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(338, 38)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 86)
        Me.Button2.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.Button2, "Adicionar")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(318, 296)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 80)
        Me.Button5.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.Button5, "Eliminar")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(215, 296)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 80)
        Me.Button3.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.Button3, "Gravar")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(279, 54)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 63)
        Me.Button4.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.Button4, "Anterior")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(408, 46)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 71)
        Me.Button6.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.Button6, "Seguinte")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesportoEscolarToolStripMenuItem, Me.VitóriasToolStripMenuItem, Me.NumerosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1317, 27)
        Me.MenuStrip1.TabIndex = 61
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DesportoEscolarToolStripMenuItem
        '
        Me.DesportoEscolarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DesportoEscolarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultadosToolStripMenuItem, Me.ClassificaçõesToolStripMenuItem})
        Me.DesportoEscolarToolStripMenuItem.Image = CType(resources.GetObject("DesportoEscolarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DesportoEscolarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DesportoEscolarToolStripMenuItem.Name = "DesportoEscolarToolStripMenuItem"
        Me.DesportoEscolarToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.DesportoEscolarToolStripMenuItem.Text = "Desporto Escolar"
        Me.DesportoEscolarToolStripMenuItem.ToolTipText = "Desporto escolar"
        '
        'ResultadosToolStripMenuItem
        '
        Me.ResultadosToolStripMenuItem.Name = "ResultadosToolStripMenuItem"
        Me.ResultadosToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ResultadosToolStripMenuItem.Text = "Resultados"
        '
        'ClassificaçõesToolStripMenuItem
        '
        Me.ClassificaçõesToolStripMenuItem.Name = "ClassificaçõesToolStripMenuItem"
        Me.ClassificaçõesToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ClassificaçõesToolStripMenuItem.Text = "Classificações"
        '
        'VitóriasToolStripMenuItem
        '
        Me.VitóriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VitóriasToolStripMenuItem1, Me.EmpatesToolStripMenuItem, Me.DerrotasToolStripMenuItem, Me.RemoverOsFiltrosToolStripMenuItem})
        Me.VitóriasToolStripMenuItem.Name = "VitóriasToolStripMenuItem"
        Me.VitóriasToolStripMenuItem.Size = New System.Drawing.Size(47, 23)
        Me.VitóriasToolStripMenuItem.Text = "Listar"
        '
        'VitóriasToolStripMenuItem1
        '
        Me.VitóriasToolStripMenuItem1.Name = "VitóriasToolStripMenuItem1"
        Me.VitóriasToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.VitóriasToolStripMenuItem1.Text = "Vitórias"
        '
        'EmpatesToolStripMenuItem
        '
        Me.EmpatesToolStripMenuItem.Name = "EmpatesToolStripMenuItem"
        Me.EmpatesToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EmpatesToolStripMenuItem.Text = "Empates"
        '
        'DerrotasToolStripMenuItem
        '
        Me.DerrotasToolStripMenuItem.Name = "DerrotasToolStripMenuItem"
        Me.DerrotasToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DerrotasToolStripMenuItem.Text = "Derrotas"
        '
        'RemoverOsFiltrosToolStripMenuItem
        '
        Me.RemoverOsFiltrosToolStripMenuItem.Name = "RemoverOsFiltrosToolStripMenuItem"
        Me.RemoverOsFiltrosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RemoverOsFiltrosToolStripMenuItem.Text = "Remover os filtros"
        '
        'NumerosToolStripMenuItem
        '
        Me.NumerosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VitoriasToolStripMenuItem, Me.EmpatesToolStripMenuItem1, Me.DerrotasToolStripMenuItem1})
        Me.NumerosToolStripMenuItem.Name = "NumerosToolStripMenuItem"
        Me.NumerosToolStripMenuItem.Size = New System.Drawing.Size(68, 23)
        Me.NumerosToolStripMenuItem.Text = "Números"
        '
        'VitoriasToolStripMenuItem
        '
        Me.VitoriasToolStripMenuItem.Name = "VitoriasToolStripMenuItem"
        Me.VitoriasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VitoriasToolStripMenuItem.Text = "Vitórias"
        '
        'EmpatesToolStripMenuItem1
        '
        Me.EmpatesToolStripMenuItem1.Name = "EmpatesToolStripMenuItem1"
        Me.EmpatesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EmpatesToolStripMenuItem1.Text = "Empates"
        '
        'DerrotasToolStripMenuItem1
        '
        Me.DerrotasToolStripMenuItem1.Name = "DerrotasToolStripMenuItem1"
        Me.DerrotasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DerrotasToolStripMenuItem1.Text = "Derrotas"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodresultadoDataGridViewTextBoxColumn, Me.CodjogoDataGridViewTextBoxColumn, Me.ResescolaDataGridViewTextBoxColumn, Me.ResadversarioDataGridViewTextBoxColumn, Me.FCDataGridViewCheckBoxColumn, Me.FADataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.ResultadoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(597, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(539, 338)
        Me.DataGridView1.TabIndex = 62
        '
        'CodresultadoDataGridViewTextBoxColumn
        '
        Me.CodresultadoDataGridViewTextBoxColumn.DataPropertyName = "codresultado"
        Me.CodresultadoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodresultadoDataGridViewTextBoxColumn.Name = "CodresultadoDataGridViewTextBoxColumn"
        Me.CodresultadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodresultadoDataGridViewTextBoxColumn.Width = 115
        '
        'CodjogoDataGridViewTextBoxColumn
        '
        Me.CodjogoDataGridViewTextBoxColumn.DataPropertyName = "codjogo"
        Me.CodjogoDataGridViewTextBoxColumn.HeaderText = "Jogo"
        Me.CodjogoDataGridViewTextBoxColumn.Name = "CodjogoDataGridViewTextBoxColumn"
        Me.CodjogoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodjogoDataGridViewTextBoxColumn.Width = 115
        '
        'ResescolaDataGridViewTextBoxColumn
        '
        Me.ResescolaDataGridViewTextBoxColumn.DataPropertyName = "resescola"
        Me.ResescolaDataGridViewTextBoxColumn.HeaderText = "ESMC"
        Me.ResescolaDataGridViewTextBoxColumn.Name = "ResescolaDataGridViewTextBoxColumn"
        Me.ResescolaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ResescolaDataGridViewTextBoxColumn.Width = 80
        '
        'ResadversarioDataGridViewTextBoxColumn
        '
        Me.ResadversarioDataGridViewTextBoxColumn.DataPropertyName = "resadversario"
        Me.ResadversarioDataGridViewTextBoxColumn.HeaderText = "Adversário"
        Me.ResadversarioDataGridViewTextBoxColumn.Name = "ResadversarioDataGridViewTextBoxColumn"
        Me.ResadversarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ResadversarioDataGridViewTextBoxColumn.Width = 80
        '
        'FCDataGridViewCheckBoxColumn
        '
        Me.FCDataGridViewCheckBoxColumn.DataPropertyName = "FC"
        Me.FCDataGridViewCheckBoxColumn.HeaderText = "FC"
        Me.FCDataGridViewCheckBoxColumn.Name = "FCDataGridViewCheckBoxColumn"
        Me.FCDataGridViewCheckBoxColumn.ReadOnly = True
        Me.FCDataGridViewCheckBoxColumn.Width = 50
        '
        'FADataGridViewCheckBoxColumn
        '
        Me.FADataGridViewCheckBoxColumn.DataPropertyName = "FA"
        Me.FADataGridViewCheckBoxColumn.HeaderText = "FA"
        Me.FADataGridViewCheckBoxColumn.Name = "FADataGridViewCheckBoxColumn"
        Me.FADataGridViewCheckBoxColumn.ReadOnly = True
        Me.FADataGridViewCheckBoxColumn.Width = 50
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodjogoDataGridViewTextBoxColumn1, Me.OrganizaçãoDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.CodmodalidadeDataGridViewTextBoxColumn, Me.EscalãoDataGridViewTextBoxColumn, Me.GéneroDataGridViewTextBoxColumn, Me.FaseDataGridViewTextBoxColumn, Me.SérieDataGridViewTextBoxColumn, Me.CodescolaDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.LocalDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.JogosBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 395)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(1293, 245)
        Me.DataGridView2.TabIndex = 63
        '
        'CodjogoDataGridViewTextBoxColumn1
        '
        Me.CodjogoDataGridViewTextBoxColumn1.DataPropertyName = "codjogo"
        Me.CodjogoDataGridViewTextBoxColumn1.HeaderText = "Jogo"
        Me.CodjogoDataGridViewTextBoxColumn1.Name = "CodjogoDataGridViewTextBoxColumn1"
        Me.CodjogoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'OrganizaçãoDataGridViewTextBoxColumn
        '
        Me.OrganizaçãoDataGridViewTextBoxColumn.DataPropertyName = "Organização"
        Me.OrganizaçãoDataGridViewTextBoxColumn.HeaderText = "Organização"
        Me.OrganizaçãoDataGridViewTextBoxColumn.Name = "OrganizaçãoDataGridViewTextBoxColumn"
        Me.OrganizaçãoDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrganizaçãoDataGridViewTextBoxColumn.Width = 115
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodmodalidadeDataGridViewTextBoxColumn
        '
        Me.CodmodalidadeDataGridViewTextBoxColumn.DataPropertyName = "codmodalidade"
        Me.CodmodalidadeDataGridViewTextBoxColumn.HeaderText = "Modalidade"
        Me.CodmodalidadeDataGridViewTextBoxColumn.Name = "CodmodalidadeDataGridViewTextBoxColumn"
        Me.CodmodalidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EscalãoDataGridViewTextBoxColumn
        '
        Me.EscalãoDataGridViewTextBoxColumn.DataPropertyName = "Escalão"
        Me.EscalãoDataGridViewTextBoxColumn.HeaderText = "Escalão"
        Me.EscalãoDataGridViewTextBoxColumn.Name = "EscalãoDataGridViewTextBoxColumn"
        Me.EscalãoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GéneroDataGridViewTextBoxColumn
        '
        Me.GéneroDataGridViewTextBoxColumn.DataPropertyName = "Género"
        Me.GéneroDataGridViewTextBoxColumn.HeaderText = "Género"
        Me.GéneroDataGridViewTextBoxColumn.Name = "GéneroDataGridViewTextBoxColumn"
        Me.GéneroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FaseDataGridViewTextBoxColumn
        '
        Me.FaseDataGridViewTextBoxColumn.DataPropertyName = "Fase"
        Me.FaseDataGridViewTextBoxColumn.HeaderText = "Fase"
        Me.FaseDataGridViewTextBoxColumn.Name = "FaseDataGridViewTextBoxColumn"
        Me.FaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.FaseDataGridViewTextBoxColumn.Width = 50
        '
        'SérieDataGridViewTextBoxColumn
        '
        Me.SérieDataGridViewTextBoxColumn.DataPropertyName = "Série"
        Me.SérieDataGridViewTextBoxColumn.HeaderText = "Série"
        Me.SérieDataGridViewTextBoxColumn.Name = "SérieDataGridViewTextBoxColumn"
        Me.SérieDataGridViewTextBoxColumn.ReadOnly = True
        Me.SérieDataGridViewTextBoxColumn.Width = 50
        '
        'CodescolaDataGridViewTextBoxColumn
        '
        Me.CodescolaDataGridViewTextBoxColumn.DataPropertyName = "codescola"
        Me.CodescolaDataGridViewTextBoxColumn.DataSource = Me.EscolaBindingSource
        Me.CodescolaDataGridViewTextBoxColumn.DisplayMember = "Nome"
        Me.CodescolaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.CodescolaDataGridViewTextBoxColumn.HeaderText = "Escola"
        Me.CodescolaDataGridViewTextBoxColumn.Name = "CodescolaDataGridViewTextBoxColumn"
        Me.CodescolaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodescolaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CodescolaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CodescolaDataGridViewTextBoxColumn.ValueMember = "codescola"
        Me.CodescolaDataGridViewTextBoxColumn.Width = 315
        '
        'EscolaBindingSource
        '
        Me.EscolaBindingSource.DataMember = "Escola"
        Me.EscolaBindingSource.DataSource = Me.Desporto_escolarDataSet
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalDataGridViewTextBoxColumn
        '
        Me.LocalDataGridViewTextBoxColumn.DataPropertyName = "Local"
        Me.LocalDataGridViewTextBoxColumn.HeaderText = "Local"
        Me.LocalDataGridViewTextBoxColumn.Name = "LocalDataGridViewTextBoxColumn"
        Me.LocalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResultadoTableAdapter
        '
        Me.ResultadoTableAdapter.ClearBeforeFill = True
        '
        'JogosTableAdapter
        '
        Me.JogosTableAdapter.ClearBeforeFill = True
        '
        'EscolaTableAdapter
        '
        Me.EscolaTableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 652)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.FACheckBox)
        Me.Controls.Add(Me.FCCheckBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form4"
        Me.Text = "Resultado"
        CType(Me.ResultadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desporto_escolarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JogosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscolaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FCCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DesportoEscolarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassificaçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VitóriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VitóriasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DerrotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoverOsFiltrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumerosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VitoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpatesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DerrotasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Desporto_escolarDataSet As PAP.Desporto_escolarDataSet
    Friend WithEvents ResultadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResultadoTableAdapter As PAP.Desporto_escolarDataSetTableAdapters.ResultadoTableAdapter
    Friend WithEvents JogosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JogosTableAdapter As PAP.Desporto_escolarDataSetTableAdapters.JogosTableAdapter
    Friend WithEvents EscolaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EscolaTableAdapter As PAP.Desporto_escolarDataSetTableAdapters.EscolaTableAdapter
    Friend WithEvents CodresultadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodjogoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResescolaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResadversarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FADataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CodjogoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrganizaçãoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodmodalidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EscalãoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GéneroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SérieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodescolaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
