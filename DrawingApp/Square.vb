Public Class Square
    Public Property Pen As Pen
    Public Property color1 As Color
    Public Property color2 As Color
    Public Property xSpeed As Integer
    Public Property YSpeed As Integer
    Public Property W As Integer
    Public Property H As Integer
    Public Property Fill As Boolean
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Dim xOffset As Integer
    Dim yOffset As Integer

    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            xOffset += xSpeed
            yOffset += YSpeed
            If Fill Then
                Dim lingrBrush As Drawing.Drawing2D.LinearGradientBrush
                lingrBrush = New Drawing.Drawing2D.LinearGradientBrush(
                                New Point(0, 10),
                                New Point(20, 10),
                                color1,
                                color2)
                g.FillRectangle(lingrBrush, m_a.X, m_a.Y, 50, 50)
            Else
                g.DrawRectangle(Pen, m_a.X + xOffset, m_a.Y + yOffset, m_b.X + xOffset, m_b.Y + yOffset)
            End If
        End Using

    End Sub
End Class
