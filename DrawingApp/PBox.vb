Public Class PBox
    Public Property Picture As Image
    Public Property color1 As Color
    Public Property color2 As Color
    Public Property xSpeed As Integer
    Public Property YSpeed As Integer
    Public Property Fill As Boolean
    Public Property w As Integer
    Public Property h As Integer

    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Dim xOffset As Integer
    Dim yOffset As Integer


    Public Sub New(i As Image, a As Point, b As Point)
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            xOffset += xSpeed
            yOffset += YSpeed
            g.DrawImage(Picture, m_a.X + xOffset, m_a.Y + yOffset, m_b.X + xOffset, m_b.Y + yOffset)

        End Using

    End Sub
End Class
