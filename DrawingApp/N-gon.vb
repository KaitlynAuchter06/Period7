Public Class N_gon
    Public Property Pen As Pen
    Public Property color1 As Color
    Public Property color2 As Color
    Public Property xSpeed As Integer
    Public Property YSpeed As Integer
    Public Property fill As Boolean
    Public Property Sides As Integer
    Public Property Radius As Integer
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
        Dim Points(Sides - 1) As Point

        For index = 0 To Sides - 1
            Dim X As Integer
            Dim Y As Integer

            X = Math.Cos(index * 2 * Math.PI / Sides) * Radius
            Y = Math.Sin(index * 2 * Math.PI / Sides) * Radius
            Points(index) = New Point(m_a.X + xOffset + X, m_a.Y + yOffset + Y)
        Next
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
                g.FillPolygon(lingrBrush, Points)
            Else
                g.DrawPolygon(Pen, Points)
            End If
        End Using

    End Sub
End Class
