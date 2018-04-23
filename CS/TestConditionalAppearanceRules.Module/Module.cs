using System;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using System.Reflection;


namespace TestConditionalAppearanceRules.Module {
    public sealed partial class TestConditionalAppearanceRulesModule : ModuleBase {
        public TestConditionalAppearanceRulesModule() {
            ModelDifferenceResourceName = "TestConditionalAppearanceRules.Module.Model.DesignedDiffs";
            InitializeComponent();
        }
    }
}
