﻿Public Class Rectangle
    Public Property Pen As Pen
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
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
            'g.DrawRectangle(Pen, m_a.X, m_a.Y, 100, 100, h, w)
            g.DrawRectangle(Pen, m_a.X, m_b.Y, 100, 100)
        End Using

    End Sub
End Class
