<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNbSeg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblpt = New System.Windows.Forms.Label()
        Me.listBoxColor = New System.Windows.Forms.ListBox()
        Me.lblseg = New System.Windows.Forms.Label()
        Me.TrackBarSeg = New System.Windows.Forms.TrackBar()
        Me.txtBox_y4 = New System.Windows.Forms.TextBox()
        Me.txtBox_y3 = New System.Windows.Forms.TextBox()
        Me.txtBox_y2 = New System.Windows.Forms.TextBox()
        Me.txtBox_y1 = New System.Windows.Forms.TextBox()
        Me.txtBox_x4 = New System.Windows.Forms.TextBox()
        Me.txtBox_x3 = New System.Windows.Forms.TextBox()
        Me.txtBox_x2 = New System.Windows.Forms.TextBox()
        Me.txtBox_x1 = New System.Windows.Forms.TextBox()
        Me.lblx4 = New System.Windows.Forms.Label()
        Me.lblx3 = New System.Windows.Forms.Label()
        Me.lblx2 = New System.Windows.Forms.Label()
        Me.lblx1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnJPEG = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnAddBezier = New System.Windows.Forms.Button()
        Me.btnDeleteBezier = New System.Windows.Forms.Button()
        Me.btnLoadBezier = New System.Windows.Forms.Button()
        Me.txtNameBezier = New System.Windows.Forms.TextBox()
        Me.lblPointSelected = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.btnImportCSV = New System.Windows.Forms.Button()
        Me.btnExportCSV = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCursorX = New System.Windows.Forms.Label()
        Me.lblCursorY = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnRAZ = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBarSeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("DINOT-Bold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(386, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(634, 45)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "GÉNÉRATEUR DE COURBES DE BÉZIER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.btnRAZ)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblNbSeg)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblpt)
        Me.Panel1.Controls.Add(Me.listBoxColor)
        Me.Panel1.Controls.Add(Me.lblseg)
        Me.Panel1.Controls.Add(Me.TrackBarSeg)
        Me.Panel1.Controls.Add(Me.txtBox_y4)
        Me.Panel1.Controls.Add(Me.txtBox_y3)
        Me.Panel1.Controls.Add(Me.txtBox_y2)
        Me.Panel1.Controls.Add(Me.txtBox_y1)
        Me.Panel1.Controls.Add(Me.txtBox_x4)
        Me.Panel1.Controls.Add(Me.txtBox_x3)
        Me.Panel1.Controls.Add(Me.txtBox_x2)
        Me.Panel1.Controls.Add(Me.txtBox_x1)
        Me.Panel1.Controls.Add(Me.lblx4)
        Me.Panel1.Controls.Add(Me.lblx3)
        Me.Panel1.Controls.Add(Me.lblx2)
        Me.Panel1.Controls.Add(Me.lblx1)
        Me.Panel1.Location = New System.Drawing.Point(12, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1382, 184)
        Me.Panel1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(580, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 27)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Y"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(493, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 27)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "X"
        '
        'lblNbSeg
        '
        Me.lblNbSeg.AutoSize = True
        Me.lblNbSeg.Font = New System.Drawing.Font("DINOT-Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbSeg.Location = New System.Drawing.Point(877, 109)
        Me.lblNbSeg.Name = "lblNbSeg"
        Me.lblNbSeg.Size = New System.Drawing.Size(45, 35)
        Me.lblNbSeg.TabIndex = 18
        Me.lblNbSeg.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1083, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 27)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Liste de couleurs :"
        '
        'lblpt
        '
        Me.lblpt.AutoSize = True
        Me.lblpt.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpt.Location = New System.Drawing.Point(3, 4)
        Me.lblpt.Name = "lblpt"
        Me.lblpt.Size = New System.Drawing.Size(248, 27)
        Me.lblpt.TabIndex = 0
        Me.lblpt.Text = "PARAMÈTRES DU TRACÉ"
        '
        'listBoxColor
        '
        Me.listBoxColor.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBoxColor.FormattingEnabled = True
        Me.listBoxColor.ItemHeight = 27
        Me.listBoxColor.Location = New System.Drawing.Point(1088, 51)
        Me.listBoxColor.Name = "listBoxColor"
        Me.listBoxColor.Size = New System.Drawing.Size(275, 112)
        Me.listBoxColor.TabIndex = 16
        '
        'lblseg
        '
        Me.lblseg.AutoSize = True
        Me.lblseg.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseg.Location = New System.Drawing.Point(757, 19)
        Me.lblseg.Name = "lblseg"
        Me.lblseg.Size = New System.Drawing.Size(219, 27)
        Me.lblseg.TabIndex = 2
        Me.lblseg.Text = "Nombre de segments :"
        '
        'TrackBarSeg
        '
        Me.TrackBarSeg.BackColor = System.Drawing.SystemColors.Window
        Me.TrackBarSeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.TrackBarSeg.Location = New System.Drawing.Point(762, 51)
        Me.TrackBarSeg.Maximum = 20
        Me.TrackBarSeg.Minimum = 1
        Me.TrackBarSeg.Name = "TrackBarSeg"
        Me.TrackBarSeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrackBarSeg.Size = New System.Drawing.Size(275, 45)
        Me.TrackBarSeg.TabIndex = 15
        Me.TrackBarSeg.Value = 10
        '
        'txtBox_y4
        '
        Me.txtBox_y4.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_y4.Location = New System.Drawing.Point(551, 142)
        Me.txtBox_y4.Name = "txtBox_y4"
        Me.txtBox_y4.Size = New System.Drawing.Size(80, 35)
        Me.txtBox_y4.TabIndex = 14
        Me.txtBox_y4.Text = "0"
        Me.txtBox_y4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox_y3
        '
        Me.txtBox_y3.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_y3.Location = New System.Drawing.Point(551, 106)
        Me.txtBox_y3.Name = "txtBox_y3"
        Me.txtBox_y3.Size = New System.Drawing.Size(80, 35)
        Me.txtBox_y3.TabIndex = 13
        Me.txtBox_y3.Text = "0"
        Me.txtBox_y3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox_y2
        '
        Me.txtBox_y2.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_y2.Location = New System.Drawing.Point(551, 70)
        Me.txtBox_y2.Name = "txtBox_y2"
        Me.txtBox_y2.Size = New System.Drawing.Size(80, 35)
        Me.txtBox_y2.TabIndex = 12
        Me.txtBox_y2.Text = "0"
        Me.txtBox_y2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox_y1
        '
        Me.txtBox_y1.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_y1.Location = New System.Drawing.Point(551, 34)
        Me.txtBox_y1.Name = "txtBox_y1"
        Me.txtBox_y1.Size = New System.Drawing.Size(80, 35)
        Me.txtBox_y1.TabIndex = 11
        Me.txtBox_y1.Text = "0"
        Me.txtBox_y1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox_x4
        '
        Me.txtBox_x4.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_x4.Location = New System.Drawing.Point(465, 142)
        Me.txtBox_x4.Name = "txtBox_x4"
        Me.txtBox_x4.Size = New System.Drawing.Size(80, 35)
        Me.txtBox_x4.TabIndex = 6
        Me.txtBox_x4.Text = "0"
        Me.txtBox_x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox_x3
        '
        Me.txtBox_x3.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_x3.Location = New System.Drawing.Point(465, 106)
        Me.txtBox_x3.Name = "txtBox_x3"
        Me.txtBox_x3.Size = New System.Drawing.Size(80, 35)
        Me.txtBox_x3.TabIndex = 5
        Me.txtBox_x3.Text = "0"
        Me.txtBox_x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox_x2
        '
        Me.txtBox_x2.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_x2.Location = New System.Drawing.Point(465, 70)
        Me.txtBox_x2.Name = "txtBox_x2"
        Me.txtBox_x2.Size = New System.Drawing.Size(80, 35)
        Me.txtBox_x2.TabIndex = 4
        Me.txtBox_x2.Text = "0"
        Me.txtBox_x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox_x1
        '
        Me.txtBox_x1.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_x1.Location = New System.Drawing.Point(465, 34)
        Me.txtBox_x1.Name = "txtBox_x1"
        Me.txtBox_x1.Size = New System.Drawing.Size(80, 35)
        Me.txtBox_x1.TabIndex = 2
        Me.txtBox_x1.Text = "0"
        Me.txtBox_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblx4
        '
        Me.lblx4.AutoSize = True
        Me.lblx4.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx4.Location = New System.Drawing.Point(400, 142)
        Me.lblx4.Name = "lblx4"
        Me.lblx4.Size = New System.Drawing.Size(52, 27)
        Me.lblx4.TabIndex = 3
        Me.lblx4.Text = "Fin :"
        '
        'lblx3
        '
        Me.lblx3.AutoSize = True
        Me.lblx3.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx3.Location = New System.Drawing.Point(304, 106)
        Me.lblx3.Name = "lblx3"
        Me.lblx3.Size = New System.Drawing.Size(148, 27)
        Me.lblx3.TabIndex = 2
        Me.lblx3.Text = "Tangeante fin :"
        '
        'lblx2
        '
        Me.lblx2.AutoSize = True
        Me.lblx2.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx2.Location = New System.Drawing.Point(374, 70)
        Me.lblx2.Name = "lblx2"
        Me.lblx2.Size = New System.Drawing.Size(78, 27)
        Me.lblx2.TabIndex = 1
        Me.lblx2.Text = "Début :"
        '
        'lblx1
        '
        Me.lblx1.AutoSize = True
        Me.lblx1.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblx1.Location = New System.Drawing.Point(276, 34)
        Me.lblx1.Name = "lblx1"
        Me.lblx1.Size = New System.Drawing.Size(176, 27)
        Me.lblx1.TabIndex = 0
        Me.lblx1.Text = "Tangeante début :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(248, 249)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 500)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnJPEG
        '
        Me.btnJPEG.Font = New System.Drawing.Font("DINOT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJPEG.Location = New System.Drawing.Point(754, 704)
        Me.btnJPEG.Name = "btnJPEG"
        Me.btnJPEG.Size = New System.Drawing.Size(640, 45)
        Me.btnJPEG.TabIndex = 3
        Me.btnJPEG.Text = "Exporter un screenshot au format .JPEG"
        Me.btnJPEG.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 27
        Me.ListBox1.Location = New System.Drawing.Point(754, 279)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.Size = New System.Drawing.Size(640, 139)
        Me.ListBox1.TabIndex = 4
        '
        'btnAddBezier
        '
        Me.btnAddBezier.Font = New System.Drawing.Font("DINOT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBezier.Location = New System.Drawing.Point(754, 475)
        Me.btnAddBezier.Name = "btnAddBezier"
        Me.btnAddBezier.Size = New System.Drawing.Size(315, 45)
        Me.btnAddBezier.TabIndex = 5
        Me.btnAddBezier.Text = "Ajouter la courbe actuelle"
        Me.btnAddBezier.UseVisualStyleBackColor = True
        '
        'btnDeleteBezier
        '
        Me.btnDeleteBezier.Font = New System.Drawing.Font("DINOT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBezier.Location = New System.Drawing.Point(1079, 475)
        Me.btnDeleteBezier.Name = "btnDeleteBezier"
        Me.btnDeleteBezier.Size = New System.Drawing.Size(315, 45)
        Me.btnDeleteBezier.TabIndex = 6
        Me.btnDeleteBezier.Text = "Supprimer la courbe sélectionnée"
        Me.btnDeleteBezier.UseVisualStyleBackColor = True
        '
        'btnLoadBezier
        '
        Me.btnLoadBezier.Font = New System.Drawing.Font("DINOT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadBezier.Location = New System.Drawing.Point(754, 424)
        Me.btnLoadBezier.Name = "btnLoadBezier"
        Me.btnLoadBezier.Size = New System.Drawing.Size(640, 45)
        Me.btnLoadBezier.TabIndex = 8
        Me.btnLoadBezier.Text = "Charger la courbe sélectionnée"
        Me.btnLoadBezier.UseVisualStyleBackColor = True
        '
        'txtNameBezier
        '
        Me.txtNameBezier.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameBezier.Location = New System.Drawing.Point(977, 528)
        Me.txtNameBezier.Name = "txtNameBezier"
        Me.txtNameBezier.Size = New System.Drawing.Size(417, 35)
        Me.txtNameBezier.TabIndex = 9
        Me.txtNameBezier.Text = "Default"
        '
        'lblPointSelected
        '
        Me.lblPointSelected.AutoSize = True
        Me.lblPointSelected.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointSelected.Location = New System.Drawing.Point(7, 321)
        Me.lblPointSelected.Name = "lblPointSelected"
        Me.lblPointSelected.Size = New System.Drawing.Size(71, 27)
        Me.lblPointSelected.TabIndex = 10
        Me.lblPointSelected.Text = "Aucun"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(63, 620)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(23, 27)
        Me.lblLength.TabIndex = 11
        Me.lblLength.Text = "0"
        '
        'btnImportCSV
        '
        Me.btnImportCSV.Font = New System.Drawing.Font("DINOT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportCSV.Location = New System.Drawing.Point(1079, 613)
        Me.btnImportCSV.Name = "btnImportCSV"
        Me.btnImportCSV.Size = New System.Drawing.Size(315, 45)
        Me.btnImportCSV.TabIndex = 16
        Me.btnImportCSV.Text = "Importer un fichier .CSV"
        Me.btnImportCSV.UseVisualStyleBackColor = True
        '
        'btnExportCSV
        '
        Me.btnExportCSV.Font = New System.Drawing.Font("DINOT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportCSV.Location = New System.Drawing.Point(754, 613)
        Me.btnExportCSV.Name = "btnExportCSV"
        Me.btnExportCSV.Size = New System.Drawing.Size(315, 45)
        Me.btnExportCSV.TabIndex = 15
        Me.btnExportCSV.Text = "Exporter les courbes en .CSV"
        Me.btnExportCSV.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 584)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 27)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Longueur de la courbe :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(757, 532)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 27)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nom de votre courbe :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(928, 583)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 27)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Export/Import en fichier .CSV :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(895, 674)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(359, 27)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Export d'une image au format .JPEG :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(917, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(315, 27)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Liste des courbes sauvegardées :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 27)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Position du curseur :"
        '
        'lblCursorX
        '
        Me.lblCursorX.AutoSize = True
        Me.lblCursorX.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursorX.Location = New System.Drawing.Point(111, 450)
        Me.lblCursorX.Name = "lblCursorX"
        Me.lblCursorX.Size = New System.Drawing.Size(23, 27)
        Me.lblCursorX.TabIndex = 24
        Me.lblCursorX.Text = "0"
        '
        'lblCursorY
        '
        Me.lblCursorY.AutoSize = True
        Me.lblCursorY.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursorY.Location = New System.Drawing.Point(111, 485)
        Me.lblCursorY.Name = "lblCursorY"
        Me.lblCursorY.Size = New System.Drawing.Size(23, 27)
        Me.lblCursorY.TabIndex = 25
        Me.lblCursorY.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 450)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 27)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "X :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 485)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 27)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Y :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(249, 504)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 27)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "-1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(723, 472)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 27)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(472, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 27)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(500, 720)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 27)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "-1"
        '
        'btnRAZ
        '
        Me.btnRAZ.Font = New System.Drawing.Font("DINOT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRAZ.Location = New System.Drawing.Point(637, 34)
        Me.btnRAZ.Name = "btnRAZ"
        Me.btnRAZ.Size = New System.Drawing.Size(73, 143)
        Me.btnRAZ.TabIndex = 30
        Me.btnRAZ.Text = "RAZ des points"
        Me.btnRAZ.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("DINOT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label16.Location = New System.Drawing.Point(17, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(246, 24)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Les coordonnées doivent se "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("DINOT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label17.Location = New System.Drawing.Point(86, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 24)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "situer entre"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("DINOT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label18.Location = New System.Drawing.Point(108, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 24)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "-1 et 1."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("DINOT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Maroon
        Me.Label19.Location = New System.Drawing.Point(4, 157)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(304, 20)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Les décimales s'écrivent avec une virgule."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("DINOT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 291)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(182, 27)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Point sélectionné :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1406, 761)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblCursorY)
        Me.Controls.Add(Me.lblCursorX)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnImportCSV)
        Me.Controls.Add(Me.btnExportCSV)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblPointSelected)
        Me.Controls.Add(Me.txtNameBezier)
        Me.Controls.Add(Me.btnLoadBezier)
        Me.Controls.Add(Me.btnDeleteBezier)
        Me.Controls.Add(Me.btnAddBezier)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnJPEG)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbltitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Générateur de courbes de Bézier"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBarSeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblseg As Label
    Friend WithEvents TrackBarSeg As TrackBar
    Friend WithEvents txtBox_y4 As TextBox
    Friend WithEvents txtBox_y3 As TextBox
    Friend WithEvents txtBox_y2 As TextBox
    Friend WithEvents txtBox_y1 As TextBox
    Friend WithEvents txtBox_x4 As TextBox
    Friend WithEvents txtBox_x3 As TextBox
    Friend WithEvents txtBox_x2 As TextBox
    Friend WithEvents txtBox_x1 As TextBox
    Friend WithEvents lblx4 As Label
    Friend WithEvents lblx3 As Label
    Friend WithEvents lblx2 As Label
    Friend WithEvents lblx1 As Label
    Friend WithEvents lblpt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents listBoxColor As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnJPEG As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnAddBezier As Button
    Friend WithEvents btnDeleteBezier As Button
    Friend WithEvents btnLoadBezier As Button
    Friend WithEvents txtNameBezier As TextBox
    Friend WithEvents lblPointSelected As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents btnImportCSV As Button
    Friend WithEvents btnExportCSV As Button
    Friend WithEvents lblNbSeg As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCursorX As Label
    Friend WithEvents lblCursorY As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnRAZ As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
End Class
