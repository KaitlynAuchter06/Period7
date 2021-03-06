Public Class Form1
    Private m_Previous As System.Nullable(Of Point) = Nothing
    Dim m_shapes As New Collection
    Dim c As Color
    Dim w As Integer
    Dim type As String
    Dim D As Object
    Private Sub pictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        m_Previous = e.Location
        pictureBox1_MouseMove(sender, e)
    End Sub

    Private Sub pictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If m_Previous IsNot Nothing Then
            D = New Line(PictureBox1.Image, m_Previous, e.Location)
            D.Pen = New Pen(c, w)
            D.xSpeed = xSpeedTrackBar.Value
            If type = "line" Then
                D = New Line(PictureBox1.Image, m_Previous, e.Location)
                D.Pen = New Pen(c, w)
                D.xSpeed = xSpeedTrackBar.Value
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If type = "rectangle" Then
                D = New Rectangle(PictureBox1.Image, m_Previous, e.Location)
                D.xSpeed = xSpeedTrackBar.Value
                D.fill = CheckBox2.Checked
                D.color1 = c
                D.color1 = Button8.BackColor
                D.color2 = Button11.BackColor
                D.Pen = New Pen(c, w)
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If type = "Circle" Then
                D = New Circle(PictureBox1.Image, m_Previous, e.Location)
                D.xSpeed = xSpeedTrackBar.Value
                D.fill = CheckBox2.Checked
                D.color1 = c
                D.color1 = Button6.BackColor
                D.color2 = Button8.BackColor
                D.Pen = New Pen(c, w)
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If type = "Square" Then
                D = New Square(PictureBox1.Image, m_Previous, e.Location)
                D.xSpeed = xSpeedTrackBar.Value
                D.fill = CheckBox2.Checked
                D.color1 = c
                D.color1 = Button4.BackColor
                D.color2 = Button6.BackColor
                D.Pen = New Pen(c, w)
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If type = "Polygon" Then
                D = New Polygon(PictureBox1.Image, m_Previous, e.Location)
                D.xSpeed = xSpeedTrackBar.Value
                D.fill = CheckBox2.Checked
                D.color1 = c
                D.color1 = Button2.BackColor
                D.color2 = Button11.BackColor
                D.Pen = New Pen(c, w)
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If type = "N-gon" Then
                D = New N_gon(PictureBox1.Image, m_Previous, e.Location)
                D.xSpeed = xSpeedTrackBar.Value
                D.fill = CheckBox2.Checked
                D.color1 = c
                D.color1 = Button8.BackColor
                D.color2 = Button5.BackColor
                D.Pen = New Pen(c, w)
                D.Radius = RadiusTrackBar.Value
                D.Sides = SidesTrackBar.Value
                'D.h = TrackBar2.Value
                'D.w = TrackBar3.Value
            End If
            If type = "Picture" Then
                D = New PBox(PictureBox1.Image, m_Previous, e.Location)
                D.picture = PictureBox2.Image
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            If type = "Pie" Then
                D = New Pie(PictureBox1.Image, m_Previous, e.Location)
                D.xSpeed = xSpeedTrackBar.Value
            D.fill = CheckBox2.Checked
                D.color1 = c
                D.color1 = Button4.BackColor
                D.color2 = Button5.BackColor
                D.Pen = New Pen(c, w)
                D.h = TrackBar2.Value
                D.w = TrackBar3.Value
            End If
            m_shapes.Add(D)
                PictureBox1.Invalidate()
                m_Previous = e.Location
            End If



    End Sub

    Private Sub pictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        m_Previous = Nothing
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PictureBox1.Image Is Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            PictureBox1.Image = bmp
        End If

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        For Each s As Object In m_shapes
            s.Draw()
        Next
        If (CheckBox1.Checked) Then
            Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        Button1.BackColor = c

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = sender.backcolor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c = sender.backcolor
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        c = sender.backcolor
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        c = sender.backcolor
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c = sender.backcolor
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        c = sender.backcolor
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        c = sender.backcolor
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        c = sender.backcolor
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        w = TrackBar1.Value
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveFileDialog1.ShowDialog()
        PictureBox1.Image.Save(SaveFileDialog1.FileName)
    End Sub

    Private Sub RectangleButton_Click(sender As Object, e As EventArgs) Handles RectangleButton.Click
        Type = "rectangle"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles LineButton.Click
        Type = "Line"
    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        type = "Circle"
    End Sub

    Private Sub SquareButton_Click(sender As Object, e As EventArgs) Handles SquareButton.Click
        type = "Square"
    End Sub

    Private Sub PolyButton_Click(sender As Object, e As EventArgs) Handles PolyButton.Click
        type = "Polygon"
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        c = sender.backcolor
    End Sub

    Private Sub NgonButton_Click(sender As Object, e As EventArgs) Handles NgonButton.Click
        type = "N-gon"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        type = "Picture"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox2.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub PieButton_Click(sender As Object, e As EventArgs) Handles PieButton.Click
        type = "Pie"
    End Sub
End Class
