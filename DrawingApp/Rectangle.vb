Public Class Rectangle
    Public Property Pen As Pen
    Public Property color1 As Color
    Public Property color2 As Color
    Public Property xSpeed As Integer
    Public Property YSpeed As Integer
    Public Property fill As Boolean
    Public Property h As Integer
    Public Property w As Integer
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
            If fill Then
                Dim lingrBrush As Drawing.Drawing2D.LinearGradientBrush
                lingrBrush = New Drawing.Drawing2D.LinearGradientBrush(
                                New Point(0, 10),
                                New Point(20, 10),
                                color1,
                                color2)

                g.FillRectangle(lingrBrush, m_a.X, m_a.Y, 100, 100)
            Else
                g.DrawRectangle(Pen, m_a.X + xOffset, m_a.Y + yOffset, m_b.X + xOffset, m_b.Y + yOffset)
                g.DrawEllipse(Pen, m_a.X + 15, m_a.Y, 10, 100)
                g.DrawEllipse(Pen, m_a.X - 100, m_a.Y, 100, 10)
            End If

        End Using

    End Sub
End Class
