Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cmbEtapa.Text = "" Then
            MsgBox("Seleccione la Etapa",, "Error")
            Exit Sub
        End If
        If cmbEquipo.Text = "" Then
            MsgBox("Seleccione Equipo",, "Error")
            Exit Sub
        End If
        If txtRecorrido.Text = "" Or IsNumeric(txtRecorrido.Text) = False Then
            MsgBox("Ingrese la cantidad de km recorridos",, "Error")
            Exit Sub
        End If
        If txtTiempo.Text = "" Or IsNumeric(txtTiempo.Text) = False Then
            MsgBox("Ingrese el tiempo del recorrdio en minutos",, "Error")
            Exit Sub
        End If
        If rbtGuatemalteco.Checked Or rbtExtranjero.Checked Then
        Else
            MsgBox("seleccione la nacionalidad",, "Error")
            Exit Sub
        End If

        If Existente() Then
            Exit Sub
        End If

        If indice < 12 Then
            Guardar(indice)
            indice = indice + 1
        Else
            MsgBox("Memoria llena",, "Error")
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Mostrar()
    End Sub

    Private Sub btnEstadisticas_Click(sender As Object, e As EventArgs) Handles btnEstadisticas.Click
        Estadisticas()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If Consulta(cmbConsultar.Text) Then
            MsgBox("Consulta Exitosa",, "Mensaje")
        Else
            MsgBox("Lo sentimos, no se encuentra este número de etapa registrado aún",, "Mensaje")
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If control > -1 Then
            Guardar(control)
            control = -1
            MsgBox("El registro se actualizó exitosamente, pulse el botón mostrar para ver los cambios.",, "Mensaje")
        Else
            MsgBox("Realice primero la consulta y luego actualice la etapa consultada",, "Error")
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If control > -1 Then
            Eliminar(control)
            control = -1
            MsgBox("El registro se eliminó exitosamente, pulse el botón mostrar para ver los cambios.",, "Mensaje")
        Else
            MsgBox("Realice primero la consulta y luego elimine la etapa consultada",, "Error")
        End If

    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        Ordenar()
    End Sub

    Private Sub btnLimpiarEntradas_Click(sender As Object, e As EventArgs) Handles btnLimpiarEntradas.Click
        LimpiarEntradas()
    End Sub

    Private Sub btnLimpiarVectores_Click(sender As Object, e As EventArgs) Handles btnLimpiarVectores.Click
        LimpiarVectores()
    End Sub

    Private Sub btnLimpiarEstadisticas_Click(sender As Object, e As EventArgs) Handles btnLimpiarEstadisticas.Click
        LimpiarEstadisticas()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea Salir", vbYesNo, "Mensaje") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
End Class
