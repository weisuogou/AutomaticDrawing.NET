﻿Imports AutomaticDrawingLib
''' <summary>
''' 为预览图像更新时的事件提供数据
''' </summary>
Public Class UpdatePreviewEventArgs
    ''' <summary>
    ''' 新的绘制点
    ''' </summary>
    Public Property Point As Vertex
    ''' <summary>
    ''' 进度,范围0.0F~1.0F
    ''' </summary>
    Public Property Percent As Single
    ''' <summary>
    ''' 创建并初始化一个实例
    ''' </summary>
    Public Sub New(point As Vertex, percent As Single)
        Me.Point = point
        Me.Percent = percent
    End Sub
End Class
