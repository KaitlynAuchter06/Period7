Public Class Polygon
    Public Property Pen As Pen
    Public Property color1 As Color
    Public Property color2 As Color
    Public Property xSpeed As Integer
    Public Property YSpeed As Integer
    Public Property Fill As Boolean
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Dim points(2) As Point
    Dim xOffset As Integer
    Dim yOffset As Integer
    Public Property h As Integer
    Public Property w As Integer


    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            points(0) = New Point(m_a.X + xOffset, m_a.Y + yOffset)
            points(1) = New Point(m_a.X + xOffset, m_a.Y + yOffset + h)
            points(2) = New Point(m_a.X + xOffset + w, m_a.Y + yOffset)
            xOffset += xSpeed
            yOffset += YSpeed
            If Fill Then
                Dim lingrBrush As Drawing.Drawing2D.LinearGradientBrush
                lingrBrush = New Drawing.Drawing2D.LinearGradientBrush(
                                New Point(0, 10),
                                New Point(20, 10),
                                color1,
                                color2)
                g.FillPolygon(lingrBrush, points)
            Else
                g.DrawPolygon(Pen, points)
            End If
        End Using

    End Sub
End Class
