Imports System.Windows
Imports System.Windows.Controls

Namespace WeatherInLondon

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class TitleItem

        Public Property Text As String

        Public Property ImageSource As String
    End Class
End Namespace
