Imports System.Math
Module Module1
    'sanciones
    Public Const P120 As Integer = 30
    Public Const P140 As Integer = 40
    Public Const P160 As Integer = 50
    Public Const PMovistar As Integer = -15
    Public Const PTeam As Integer = -10
    'Vectores
    Public Vetapa(11) As String
    Public Vequipo(11) As String
    Public Vrecorrido(11) As Double
    Public Vtiempo(11) As Double
    Public Vpenalizacion(11) As Integer
    Public VtiempoTotal(11) As Double
    Public Vnacionalidad(11) As String
    Public indice As Integer = 0
    'Para procesos de actualizar y eliminar, variable control
    Public control As Integer = -1

    Sub Cargar()
        For i = 1 To 12 Step 1
            Form1.cmbEtapa.Items.Add(i)
            Form1.cmbConsultar.Items.Add(i)
        Next

        Form1.cmbEquipo.Items.Add("Sky")
        Form1.cmbEquipo.Items.Add("Movistar")
        Form1.cmbEquipo.Items.Add("Pro Cycling")
        Form1.cmbEquipo.Items.Add("Pro Team")
    End Sub

    Function Existente() As Boolean
        Dim i As Byte = 0

        While i < indice

            If Vetapa(i) = Form1.cmbEtapa.Text Then
                MsgBox("Este etapa ya ha sido registrada",, "Error")
                Form1.cmbEtapa.Text = ""
                Form1.cmbEtapa.Focus()
                Existente = True
                Return Existente
            Else
                i = i + 1
            End If
        End While

        Existente = False
        Return Existente
    End Function

    Sub Guardar(ByRef fila As Byte)
        Vetapa(fila) = Form1.cmbEtapa.Text
        Vequipo(fila) = Form1.cmbEquipo.Text
        Vrecorrido(fila) = Val(Form1.txtRecorrido.Text)
        Vtiempo(fila) = Val(Form1.txtTiempo.Text)
        Vpenalizacion(fila) = Fpenalizacion(Vtiempo(fila), Vequipo(fila))
        VtiempoTotal(fila) = Val(Vtiempo(fila)) + Val(Vpenalizacion(fila))
        Vnacionalidad(fila) = Fnacionalidad()


    End Sub

    Function Fpenalizacion(ByVal tiempo As Double, ByVal equipo As String) As Integer
        Select Case tiempo
            Case < 85
                Select Case equipo
                    Case "Movistar"
                        Fpenalizacion = PMovistar
                    Case "Pro Team"
                        Fpenalizacion = PTeam
                    Case Else
                        Fpenalizacion = 0
                End Select
            Case 120.01 To 140
                Fpenalizacion = P120
            Case 140.01 To 160
                Fpenalizacion = P140
            Case > 160
                Fpenalizacion = P160
            Case Else
                Fpenalizacion = 0
        End Select
        Return Fpenalizacion
    End Function

    Function Fnacionalidad() As String
        If Form1.rbtGuatemalteco.Checked Then
            Fnacionalidad = "guatemalteco"
        Else
            Fnacionalidad = "extranjero"
        End If
        Return Fnacionalidad
    End Function

    Sub Mostrar()
        Form1.DataGridView1.Rows.Clear()

        For i = 0 To indice - 1 Step 1
            Form1.DataGridView1.Rows.Add(Vetapa(i), Vequipo(i), Vrecorrido(i), Vtiempo(i), Vpenalizacion(i), VtiempoTotal(i), Vnacionalidad(i))
        Next
    End Sub

    Sub Estadisticas()
        Dim r1 As Byte = 0
        Dim Resultados(3, 1) As Double

        For i = 0 To indice - 1
            Select Case Vnacionalidad(i)
                Case "guatemalteco"
                    Select Case Vrecorrido(i)
                        Case > 45
                            r1 = r1 + 1
                    End Select
            End Select
            Select Case Vequipo(i)
                Case "Sky"
                    Resultados(0, 0) = Resultados(0, 0) + Vrecorrido(i)
                    Resultados(0, 1) = Resultados(0, 1) + VtiempoTotal(i)
                Case "Movistar"
                    Resultados(1, 0) = Resultados(1, 0) + Vrecorrido(i)
                    Resultados(1, 1) = Resultados(1, 1) + VtiempoTotal(i)
                Case "Pro Cycling"
                    Resultados(2, 0) = Resultados(2, 0) + Vrecorrido(i)
                    Resultados(2, 1) = Resultados(2, 1) + VtiempoTotal(i)
                Case "Pro Team"
                    Resultados(3, 0) = Resultados(3, 0) + Vrecorrido(i)
                    Resultados(3, 1) = Resultados(3, 1) + VtiempoTotal(i)
            End Select
        Next

        Form1.lblE1.Text = r1.ToString
        Form1.lblRSky.Text = Resultados(0, 0).ToString
        Form1.lblTSky.Text = Resultados(0, 1).ToString
        Form1.lblRMovistar.Text = Resultados(1, 0).ToString
        Form1.lblTMovistar.Text = Resultados(1, 1).ToString
        Form1.lblRCycling.Text = Resultados(2, 0).ToString
        Form1.lblTCycling.Text = Resultados(2, 1).ToString
        Form1.lblRTeam.Text = Resultados(3, 0).ToString
        Form1.lblTTeam.Text = Resultados(3, 1).ToString
    End Sub

    Function Consulta(ByRef etapa As String)
        Dim i As Byte = 0

        While i < indice
            If Vetapa(i) = etapa Then
                Form1.DataGridView1.Rows.Clear()
                Form1.cmbEtapa.Text = Vetapa(i)
                Form1.cmbEquipo.Text = Vequipo(i)
                Form1.txtRecorrido.Text = Vrecorrido(i)
                Form1.txtTiempo.Text = Vtiempo(i)
                If Vnacionalidad(i) = "guatemalteco" Then
                    Form1.rbtGuatemalteco.Checked = True
                    Form1.rbtExtranjero.Checked = False
                Else
                    Form1.rbtExtranjero.Checked = True
                    Form1.rbtGuatemalteco.Checked = False
                End If
                Form1.DataGridView1.Rows.Add(Vetapa(i), Vequipo(i), Vrecorrido(i), Vtiempo(i), Vpenalizacion(i), VtiempoTotal(i), Vnacionalidad(i))
                Consulta = True
                control = i
                Return Consulta
            Else
                i = i + 1
            End If
        End While
        control = -1
        Consulta = False
        Return Consulta
    End Function

    Sub Eliminar(ByRef fila As Byte)
        Dim i As Byte
        Dim final As Byte
        'Evitar error para el ciclo for
        If indice = 1 Then
            final = 0
        Else
            final = indice - 2
        End If

        'Corrimiento de filas
        For i = fila To final
            Vetapa(i) = Vetapa(i + 1)
            Vequipo(i) = Vequipo(i + 1)
            Vrecorrido(i) = Vrecorrido(i + 1)
            Vtiempo(i) = Vtiempo(i + 1)
            Vpenalizacion(i) = Vpenalizacion(i + 1)
            VtiempoTotal(i) = VtiempoTotal(i + 1)
            Vnacionalidad(i) = Vnacionalidad(i + 1)
            'Evitar que el indice quede en 1 por ciclo for
            If indice = 1 Then
                Exit For
            End If
        Next

        'eliminar la última fila duplicada en vectores
        Vetapa(indice - 1) = Nothing
        Vequipo(indice - 1) = Nothing
        Vrecorrido(indice - 1) = Nothing
        Vtiempo(indice - 1) = Nothing
        Vpenalizacion(indice - 1) = Nothing
        VtiempoTotal(indice - 1) = Nothing
        Vnacionalidad(indice - 1) = Nothing
        'Reasignar el valor del indice
        indice = i
        control = -1
    End Sub

    Sub ordenar()
        Form1.DataGridView1.Rows.Clear()
        For i = 1 To 12
            For j = 0 To indice - 1
                If Vetapa(j) = i Then
                    Form1.DataGridView1.Rows.Add(Vetapa(j), Vequipo(j), Vrecorrido(j), Vtiempo(j), Vpenalizacion(j), VtiempoTotal(j), Vnacionalidad(j))
                End If
            Next


        Next
    End Sub

    Sub LimpiarEntradas()
        Form1.cmbEtapa.Text = ""
        Form1.cmbEquipo.Text = ""
        Form1.txtRecorrido.Clear()
        Form1.txtTiempo.Clear()
        Form1.rbtGuatemalteco.Checked = False
        Form1.rbtExtranjero.Checked = False
        Form1.cmbConsultar.Text = ""
        Form1.cmbEtapa.Focus()
    End Sub

    Sub LimpiarVectores()
        Form1.DataGridView1.Rows.Clear()
        For i = 0 To indice - 1
            Vetapa(i) = Nothing
            Vequipo(i) = Nothing
            Vrecorrido(i) = Nothing
            Vtiempo(i) = Nothing
            Vpenalizacion(i) = Nothing
            VtiempoTotal(i) = Nothing
            Vnacionalidad(i) = Nothing
            indice = 0
        Next
    End Sub

    Sub LimpiarEstadisticas()
        Form1.lblE1.Text = 0
        Form1.lblRSky.Text = 0
        Form1.lblTSky.Text = 0
        Form1.lblRMovistar.Text = 0
        Form1.lblTMovistar.Text = 0
        Form1.lblRCycling.Text = 0
        Form1.lblTCycling.Text = 0
        Form1.lblRTeam.Text = 0
        Form1.lblTTeam.Text = 0
    End Sub
End Module
