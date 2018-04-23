Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports DevExpress.ExpressApp.Editors

Namespace TestConditionalAppearanceRules.UnitTests
    Public Class FakeAppearanceTarget
        Implements IAppearanceFormat, IAppearanceEnabled, IAppearanceVisibility

        #Region "IAppearanceFormat Members"

        Private _backColor As Color
        Public Property BackColor() As Color Implements IAppearanceFormat.BackColor
            Get
                Return _backColor
            End Get
            Set(ByVal value As Color)
                _backColor = value
            End Set
        End Property

        Private _fontColor As Color
        Public Property FontColor() As Color Implements IAppearanceFormat.FontColor
            Get
                Return _fontColor
            End Get
            Set(ByVal value As Color)
                _fontColor = value
            End Set
        End Property

        Private _fontstyle As FontStyle
        Public Property FontStyle() As FontStyle Implements IAppearanceFormat.FontStyle
            Get
                Return _fontstyle
            End Get
            Set(ByVal value As FontStyle)
                _fontstyle = value
            End Set
        End Property
        Public Sub ResetFontStyle() Implements IAppearanceFormat.ResetFontStyle
            FontStyle = FontStyle.Regular
        End Sub
        Public Sub ResetFontColor() Implements IAppearanceFormat.ResetFontColor
            FontColor = New Color()
        End Sub
        Public Sub ResetBackColor() Implements IAppearanceFormat.ResetBackColor
            FontColor = New Color()
        End Sub
        #End Region
        #Region "IAppearanceEnabled Members"

        Private _enabled As Boolean
        Public Property Enabled() As Boolean Implements IAppearanceEnabled.Enabled
            Get
                Return _enabled
            End Get
            Set(ByVal value As Boolean)
                _enabled = value
            End Set
        End Property
        Public Sub ResetEnabled() Implements IAppearanceEnabled.ResetEnabled
            Enabled = True
        End Sub
#End Region

        #Region "IAppearanceVisibility Members"
        Private _visibility As ViewItemVisibility = ViewItemVisibility.Show
        Public Property Visibility() As ViewItemVisibility Implements IAppearanceVisibility.Visibility
            Get
                Return _visibility
            End Get
            Set(ByVal value As ViewItemVisibility)
                If (Not _visibility.Equals(value)) Then
                    _visibility = value
                End If
            End Set
        End Property
        Public Sub ResetVisibility() Implements IAppearanceVisibility.ResetVisibility
            Visibility = ViewItemVisibility.Show
        End Sub
        #End Region
    End Class
End Namespace
