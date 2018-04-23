Imports DevExpress.ExpressApp.Xpo
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Layout

Namespace TestConditionalAppearanceRules.UnitTests
    Friend Class TestApplication
        Inherits XafApplication

        Protected Overrides Function CreateLayoutManagerCore(ByVal simple As Boolean) As LayoutManager
            Return Nothing
        End Function
    End Class
End Namespace
