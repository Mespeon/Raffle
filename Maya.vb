Imports MySql.Data.MySqlClient
Module Maya

    Public sqlConnection As New MySqlConnection
    Public sqlCommand As New MySqlCommand
    Public sqlDataReader As MySqlDataReader
    Public sqlQuery As String

    Public randomizer As New Random
    Public randomNumber As Integer

    Public Sub connect()
        If sqlConnection.State = ConnectionState.Closed Then
            Try
                sqlConnection.ConnectionString = "SERVER = localhost; DATABASE = raffle; UID = root; PWD="
                sqlConnection.Open()
                Main.lblDBConnMarker.Text = "Online"
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Main.Close()
            End Try
        End If
    End Sub

    Public Sub disconnect()
        If sqlConnection.State = ConnectionState.Open Then
            sqlConnection.Close()
        End If
    End Sub

    Public Sub closeEverything()
        sqlCommand.Dispose()
        sqlDataReader.Close()
        sqlConnection.Close()
    End Sub

    Public Sub setDefaults()

    End Sub

    'Generate random number for row lock
    Public Sub generateRandomRow()
        randomNumber = randomizer.Next(1, 5) 'Set to 1 to (n+1) in order to cover every available row
        checkIfPicked(randomNumber)
    End Sub

    'Check if row is picked: if NO, update and set it as winner; if YES, generate another random number.
    Public Sub checkIfPicked(randomizedNumber)
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            'Fully fair SQL query for row lock
            sqlQuery = "SELECT rowID, studentNumber FROM participants WHERE rowID = " + randomizedNumber.ToString + " AND isPicked = 'NO'"

            With sqlCommand
                .Connection = sqlConnection
                .CommandText = sqlQuery
            End With

            sqlDataReader = sqlCommand.ExecuteReader
            If sqlDataReader.HasRows Then
                Dim row As Integer = 0
                Dim studentNumber As Integer = 0
                'If the query hits a match, the first (and only) result will be set as the winner
                While sqlDataReader.Read()
                    row = sqlDataReader.Item("rowID")
                    studentNumber = sqlDataReader.Item("studentNumber")
                    MessageBox.Show(row.ToString + " " + studentNumber.ToString)
                End While
                closeEverything()   'Close this method's reader and connection first before exiting
                setWinner(row, studentNumber)    'Call method for setting the winning row
            Else
                'Will be executed if the query above hits no match
                sqlDataReader.Close() 'Close the other data reader first

                'Check first if there are still rows available for picking
                sqlQuery = "SELECT rowID FROM participants WHERE isPicked = 'NO'"

                Try
                    With sqlCommand
                        .Connection = sqlConnection
                        .CommandText = sqlQuery
                    End With

                    sqlDataReader = sqlCommand.ExecuteReader
                    If sqlDataReader.HasRows Then
                        'If there are still pickable rows, generate another row number
                        closeEverything()
                        generateRandomRow()
                    Else
                        'If there are none, simply show a message that no one is available for picking 
                        MessageBox.Show("No more rows to pick.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        closeEverything()
                    End If

                    closeEverything()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString, "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    closeEverything()
                End Try
            End If

            closeEverything()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            closeEverything()
        End Try
    End Sub

    Public Sub setWinner(row, studentNumber)
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        'Update Winning Row FIRST before doing anything else
        Try
            sqlQuery = "UPDATE participants SET isPicked ='YES' WHERE rowID = " + row.ToString + " AND studentNumber = " + studentNumber.ToString

            With sqlCommand
                .Connection = sqlConnection
                .CommandText = sqlQuery
            End With

            sqlCommand.ExecuteNonQuery()
            closeEverything()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            closeEverything()
        End Try

        'Begin effects for randomization
        'MessageBox.Show((studentNumber.ToString).Length) 'Return student number length for testing purposes

        'Get year substring
        Dim student As String = studentNumber.ToString
        Dim yearSubstring As String = student.Substring(0, 4)
        'Set year string picture box image
        Select Case yearSubstring
            Case "2010"
                Main.pbxYearString.Image = My.Resources._2010

            Case "2011"
                Main.pbxYearString.Image = My.Resources._2011

            Case "2012"
                Main.pbxYearString.Image = My.Resources._2012

            Case "2013"
                Main.pbxYearString.Image = My.Resources._2013

            Case "2014"
                Main.pbxYearString.Image = My.Resources._2014

            Case "2015"
                Main.pbxYearString.Image = My.Resources._2015

            Case "2016"
                Main.pbxYearString.Image = My.Resources._2016

            Case "2017"
                Main.pbxYearString.Image = My.Resources._2017

            Case "2018"
                Main.pbxYearString.Image = My.Resources._2018
        End Select

        'Get student number substring at specific positions
        'Remap this to timer tick for more thrills
        Try
            Dim digits(5) As String
            Dim ctr As Integer = 0
            For position = 4 To 8 Step 1
                Dim numberSubstring = student.Substring(position, 1) 'Get the substring character at position specified by loop
                digits(ctr) = numberSubstring   'Save it to an array
                ctr += 1
            Next

            'Set individual digits to individual boxes
            Dim resourcePath = "C:\Users\Mark Nolledo\Documents\Visual Studio 2015\Projects\Randomizer\Randomizer\Resources\"
            Main.pbxDigit01.ImageLocation = resourcePath + digits(0) + ".png"
            Main.pbxDigit02.ImageLocation = resourcePath + digits(1) + ".png"
            Main.pbxDigit03.ImageLocation = resourcePath + digits(2) + ".png"
            Main.pbxDigit04.ImageLocation = resourcePath + digits(3) + ".png"
            Main.pbxDigit05.ImageLocation = resourcePath + digits(4) + ".png"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub getAllRows()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "SELECT * FROM participants WHERE isPicked = 'NO' ORDER BY rowID ASC"

            With sqlCommand
                .Connection = sqlConnection
                .CommandText = sqlQuery
            End With

            sqlDataReader = sqlCommand.ExecuteReader
            If sqlDataReader.HasRows Then
                While sqlDataReader.Read()
                    Dim row As Integer = sqlDataReader.Item("rowID")
                    Dim student As Integer = sqlDataReader.Item("studentNumber")
                    MessageBox.Show(row & " " & " " & student)
                End While
            Else
                MessageBox.Show("No retrievable data.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub
End Module
