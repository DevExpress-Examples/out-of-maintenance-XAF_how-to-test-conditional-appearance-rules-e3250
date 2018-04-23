Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.ConditionalAppearance
Imports TestConditionalAppearanceRules.Module
Imports System.Drawing
Imports DevExpress.ExpressApp.SystemModule

Namespace TestConditionalAppearanceRules.UnitTests
    <TestFixture> _
    Public Class PersonConditionalAppearanceTests
        Private person As MyPerson
        Private target As FakeAppearanceTarget
        Private controller As AppearanceController
        Private detailView As DetailView
        <SetUp> _
        Public Sub SetUp()
            Dim objectSpaceProvider As New XPObjectSpaceProvider(New MemoryDataStoreProvider())
            Dim application As New TestApplication()
            Dim testModule As New ModuleBase()
            testModule.AdditionalExportedTypes.Add(GetType(MyPerson))
            application.Modules.Add(testModule)
            application.Modules.Add(New ConditionalAppearanceModule())
            application.Setup("TestApplication", objectSpaceProvider)
            Dim objectSpace As IObjectSpace = objectSpaceProvider.CreateObjectSpace()
            person = objectSpace.CreateObject(Of MyPerson)()
            target = New FakeAppearanceTarget()
            controller = New AppearanceController()
            detailView = application.CreateDetailView(objectSpace, person)
            controller.SetView(detailView)
        End Sub
        <Test> _
        Public Sub TestSpouseNameVisibility()
            person.IsMarried = True
            controller.RefreshItemAppearance(detailView, "ViewItem", "SpouseName", target, person)
            Assert.IsTrue(target.Enabled)
            person.IsMarried = False
            controller.RefreshItemAppearance(detailView, "ViewItem", "SpouseName", target, person)
            Assert.IsFalse(target.Enabled)
        End Sub
        <Test> _
        Public Sub TestNameFontColor()
            person.IsMarried = True
            controller.RefreshItemAppearance(detailView, "ViewItem", "Name", target, person)
            Assert.AreEqual(Color.Red, target.FontColor)
            person.IsMarried = False
            controller.RefreshItemAppearance(detailView, "ViewItem", "Name", target, person)
            Assert.AreEqual(Color.Green, target.FontColor)
        End Sub
    End Class
End Namespace
