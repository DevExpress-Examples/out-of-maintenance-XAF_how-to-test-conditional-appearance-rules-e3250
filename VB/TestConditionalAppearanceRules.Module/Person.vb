Imports DevExpress.ExpressApp.Model
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.ConditionalAppearance
Imports DevExpress.Persistent.BaseImpl

Namespace TestConditionalAppearanceRules.Module
    <DefaultClassOptions, ImageName("BO_Person"), ModelDefault("Caption", "Person")> _
    Public Class MyPerson
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private name_Renamed As String
        <Appearance("NameFontIsRed", Criteria:="IsMarried", FontColor:="Red"), Appearance("NameFontIsGreen", Criteria:="!IsMarried", FontColor := "Green")> _
        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", name_Renamed, value)
            End Set
        End Property

        Private isMarried_Renamed As Boolean
        <ImmediatePostData> _
        Public Property IsMarried() As Boolean
            Get
                Return isMarried_Renamed
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue("IsMarried", isMarried_Renamed, value)
                If (Not String.IsNullOrEmpty(SpouseName)) AndAlso (Not value) Then
                    SpouseName = String.Empty
                End If
            End Set
        End Property

        Private spouseName_Renamed As String
        <Appearance("DisableSpouseName", Criteria:="!IsMarried", Enabled:=False)> _
        Public Property SpouseName() As String
            Get
                Return spouseName_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("SpouseName", spouseName_Renamed, value)
            End Set
        End Property
    End Class
End Namespace
