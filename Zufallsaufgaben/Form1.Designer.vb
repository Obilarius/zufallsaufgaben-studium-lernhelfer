<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zufallsaufgaben
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zufallsaufgaben))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.num_AufgabeVon = New System.Windows.Forms.NumericUpDown()
        Me.num_AufgabeBis = New System.Windows.Forms.NumericUpDown()
        Me.num_Unterpunkte = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.check_Unterpunkte = New System.Windows.Forms.CheckBox()
        Me.grp_Unterpunkte = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Generieren = New System.Windows.Forms.Button()
        Me.num_AnzahlAufgaben = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstBox_Ausgabe = New System.Windows.Forms.ListView()
        Me.Aufgabe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_start = New System.Windows.Forms.Label()
        CType(Me.num_AufgabeVon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_AufgabeBis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_Unterpunkte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Unterpunkte.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_AnzahlAufgaben, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aufgaben Nummern"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Von:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bis:"
        '
        'num_AufgabeVon
        '
        Me.num_AufgabeVon.Location = New System.Drawing.Point(37, 68)
        Me.num_AufgabeVon.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_AufgabeVon.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_AufgabeVon.Name = "num_AufgabeVon"
        Me.num_AufgabeVon.Size = New System.Drawing.Size(47, 20)
        Me.num_AufgabeVon.TabIndex = 3
        Me.num_AufgabeVon.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'num_AufgabeBis
        '
        Me.num_AufgabeBis.Location = New System.Drawing.Point(90, 68)
        Me.num_AufgabeBis.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_AufgabeBis.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_AufgabeBis.Name = "num_AufgabeBis"
        Me.num_AufgabeBis.Size = New System.Drawing.Size(47, 20)
        Me.num_AufgabeBis.TabIndex = 4
        Me.num_AufgabeBis.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'num_Unterpunkte
        '
        Me.num_Unterpunkte.Location = New System.Drawing.Point(19, 36)
        Me.num_Unterpunkte.Maximum = New Decimal(New Integer() {26, 0, 0, 0})
        Me.num_Unterpunkte.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_Unterpunkte.Name = "num_Unterpunkte"
        Me.num_Unterpunkte.Size = New System.Drawing.Size(62, 20)
        Me.num_Unterpunkte.TabIndex = 8
        Me.num_Unterpunkte.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Anzahl:"
        '
        'check_Unterpunkte
        '
        Me.check_Unterpunkte.AutoSize = True
        Me.check_Unterpunkte.Location = New System.Drawing.Point(40, 156)
        Me.check_Unterpunkte.Name = "check_Unterpunkte"
        Me.check_Unterpunkte.Size = New System.Drawing.Size(85, 17)
        Me.check_Unterpunkte.TabIndex = 10
        Me.check_Unterpunkte.Text = "Unterpunkte"
        Me.check_Unterpunkte.UseVisualStyleBackColor = True
        '
        'grp_Unterpunkte
        '
        Me.grp_Unterpunkte.Controls.Add(Me.Label5)
        Me.grp_Unterpunkte.Controls.Add(Me.num_Unterpunkte)
        Me.grp_Unterpunkte.Location = New System.Drawing.Point(36, 195)
        Me.grp_Unterpunkte.Name = "grp_Unterpunkte"
        Me.grp_Unterpunkte.Size = New System.Drawing.Size(101, 67)
        Me.grp_Unterpunkte.TabIndex = 11
        Me.grp_Unterpunkte.TabStop = False
        Me.grp_Unterpunkte.Text = "Unterpunkte"
        Me.grp_Unterpunkte.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Zufallsaufgaben.My.Resources.Resources.image_mini
        Me.PictureBox1.Location = New System.Drawing.Point(160, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btn_Generieren
        '
        Me.btn_Generieren.Location = New System.Drawing.Point(37, 280)
        Me.btn_Generieren.Name = "btn_Generieren"
        Me.btn_Generieren.Size = New System.Drawing.Size(100, 31)
        Me.btn_Generieren.TabIndex = 13
        Me.btn_Generieren.Text = "Generieren"
        Me.btn_Generieren.UseVisualStyleBackColor = True
        '
        'num_AnzahlAufgaben
        '
        Me.num_AnzahlAufgaben.Location = New System.Drawing.Point(36, 122)
        Me.num_AnzahlAufgaben.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_AnzahlAufgaben.Name = "num_AnzahlAufgaben"
        Me.num_AnzahlAufgaben.Size = New System.Drawing.Size(100, 20)
        Me.num_AnzahlAufgaben.TabIndex = 15
        Me.num_AnzahlAufgaben.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Anzahl Aufgaben:"
        '
        'lstBox_Ausgabe
        '
        Me.lstBox_Ausgabe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstBox_Ausgabe.BackColor = System.Drawing.SystemColors.Control
        Me.lstBox_Ausgabe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstBox_Ausgabe.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Aufgabe})
        Me.lstBox_Ausgabe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBox_Ausgabe.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstBox_Ausgabe.Location = New System.Drawing.Point(399, 43)
        Me.lstBox_Ausgabe.Name = "lstBox_Ausgabe"
        Me.lstBox_Ausgabe.Size = New System.Drawing.Size(297, 279)
        Me.lstBox_Ausgabe.TabIndex = 17
        Me.lstBox_Ausgabe.UseCompatibleStateImageBehavior = False
        Me.lstBox_Ausgabe.View = System.Windows.Forms.View.SmallIcon
        '
        'Aufgabe
        '
        Me.Aufgabe.Text = "Aufgabe"
        Me.Aufgabe.Width = 30
        '
        'lbl_start
        '
        Me.lbl_start.AutoSize = True
        Me.lbl_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_start.Location = New System.Drawing.Point(437, 129)
        Me.lbl_start.Name = "lbl_start"
        Me.lbl_start.Size = New System.Drawing.Size(57, 20)
        Me.lbl_start.TabIndex = 18
        Me.lbl_start.Text = "Label6"
        '
        'Zufallsaufgaben
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 339)
        Me.Controls.Add(Me.lbl_start)
        Me.Controls.Add(Me.lstBox_Ausgabe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.num_AnzahlAufgaben)
        Me.Controls.Add(Me.btn_Generieren)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grp_Unterpunkte)
        Me.Controls.Add(Me.check_Unterpunkte)
        Me.Controls.Add(Me.num_AufgabeBis)
        Me.Controls.Add(Me.num_AufgabeVon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(735, 378)
        Me.MinimumSize = New System.Drawing.Size(735, 378)
        Me.Name = "Zufallsaufgaben"
        Me.Text = "Zufallsaufgaben"
        CType(Me.num_AufgabeVon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_AufgabeBis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_Unterpunkte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Unterpunkte.ResumeLayout(False)
        Me.grp_Unterpunkte.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_AnzahlAufgaben, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents num_AufgabeVon As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_AufgabeBis As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_Unterpunkte As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents check_Unterpunkte As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Unterpunkte As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Generieren As System.Windows.Forms.Button
    Friend WithEvents num_AnzahlAufgaben As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstBox_Ausgabe As System.Windows.Forms.ListView
    Friend WithEvents Aufgabe As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_start As System.Windows.Forms.Label

End Class
