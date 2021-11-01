<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtExtranjero = New System.Windows.Forms.RadioButton()
        Me.rbtGuatemalteco = New System.Windows.Forms.RadioButton()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRecorrido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEquipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbEtapa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnLimpiarEstadisticas = New System.Windows.Forms.Button()
        Me.btnLimpiarVectores = New System.Windows.Forms.Button()
        Me.btnLimpiarEntradas = New System.Windows.Forms.Button()
        Me.btnEstadisticas = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblE1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTTeam = New System.Windows.Forms.Label()
        Me.lblRTeam = New System.Windows.Forms.Label()
        Me.lblTCycling = New System.Windows.Forms.Label()
        Me.lblRCycling = New System.Windows.Forms.Label()
        Me.lblTMovistar = New System.Windows.Forms.Label()
        Me.lblRMovistar = New System.Windows.Forms.Label()
        Me.lblTSky = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRSky = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbConsultar = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtTiempo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRecorrido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbEquipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbEtapa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtExtranjero)
        Me.GroupBox2.Controls.Add(Me.rbtGuatemalteco)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 55)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nacionalidad"
        '
        'rbtExtranjero
        '
        Me.rbtExtranjero.AutoSize = True
        Me.rbtExtranjero.Location = New System.Drawing.Point(110, 22)
        Me.rbtExtranjero.Name = "rbtExtranjero"
        Me.rbtExtranjero.Size = New System.Drawing.Size(77, 19)
        Me.rbtExtranjero.TabIndex = 1
        Me.rbtExtranjero.TabStop = True
        Me.rbtExtranjero.Text = "Extranjero"
        Me.rbtExtranjero.UseVisualStyleBackColor = True
        '
        'rbtGuatemalteco
        '
        Me.rbtGuatemalteco.AutoSize = True
        Me.rbtGuatemalteco.Location = New System.Drawing.Point(7, 23)
        Me.rbtGuatemalteco.Name = "rbtGuatemalteco"
        Me.rbtGuatemalteco.Size = New System.Drawing.Size(99, 19)
        Me.rbtGuatemalteco.TabIndex = 0
        Me.rbtGuatemalteco.TabStop = True
        Me.rbtGuatemalteco.Text = "Guatemalteco"
        Me.rbtGuatemalteco.UseVisualStyleBackColor = True
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(271, 52)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(100, 23)
        Me.txtTiempo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(185, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tiempo (min)"
        '
        'txtRecorrido
        '
        Me.txtRecorrido.Location = New System.Drawing.Point(271, 20)
        Me.txtRecorrido.Name = "txtRecorrido"
        Me.txtRecorrido.Size = New System.Drawing.Size(100, 23)
        Me.txtRecorrido.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "km recorridos"
        '
        'cmbEquipo
        '
        Me.cmbEquipo.FormattingEnabled = True
        Me.cmbEquipo.Location = New System.Drawing.Point(57, 49)
        Me.cmbEquipo.Name = "cmbEquipo"
        Me.cmbEquipo.Size = New System.Drawing.Size(121, 23)
        Me.cmbEquipo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Equipo"
        '
        'cmbEtapa
        '
        Me.cmbEtapa.FormattingEnabled = True
        Me.cmbEtapa.Location = New System.Drawing.Point(57, 20)
        Me.cmbEtapa.Name = "cmbEtapa"
        Me.cmbEtapa.Size = New System.Drawing.Size(121, 23)
        Me.cmbEtapa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Etapa"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.btnOrdenar)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.btnActualizar)
        Me.GroupBox3.Controls.Add(Me.btnConsultar)
        Me.GroupBox3.Controls.Add(Me.btnLimpiarEstadisticas)
        Me.GroupBox3.Controls.Add(Me.btnLimpiarVectores)
        Me.GroupBox3.Controls.Add(Me.btnLimpiarEntradas)
        Me.GroupBox3.Controls.Add(Me.btnEstadisticas)
        Me.GroupBox3.Controls.Add(Me.btnMostrar)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(604, 82)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(467, 52)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(303, 51)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(157, 23)
        Me.btnOrdenar.TabIndex = 9
        Me.btnOrdenar.Text = "Ordenar Ascendentemente"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(221, 52)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(139, 51)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(57, 52)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 6
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnLimpiarEstadisticas
        '
        Me.btnLimpiarEstadisticas.Location = New System.Drawing.Point(475, 22)
        Me.btnLimpiarEstadisticas.Name = "btnLimpiarEstadisticas"
        Me.btnLimpiarEstadisticas.Size = New System.Drawing.Size(119, 23)
        Me.btnLimpiarEstadisticas.TabIndex = 5
        Me.btnLimpiarEstadisticas.Text = "Limpiar Estadísticas"
        Me.btnLimpiarEstadisticas.UseVisualStyleBackColor = True
        '
        'btnLimpiarVectores
        '
        Me.btnLimpiarVectores.Location = New System.Drawing.Point(364, 22)
        Me.btnLimpiarVectores.Name = "btnLimpiarVectores"
        Me.btnLimpiarVectores.Size = New System.Drawing.Size(105, 23)
        Me.btnLimpiarVectores.TabIndex = 4
        Me.btnLimpiarVectores.Text = "Limpiar Vectores"
        Me.btnLimpiarVectores.UseVisualStyleBackColor = True
        '
        'btnLimpiarEntradas
        '
        Me.btnLimpiarEntradas.Location = New System.Drawing.Point(253, 23)
        Me.btnLimpiarEntradas.Name = "btnLimpiarEntradas"
        Me.btnLimpiarEntradas.Size = New System.Drawing.Size(105, 23)
        Me.btnLimpiarEntradas.TabIndex = 3
        Me.btnLimpiarEntradas.Text = "Limpiar Entradas"
        Me.btnLimpiarEntradas.UseVisualStyleBackColor = True
        '
        'btnEstadisticas
        '
        Me.btnEstadisticas.Location = New System.Drawing.Point(170, 23)
        Me.btnEstadisticas.Name = "btnEstadisticas"
        Me.btnEstadisticas.Size = New System.Drawing.Size(75, 23)
        Me.btnEstadisticas.TabIndex = 2
        Me.btnEstadisticas.Text = "Estadísticas"
        Me.btnEstadisticas.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(89, 23)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(7, 23)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 255)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(604, 201)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Etapa"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Equipo"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Recorrido"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tiempo"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Penalización"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Tiempo Total"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Nacionalidad"
        Me.Column7.Name = "Column7"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblE1)
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 462)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(604, 170)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Estadísticas"
        '
        'lblE1
        '
        Me.lblE1.AutoSize = True
        Me.lblE1.Location = New System.Drawing.Point(259, 22)
        Me.lblE1.Name = "lblE1"
        Me.lblE1.Size = New System.Drawing.Size(13, 15)
        Me.lblE1.TabIndex = 9
        Me.lblE1.Text = "0"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.70833!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.29167!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTTeam, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRTeam, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTCycling, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRCycling, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTMovistar, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRMovistar, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTSky, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRSky, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.81395!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.18605!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(320, 104)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'lblTTeam
        '
        Me.lblTTeam.AutoSize = True
        Me.lblTTeam.Location = New System.Drawing.Point(203, 83)
        Me.lblTTeam.Name = "lblTTeam"
        Me.lblTTeam.Size = New System.Drawing.Size(13, 15)
        Me.lblTTeam.TabIndex = 16
        Me.lblTTeam.Text = "0"
        '
        'lblRTeam
        '
        Me.lblRTeam.AutoSize = True
        Me.lblRTeam.Location = New System.Drawing.Point(88, 83)
        Me.lblRTeam.Name = "lblRTeam"
        Me.lblRTeam.Size = New System.Drawing.Size(13, 15)
        Me.lblRTeam.TabIndex = 15
        Me.lblRTeam.Text = "0"
        '
        'lblTCycling
        '
        Me.lblTCycling.AutoSize = True
        Me.lblTCycling.Location = New System.Drawing.Point(203, 63)
        Me.lblTCycling.Name = "lblTCycling"
        Me.lblTCycling.Size = New System.Drawing.Size(13, 15)
        Me.lblTCycling.TabIndex = 14
        Me.lblTCycling.Text = "0"
        '
        'lblRCycling
        '
        Me.lblRCycling.AutoSize = True
        Me.lblRCycling.Location = New System.Drawing.Point(88, 63)
        Me.lblRCycling.Name = "lblRCycling"
        Me.lblRCycling.Size = New System.Drawing.Size(13, 15)
        Me.lblRCycling.TabIndex = 13
        Me.lblRCycling.Text = "0"
        '
        'lblTMovistar
        '
        Me.lblTMovistar.AutoSize = True
        Me.lblTMovistar.Location = New System.Drawing.Point(203, 45)
        Me.lblTMovistar.Name = "lblTMovistar"
        Me.lblTMovistar.Size = New System.Drawing.Size(13, 15)
        Me.lblTMovistar.TabIndex = 12
        Me.lblTMovistar.Text = "0"
        '
        'lblRMovistar
        '
        Me.lblRMovistar.AutoSize = True
        Me.lblRMovistar.Location = New System.Drawing.Point(88, 45)
        Me.lblRMovistar.Name = "lblRMovistar"
        Me.lblRMovistar.Size = New System.Drawing.Size(13, 15)
        Me.lblRMovistar.TabIndex = 11
        Me.lblRMovistar.Text = "0"
        '
        'lblTSky
        '
        Me.lblTSky.AutoSize = True
        Me.lblTSky.Location = New System.Drawing.Point(203, 25)
        Me.lblTSky.Name = "lblTSky"
        Me.lblTSky.Size = New System.Drawing.Size(13, 15)
        Me.lblTSky.TabIndex = 10
        Me.lblTSky.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 15)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Pro Team"
        '
        'lblRSky
        '
        Me.lblRSky.AutoSize = True
        Me.lblRSky.Location = New System.Drawing.Point(88, 25)
        Me.lblRSky.Name = "lblRSky"
        Me.lblRSky.Size = New System.Drawing.Size(13, 15)
        Me.lblRSky.TabIndex = 6
        Me.lblRSky.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Movistar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "RECORRIDO (km)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(203, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Tiempo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Sky"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "EQUIPO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Pro Cycling"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(245, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Corredores guatemaltecos con más de 45 km"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmbConsultar)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 196)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(179, 53)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Consultar"
        '
        'cmbConsultar
        '
        Me.cmbConsultar.FormattingEnabled = True
        Me.cmbConsultar.Location = New System.Drawing.Point(48, 19)
        Me.cmbConsultar.Name = "cmbConsultar"
        Me.cmbConsultar.Size = New System.Drawing.Size(121, 23)
        Me.cmbConsultar.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Etapa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(627, 644)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Etapas / Vuelta Ciclista a Guatemala"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtExtranjero As RadioButton
    Friend WithEvents rbtGuatemalteco As RadioButton
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRecorrido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbEquipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEtapa As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLimpiarEstadisticas As Button
    Friend WithEvents btnLimpiarVectores As Button
    Friend WithEvents btnLimpiarEntradas As Button
    Friend WithEvents btnEstadisticas As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblRSky As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTTeam As Label
    Friend WithEvents lblRTeam As Label
    Friend WithEvents lblTCycling As Label
    Friend WithEvents lblRCycling As Label
    Friend WithEvents lblTMovistar As Label
    Friend WithEvents lblRMovistar As Label
    Friend WithEvents lblTSky As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents lblE1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cmbConsultar As ComboBox
    Friend WithEvents Label10 As Label
End Class
