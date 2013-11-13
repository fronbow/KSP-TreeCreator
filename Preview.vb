Public Class Preview

    Private Sub Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildPreview(Main.Tree)
    End Sub
    Const WidthConst As Integer = 75
    Public Sub BuildPreview(ByVal Tree As Tree)
        Try
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
            Using g As Graphics = Graphics.FromImage(b), dash As New Drawing.Pen(Brushes.Gray, 7), p As New Drawing.Pen(Brushes.Black, 7), line As New Pen(Brushes.LightBlue, 7.5), start As New Drawing.Pen(Brushes.Red, 7)
                dash.DashStyle = Drawing2D.DashStyle.Dash
                line.StartCap = Drawing2D.LineCap.ArrowAnchor
                line.EndCap = Drawing2D.LineCap.Round
                g.FillRectangle(Brushes.White, New Rectangle(0, 0, b.Width, b.Height))
                For Each n As Node In Tree.Nodes
                    Dim pos As New Pos(n.pos.Value)
                    'Dim r As New Rectangle(((pos.X + WidthConst) + WidthConst * -1) * -1, ((pos.Y + WidthConst) + maxy * -1) * -1, WidthConst, WidthConst)
                    Dim r As New Rectangle((pos.X * -1) - (WidthConst / 2) - maxx, pos.Y - (WidthConst / 2) - miny, WidthConst, WidthConst)
                    If n.hideIfEmpty.Value = "True" Then
                        g.DrawRectangle(dash, r)
                    ElseIf n.name.Value = "node0_start" Then
                        g.DrawRectangle(start, r)
                    Else
                        g.DrawRectangle(p, r)
                    End If
                    'g.DrawString(n.title.Value, Drawing.SystemFonts.DefaultFont, Brushes.Black, r.X, r.Y - 25)
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
                b.RotateFlip(RotateFlipType.RotateNoneFlipXY)
                For Each n As Node In Tree.Nodes
                    Dim pos As New Pos(n.pos.Value)
                    'Dim r As New Rectangle(((pos.X + WidthConst) + WidthConst * -1) * -1, ((pos.Y + WidthConst) + maxy * -1) * -1, WidthConst, WidthConst)
                    Dim r As New Rectangle((pos.X * -1) - (WidthConst / 2) - maxx, pos.Y - (WidthConst / 2) - miny, WidthConst, WidthConst)
                    'g.DrawRectangle(p, r)
                    g.DrawString(n.title.Value, Drawing.SystemFonts.DefaultFont, Brushes.Black, b.Width - r.X - r.Width - 3, b.Height - r.Y + 3)
                Next
            End Using
            Crop(b)
            PictureBox1.Image = b
            b = Nothing
            'PictureBox1.Invalidate()
        Catch
        End Try
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

    Private Sub Preview_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PictureBox1.Image = Nothing
        PictureBox1.Dispose()
        GC.Collect()
    End Sub
End Class