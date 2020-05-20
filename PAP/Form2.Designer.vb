<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.JogosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Desporto_escolarDataSet = New PAP.Desporto_escolarDataSet()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.EscolaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ModalidadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DesportoEscolarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodjogoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganizaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodmodalidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EscalãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GéneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SérieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodescolaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JogosTableAdapter = New PAP.Desporto_escolarDataSetTableAdapters.JogosTableAdapter()
        Me.ModalidadeTableAdapter = New PAP.Desporto_escolarDataSetTableAdapters.ModalidadeTableAdapter()
        Me.TableAdapterManager = New PAP.Desporto_escolarDataSetTableAdapters.TableAdapterManager()
        Me.EscolaTableAdapter = New PAP.Desporto_escolarDataSetTableAdapters.EscolaTableAdapter()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        CType(Me.JogosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desporto_escolarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscolaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModalidadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JogosBindingSource, "Hora", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "t"))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(873, 59)
        Me.MaskedTextBox1.Mask = "00:00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(63, 25)
        Me.MaskedTextBox1.TabIndex = 80
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'JogosBindingSource
        '
        Me.JogosBindingSource.DataMember = "Jogos"
        Me.JogosBindingSource.DataSource = Me.Desporto_escolarDataSet
        '
        'Desporto_escolarDataSet
        '
        Me.Desporto_escolarDataSet.DataSetName = "Desporto_escolarDataSet"
        Me.Desporto_escolarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Button7.Location = New System.Drawing.Point(766, 217)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 88)
        Me.Button7.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.Button7, "Cancelar Registo")
        Me.Button7.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JogosBindingSource, "Série", True))
        Me.TextBox5.Location = New System.Drawing.Point(399, 283)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(95, 25)
        Me.TextBox5.TabIndex = 77
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JogosBindingSource, "Fase", True))
        Me.TextBox4.Location = New System.Drawing.Point(298, 283)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(82, 25)
        Me.TextBox4.TabIndex = 78
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JogosBindingSource, "Género", True))
        Me.ComboBox5.DisplayMember = "Género"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.ComboBox5.Location = New System.Drawing.Point(163, 283)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(112, 25)
        Me.ComboBox5.TabIndex = 76
        Me.ComboBox5.ValueMember = "Género"
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JogosBindingSource, "Escalão", True))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Infantil", "Iniciado", "Juvenil", "Júnior"})
        Me.ComboBox4.Location = New System.Drawing.Point(22, 283)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(107, 25)
        Me.ComboBox4.TabIndex = 75
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.JogosBindingSource, "codescola", True))
        Me.ComboBox3.DataSource = Me.EscolaBindingSource
        Me.ComboBox3.DisplayMember = "Nome"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(873, 126)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(373, 25)
        Me.ComboBox3.TabIndex = 74
        Me.ComboBox3.ValueMember = "codescola"
        '
        'EscolaBindingSource
        '
        Me.EscolaBindingSource.DataMember = "Escola"
        Me.EscolaBindingSource.DataSource = Me.Desporto_escolarDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.JogosBindingSource, "codmodalidade", True))
        Me.ComboBox2.DataSource = Me.ModalidadeBindingSource
        Me.ComboBox2.DisplayMember = "codmodalidade"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(422, 169)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(104, 25)
        Me.ComboBox2.TabIndex = 73
        Me.ComboBox2.ValueMember = "codmodalidade"
        '
        'ModalidadeBindingSource
        '
        Me.ModalidadeBindingSource.DataMember = "Modalidade"
        Me.ModalidadeBindingSource.DataSource = Me.Desporto_escolarDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JogosBindingSource, "Tipo", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Amigável", "Torneio"})
        Me.ComboBox1.Location = New System.Drawing.Point(299, 169)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(99, 25)
        Me.ComboBox1.TabIndex = 72
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JogosBindingSource, "codjogo", True))
        Me.TextBox2.Location = New System.Drawing.Point(22, 169)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 25)
        Me.TextBox2.TabIndex = 70
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JogosBindingSource, "Local", True))
        Me.TextBox1.Location = New System.Drawing.Point(873, 95)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 25)
        Me.TextBox1.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(804, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 22)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Hora"
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Location = New System.Drawing.Point(22, 44)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 80)
        Me.Button6.TabIndex = 67
        Me.ToolTip1.SetToolTip(Me.Button6, "Voltar")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(322, 134)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 22)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Tipo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(804, 123)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 22)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Escola"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(804, 89)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 22)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Local"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(804, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 22)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Data"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(418, 249)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 22)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Série"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(316, 249)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 22)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Fase"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(177, 249)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 22)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Género"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 22)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Escalão"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(418, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 22)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Modalidade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 22)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Organização"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 134)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 22)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Jogo"
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
        Me.Button2.Location = New System.Drawing.Point(541, 29)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 95)
        Me.Button2.TabIndex = 53
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
        Me.Button5.Location = New System.Drawing.Point(659, 217)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 88)
        Me.Button5.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.Button5, "Eliminar")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(536, 217)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 88)
        Me.Button1.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.Button1, "Gravar")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(478, 36)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 80)
        Me.Button3.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.Button3, "Anterior")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(621, 36)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 80)
        Me.Button4.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.Button4, "Seguinte")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesportoEscolarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 27)
        Me.MenuStrip1.TabIndex = 82
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DesportoEscolarToolStripMenuItem
        '
        Me.DesportoEscolarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DesportoEscolarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogosToolStripMenuItem})
        Me.DesportoEscolarToolStripMenuItem.Image = CType(resources.GetObject("DesportoEscolarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DesportoEscolarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DesportoEscolarToolStripMenuItem.Name = "DesportoEscolarToolStripMenuItem"
        Me.DesportoEscolarToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.DesportoEscolarToolStripMenuItem.Text = "Desporto Escolar"
        '
        'JogosToolStripMenuItem
        '
        Me.JogosToolStripMenuItem.Name = "JogosToolStripMenuItem"
        Me.JogosToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.JogosToolStripMenuItem.Text = "Jogos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodjogoDataGridViewTextBoxColumn, Me.OrganizaçãoDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.CodmodalidadeDataGridViewTextBoxColumn, Me.EscalãoDataGridViewTextBoxColumn, Me.GéneroDataGridViewTextBoxColumn, Me.FaseDataGridViewTextBoxColumn, Me.SérieDataGridViewTextBoxColumn, Me.CodescolaDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.LocalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JogosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 328)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1328, 384)
        Me.DataGridView1.TabIndex = 83
        '
        'CodjogoDataGridViewTextBoxColumn
        '
        Me.CodjogoDataGridViewTextBoxColumn.DataPropertyName = "codjogo"
        Me.CodjogoDataGridViewTextBoxColumn.HeaderText = "Jogo"
        Me.CodjogoDataGridViewTextBoxColumn.Name = "CodjogoDataGridViewTextBoxColumn"
        Me.CodjogoDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.TipoDataGridViewTextBoxColumn.Width = 115
        '
        'CodmodalidadeDataGridViewTextBoxColumn
        '
        Me.CodmodalidadeDataGridViewTextBoxColumn.DataPropertyName = "codmodalidade"
        Me.CodmodalidadeDataGridViewTextBoxColumn.HeaderText = "Modalidade"
        Me.CodmodalidadeDataGridViewTextBoxColumn.Name = "CodmodalidadeDataGridViewTextBoxColumn"
        Me.CodmodalidadeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodmodalidadeDataGridViewTextBoxColumn.Width = 115
        '
        'EscalãoDataGridViewTextBoxColumn
        '
        Me.EscalãoDataGridViewTextBoxColumn.DataPropertyName = "Escalão"
        Me.EscalãoDataGridViewTextBoxColumn.HeaderText = "Escalão"
        Me.EscalãoDataGridViewTextBoxColumn.Name = "EscalãoDataGridViewTextBoxColumn"
        Me.EscalãoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EscalãoDataGridViewTextBoxColumn.Width = 115
        '
        'GéneroDataGridViewTextBoxColumn
        '
        Me.GéneroDataGridViewTextBoxColumn.DataPropertyName = "Género"
        Me.GéneroDataGridViewTextBoxColumn.HeaderText = "Género"
        Me.GéneroDataGridViewTextBoxColumn.Name = "GéneroDataGridViewTextBoxColumn"
        Me.GéneroDataGridViewTextBoxColumn.ReadOnly = True
        Me.GéneroDataGridViewTextBoxColumn.Width = 115
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
        Me.CodescolaDataGridViewTextBoxColumn.Width = 300
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
        'JogosTableAdapter
        '
        Me.JogosTableAdapter.ClearBeforeFill = True
        '
        'ModalidadeTableAdapter
        '
        Me.ModalidadeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EscolaTableAdapter = Me.EscolaTableAdapter
        Me.TableAdapterManager.JogosTableAdapter = Me.JogosTableAdapter
        Me.TableAdapterManager.ModalidadeTableAdapter = Me.ModalidadeTableAdapter
        Me.TableAdapterManager.ResultadoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PAP.Desporto_escolarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EscolaTableAdapter
        '
        Me.EscolaTableAdapter.ClearBeforeFill = True
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JogosBindingSource, "Data", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(873, 32)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 25)
        Me.MaskedTextBox2.TabIndex = 84
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JogosBindingSource, "Organização", True))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"CLDE Setúbal"})
        Me.ComboBox6.Location = New System.Drawing.Point(154, 169)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox6.TabIndex = 85
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Jogos"
        CType(Me.JogosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desporto_escolarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscolaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModalidadeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DesportoEscolarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Desporto_escolarDataSet As PAP.Desporto_escolarDataSet
    Friend WithEvents JogosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JogosTableAdapter As PAP.Desporto_escolarDataSetTableAdapters.JogosTableAdapter
    Friend WithEvents ModalidadeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModalidadeTableAdapter As PAP.Desporto_escolarDataSetTableAdapters.ModalidadeTableAdapter
    Friend WithEvents TableAdapterManager As PAP.Desporto_escolarDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EscolaTableAdapter As PAP.Desporto_escolarDataSetTableAdapters.EscolaTableAdapter
    Friend WithEvents EscolaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CodjogoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
End Class
