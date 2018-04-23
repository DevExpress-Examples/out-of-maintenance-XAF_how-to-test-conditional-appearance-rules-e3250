Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace TestConditionalAppearanceRules.Web
    Partial Public Class TestConditionalAppearanceRulesAspNetApplication
        Inherits WebApplication

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub
        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
        Private module3 As TestConditionalAppearanceRules.Module.TestConditionalAppearanceRulesModule
        'private TestConditionalAppearanceRules.Module.Web.TestConditionalAppearanceRulesAspNetModule module4;
        Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
        Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private conditionalAppearanceModule1 As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
        Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub TestConditionalAppearanceRulesAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub

        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
            Me.module3 = New TestConditionalAppearanceRules.Module.TestConditionalAppearanceRulesModule()
            Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
            Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
            Me.conditionalAppearanceModule1 = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' module3
            ' 
            Me.module3.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Country))
            ' 
            ' module5
            ' 
            Me.module5.AllowValidationDetailsAccess = True
            ' 
            ' TestConditionalAppearanceRulesAspNetApplication
            ' 
            Me.ApplicationName = "TestConditionalAppearanceRules"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module6)
            Me.Modules.Add(Me.conditionalAppearanceModule1)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module5)
            Me.Modules.Add(Me.securityModule1)
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace
