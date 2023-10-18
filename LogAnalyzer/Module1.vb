Module Module1
    Public logfilepath As String
    Public language As String
    Public lineoftext() = New String(1000) {}
    Public t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16,
        t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30,
        t31, t32, t33, t34, t35, t36, t37, t38, t39, t40 As String

    Public Sub language_settings()
        If language = "EN" Then
            t1 = "Cancel"
            t2 = "Language"
            t3 = "anyERP Logfile Path"
            t4 = "Data Analyzing"
            t5 = "Error Analyzing"
            t6 = "MM work up"
            t7 = "FI work up"
            t8 = "IP data"
            t9 = "DB data"
            t10 = "Filename"
            t11 = "anyERP Version"
            t12 = "Lines"
            t13 = "Runtime"
            t14 = "Start Time"
            t15 = "End Time"
            t16 = "Error Stamp"
            t17 = "SAP connection"
            t18 = "Variables"
            t19 = "Transactions"
            t20 = "SQL statements"
            t21 = "Parameters"
            t22 = "Error Location"
            t23 = "Error Text"
            t24 = "Supplier"
            t25 = "Invoicedate"
            t26 = "Cashdate"
            t27 = "Paymentdate"
            t28 = "Paymentterm"
            t29 = "Connect Database"
            t30 = "&Load Logfile"
            t31 = "Print"
            t32 = "Pre&view"
            t33 = "&Close"
        End If
        If language = "DE" Then
            t1 = "Abbruch"
            t2 = "Sprache"
            t3 = "anyERP-Logfile-Pfad"
            t4 = "Datenanalyse"
            t5 = "Fehleranalyse"
            t6 = "MM-Aufbereitung"
            t7 = "FI-Aufbereitung"
            t8 = "IP-Daten"
            t9 = "DB-Daten"
            t10 = "Dateiname"
            t11 = "anyERP Version"
            t12 = "Zeilenzahl"
            t13 = "Laufzeit"
            t14 = "Startzeit"
            t15 = "Endzeit"
            t16 = "Fehlerzeit"
            t17 = "SAP-Connection"
            t18 = "Variablen"
            t19 = "Transaktionen"
            t20 = "SQL-Statements"
            t21 = "Parameter"
            t22 = "Auftreten des Fehlers"
            t23 = "Fehlertext"
            t24 = "Kreditor"
            t25 = "Rech.Datum"
            t26 = "Skontodatum"
            t27 = "Zahl.Ziel"
            t28 = "Zahlungsbed."
            t29 = "Datenbank verbinden"
            t30 = "&Logfile Öffnen"
            t31 = "Drucken"
            t32 = "&Vorschau"
            t33 = "Be&enden"
        End If
    End Sub
    Public Sub ReadIniFile()
        Dim a As Integer = 0
        Try
            FileOpen(1, "LogAnalyzer.ini", OpenMode.Input)
            Do Until EOF(1)
                a = a + 1
                lineoftext(a) = LineInput(1)
                ' anyERP-Logfilepath
                If InStr(lineoftext(a), "anyERPLogPath") > 0 Then
                    logfilepath = Mid(lineoftext(a), 15)
                End If
                If InStr(lineoftext(a), "language") > 0 Then
                    language = Mid(lineoftext(a), 10)
                End If
            Loop

        Catch
            MsgBox("Fehler beim Öffnen von LogAnalyzer.ini - File!")
        Finally
            FileClose(1)
        End Try

    End Sub

    Public Sub WriteIniFile()
        Dim a As Integer = 0
        Dim test As String
        lineoftext(1) = "anyERPLogPath=" + logfilepath
        lineoftext(2) = "language=" + language
        Try
            FileOpen(1, "LogAnalyzer.ini", OpenMode.Output)
            For a = 1 To 10
                test = lineoftext(a)
                PrintLine(1, lineoftext(a))
            Next a
        Catch
            MsgBox("Fehler beim Schreiben von LogAnalyzer.ini - File!")
        Finally
            FileClose(1)
        End Try
    End Sub

End Module

