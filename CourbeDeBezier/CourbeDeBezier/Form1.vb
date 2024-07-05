Imports System.Windows.Forms
Imports System.Windows
Imports System.Text.RegularExpressions

Public Class Form1

    Public Const decim = 10

    Dim isSelected As Boolean = False
    Dim clickedPoint As PointF
    Dim distMin As Double

    'Initilialisation phase de test -> deviendront les valeurs d'entrée
    Dim XdebTg As Single
    Dim Xdeb As Single
    Dim YdebTg As Single
    Dim Ydeb As Single

    Dim XfinTg As Single
    Dim Xfin As Single
    Dim YfinTg As Single
    Dim Yfin As Single

    Dim bezierList As New List(Of CourbeBezier)
    Dim currentBezier As New CourbeBezier(0, 0, 0, 0, 0, 0, 0, 0)


    ' CONVERSION POUR PASSER DU REPERE -1/1 A 0/500 et inverssement
    Public Function ConvProp_PictureToRepereX(ByVal coordX As Single)
        Return Math.Round(PictureBox1.Width / 2 + coordX * PictureBox1.Width / 2, decim)
    End Function

    Public Function ConvProp_PictureToRepereY(ByVal coordY As Single)
        Return Math.Round(PictureBox1.Height / 2 + coordY * PictureBox1.Height / -2, decim)
    End Function

    Public Function ConvProp_RepereToPictureX(ByVal coordX As Single)
        Return Math.Round((-PictureBox1.Width / 2 + coordX) * (2 / PictureBox1.Width), decim)
    End Function

    Public Function ConvProp_RepereToPictureY(ByVal coordY As Single)
        Return Math.Round((-PictureBox1.Height / 2 + coordY) * (-2 / PictureBox1.Height), decim)
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Ajout des couleurs dans la ListBox
        listBoxColor.Items.Add("Rouge")
        listBoxColor.Items.Add("Bleu")
        listBoxColor.Items.Add("Jaune")
        listBoxColor.Items.Add("Vert")
        listBoxColor.Items.Add("Noir")
        listBoxColor.Items.Add("Rose")
        listBoxColor.Items.Add("Gris")

        btnLoadBezier.Enabled = False
        btnDeleteBezier.Enabled = False

        Xdeb = ConvProp_PictureToRepereX(0)
        XdebTg = ConvProp_PictureToRepereX(0)
        Xfin = ConvProp_PictureToRepereX(0)
        XfinTg = ConvProp_PictureToRepereX(0)

        Ydeb = ConvProp_PictureToRepereY(0)
        YdebTg = ConvProp_PictureToRepereY(0)
        Yfin = ConvProp_PictureToRepereY(0)
        YfinTg = ConvProp_PictureToRepereY(0)

        Draw()

        TrackBarSeg.Value = 10
    End Sub

    Private Function Couleur() As Color

        Select Case listBoxColor.SelectedItem
            Case "Rouge"
                Return Color.Red
            Case "Bleu"
                Return Color.Blue
            Case "Jaune"
                Return Color.Yellow
            Case "Vert"
                Return Color.Green
            Case "Noir"
                Return Color.Black
            Case "Rose"
                Return Color.Pink
            Case "Gris"
                Return Color.Gray
            Case Else
                Return Color.Gray
        End Select

    End Function

    Private Sub Reload() Handles TrackBarSeg.ValueChanged, listBoxColor.SelectedIndexChanged
        Draw()
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick 'Check nearest point : utiliser pythagore.

        If isSelected = False Then ' PREMIER CLIQUE : sélectionne 
            Me.Cursor = Cursors.Hand
            clickedPoint = e.Location
            distMin = Distance(clickedPoint.X, clickedPoint.Y, Xdeb, Ydeb)
            lblPointSelected.Text = "Début"

            If distMin > Distance(clickedPoint.X, clickedPoint.Y, XdebTg, YdebTg) Then
                distMin = Distance(clickedPoint.X, clickedPoint.Y, XdebTg, YdebTg)
                lblPointSelected.Text = "Tangeante début"
            End If

            If distMin > Distance(clickedPoint.X, clickedPoint.Y, Xfin, Yfin) Then
                distMin = Distance(clickedPoint.X, clickedPoint.Y, Xfin, Yfin)
                lblPointSelected.Text = "Fin"
            End If

            If distMin > Distance(clickedPoint.X, clickedPoint.Y, XfinTg, YfinTg) Then
                distMin = Distance(clickedPoint.X, clickedPoint.Y, XfinTg, YfinTg)
                lblPointSelected.Text = "Tangeante fin"
            End If
            isSelected = True
        Else ' DEUXIEME CLIQUE : déplace après modification de la souris
            Me.Cursor = Cursors.Arrow
            Select Case Math.Round(distMin)
                Case Math.Round(Distance(clickedPoint.X, clickedPoint.Y, Xdeb, Ydeb))
                    Xdeb = e.Location.X
                    Ydeb = e.Location.Y
                Case Math.Round(Distance(clickedPoint.X, clickedPoint.Y, XdebTg, YdebTg))
                    XdebTg = e.Location.X
                    YdebTg = e.Location.Y
                Case Math.Round(Distance(clickedPoint.X, clickedPoint.Y, Xfin, Yfin))
                    Xfin = e.Location.X
                    Yfin = e.Location.Y
                Case Math.Round(Distance(clickedPoint.X, clickedPoint.Y, XfinTg, YfinTg))
                    XfinTg = e.Location.X
                    YfinTg = e.Location.Y
            End Select
            Draw()

            SetText_TxtBox()
            isSelected = False
            lblPointSelected.Text = "Aucun"
        End If

    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        isSelected = False
        Me.Cursor = Cursors.Arrow
        lblPointSelected.Text = "Aucun"
    End Sub

    Public Sub Draw()

        'Instances du controle graphique, ici pictureBox + du Pen, régler épaisseur couleur etc.. et rajouter d'autres Pens
        Dim myGraphics As Graphics
        Dim myPenRepere As Pen
        Dim myPen As Pen
        Dim myPenTg As Pen
        myGraphics = PictureBox1.CreateGraphics() 'Utilise le picturebox
        myPen = New Pen(color:=Couleur(), width:=5)
        myPenTg = New Pen(color:=Color.Red, width:=3)
        myPenRepere = New Pen(Color.Black, width:=1)

        myGraphics.Clear(Color.White)

        'Trace le repère
        myGraphics.DrawLine(myPenRepere, 0, CSng(PictureBox1.Height / 2), CSng(PictureBox1.Width), CSng(PictureBox1.Height / 2))
        myGraphics.DrawLine(myPenRepere, CSng(PictureBox1.Width / 2), 0, CSng(PictureBox1.Width / 2), CSng(PictureBox1.Height))


        'Crée les tableaux qui seront remplis avec les valeurs des fonctions x(t) et y (t)
        Dim xArray(20) As Single
        Dim yArray(20) As Single


        'Nombre de points de la courbe de Bézier
        Dim nbPoints As Integer = TrackBarSeg.Value '20 Max

        Dim t As Single
        For i = 0 To nbPoints 'ICI 20 POINTS MAX 
            t = (i / nbPoints)
            ' OFFSET + Proportions
            xArray(i) = (((1 - t) ^ 3) * Xdeb) + (3 * t * (1 - t) ^ 2 * XdebTg) + 3 * t ^ 2 * (1 - t) * XfinTg + (t ^ 3) * Xfin
            yArray(i) = (((1 - t) ^ 3) * Ydeb) + (3 * t * (1 - t) ^ 2 * YdebTg) + 3 * t ^ 2 * (1 - t) * YfinTg + (t ^ 3) * Yfin
        Next

        For i = nbPoints To 20 'ICI 20 POINTS MAX 
            xArray(i) = xArray(nbPoints)
            yArray(i) = yArray(nbPoints)
        Next

        'Crée les points de la courbe
        Dim point0 As New PointF(xArray(0), yArray(0))
        Dim point1 As New PointF(xArray(1), yArray(1))
        Dim point2 As New PointF(xArray(2), yArray(2))
        Dim point3 As New PointF(xArray(3), yArray(3))
        Dim point4 As New PointF(xArray(4), yArray(4))
        Dim point5 As New PointF(xArray(5), yArray(5))
        Dim point6 As New PointF(xArray(6), yArray(6))
        Dim point7 As New PointF(xArray(7), yArray(7))
        Dim point8 As New PointF(xArray(8), yArray(8))
        Dim point9 As New PointF(xArray(9), yArray(9))
        Dim point10 As New PointF(xArray(10), yArray(10))
        Dim point11 As New PointF(xArray(11), yArray(11))
        Dim point12 As New PointF(xArray(12), yArray(12))
        Dim point13 As New PointF(xArray(13), yArray(13))
        Dim point14 As New PointF(xArray(14), yArray(14))
        Dim point15 As New PointF(xArray(15), yArray(15))
        Dim point16 As New PointF(xArray(16), yArray(16))
        Dim point17 As New PointF(xArray(17), yArray(17))
        Dim point18 As New PointF(xArray(18), yArray(18))
        Dim point19 As New PointF(xArray(19), yArray(19))
        Dim point20 As New PointF(xArray(20), yArray(20))
        Dim curvePoints = New PointF() {point0, point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12, point13, point14, point15, point16, point17, point18, point19, point20}

        'Dessine la courbe + les tangeantes
        myGraphics.DrawCurve(myPen, curvePoints, 0)
        myGraphics.DrawLine(myPenTg, Xdeb, Ydeb, XdebTg, YdebTg)
        myGraphics.DrawLine(myPenTg, Xfin, Yfin, XfinTg, YfinTg)

        'TODO CALCUL LONGUEUR -> PAS ENCORE FONCTIONNEL

        Dim longueurCourbe As Single = 0
        point0.X = ConvProp_RepereToPictureX(point0.X)
        point1.X = ConvProp_RepereToPictureX(point1.X)
        point2.X = ConvProp_RepereToPictureX(point2.X)
        point3.X = ConvProp_RepereToPictureX(point3.X)
        point4.X = ConvProp_RepereToPictureX(point4.X)
        point5.X = ConvProp_RepereToPictureX(point5.X)
        point6.X = ConvProp_RepereToPictureX(point6.X)
        point7.X = ConvProp_RepereToPictureX(point7.X)
        point8.X = ConvProp_RepereToPictureX(point8.X)
        point9.X = ConvProp_RepereToPictureX(point9.X)
        point10.X = ConvProp_RepereToPictureX(point10.X)
        point11.X = ConvProp_RepereToPictureX(point11.X)
        point12.X = ConvProp_RepereToPictureX(point12.X)
        point13.X = ConvProp_RepereToPictureX(point13.X)
        point14.X = ConvProp_RepereToPictureX(point14.X)
        point15.X = ConvProp_RepereToPictureX(point15.X)
        point16.X = ConvProp_RepereToPictureX(point16.X)
        point17.X = ConvProp_RepereToPictureX(point17.X)
        point18.X = ConvProp_RepereToPictureX(point18.X)
        point19.X = ConvProp_RepereToPictureX(point19.X)
        point20.X = ConvProp_RepereToPictureX(point20.X)

        point0.Y = ConvProp_RepereToPictureY(point0.Y)
        point1.Y = ConvProp_RepereToPictureY(point1.Y)
        point2.Y = ConvProp_RepereToPictureY(point2.Y)
        point3.Y = ConvProp_RepereToPictureY(point3.Y)
        point4.Y = ConvProp_RepereToPictureY(point4.Y)
        point5.Y = ConvProp_RepereToPictureY(point5.Y)
        point6.Y = ConvProp_RepereToPictureY(point6.Y)
        point7.Y = ConvProp_RepereToPictureY(point7.Y)
        point8.Y = ConvProp_RepereToPictureY(point8.Y)
        point9.Y = ConvProp_RepereToPictureY(point9.Y)
        point10.Y = ConvProp_RepereToPictureY(point10.Y)
        point11.Y = ConvProp_RepereToPictureY(point11.Y)
        point12.Y = ConvProp_RepereToPictureY(point12.Y)
        point13.Y = ConvProp_RepereToPictureY(point13.Y)
        point14.Y = ConvProp_RepereToPictureY(point14.Y)
        point15.Y = ConvProp_RepereToPictureY(point15.Y)
        point16.Y = ConvProp_RepereToPictureY(point16.Y)
        point17.Y = ConvProp_RepereToPictureY(point17.Y)
        point18.Y = ConvProp_RepereToPictureY(point18.Y)
        point19.Y = ConvProp_RepereToPictureY(point19.Y)
        point20.Y = ConvProp_RepereToPictureY(point20.Y)

        longueurCourbe = Distance(point0.X, point0.Y, point1.X, point1.Y) + Distance(point1.X, point1.Y, point2.X, point2.Y) + Distance(point2.X, point2.Y, point3.X, point3.Y) _
            + Distance(point3.X, point3.Y, point4.X, point4.Y) + Distance(point4.X, point4.Y, point5.X, point5.Y) + Distance(point5.X, point5.Y, point6.X, point6.Y) _
            + Distance(point6.X, point6.Y, point7.X, point7.Y) + Distance(point7.X, point7.Y, point8.X, point8.Y) + Distance(point8.X, point8.Y, point9.X, point9.Y) _
            + Distance(point9.X, point9.Y, point10.X, point10.Y) + Distance(point10.X, point10.Y, point11.X, point11.Y) + Distance(point11.X, point11.Y, point12.X, point12.Y) _
            + Distance(point12.X, point12.Y, point13.X, point13.Y) + Distance(point13.X, point13.Y, point14.X, point14.Y) + Distance(point14.X, point14.Y, point15.X, point15.Y) _
            + Distance(point15.X, point15.Y, point16.X, point16.Y) + Distance(point16.X, point16.Y, point17.X, point17.Y) + Distance(point17.X, point17.Y, point18.X, point18.Y) _
            + Distance(point18.X, point18.Y, point19.X, point19.Y) + Distance(point19.X, point19.Y, point20.X, point20.Y)

        lblLength.Text = longueurCourbe
    End Sub

    Function Sqr(ByVal a As Double) As Double
        Return a * a
    End Function

    Function Distance(ByVal x1 As Double, ByVal y1 As Double, ByVal x2 As Double, ByVal y2 As Double) As Double
        Return Math.Sqrt(Sqr(y2 - y1) + Sqr(x2 - x1))
    End Function

    Public Sub LoadBezier() 'Modifie la courbe affichée avec celle selectionnée
        Dim numberBezier As Integer = ListBox1.SelectedIndex

        XdebTg = bezierList(numberBezier).XdebTg
        Xdeb = bezierList(numberBezier).Xdeb
        XfinTg = bezierList(numberBezier).XfinTg
        Xfin = bezierList(numberBezier).Xfin

        YdebTg = bezierList(numberBezier).YdebTg
        Ydeb = bezierList(numberBezier).Ydeb
        YfinTg = bezierList(numberBezier).YfinTg
        Yfin = bezierList(numberBezier).Yfin

        Draw()

        SetText_TxtBox()

    End Sub

    Public Sub RemoveBezier(ByVal numberBezier As Integer)
        bezierList.RemoveAt(numberBezier)
        ListBox1.Items.RemoveAt(numberBezier)
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoadBezier.Click
        LoadBezier()
    End Sub

    Private Sub btnDeleteBezier_Click(sender As Object, e As EventArgs) Handles btnDeleteBezier.Click
        RemoveBezier(ListBox1.SelectedIndex)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            btnLoadBezier.Enabled = True
            btnDeleteBezier.Enabled = True
        Else
            btnLoadBezier.Enabled = False
            btnDeleteBezier.Enabled = False
        End If
    End Sub

    Private Sub btnAddBezier_Click(sender As Object, e As EventArgs) Handles btnAddBezier.Click
        AddBezier()
    End Sub

    Public Sub AddBezier()

        currentBezier = New CourbeBezier(XdebTg, Xdeb, XfinTg, Xfin, YdebTg, Ydeb, YfinTg, Yfin)
        bezierList.Add(currentBezier)

        'Rempli la ListBox -> les indices sont réutilisés pour faire le lien
        ListBox1.Items.Add(txtNameBezier.Text + " : " + DateTime.Now.ToString())
    End Sub

    Public Sub SetText_TxtBox()
        txtBox_x1.Text = ConvProp_RepereToPictureX(XdebTg)
        txtBox_x2.Text = ConvProp_RepereToPictureX(Xdeb)
        txtBox_x3.Text = ConvProp_RepereToPictureX(XfinTg)
        txtBox_x4.Text = ConvProp_RepereToPictureX(Xfin)

        txtBox_y1.Text = ConvProp_RepereToPictureY(YdebTg)
        txtBox_y2.Text = ConvProp_RepereToPictureY(Ydeb)
        txtBox_y3.Text = ConvProp_RepereToPictureY(YfinTg)
        txtBox_y4.Text = ConvProp_RepereToPictureY(Yfin)
    End Sub
    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function
    Private Sub txtBox_Leave(sender As Object, e As EventArgs) Handles txtBox_x1.Leave, txtBox_x2.Leave, txtBox_x3.Leave, txtBox_x4.Leave, txtBox_y1.Leave, txtBox_y2.Leave, txtBox_y3.Leave, txtBox_y4.Leave
        Dim isOk As Boolean = False
        Try
            Dim regex = New Regex("^-?[0-1]\d*(\,\d+)?$", RegexOptions.IgnoreCase)
            ' TODO : ESSAYER AVEC UN REGEX DE PRENDRE COMPARER LA VALEUR ou alors -> Décimal ? puis >= -1 & <= 1
            isOk = regex.IsMatch(sender.Text)
            Dim test As Integer = CountCharacter(sender.Text, ",")

            If (sender.Text <> "" And isOk And CountCharacter(sender.Text, ",") <= 1) Then
                If (CSng(sender.Text) <= 1 And CSng(sender.Text) >= -1) Then

                    Select Case sender.Name
                        Case "txtBox_x1"
                            XdebTg = ConvProp_PictureToRepereX(CSng(sender.Text))
                        Case "txtBox_x2"
                            Xdeb = ConvProp_PictureToRepereX(CSng(sender.Text))
                        Case "txtBox_x3"
                            XfinTg = ConvProp_PictureToRepereX(CSng(sender.Text))
                        Case "txtBox_x4"
                            Xfin = ConvProp_PictureToRepereX(CSng(sender.Text))
                        Case "txtBox_y1"
                            YdebTg = ConvProp_PictureToRepereY(CSng(sender.Text))
                        Case "txtBox_y2"
                            Ydeb = ConvProp_PictureToRepereY(CSng(sender.Text))
                        Case "txtBox_y3"
                            YfinTg = ConvProp_PictureToRepereY(CSng(sender.Text))
                        Case "txtBox_y4"
                            Yfin = ConvProp_PictureToRepereY(CSng(sender.Text))
                    End Select
                Else
                    Select Case sender.Name
                        Case "txtBox_x1"
                            sender.Text = ConvProp_RepereToPictureX(XdebTg)
                        Case "txtBox_x2"
                            sender.Text = ConvProp_RepereToPictureX(Xdeb)
                        Case "txtBox_x3"
                            sender.Text = ConvProp_RepereToPictureX(XfinTg)
                        Case "txtBox_x4"
                            sender.Text = ConvProp_RepereToPictureX(Xfin)
                        Case "txtBox_y1"
                            sender.Text = ConvProp_RepereToPictureY(YdebTg)
                        Case "txtBox_y2"
                            sender.Text = ConvProp_RepereToPictureY(Ydeb)
                        Case "txtBox_y3"
                            sender.Text = ConvProp_RepereToPictureY(YfinTg)
                        Case "txtBox_y4"
                            sender.Text = ConvProp_RepereToPictureY(Yfin)
                    End Select
                End If
            Else
                Select Case sender.Name
                    Case "txtBox_x1"
                        sender.Text = ConvProp_RepereToPictureX(XdebTg)
                    Case "txtBox_x2"
                        sender.Text = ConvProp_RepereToPictureX(Xdeb)
                    Case "txtBox_x3"
                        sender.Text = ConvProp_RepereToPictureX(XfinTg)
                    Case "txtBox_x4"
                        sender.Text = ConvProp_RepereToPictureX(Xfin)
                    Case "txtBox_y1"
                        sender.Text = ConvProp_RepereToPictureY(YdebTg)
                    Case "txtBox_y2"
                        sender.Text = ConvProp_RepereToPictureY(Ydeb)
                    Case "txtBox_y3"
                        sender.Text = ConvProp_RepereToPictureY(YfinTg)
                    Case "txtBox_y4"
                        sender.Text = ConvProp_RepereToPictureY(Yfin)
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        Draw()
    End Sub

    Private Sub btnJPEG_Click(sender As Object, e As EventArgs) Handles btnJPEG.Click
        ' Enregistre dans le dossier Debug
        Dim bit As Bitmap = CaptureScreen(Me.Location.X, Me.Location.Y, Me.Width, Me.Height)
        bit.Save(".\Courbe_De_Bézier.jpg", Imaging.ImageFormat.Jpeg)

    End Sub

    Private Function CaptureScreen(ByVal locX As Integer, ByVal locY As Integer, ByVal width As Integer, ByVal height As Integer) As Bitmap

        Dim NewImage As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(NewImage)
            g.CopyFromScreen(locX, locY, 0, 0, NewImage.Size)
        End Using

        Return NewImage

    End Function

    Private Function SaveFile(ByVal wFichier As String) As Boolean

        Dim wFile As System.IO.StreamWriter

        Try

            wFile = New System.IO.StreamWriter(wFichier)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return False

        End Try

        Try

            For Each list In bezierList

                wFile.WriteLine(list.XdebTg.ToString() + ";" + list.Xdeb.ToString() + ";" + list.XfinTg.ToString() + ";" + list.Xfin.ToString() + ";" + list.YdebTg.ToString() + ";" + list.Ydeb.ToString() + ";" + list.YfinTg.ToString() + ";" + list.Yfin.ToString())

            Next

        Catch ex As Exception

            wFile.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try

        wFile.Close()

        Return True
    End Function

    Private Function SaveUnderFile() As Boolean

        Dim pFichierEnCours As String 'déclaration de la variabl
        'Code de la fonction EnregistrerSous. Cette fonction ouvre un boite de dialogue pour le fichier CSV
        Dim wSaveFileDialog As New SaveFileDialog()
        Dim wFlag As Boolean

        wSaveFileDialog.FileName = pFichierEnCours

        wSaveFileDialog.Filter = "Fichiers CSV(csv)|*.csv|Tous les fichiers|*.*"


        If wSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            If SaveFile(wSaveFileDialog.FileName) Then

                wFlag = True

                pFichierEnCours = wSaveFileDialog.FileName

            End If
        End If
        wSaveFileDialog.Dispose()

        Return wFlag
    End Function

    Public Sub GetFromFile()
        ' TODO : Obtenir à partir d'un FICHIER CSV ??
    End Sub

    Private Sub btnRedraw_Click(sender As Object, e As EventArgs)
        'INUTILE ACTUELLEMENT
    End Sub

    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click

        Dim pFichierEnCours As String
        If pFichierEnCours = "" Then 'On sauvegarde le fichier csv dans le repertoire de notre choix
            SaveUnderFile()
        Else
            SaveFile(pFichierEnCours)

        End If

    End Sub

    Private Sub btnImportCSV_Click(sender As Object, e As EventArgs) Handles btnImportCSV.Click

        Dim fileReader As System.IO.StreamReader
        Dim currentBezier As New CourbeBezier(0, 0, 0, 0, 0, 0, 0, 0)
        Dim stringReader As String

        fileReader = My.Computer.FileSystem.OpenTextFileReader(".\Courbe_De_Bézier.csv")
        stringReader = fileReader.ReadLine()

        Dim i As Integer

        Do While (Not fileReader.EndOfStream)

            MessageBox.Show(stringReader)

        Loop

    End Sub

    Private Sub TrackBarSeg_Scroll(sender As Object, e As EventArgs) Handles TrackBarSeg.Scroll
        lblNbSeg.Text = TrackBarSeg.Value
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        lblCursorX.Text = ConvProp_RepereToPictureX(e.Location.X)
        lblCursorY.Text = ConvProp_RepereToPictureY(e.Location.Y)
    End Sub

    Private Sub btnRAZ_Click(sender As Object, e As EventArgs) Handles btnRAZ.Click
        Xdeb = ConvProp_PictureToRepereX(0)
        XdebTg = ConvProp_PictureToRepereX(0)
        Xfin = ConvProp_PictureToRepereX(0)
        XfinTg = ConvProp_PictureToRepereX(0)

        Ydeb = ConvProp_PictureToRepereY(0)
        YdebTg = ConvProp_PictureToRepereY(0)
        Yfin = ConvProp_PictureToRepereY(0)
        YfinTg = ConvProp_PictureToRepereY(0)

        txtBox_x1.Text = 0
        txtBox_x2.Text = 0
        txtBox_x3.Text = 0
        txtBox_x4.Text = 0

        txtBox_y1.Text = 0
        txtBox_y2.Text = 0
        txtBox_y3.Text = 0
        txtBox_y4.Text = 0

        TrackBarSeg.Value = 10
        lblNbSeg.Text = 10

        Draw()
    End Sub

End Class
