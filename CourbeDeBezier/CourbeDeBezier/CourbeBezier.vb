Public Class CourbeBezier
    Public XdebTg As Single
    Public Xdeb As Single
    Public YdebTg As Single
    Public Ydeb As Single

    Public XfinTg As Single
    Public Xfin As Single
    Public YfinTg As Single
    Public Yfin As Single

    Public Sub New(ByVal _XdebTg As Single, _Xdeb As Single, _XfinTg As Single, _Xfin As Single, _YdebTg As Single, _Ydeb As Single, _YfinTg As Single, _Yfin As Single)
        Me.Xdeb = _Xdeb
        Me.XdebTg = _XdebTg
        Me.Xfin = _Xfin
        Me.XfinTg = _XfinTg

        Me.Ydeb = _Ydeb
        Me.YdebTg = _YdebTg
        Me.Yfin = _Yfin
        Me.YfinTg = _YfinTg

    End Sub

End Class
