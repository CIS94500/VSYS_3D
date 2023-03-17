<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vs3D
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vs3D))
        Me.TabControl1 = New VSYS_3D.TabControl()
        Me.TabPageKlipper = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextKExtrusionDemande = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextKRdn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextKExtrude = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextKRda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxKHelp = New System.Windows.Forms.PictureBox()
        Me.TextKPaStart = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextKPaValue = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextKPaMesure = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioKBowden = New System.Windows.Forms.RadioButton()
        Me.RadioKDirectDrive = New System.Windows.Forms.RadioButton()
        Me.TabPageMarlin = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextMExtrusionDemande = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextMeStepn = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextMExtrude = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextMeStepa = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextMAcceleration = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextMJerk = New System.Windows.Forms.TextBox()
        Me.TextMJunction = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPageKlipper.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxKHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMarlin.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPageKlipper)
        Me.TabControl1.Controls.Add(Me.TabPageMarlin)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Location = New System.Drawing.Point(5, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(283, 308)
        Me.TabControl1.TabIndex = 2
        '
        'TabPageKlipper
        '
        Me.TabPageKlipper.Controls.Add(Me.GroupBox1)
        Me.TabPageKlipper.Controls.Add(Me.GroupBox2)
        Me.TabPageKlipper.Location = New System.Drawing.Point(4, 28)
        Me.TabPageKlipper.Name = "TabPageKlipper"
        Me.TabPageKlipper.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageKlipper.Size = New System.Drawing.Size(275, 276)
        Me.TabPageKlipper.TabIndex = 0
        Me.TabPageKlipper.Text = "Klipper"
        Me.TabPageKlipper.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextKExtrusionDemande)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextKRdn)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextKExtrude)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextKRda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calibration extrudeur"
        '
        'TextKExtrusionDemande
        '
        Me.TextKExtrusionDemande.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextKExtrusionDemande.Location = New System.Drawing.Point(147, 20)
        Me.TextKExtrusionDemande.Name = "TextKExtrusionDemande"
        Me.TextKExtrusionDemande.Size = New System.Drawing.Size(100, 20)
        Me.TextKExtrusionDemande.TabIndex = 1
        Me.TextKExtrusionDemande.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(5, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Extrusion demandée (mm) :"
        '
        'TextKRdn
        '
        Me.TextKRdn.Location = New System.Drawing.Point(147, 98)
        Me.TextKRdn.Name = "TextKRdn"
        Me.TextKRdn.Size = New System.Drawing.Size(100, 20)
        Me.TextKRdn.TabIndex = 4
        Me.TextKRdn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(5, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nouvelle rotation distance :"
        '
        'TextKExtrude
        '
        Me.TextKExtrude.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextKExtrude.Location = New System.Drawing.Point(147, 72)
        Me.TextKExtrude.Name = "TextKExtrude"
        Me.TextKExtrude.Size = New System.Drawing.Size(100, 20)
        Me.TextKExtrude.TabIndex = 3
        Me.TextKExtrude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(5, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Filament extrudé (mm) :"
        '
        'TextKRda
        '
        Me.TextKRda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextKRda.Location = New System.Drawing.Point(147, 46)
        Me.TextKRda.Name = "TextKRda"
        Me.TextKRda.Size = New System.Drawing.Size(100, 20)
        Me.TextKRda.TabIndex = 2
        Me.TextKRda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(5, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rotation distance actuelle :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBoxKHelp)
        Me.GroupBox2.Controls.Add(Me.TextKPaStart)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextKPaValue)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextKPaMesure)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.RadioKBowden)
        Me.GroupBox2.Controls.Add(Me.RadioKDirectDrive)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 127)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pressure Advance"
        '
        'PictureBoxKHelp
        '
        Me.PictureBoxKHelp.BackgroundImage = Global.VSYS_3D.My.Resources.Resources.help
        Me.PictureBoxKHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxKHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxKHelp.InitialImage = Nothing
        Me.PictureBoxKHelp.Location = New System.Drawing.Point(229, 12)
        Me.PictureBoxKHelp.Name = "PictureBoxKHelp"
        Me.PictureBoxKHelp.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxKHelp.TabIndex = 15
        Me.PictureBoxKHelp.TabStop = False
        '
        'TextKPaStart
        '
        Me.TextKPaStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextKPaStart.Location = New System.Drawing.Point(147, 44)
        Me.TextKPaStart.Name = "TextKPaStart"
        Me.TextKPaStart.Size = New System.Drawing.Size(100, 20)
        Me.TextKPaStart.TabIndex = 7
        Me.TextKPaStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(5, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Départ (défaut 0 mm) :"
        '
        'TextKPaValue
        '
        Me.TextKPaValue.Location = New System.Drawing.Point(147, 97)
        Me.TextKPaValue.Name = "TextKPaValue"
        Me.TextKPaValue.Size = New System.Drawing.Size(100, 20)
        Me.TextKPaValue.TabIndex = 9
        Me.TextKPaValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(147, -21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(5, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pressure advance :"
        '
        'TextKPaMesure
        '
        Me.TextKPaMesure.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextKPaMesure.Location = New System.Drawing.Point(147, 71)
        Me.TextKPaMesure.Name = "TextKPaMesure"
        Me.TextKPaMesure.Size = New System.Drawing.Size(100, 20)
        Me.TextKPaMesure.TabIndex = 8
        Me.TextKPaMesure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(5, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hauteur mesurée (mm) :"
        '
        'RadioKBowden
        '
        Me.RadioKBowden.AutoSize = True
        Me.RadioKBowden.BackColor = System.Drawing.Color.White
        Me.RadioKBowden.Checked = True
        Me.RadioKBowden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioKBowden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RadioKBowden.Location = New System.Drawing.Point(6, 21)
        Me.RadioKBowden.Name = "RadioKBowden"
        Me.RadioKBowden.Size = New System.Drawing.Size(64, 17)
        Me.RadioKBowden.TabIndex = 5
        Me.RadioKBowden.TabStop = True
        Me.RadioKBowden.Text = "Bowden"
        Me.RadioKBowden.UseVisualStyleBackColor = False
        '
        'RadioKDirectDrive
        '
        Me.RadioKDirectDrive.AutoSize = True
        Me.RadioKDirectDrive.BackColor = System.Drawing.Color.White
        Me.RadioKDirectDrive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioKDirectDrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RadioKDirectDrive.Location = New System.Drawing.Point(75, 21)
        Me.RadioKDirectDrive.Name = "RadioKDirectDrive"
        Me.RadioKDirectDrive.Size = New System.Drawing.Size(79, 17)
        Me.RadioKDirectDrive.TabIndex = 6
        Me.RadioKDirectDrive.Text = "Direct drive"
        Me.RadioKDirectDrive.UseVisualStyleBackColor = False
        '
        'TabPageMarlin
        '
        Me.TabPageMarlin.Controls.Add(Me.GroupBox4)
        Me.TabPageMarlin.Controls.Add(Me.GroupBox3)
        Me.TabPageMarlin.Location = New System.Drawing.Point(4, 28)
        Me.TabPageMarlin.Name = "TabPageMarlin"
        Me.TabPageMarlin.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMarlin.Size = New System.Drawing.Size(275, 276)
        Me.TabPageMarlin.TabIndex = 1
        Me.TabPageMarlin.Text = "Marlin"
        Me.TabPageMarlin.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextMExtrusionDemande)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TextMeStepn)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TextMExtrude)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TextMeStepa)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 129)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Calibration extrudeur"
        '
        'TextMExtrusionDemande
        '
        Me.TextMExtrusionDemande.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextMExtrusionDemande.Location = New System.Drawing.Point(147, 20)
        Me.TextMExtrusionDemande.Name = "TextMExtrusionDemande"
        Me.TextMExtrusionDemande.Size = New System.Drawing.Size(100, 20)
        Me.TextMExtrusionDemande.TabIndex = 1
        Me.TextMExtrusionDemande.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(5, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Extrusion demandée (mm) :"
        '
        'TextMeStepn
        '
        Me.TextMeStepn.Location = New System.Drawing.Point(147, 98)
        Me.TextMeStepn.Name = "TextMeStepn"
        Me.TextMeStepn.Size = New System.Drawing.Size(100, 20)
        Me.TextMeStepn.TabIndex = 4
        Me.TextMeStepn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(5, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Nouveau EStep :"
        '
        'TextMExtrude
        '
        Me.TextMExtrude.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextMExtrude.Location = New System.Drawing.Point(147, 72)
        Me.TextMExtrude.Name = "TextMExtrude"
        Me.TextMExtrude.Size = New System.Drawing.Size(100, 20)
        Me.TextMExtrude.TabIndex = 3
        Me.TextMExtrude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(5, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Filament extrudé (mm) :"
        '
        'TextMeStepa
        '
        Me.TextMeStepa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextMeStepa.Location = New System.Drawing.Point(147, 46)
        Me.TextMeStepa.Name = "TextMeStepa"
        Me.TextMeStepa.Size = New System.Drawing.Size(100, 20)
        Me.TextMeStepa.TabIndex = 2
        Me.TextMeStepa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(5, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "EStep actuel :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextMAcceleration)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextMJerk)
        Me.GroupBox3.Controls.Add(Me.TextMJunction)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 127)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Jerk | Junction déviation"
        '
        'TextMAcceleration
        '
        Me.TextMAcceleration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextMAcceleration.Location = New System.Drawing.Point(147, 33)
        Me.TextMAcceleration.Name = "TextMAcceleration"
        Me.TextMAcceleration.Size = New System.Drawing.Size(100, 20)
        Me.TextMAcceleration.TabIndex = 0
        Me.TextMAcceleration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(5, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Junction :"
        '
        'TextMJerk
        '
        Me.TextMJerk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextMJerk.Location = New System.Drawing.Point(147, 59)
        Me.TextMJerk.Name = "TextMJerk"
        Me.TextMJerk.Size = New System.Drawing.Size(100, 20)
        Me.TextMJerk.TabIndex = 1
        Me.TextMJerk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextMJunction
        '
        Me.TextMJunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextMJunction.Location = New System.Drawing.Point(147, 85)
        Me.TextMJunction.Name = "TextMJunction"
        Me.TextMJunction.Size = New System.Drawing.Size(100, 20)
        Me.TextMJunction.TabIndex = 2
        Me.TextMJunction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(5, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Jerk  :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(5, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Acceleration :"
        '
        'Vs3D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(291, 316)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Vs3D"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3D Tools"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageKlipper.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxKHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMarlin.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioKBowden As System.Windows.Forms.RadioButton
    Friend WithEvents RadioKDirectDrive As System.Windows.Forms.RadioButton
    Friend WithEvents TextKRdn As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextKExtrude As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextKRda As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextKPaValue As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextKPaMesure As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextKExtrusionDemande As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextKPaStart As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxKHelp As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As VSYS_3D.TabControl
    Friend WithEvents TabPageKlipper As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMarlin As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextMAcceleration As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextMJerk As System.Windows.Forms.TextBox
    Friend WithEvents TextMJunction As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextMExtrusionDemande As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextMeStepn As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextMExtrude As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextMeStepa As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
