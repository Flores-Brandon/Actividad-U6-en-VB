Imports System.IO

Public Class Form1



    Private Const FILENAME As String = "Libros.dat"

    Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub btnMostrar_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub btnMostrar_Click_1(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            'Abrir el archivo binario para lectura
            Using archivo As New FileStream(FILENAME, FileMode.Open, FileAccess.Read)
                ' Leer el archivo y mostrar las películas guardadas
                Dim lector As New BinaryReader(archivo)

                While archivo.Position < archivo.Length
                    Dim libro As New Libros
                    libro.Deserializar(lector)
                    MessageBox.Show(libro.ToString())
                End While
            End Using

        Catch ex As FileNotFoundException
            MessageBox.Show("No se encontró el archivo de Libros.")
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar leer el archivo de Libros: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'Crear un objeto de Libros a partir de la informmacion por el usuario
            Dim libro As New Libros(txtLibro.Text, txtDirector.Text, Integer.Parse(txtAño.Text))

            'Abrir el archivo binario para escritura (creando uno nuevo si no existe)
            Using archivo As New FileStream(FILENAME, FileMode.Append, FileAccess.Write)
                ' Serializar el objeto de Libros y escribirlo en el archivo
                Dim escritor As New BinaryWriter(archivo)
                libro.Serializar(escritor)
            End Using

            MessageBox.Show("El libro ha sido guardada correctamente.")
        Catch ex As FormatException
            MessageBox.Show("El año ingresado no es un número válido.")
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al intentar guardar el libro: " & ex.Message)
        End Try
    End Sub
End Class

