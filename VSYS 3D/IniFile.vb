Public Module MyFonctions

    Public Function TextBoxNumeric(ByVal key As KeyPressEventArgs, ByVal myTextBox As TextBox, Optional ByVal withNegatif As Boolean = False) As Boolean

        If (key.KeyChar = "." OrElse key.KeyChar = ",") _
            And (myTextBox.Text.Contains(".") OrElse myTextBox.Text.Contains(",")) And myTextBox.SelectionStart > 0 Then
            Beep()
            Return False
        ElseIf (key.KeyChar = "." OrElse key.KeyChar = ",") And myTextBox.SelectionStart = 0 Then
            Beep()
            Return False
        ElseIf key.KeyChar = "." OrElse key.KeyChar = "," OrElse (key.KeyChar = "-" And myTextBox.SelectionStart = 0 And withNegatif) Then
            Return True
        ElseIf Not (Char.IsNumber(key.KeyChar) Or Char.IsControl(key.KeyChar)) Then
            Beep()
            Return False
        End If

        Return True

    End Function

    Public Function CheckNull(ByVal value As Object) As Boolean
        If value Is Nothing OrElse value.Equals(DBNull.Value) OrElse String.IsNullOrEmpty(value.ToString.Trim) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CDbl2(ByVal value As Object) As Double
        Try
            Return CDbl(value.ToString.Replace(" ", "") _
                                      .Replace("²", "") _
                                      .Replace(".", ",") _
                                      .Replace(ChrW(32), "") _
                                      .Replace(ChrW(160), "") _
                                      .Replace(vbTab, "").Trim)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module

Public Module ModIni
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32

    Public Sub WriteIni(ByVal iniFileName As String, ByVal section As String, ByVal paramName As String, ByVal paramVal As String)
        Dim result As Integer = WritePrivateProfileString(section, paramName, paramVal, iniFileName)
    End Sub

    Public Function ReadIni(ByVal iniFileName As String, ByVal section As String, ByVal paramName As String, ByVal paramDefault As String) As String
        Dim paramVal As String = Space$(1024)
        Dim lenParamVal As Long = GetPrivateProfileString(section, paramName, paramDefault, paramVal, paramVal.Length, iniFileName)
        ReadIni = Left$(paramVal, CInt(lenParamVal))
    End Function
End Module

Public Class ClsMyValue
    'KLIPPER
    Property MyIniFile As String
    Property KExtrudeDemande As Double
    Property KRda As Double
    Property KExtrude As Double
    Property KRdn As Double
    Property KPaStart As Double
    Property KPaMesure As Double
    Property KPaValue As Double
    Property KEtype As String
    'MARLIN
    Property MAccel As Double
    Property MJerk As Double
    Property MJunction As Double
    Property MExtrudeDemande As Double
    Property MeStepa As Double
    Property MExtrude As Double
    Property MeStepn As Double


    Public Sub New()

        Try

            If IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) Then
                Me.MyIniFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vs3d.ini"
            Else
                Me.MyIniFile = AppDomain.CurrentDomain.BaseDirectory() & "vs3d.ini"
            End If

            If IO.File.Exists(MyIniFile) Then
                'KLIPPER
                Me.KExtrudeDemande = CDbl2(ReadIni(MyIniFile, "Klipper", "ExtrusionDemande", "100"))
                Me.KRda = CDbl2(ReadIni(MyIniFile, "Klipper", "RotationDistanceActuelle", "0"))
                Me.KExtrude = CDbl2(ReadIni(MyIniFile, "Klipper", "Extrude", "0"))
                Me.KRdn = CDbl2(ReadIni(MyIniFile, "Klipper", "NouvelleRotationDistance", "0"))
                Me.KPaStart = CDbl2(ReadIni(MyIniFile, "Klipper", "PaStart", "0"))
                Me.KPaMesure = CDbl2(ReadIni(MyIniFile, "Klipper", "PaMesure", "0"))
                Me.KPaValue = CDbl2(ReadIni(MyIniFile, "Klipper", "PaValue", "0"))
                Me.KEtype = ReadIni(MyIniFile, "Klipper", "EType", "bowden")
                'MARLIN
                Me.MAccel = CDbl2(ReadIni(MyIniFile, "Marlin", "Accel", "500"))
                Me.MJerk = CDbl2(ReadIni(MyIniFile, "Marlin", "Jerk", "10"))
                Me.MJunction = CDbl2(ReadIni(MyIniFile, "Marlin", "Junction", "0.08"))
                Me.MExtrudeDemande = CDbl2(ReadIni(MyIniFile, "Marlin", "ExtrusionDemande", "100"))
                Me.MeStepa = CDbl2(ReadIni(MyIniFile, "Marlin", "EStepActuel", "0"))
                Me.MExtrude = CDbl2(ReadIni(MyIniFile, "Marlin", "Extrude", "0"))
                Me.MeStepn = CDbl2(ReadIni(MyIniFile, "Marlin", "NouveauEStep", "0"))
            Else
                'KLIPPER
                Me.KExtrudeDemande = 100
                Me.KRda = 0
                Me.KExtrude = 0
                Me.KRdn = 0
                Me.KPaStart = 0
                Me.KPaMesure = 0
                Me.KPaValue = 0
                Me.KEtype = "bowden"
                'MARLIN
                Me.MAccel = 500
                Me.MJerk = 10
                Me.MJunction = 0.08
                Me.MExtrudeDemande = 100
                Me.MeStepa = 0
                Me.MExtrude = 0
                Me.MeStepn = 0
            End If

        Catch ex As Exception
            'KLIPPER
            Me.KExtrudeDemande = 100
            Me.KRda = 0
            Me.KExtrude = 0
            Me.KRdn = 0
            Me.KPaStart = 0
            Me.KPaMesure = 0
            Me.KPaValue = 0
            Me.KEtype = "bowden"
            'MARLIN
            Me.MAccel = 500
            Me.MJerk = 10
            Me.MJunction = 0.08
            Me.MExtrudeDemande = 100
            Me.MeStepa = 0
            Me.MExtrude = 0
            Me.MeStepn = 0
        End Try

    End Sub
End Class
