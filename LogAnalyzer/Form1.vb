
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc



Public Class frmMain
    Inherits System.Windows.Forms.Form
    Dim filename1 As String ' Nimmt den Dateinamen auf

    Dim logfile() As String ' nimmt die Daten des Logfiles auf
    Dim Connectionstring As String
    Dim doc_id As String
    Dim DataTable As DataTable

    Private Property DataSource As BindingSource

    Sub FillAnyERPVersion(ByVal logfiledata, ByVal lines)
        Dim a As Integer = 1
        Dim pos As Integer = 0
        For a = 0 To lines
            pos = InStr(logfiledata(a), "anyERP Adapter")
            If pos > 0 Then
                tbVersion1.Text = Mid(logfiledata(a), pos + 15, 7)
                Exit For
            End If
            pos = InStr(logfiledata(a), "ErpConnectorServer")
            If pos > 0 Then
                tbVersion1.Text = Mid(logfiledata(a), pos + 19, 7)
                Exit For
            End If
        Next
    End Sub
    Sub FillDBConnection(ByVal logfiledata, ByVal lines)
        Dim a As Integer = 1
        Dim pos As Integer = 0
        For a = 1 To lines
            pos = InStr(logfiledata(a), "connstr' with value")
            If pos > 0 Then
                tbDBConnStr1.Text = Mid(logfiledata(a), pos + 21, Len(logfiledata(a)) - 21 - pos)
                Exit For
            End If
        Next a
        Connectionstring = tbDBConnStr1.Text
    End Sub
    Sub FillDocID(ByVal logfiledata, _
                  ByVal lines)
        Dim a As Integer = 1
        Dim pos As Integer = 0
        tbDoc_ID1.Text=""

        For a = 1 To lines
            pos = InStr(logfiledata(a), "'doc_id' with value")

            If pos > 0 Then
                tbDoc_ID1.Text = Mid(logfiledata(a), pos + 21, Len(logfiledata(a)) - 21 - pos - 1)
                Exit For
            End If
        Next a
        doc_id = tbDoc_ID1.Text
    End Sub
    Sub FillEnddate(ByVal logfiledata, ByVal lines)
        Dim tempstring As String
        'Check auf englisches oder deutsches Datumsformat
        If InStr(logfiledata(lines - 1), "/") > 0 Then
            tempstring = Microsoft.VisualBasic.Left(logfiledata(lines - 1), 22)
        Else
            tempstring = Microsoft.VisualBasic.Left(logfiledata(lines - 1), 19)
        End If
        tbEndzeit1.Text = tempstring
    End Sub

    Sub FillErrorBefore(ByVal logfiledata, ByVal lines)
        'Füllt das Feld "Zeilen vor dem Fehler"
        'Hierbei wird vom Auftreten des Fehler bis zum Anfang der betreffenden Transaktion zurückgegangen.
        Dim a As Integer = 1
        Dim pos_found As Integer = 0    ' Position des gefundenen Strings
        Dim pos_start As Integer = 0    ' start des auszugebenden Textes   
        Dim pos_end As Integer = 0       ' ende des auszugebenden Textes
        tbvorFehler1.Text = ""
        For a = 1 To lines
            If InStr(logfiledata(a), "Transaction received abort request") > 0 Then pos_found = a
        Next a
        'search start
        For a = pos_found To 1 Step -1
            If InStr(logfiledata(a), "-----------------------------") > 0 Then
                pos_start = a
                Exit For
            End If
        Next
        'search end
        For a = pos_found To lines
            If InStr(logfiledata(a), "-----------------------------") Then
                pos_end = a
                Exit For
            End If
        Next
        'Textausgabe
        If pos_found > 0 Then
            For a = pos_start To pos_end
                tbvorFehler1.Text = tbvorFehler1.Text + logfiledata(a) + Chr(13) + Chr(10)
            Next
        End If
    End Sub
    Sub FillErrorDate(ByVal logfiledata, ByVal lines)
        Dim tempstring As String = ""
        Dim a As Integer = 1
        'suche nach Fehlerzeile mit Check auf englisches oder deutsches Datumsformat
        For a = 1 To lines
            If InStr(logfiledata(a), "[ERROR  ]") > 0 Then
                If InStr(logfiledata(a), "/") > 0 Then
                    tempstring = Microsoft.VisualBasic.Left(logfiledata(a), 22)
                Else
                    tempstring = Microsoft.VisualBasic.Left(logfiledata(a), 19)
                End If
            End If
        Next a
        tbErrorzeit1.Text = tempstring
    End Sub
    Sub FillErrorText(ByVal logfiledata, ByVal lines)
        'Füllt das Feld "Fehlertext"
        'Hierbei wird vom Auftreten des Fehler bis zum Anfang der betreffenden Transaktion zurückgegangen.
        Dim a As Integer = 1
        Dim pos_start As Integer = 0    ' start des auszugebenden Textes   
        Dim pos_end As Integer = 0      ' ende des auszugebenden Textes
        tbFehlertext1.Text = ""
        'search start
        For a = 1 To lines
            If InStr(logfiledata(a), "-- Error Details --") > 0 Then pos_start = a
        Next a
        'Textausgabe bis zum Ende des Fehlers
        If pos_start > 0 Then
            For a = pos_start To lines
                tbFehlertext1.Text = tbFehlertext1.Text + logfiledata(a) + Chr(13) + Chr(10)
                If InStr(logfiledata(a + 2), "at BasWare") Then Exit For
            Next
        End If
    End Sub
    Sub FillFilename(ByVal filename1)
        Dim start_filename2 As Integer = filename1.lastindexof("\")
        Dim tempstring As String
        tempstring = Mid(filename1, start_filename2 + 2)
        tbFilename1.Text = tempstring
    End Sub
    Sub FillLinecounter(ByVal lines)
        tbZeilenzahl1.Text = lines
    End Sub
    Sub FillParameter(ByVal logfiledata, ByVal lines)
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim znr As Integer = 0
        Dim pos_variable1 As Integer = 0    ' Position der Variable
        Dim pos_variable2 As Integer = 0    ' Position der Variable
        Dim pos_value As Integer = 0        ' Position des Wertes
        Dim variable_txt As String          ' Variable
        Dim value_txt As String             ' Wert
        Dim dt As New DataTable()
        Dim dr As DataRow = dt.NewRow()
        dt.Columns.Add("Nr")                ' Zeilennummer
        dt.Columns.Add("Parameter")         ' Überschrift im Data-Grid
        dt.Columns.Add("Wert")              ' Überschrift im Data-Grid
        ' loopt durch alle Logfile-Zeilen und füllt das Grid
        For a = 1 To lines
            pos_variable1 = InStr(logfiledata(a), "Loading Parameter '")
            pos_variable2 = InStr(logfiledata(a), "Loaded input parameter '")
            If pos_variable1 > 0 Then
                pos_value = InStr(logfiledata(a), "with value '")
                variable_txt = Mid(logfiledata(a), pos_variable1 + 19, pos_value - pos_variable1 - 21)
                If Len(logfiledata(a)) < 85 And InStr(logfiledata(a), "onn") > 0 Then
                    value_txt = Mid(logfiledata(a + 1), 9, Len(logfiledata(a + 1)) - 9)
                Else
                    value_txt = Mid(logfiledata(a), pos_value + 12, Len(logfiledata(a)) - 12 - pos_value)
                End If
                znr = znr + 1
                dr(0) = znr
                dr(1) = variable_txt
                dr(2) = value_txt
                dt.Rows.Add(dr)
                dr = dt.NewRow()
            End If
            If pos_variable2 > 0 Then
                pos_value = InStr(logfiledata(a), "with value '")
                variable_txt = Mid(logfiledata(a), pos_variable2 + 24, pos_value - pos_variable2 - 26)
                value_txt = Mid(logfiledata(a), pos_value + 12, Len(logfiledata(a)) - 13 - pos_value)
                znr = znr + 1
                dr(0) = znr
                dr(1) = variable_txt
                dr(2) = value_txt
                dt.Rows.Add(dr)
                dr = dt.NewRow()
            End If
        Next a
        dgParameter1.DataSource = dt
        dgParameter1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgParameter1.ReadOnly = True
    End Sub
    Sub FillRuntime(ByVal logfiledata, ByVal lines)
        Dim temp_time_start, temp_time_end As Date
        Dim seconds, ss, mm As Long
        Dim temp_time_diff As String
        temp_time_start = CDate(Microsoft.VisualBasic.Left(logfiledata(1), 19))
        temp_time_end = CDate(Microsoft.VisualBasic.Left(logfiledata(lines - 1), 19))
        seconds = DateDiff("s", temp_time_start, temp_time_end)
        mm = Int(seconds / 60)
        ss = seconds - (mm * 60)
        temp_time_diff = Str(mm) + ":" + Microsoft.VisualBasic.Right(ss, 2) + "Min.   (=" + Str(seconds) + "s)"
        tbLaufzeit1.Text = temp_time_diff
    End Sub
    Sub FillSAPConnection(ByVal logfiledata, ByVal lines)
        Dim a As Integer = 1
        Dim pos As Integer = 0
        For a = 1 To lines
            pos = InStr(logfiledata(a), "SAP with connection string")
            If pos > 0 Then
                tbSAPConnStr1.Text = Mid(logfiledata(a), pos + 28, Len(logfiledata(a)) - 28 - pos)
                Exit For
            End If
        Next a
    End Sub
    Sub FillSQLStatements(ByVal logfiledata, ByVal lines)
        Dim a As Integer = 0
        Dim znr As Integer = 0
        Dim posI As Integer = 0         ' Position des Wertes für INSERT
        Dim posS As Integer = 0         ' Position des Wertes für SELECT
        Dim posU As Integer = 0         ' Position des Wertes für UPDATE
        Dim value_txt As String         ' Wert
        Dim dt As New DataTable()
        Dim dr As DataRow = dt.NewRow()
        dt.Columns.Add("Nr")            ' Zeilennummer
        dt.Columns.Add("Wert")          ' Überschrift im Data-Grid
        ' loopt durch alle Logfile-Zeilen und füllt das Grid
        For a = 1 To lines
            posI = InStr(logfiledata(a), "'INSERT")
            posS = InStr(logfiledata(a), "'SELECT")
            posU = InStr(logfiledata(a), "'UPDATE")
            posI = posI + posS + posU ' ermittelt ob einer der Werte > 0 ist
            If posI > 0 Then
                value_txt = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - posI)
                znr = znr + 1
                dr(0) = znr
                dr(1) = value_txt
                dt.Rows.Add(dr)
                dr = dt.NewRow()
                posI = 0
                posS = 0
                posU = 0
            End If
        Next a
        dgSQLStat1.DataSource = dt
        dgSQLStat1.ReadOnly = True
        dgSQLStat1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Sub FillStartdate(ByVal logfiledata)
        Dim tempstring As String
        'Check auf englisches oder deutsches Datumsformat
        If InStr(logfiledata(1), "/") > 0 Then
            tempstring = Microsoft.VisualBasic.Left(logfiledata(1), 22)
        Else
            tempstring = Microsoft.VisualBasic.Left(logfiledata(1), 19)

        End If
        tbStartzeit1.Text = tempstring
    End Sub
    Sub FillTransaktionen(ByVal logfiledata, ByVal lines)
        Dim a As Integer = 0
        Dim znr As Integer = 0
        Dim pos1 As Integer = 0             ' Position der Variable für "Transaction"
        Dim pos2 As Integer = 0             ' Position der Variable für "Section"
        Dim pos3 As Integer = 0             ' Position der Variable für "Method"
        Dim value_txt As String             ' Wert
        Dim dt As New DataTable()
        Dim dr As DataRow = dt.NewRow()
        dt.Columns.Add("Nr")                ' Zeilennummer
        dt.Columns.Add("Typ")               ' Überschrift im Data-Grid
        dt.Columns.Add("Einsprungspunkt")   ' Überschrift im Data-Grid
        ' loopt durch alle Logfile-Zeilen und füllt das Grid
        For a = 1 To lines
            pos1 = InStr(logfiledata(a), "Processing element 'transaction'")
            pos2 = InStr(logfiledata(a), "Processing element 'section' ")
            pos3 = InStr(logfiledata(a), "Processing element 'method' with name ")
            If pos1 > 0 Then
                value_txt = Mid(logfiledata(a), pos1 + 44, Len(logfiledata(a)) - 45 - pos1)
                znr = znr + 1
                dr(0) = znr
                dr(1) = "Transaction"
                dr(2) = value_txt
                dt.Rows.Add(dr)
                dr = dt.NewRow()
                pos1 = 0
            End If
            If pos2 > 0 Then
                value_txt = Mid(logfiledata(a), pos2 + 40, Len(logfiledata(a)) - 41 - pos2)
                znr = znr + 1
                dr(0) = znr
                dr(1) = "Section"
                dr(2) = value_txt
                dt.Rows.Add(dr)
                dr = dt.NewRow()
                pos2 = 0
            End If
            If pos3 > 0 Then
                value_txt = Mid(logfiledata(a), pos3 + 39, Len(logfiledata(a)) - 40 - pos3)
                znr = znr + 1
                dr(0) = znr
                dr(1) = "Method"
                dr(2) = value_txt
                dt.Rows.Add(dr)
                dr = dt.NewRow()
                pos3 = 0
            End If
            dgTransaktionen1.DataSource = dt
            dgTransaktionen1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgTransaktionen1.ReadOnly = True
        Next a
    End Sub
    Sub FillVariablen(ByVal logfiledata, ByVal lines)
        Dim a As Integer = 0
        Dim znr As Integer = 0
        Dim pos_variable As Integer = 0 ' Position der Variable
        Dim pos_value As Integer = 0    ' Position des Wertes
        Dim variable_txt As String      ' Variable
        Dim value_txt As String         ' Wert

        Dim dt As New DataTable()
        Dim dr As DataRow = dt.NewRow()
        dt.Columns.Add("Nr")            ' Zeilennummer
        dt.Columns.Add("Variable")      ' Überschrift im Data-Grid
        dt.Columns.Add("Wert")          ' Überschrift im Data-Grid
        ' loopt durch alle Logfile-Zeilen und füllt das Grid
        For a = 1 To lines
            pos_variable = InStr(logfiledata(a), "]Loading variable '")
            If pos_variable > 0 Then
                pos_value = InStr(logfiledata(a), "with value '")
                variable_txt = Mid(logfiledata(a), pos_variable + 19, pos_value - pos_variable - 21)
                If Len(logfiledata(a)) < 85 And InStr(logfiledata(a), "onn") > 0 Then
                    value_txt = Mid(logfiledata(a + 1), 9, Len(logfiledata(a + 1)) - 9)
                Else
                    value_txt = Mid(logfiledata(a), pos_value + 12, Len(logfiledata(a)) - 12 - pos_value)
                    znr = znr + 1
                    dr(0) = znr
                    dr(1) = variable_txt
                    dr(2) = value_txt
                    dt.Rows.Add(dr)
                    dr = dt.NewRow()
                End If
            End If
        Next a
        dgVariablen1.DataSource = dt
        dgVariablen1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgVariablen1.ReadOnly = True
    End Sub
    Sub FillMMAufbereitung(ByVal logfiledata, ByVal lines)
        'Füllt das Feld "MM-Aufbereitung"
        Dim a As Integer = 1
        Dim b As Integer = 0
        Dim c As Integer = 0
        tbMM1.Text = ""
        Dim dist As String = ""
        Dim dummystring, dummyleft, dummyright As String
        Dim dummy_pos As Integer
        Dim tempdata(500) As String
        For a = 1 To lines
            If InStr(logfiledata(a), "-- headerdata --") > 0 Then
                b = b + 1
                tbFI1.Text = ""  'FI-Textbox löschen, da es sich um eine MM-Transaktion handelt'
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- itemdata --") > 0 Then
                b = b + 1
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- accountingdata --") > 0 Then
                b = b + 1
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- glaccountdata --") > 0 Then
                b = b + 1
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If

            If InStr(logfiledata(a), "-- taxdata --") > 0 Then
                b = b + 1
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- materialdata --") > 0 Then
                b = b + 1
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "Adding property: '") > 0 Then
                b = b + 1
                dummystring = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - InStr(logfiledata(a), "property:") - 9)
                dummy_pos = InStr(dummystring, ",")
                dummyleft = Microsoft.VisualBasic.Left(dummystring, dummy_pos - 1)
                dummyright = Microsoft.VisualBasic.Mid(dummystring, dummy_pos + 8, Len(dummystring) - dummy_pos)
                For c = 1 To 20 - Len(dummyleft)
                    dummyleft = dummyleft + " "
                Next
                tempdata(b) = dummyleft + dummyright
            End If

        Next a
        'Textausgabe bis zum Ende des Fehlers
        For a = 1 To b
            If InStr(tempdata(a), "connection") = 0 And
                InStr(tempdata(a), "allow") = 0 And
                InStr(tempdata(a), "supportschangenotification") = 0 Then
                tbMM1.Text = tbMM1.Text + tempdata(a) + Chr(13) + Chr(10)
            End If
        Next
    End Sub
    Sub FillFIAufbereitung(ByVal logfiledata, ByVal lines)
        'Füllt das Feld "FI-Aufbereitung"
        Dim a As Integer = 1
        Dim b As Integer = 0
        Dim c As Integer = 0
        tbFI1.Text = ""
        Dim dist As String = ""
        Dim tempdata(500) As String
        For a = 1 To lines
            If InStr(logfiledata(a), "Loading variable 'transaction'") > 0 Then
                b = b + 1
                tempdata(b) = "SAP transaction " + Microsoft.VisualBasic.Mid(logfiledata(a), InStr(logfiledata(a), "Loading variable 'transaction'") + 43, 4)
            End If
            If InStr(logfiledata(a), "-- BasicData --") > 0 Then
                b = b + 2
                tbMM1.Text = "" 'MM-Textbox löschen, da es sich um eine FI-Transaktion handelt '
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- VendorData --") > 0 Then
                b = b + 2
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- VendorBankCode --") > 0 Then
                b = b + 2
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If

            If InStr(logfiledata(a), "-- ItemData --") > 0 Then
                b = b + 2
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- GLAccount --") > 0 Then
                b = b + 2
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- Codeblock --") > 0 Then
                b = b + 2
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- GLAccount_2 --") > 0 Then
                b = b + 2
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- Overview --") > 0 Then
                b = b + 2
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- FinalScreen --") > 0 Then
                b = b + 2
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "-- ExitBatch --") > 0 Then
                b = b + 2
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - 36)
            End If
            If InStr(logfiledata(a), "Adding screen ") > 0 Then
                b = b + 1
                tempdata(b) = "Dynpro: " + Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - InStr(logfiledata(a), "Adding screen ") - 13)
            End If
            If InStr(logfiledata(a), "Added field: ") > 0 Then
                b = b + 1
                tempdata(b) = Microsoft.VisualBasic.Right(logfiledata(a), Len(logfiledata(a)) - InStr(logfiledata(a), "Added field: ") - 12)
            End If


        Next a
        'Textausgabe bis zum Ende des Fehlers'
        For a = 1 To b
            If InStr(tempdata(a), "connection") = 0 And
                InStr(tempdata(a), "allow") = 0 And
                InStr(tempdata(a), "supportschangenotification") = 0 Then
                tbFI1.Text = tbFI1.Text + tempdata(a) + Chr(13) + Chr(10)
            End If
        Next
    End Sub
    Sub FillIPDaten(ByVal logfiledata, ByVal lines)
    End Sub
    Sub ConnectToDb()
        'Check auf englisches oder deutsches Datumsformat
        Dim objconn As New System.Data.OleDb.OleDbConnection(Connectionstring) 'Instanz erstellen
        Try
            objconn.Open() ' Datenverbindung aufbauen
            Button2.BackColor = Color.LightGreen
            Button2.Text = "Datenbank verbunden"
        Catch myexception As System.Exception ' Fehlerbehandlung
            MessageBox.Show("Fehler: " + myexception.Message, "Fehler bei der Verbindung")
            Button2.BackColor = Color.Red
            Button2.Text = "Datenbank verbinden"
        End Try
    End Sub


    Function MDY_to_DMY1(ByVal sInput As String) As String
        'Amerikanisches Datum m/dd/yyyy in deutsches Datum dd.mm.yyyy
        'konvertieren
        Dim MDY As String = "\b(?<month>\d{1,2})/(?<day>\d{1,2})/" & _
                            "(?<year>\d{2,4})\b"
        Dim DMY As String = "${day}.0${month}.${year}"
        Return Regex.Replace(sInput, MDY, DMY)
    End Function
    Function MDY_to_DMY2(ByVal sInput As String) As String
        'Amerikanisches Datum mm/dd/yyyy in deutsches Datum dd.mm.yyyy
        'konvertieren
        Dim MDY As String = "\b(?<month>\d{1,2})/(?<day>\d{1,2})/" & _
                            "(?<year>\d{2,4})\b"
        Dim DMY As String = "${day}.${month}.${year}"
        Return Regex.Replace(sInput, MDY, DMY)
    End Function
    Public Sub ÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripMenuItem.Click
        OpenFileDialog1.InitialDirectory = logfilepath
        OpenFileDialog1.ShowDialog()
        Dim linecounter As Integer = 1 ' zeilenzähler für das logfile
        Dim logfiledata(1) As String
        Dim lines As Integer
        logfiledata = New String(5000000) {}
        'Filenamen lesen

        filename1 = OpenFileDialog1.FileName
        If filename1 = "" Then Exit Sub
        'ToolStripStatusLabel1.Text = "File " + filename1 + " wird gelesen..."

        Dim reader As StreamReader = File.OpenText(filename1)
        ' schleife durchlaufen, bis das ende des logfiles erreicht ist
        While (reader.Peek() > -1)
            logfiledata(linecounter) = reader.ReadLine()
            linecounter = linecounter + 1
            'ToolStripStatusLabel1.Text = "File " + filename1 + " wird gelesen...  " + Str(linecounter)
        End While
        ' Datum aller Logfilezeilen konvertieren
        Dim tempstring As String = ""
        Dim leftpart As String
        Dim sourcestring As String = ""
        For a = 1 To linecounter
            'Amerikanisches Datum mm/dd/yyyy in deutsches Datum dd.mm.yyyy
            'konvertieren
            'month 1-9
            sourcestring = logfiledata(a)
            If Mid(logfiledata(a), 2, 1) = "/" Then
                leftpart = Mid(logfiledata(a), 1, 9)
                leftpart = MDY_to_DMY1(leftpart)
                tempstring = leftpart + Mid(logfiledata(a), Len(leftpart))
                If Mid(tempstring, 2, 1) = "." Then tempstring = "0" + tempstring
                logfiledata(a) = tempstring
            End If
            'month(10 - 12)
            If Mid(logfiledata(a), 3, 1) = "/" Then
                leftpart = Mid(logfiledata(a), 1, 10)
                leftpart = MDY_to_DMY2(leftpart)
                tempstring = leftpart + Mid(logfiledata(a), Len(leftpart) + 1)
                If Mid(tempstring, 2, 1) = "." Then tempstring = "0" + tempstring
                logfiledata(a) = tempstring
            End If
            REM
        Next a
        lines = linecounter
        FillFilename(filename1)
        pgb1.Value = 15
        FillLinecounter(lines)
        pgb1.Value = 20
        FillStartdate(logfiledata)
        pgb1.Value = 25
        FillEnddate(logfiledata, lines)
        pgb1.Value = 30
        FillErrorDate(logfiledata, lines)
        pgb1.Value = 35
        FillRuntime(logfiledata, lines)
        pgb1.Value = 40
        FillAnyERPVersion(logfiledata, lines)
        pgb1.Value = 45
        FillSAPConnection(logfiledata, lines)
        pgb1.Value = 50
        FillDBConnection(logfiledata, lines)
        pgb1.Value = 60
        FillDocID(logfiledata, lines)
        pgb1.Value = 70
        ToolStripStatusLabel2.Text = "Variablen..."
        Update()
        FillVariablen(logfiledata, lines)
        pgb1.Value = 80
        ToolStripStatusLabel2.Text = "Transaktionen..."
        Update()
        FillTransaktionen(logfiledata, lines)
        pgb1.Value = 90
        ToolStripStatusLabel2.Text = "SQLStatements..."
        Update()
        FillSQLStatements(logfiledata, lines)
        pgb1.Value = 100
        ToolStripStatusLabel2.Text = "Parameter..."
        Update()
        FillErrorBefore(logfiledata, lines)
        FillErrorText(logfiledata, lines)
        ToolStripStatusLabel2.Text = "Fehlerzeilen..."
        Update()
        FillMMAufbereitung(logfiledata, lines)
        ToolStripStatusLabel2.Text = "MM-Aufbereitung..."
        Update()
        FillFIAufbereitung(logfiledata, lines)
        ToolStripStatusLabel2.Text = "FI-Aufbereitung..."
        Update()
        FillIPDaten(logfiledata, lines)
        ToolStripStatusLabel2.Text = "IPDaten-Aufbereitung..."
        Update()
        FillParameter(logfiledata, lines)
        ToolStripStatusLabel2.ForeColor = Color.Black
        ToolStripStatusLabel2.Text = "Analyse beendet..."
        Update()
    End Sub
    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, _
                                               ByVal e As System.EventArgs) _
            Handles BeendenToolStripMenuItem.Click
        dConfirm1.Show()
    End Sub
    Private Sub DruckenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        SetLanguage_Form1()
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "SalzmannDataSet.docs". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.DocsTableAdapter.Fill(Me.SalzmannDataSet.docs)
        ReadIniFile()
        SetLanguage_Form1()
    End Sub
    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
    Private Sub MMDatenGenerierenToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        ToolStripStatusLabel1.Text = "Extrahiert MM-Daten und schreibt sie in ein File"
    End Sub
    Private Sub MMDatenGenerierenToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        ToolStripStatusLabel1.Text = ""
    End Sub
    Private Sub OptionenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionenToolStripMenuItem.Click
        Options2.Show()
    End Sub
    Sub SetLanguage_Form1()
        language_settings()
        tpGrunddaten.Text = t4
        tpFehleranalyse.Text = t5
        tpMM.Text = t6
        tpFI.Text = t7
        tpIPdaten.Text = t8
        tpDBdaten.Text = t9
        tb2.Text = t10
        tb6.Text = t11
        tb3.Text = t12
        tb10.Text = t13
        tb5.Text = t14
        tb9.Text = t15
        tb8.Text = t16
        tb4.Text = t17
        tpVariablen.Text = t18
        tpTransaktionen.Text = t19
        tpSQLStat1.Text = t20
        tpParameter.Text = t21
        Label10.Text = t22
        Label9.Text = t23
        Label12.Text = t24
        Label14.Text = t25
        Label15.Text = t26
        Label16.Text = t27
        Label17.Text = t28
        Button2.Text = t29
        ÖffnenToolStripMenuItem.Text = t30
        DruckenToolStripMenuItem.Text = t31
        SeitenansichtToolStripMenuItem.Text = t32
        BeendenToolStripMenuItem.Text = t33

    End Sub

    Private Sub frmMain_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        SetLanguage_Form1()
    End Sub


    Private Sub tpGrunddaten_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpGrunddaten.MouseHover
        SetLanguage_Form1()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ConnectToDb()

        DataGridView1.Dock = DockStyle.Fill
        DataGridView2.Dock = DockStyle.Fill
        DataGridView3.Dock = DockStyle.Fill
        DataGridView4.Dock = DockStyle.Fill
        DataGridView5.Dock = DockStyle.Fill
        DataGridView6.Dock = DockStyle.Fill
        Dim bindingSource1 As New BindingSource()
        Dim bindingSource2 As New BindingSource()
        Dim bindingSource3 As New BindingSource()
        Dim bindingSource4 As New BindingSource()
        Dim bindingSource5 As New BindingSource()
        Dim bindingSource6 As New BindingSource()
        Dim sqlcommand_docs = "select * from docs where doc_id = '" + tbDoc_ID1.Text + "'"
        Dim sqlcommand_doc_data = "select * from doc_data where doc_id = '" + tbDoc_ID1.Text + "' order by stamp_date desc"
        Dim sqlcommand_action_log = "select * from action_log where doc_id = '" + tbDoc_ID1.Text + "' order by stamp_date desc"
        Dim sqlcommand_flow_log = "select * from flow_log where doc_id = '" + tbDoc_ID1.Text + "' order by sended_to_timestamp desc"
        Dim sqlcommand_doc_files = "select * from doc_files where doc_id = '" + tbDoc_ID1.Text + "'"
        Dim sqlcommand_doc_attachments = "select * from doc_attachments where doc_id = '" + tbDoc_ID1.Text + "'"

        'docs'
        Try
            With Me.DataGridView1
                bindingSource1.DataSource = GetData(DataTable, sqlcommand_docs)
                .DataSource = bindingSource1
                .AutoGenerateColumns = True
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
                .BorderStyle = BorderStyle.Fixed3D
                '.EditMode = DataGridViewEditMode.EditOnEnter'
            End With
        Catch ex As SqlException
            MessageBox.Show("To run this sample replace " _
                & "connection.ConnectionString with a valid connection string" _
                & "  to a Northwind database accessible to your system.",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            System.Threading.Thread.CurrentThread.Abort()
        End Try
        'doc_data'
        Try
            With Me.DataGridView2
                bindingSource2.DataSource = GetData(DataTable, sqlcommand_doc_data)
                .DataSource = bindingSource2
                .AutoGenerateColumns = True
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
                .BorderStyle = BorderStyle.Fixed3D
                '.EditMode = DataGridViewEditMode.EditOnEnter'
            End With
        Catch ex As SqlException
            MessageBox.Show("To run this sample replace " _
                & "connection.ConnectionString with a valid connection string" _
                & "  to a Northwind database accessible to your system.",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            System.Threading.Thread.CurrentThread.Abort()
        End Try
        'action_log'
        Try
            With Me.DataGridView3
                bindingSource3.DataSource = GetData(DataTable, sqlcommand_action_log)
                .DataSource = bindingSource3
                .AutoGenerateColumns = True
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
                .BorderStyle = BorderStyle.Fixed3D
                '.EditMode = DataGridViewEditMode.EditOnEnter'
            End With
        Catch ex As SqlException
            MessageBox.Show("To run this sample replace " _
                & "connection.ConnectionString with a valid connection string" _
                & "  to a Northwind database accessible to your system.",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            System.Threading.Thread.CurrentThread.Abort()
        End Try
        'flow_log'
        Try
            With Me.DataGridView4
                bindingSource4.DataSource = GetData(DataTable, sqlcommand_flow_log)
                .DataSource = bindingSource4
                .AutoGenerateColumns = True
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
                .BorderStyle = BorderStyle.Fixed3D
                '.EditMode = DataGridViewEditMode.EditOnEnter'
            End With
        Catch ex As SqlException
            MessageBox.Show("To run this sample replace " _
                & "connection.ConnectionString with a valid connection string" _
                & "  to a Northwind database accessible to your system.",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            System.Threading.Thread.CurrentThread.Abort()
        End Try
        'doc_files'
        Try
            With Me.DataGridView5
                bindingSource5.DataSource = GetData(DataTable, sqlcommand_doc_files)
                .DataSource = bindingSource5
                .AutoGenerateColumns = True
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
                .BorderStyle = BorderStyle.Fixed3D
                '.EditMode = DataGridViewEditMode.EditOnEnter'
            End With
        Catch ex As SqlException
            MessageBox.Show("To run this sample replace " _
                & "connection.ConnectionString with a valid connection string" _
                & "  to a Northwind database accessible to your system.",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            System.Threading.Thread.CurrentThread.Abort()
        End Try
        'doc_attachments'
        Try
            With Me.DataGridView6
                bindingSource6.DataSource = GetData(DataTable, sqlcommand_doc_attachments)
                .DataSource = bindingSource6
                .AutoGenerateColumns = True
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
                .BorderStyle = BorderStyle.Fixed3D
                '.EditMode = DataGridViewEditMode.EditOnEnter'
            End With
        Catch ex As SqlException
            MessageBox.Show("To run this sample replace " _
                & "connection.ConnectionString with a valid connection string" _
                & "  to a Northwind database accessible to your system.",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            System.Threading.Thread.CurrentThread.Abort()
        End Try
    End Sub
    Function GetData(ByVal datatable As DataTable, ByVal odbcCommand As String) As DataTable

        Dim connectionString As String = tbDBConnStr1.Text
        connectionString = "Provider=SQLOLEDB.1;Password=basware;Persist Security Info=True;User ID=basware;Data Source=localhost"


        Dim Connection As New OdbcConnection(connectionString)

        'Dim command As New OdbcCommand(odbcCommand, Connection)'
        Dim adapter As New OdbcDataAdapter(odbcCommand, Connection)
        'Dim adapter As OdbcDataAdapter = New OdbcDataAdapter()'
        'adapter.SelectCommand = command'


        Dim table As New DataTable
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(datatable)

        Return table

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ÖffnenToolStripMenuItem_Click(sender, e)
    End Sub
End Class


