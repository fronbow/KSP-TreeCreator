Public Class Preview

    Private Sub Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildPreview(Main.Tree)
    End Sub
    Const WidthConst As Integer = 75
    Public Sub BuildPreview(ByVal Tree As Tree)
        Dim maxx As Integer = Integer.MinValue + WidthConst
        Dim maxy As Integer = Integer.MinValue + WidthConst
        Dim minx As Integer = Integer.MaxValue - WidthConst
        Dim miny As Integer = Integer.MaxValue - WidthConst
        For Each n As Node In Tree.Nodes
            Dim p As New Pos(n.pos.Value)
            If p.X < minx + WidthConst Then minx = p.X - WidthConst
            If p.Y < miny + WidthConst Then miny = p.Y - WidthConst
            If p.X > maxx - WidthConst Then maxx = p.X + WidthConst
            If p.Y > maxy - WidthConst Then maxy = p.Y + WidthConst
        Next

        Dim b As New Bitmap(((maxx * 2) + minx) * -1, maxy - miny)
        Using g As Graphics = Graphics.FromImage(b), p As New Drawing.Pen(Brushes.Black, 7), line As New Pen(Brushes.LightBlue, 7.5)
            line.StartCap = Drawing2D.LineCap.ArrowAnchor
            g.FillRectangle(Brushes.White, New Rectangle(0, 0, b.Width, b.Height))
            For Each n As Node In Tree.Nodes
                Dim pos As New Pos(n.pos.Value)
                'Dim r As New Rectangle(((pos.X + WidthConst) + WidthConst * -1) * -1, ((pos.Y + WidthConst) + maxy * -1) * -1, WidthConst, WidthConst)
                Dim r As New Rectangle((pos.X * -1) - (WidthConst / 2) - maxx, pos.Y - (WidthConst / 2) - miny, WidthConst, WidthConst)
                g.DrawRectangle(p, r)
            Next
            For Each n As Node In Tree.Nodes
                For Each pp As String In n.parents.Value.ToString.Split(","c)
                    For Each nn As Node In Tree.Nodes
                        If pp = nn.name.Value Then
                            Dim ppos As New Pos(nn.pos.Value)
                            Dim pos As New Pos(n.pos.Value)
                            Dim r As New Rectangle((pos.X * -1) - (WidthConst / 2) - maxx, pos.Y - (WidthConst / 2) - miny, WidthConst, WidthConst)
                            Dim xx As Integer = CInt((ppos.X * -1) - (WidthConst / 2) - maxx)
                            Dim yy As Integer = CInt(ppos.Y - (WidthConst / 2) - miny)
                            g.DrawLine(line, r.X + r.Width, r.Y + (r.Height \ 2), xx, yy + (WidthConst \ 2))
                        End If
                    Next
                Next
            Next
        End Using
        b.RotateFlip(RotateFlipType.RotateNoneFlipX)
        Crop(b)
        PictureBox1.Image = b
        'PictureBox1.Invalidate()
    End Sub

    Private Sub Crop(ByRef originalBitmap As Bitmap)
        ' Load the bitmap

        ' Find the min/max non-white/transparent pixels
        Dim min As New Point(Integer.MaxValue, Integer.MaxValue)
        Dim max As New Point(Integer.MinValue, Integer.MinValue)

        For x As Integer = 0 To originalBitmap.Width - 1
            For y As Integer = 0 To originalBitmap.Height - 1
                Dim pixelColor As Color = originalBitmap.GetPixel(x, y)
                If Not (pixelColor.R = 255 AndAlso pixelColor.G = 255 AndAlso pixelColor.B = 255) OrElse pixelColor.A < 255 Then
                    If x < min.X Then min.X = x
                    If y < min.Y Then min.Y = y
                    If x > max.X Then max.X = x
                    If y > max.Y Then max.Y = y
                End If
            Next
        Next

        ' Create a new bitmap from the crop rectangle
        Dim cropRectangle As New Rectangle(min.X, min.Y, max.X - min.X, max.Y - min.Y)
        Dim newBitmap As New Bitmap(cropRectangle.Width, cropRectangle.Height)
        originalBitmap = originalBitmap.Clone(cropRectangle, originalBitmap.PixelFormat)
    End Sub
End Class