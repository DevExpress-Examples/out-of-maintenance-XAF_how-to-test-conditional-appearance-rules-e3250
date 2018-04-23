using DevExpress.ExpressApp.Xpo;
using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Layout;

namespace TestConditionalAppearanceRules.UnitTests {
    class TestApplication : XafApplication {
        protected override LayoutManager CreateLayoutManagerCore(bool simple) {
            return null;
        }
    }
}
