Public Class Vs3D
    Private _initialize As Boolean = True
    Private ReadOnly _3D As New ClsMyValue

    Private Sub Vs3D_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Try

            If Me.WindowState.Equals(FormWindowState.Minimized) Then Me.WindowState = FormWindowState.Normal

            Dim q As New Form
            q.TopMost = True

            Dim reponse As DialogResult
            Using New CenterMessageBox(Me)
                reponse = MessageBox.Show(q, "Voulez vous sauvegarder vos valeurs avant de quitter ?", "VS Klipper Tools", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            End Using
            If reponse = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
                Exit Sub
            ElseIf reponse = Windows.Forms.DialogResult.Yes Then

                If IO.File.Exists(_3D.MyIniFile).Equals(False) Then
                    Dim fs As IO.FileStream = IO.File.Create(_3D.MyIniFile)
                    fs.Close()
                    Try
                        IO.File.SetAttributes(_3D.MyIniFile, IO.FileAttributes.Hidden)
                    Catch ex As Exception
                    End Try
                End If
                'KLIPPER
                WriteIni(_3D.MyIniFile, "Klipper", "ExtrusionDemande", _3D.KExtrudeDemande.ToString)
                WriteIni(_3D.MyIniFile, "Klipper", "RotationDistanceActuelle", _3D.KRda.ToString)
                WriteIni(_3D.MyIniFile, "Klipper", "Extrude", _3D.KExtrude.ToString)
                WriteIni(_3D.MyIniFile, "Klipper", "NouvelleRotationDistance", _3D.KRdn.ToString)
                WriteIni(_3D.MyIniFile, "Klipper", "PaStart", _3D.KPaStart.ToString)
                WriteIni(_3D.MyIniFile, "Klipper", "PaMesure", _3D.KPaMesure.ToString)
                WriteIni(_3D.MyIniFile, "Klipper", "PaValue", _3D.KPaValue.ToString)
                WriteIni(_3D.MyIniFile, "Klipper", "EType", If(Me.RadioKBowden.Checked, "bowden", "dd"))
                'MARLIN
                WriteIni(_3D.MyIniFile, "Marlin", "Accel", _3D.MAccel.ToString)
                WriteIni(_3D.MyIniFile, "Marlin", "Jerk", _3D.MJerk.ToString)
                WriteIni(_3D.MyIniFile, "Marlin", "Junction", _3D.MJunction.ToString)
                WriteIni(_3D.MyIniFile, "Marlin", "ExtrusionDemande", _3D.MExtrudeDemande.ToString)
                WriteIni(_3D.MyIniFile, "Marlin", "EStepActuel", _3D.MeStepa.ToString)
                WriteIni(_3D.MyIniFile, "Marlin", "Extrude", _3D.MExtrude.ToString)
                WriteIni(_3D.MyIniFile, "Marlin", "NouveauEStep", _3D.MeStepn.ToString)
            ElseIf reponse = Windows.Forms.DialogResult.No Then
                If IO.File.Exists(_3D.MyIniFile) Then IO.File.Delete(_3D.MyIniFile)
            End If

            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Vs3D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '################################################################################
        'KLIPPER
        '################################################################################
        Me.RadioKDirectDrive.Checked = _3D.KEtype.Equals("dd")
        Me.TextKExtrusionDemande.Text = _3D.KExtrudeDemande.ToString
        Me.TextKRda.Text = _3D.KRda.ToString
        Me.TextKExtrude.Text = _3D.KExtrude.ToString
        Me.TextKRdn.Text = _3D.KRdn.ToString
        Me.TextKPaStart.Text = _3D.KPaStart.ToString
        Me.TextKPaMesure.Text = _3D.KPaMesure.ToString
        Me.TextKPaValue.Text = _3D.KPaValue.ToString
        '################################################################################
        'MARLIN
        '################################################################################
        Me.TextMAcceleration.Text = _3D.MAccel.ToString
        Me.TextMJerk.Text = _3D.MJerk.ToString
        Me.TextMJunction.Text = _3D.MJunction.ToString
        Me.TextMExtrusionDemande.Text = _3D.MExtrudeDemande.ToString
        Me.TextMeStepa.Text = _3D.MeStepa.ToString
        Me.TextMExtrude.Text = _3D.MExtrude.ToString
        Me.TextMeStepn.Text = _3D.MeStepn.ToString
        _initialize = False
    End Sub

    '################################################################################
    'KLIPPER
    '################################################################################
    Private Sub TextKExtrusionDemande_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextKExtrusionDemande.KeyPress
        If TextBoxNumeric(e, TextKExtrusionDemande).Equals(False) Then e.Handled = True
    End Sub
    Private Sub TextKRda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextKRda.KeyPress
        If TextBoxNumeric(e, TextKRda).Equals(False) Then e.Handled = True
    End Sub
    Private Sub TextKExtrude_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextKExtrude.KeyPress
        If TextBoxNumeric(e, TextKExtrude).Equals(False) Then e.Handled = True
    End Sub
    Private Sub TextKRdn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextKRdn.KeyPress
        e.Handled = True
    End Sub

    '################################################################################
    Private Sub TextKPaStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextKPaStart.KeyPress
        If TextBoxNumeric(e, TextKPaStart).Equals(False) Then e.Handled = True
    End Sub
    Private Sub TextKPaMesure_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextKPaMesure.KeyPress
        If TextBoxNumeric(e, TextKPaMesure).Equals(False) Then e.Handled = True
    End Sub
    Private Sub TextKPaValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextKPaValue.KeyPress
        e.Handled = True
    End Sub

    '################################################################################
    Private Sub RadioKBowden_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKBowden.CheckedChanged
        If _initialize.Equals(False) Then KCalculPressure()
    End Sub

    '################################################################################
    Private Sub TextKRdaExtrude_TextChanged(sender As Object, e As EventArgs) Handles TextKRda.TextChanged, TextKExtrude.TextChanged, TextKExtrusionDemande.TextChanged
        If _initialize.Equals(False) Then KCalculCalibration()
    End Sub
    Private Sub TextKPaMesurePaStar_TextChanged(sender As Object, e As EventArgs) Handles TextKPaMesure.TextChanged, TextKPaStart.TextChanged
        If _initialize.Equals(False) Then KCalculPressure()
    End Sub

    '################################################################################
    Private Sub KCalculCalibration()
        _3D.KExtrudeDemande = If(CheckNull(Me.TextKExtrusionDemande.Text), 100, CDbl2(Me.TextKExtrusionDemande.Text))
        _3D.KRda = If(CheckNull(Me.TextKRda.Text), 0, CDbl2(Me.TextKRda.Text))
        _3D.KExtrude = If(CheckNull(Me.TextKExtrude.Text), 0, CDbl2(Me.TextKExtrude.Text))
        _3D.KRdn = Math.Round((_3D.KRda * _3D.KExtrude / _3D.KExtrudeDemande), 3, MidpointRounding.ToEven)
        Me.TextKRdn.Text = _3D.KRdn.ToString
    End Sub

    Private Sub KCalculPressure()
        Dim myFactor As Double = If(Me.RadioKBowden.Checked, 0.02, 0.005)
        _3D.KPaStart = If(CheckNull(Me.TextKPaStart.Text), 0, CDbl2(Me.TextKPaStart.Text))
        _3D.KPaMesure = If(CheckNull(Me.TextKPaMesure.Text), 0, CDbl2(Me.TextKPaMesure.Text))
        _3D.KPaValue = Math.Round((_3D.KPaStart + _3D.KPaMesure * myFactor), 3, MidpointRounding.ToEven)
        Me.TextKPaValue.Text = _3D.KPaValue.ToString
    End Sub

    Private Sub PictureBoxKHelp_Click(sender As Object, e As EventArgs) Handles PictureBoxKHelp.Click
        Process.Start("https://www.klipper3d.org/Pressure_Advance.html?h=pres")
    End Sub

    '################################################################################
    'MARLIN
    '################################################################################
    Private Sub TextMExtrusionDemande_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMExtrusionDemande.KeyPress
        If TextBoxNumeric(e, TextKExtrusionDemande).Equals(False) Then e.Handled = True
    End Sub
    Private Sub TextMeStepa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMeStepa.KeyPress
        If TextBoxNumeric(e, TextKRda).Equals(False) Then e.Handled = True
    End Sub
    Private Sub TextMExtrude_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMExtrude.KeyPress
        If TextBoxNumeric(e, TextKExtrude).Equals(False) Then e.Handled = True
    End Sub
    Private Sub TextMeStepn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMeStepn.KeyPress
        e.Handled = True
    End Sub
    '################################################################################
    Private Sub TextMeStepa_TextChanged(sender As Object, e As EventArgs) Handles TextMeStepa.TextChanged, TextMExtrude.TextChanged, TextMExtrusionDemande.TextChanged
        If _initialize.Equals(False) Then MCalculCalibration()
    End Sub

    Private Sub MCalculCalibration()
        _3D.MExtrudeDemande = If(CheckNull(Me.TextMExtrusionDemande.Text), 100, CDbl2(Me.TextMExtrusionDemande.Text))
        _3D.MeStepa = If(CheckNull(Me.TextMeStepa.Text), 1, CDbl2(Me.TextMeStepa.Text))
        _3D.MExtrude = If(CheckNull(Me.TextMExtrude.Text), 1, CDbl2(Me.TextMExtrude.Text))
        _3D.MeStepn = Math.Round(((_3D.MeStepa * _3D.MExtrudeDemande) / _3D.MExtrude), 3, MidpointRounding.ToEven)
        Me.TextMeStepn.Text = _3D.MeStepn.ToString
    End Sub


    Private Sub TextMAcceleration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMAcceleration.KeyPress
        If TextBoxNumeric(e, TextMAcceleration).Equals(False) Then e.Handled = True
    End Sub
    Private Sub TextMJerk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMJerk.KeyPress
        If TextBoxNumeric(e, TextMJerk).Equals(False) Then e.Handled = True
    End Sub
    Private Sub TextMJunction_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMJunction.KeyPress
        If TextBoxNumeric(e, TextMJunction).Equals(False) Then e.Handled = True
    End Sub
    '################################################################################
    Private Sub TextMAccelerationTextJerk_TextChanged(sender As Object, e As EventArgs) Handles TextMAcceleration.TextChanged, TextMJerk.TextChanged
        If _initialize.Equals(False) Then
            _initialize = True
            MCalculateJunction()
            _initialize = False
        End If
    End Sub
    Private Sub TextMJunction_TextChanged(sender As Object, e As EventArgs) Handles TextMJunction.TextChanged
        If _initialize.Equals(False) Then
            _initialize = True
            MCalculateJerk()
            _initialize = False
        End If
    End Sub

    Private Sub MCalculateJunction()
        _3D.MAccel = If(CheckNull(Me.TextMAcceleration.Text), 500, CDbl2(Me.TextMAcceleration.Text))
        _3D.MJerk = If(CheckNull(Me.TextMJerk.Text), 10, CDbl2(Me.TextMJerk.Text))
        _3D.MJunction = 0.4 * ((_3D.MJerk * _3D.MJerk) / _3D.MAccel)
        Me.TextMJunction.Text = Math.Round(_3D.MJunction, 4).ToString
    End Sub

    Private Sub MCalculateJerk()
        _3D.MAccel = If(CheckNull(Me.TextMAcceleration.Text), 500, CDbl2(Me.TextMAcceleration.Text))
        _3D.MJunction = If(CheckNull(Me.TextMJunction.Text), 10, CDbl2(Me.TextMJunction.Text))
        _3D.MJerk = Math.Sqrt(((_3D.MJunction * _3D.MAccel) / 0.4))
        Me.TextMJerk.Text = Math.Round(_3D.MJerk, 2).ToString
    End Sub

    '################################################################################

End Class
