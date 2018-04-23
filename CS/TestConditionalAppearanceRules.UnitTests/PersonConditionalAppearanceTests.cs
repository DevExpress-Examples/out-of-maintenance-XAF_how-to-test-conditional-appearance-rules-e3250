using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.ConditionalAppearance;
using TestConditionalAppearanceRules.Module;
using System.Drawing;
using DevExpress.ExpressApp.SystemModule;

namespace TestConditionalAppearanceRules.UnitTests {
    [TestFixture]
    public class PersonConditionalAppearanceTests {
        private MyPerson person;
        private FakeAppearanceTarget target;
        private AppearanceController controller;
        private DetailView detailView;
        [SetUp]
        public void SetUp() {
            XPObjectSpaceProvider objectSpaceProvider = 
                new XPObjectSpaceProvider(new MemoryDataStoreProvider());
            TestApplication application = new TestApplication();
            ModuleBase testModule = new ModuleBase();
            testModule.AdditionalExportedTypes.Add(typeof(MyPerson));
            application.Modules.Add(testModule);
            application.Modules.Add(new ConditionalAppearanceModule());
            application.Setup("TestApplication", objectSpaceProvider);
            IObjectSpace objectSpace = objectSpaceProvider.CreateObjectSpace();
            person = objectSpace.CreateObject<MyPerson>();
            target = new FakeAppearanceTarget();
            controller = new AppearanceController();
            detailView = application.CreateDetailView(objectSpace, person);
            controller.SetView(detailView);
        }
        [Test]
        public void TestSpouseNameVisibility() {
            person.IsMarried = true;
            controller.RefreshItemAppearance(detailView, "ViewItem", "SpouseName", target, person);
            Assert.IsTrue(target.Enabled);
            person.IsMarried = false;
            controller.RefreshItemAppearance(detailView, "ViewItem", "SpouseName", target, person);
            Assert.IsFalse(target.Enabled);
        }
        [Test]
        public void TestNameFontColor() {
            person.IsMarried = true;
            controller.RefreshItemAppearance(detailView, "ViewItem", "Name", target, person);
            Assert.AreEqual(Color.Red, target.FontColor);
            person.IsMarried = false;
            controller.RefreshItemAppearance(detailView, "ViewItem", "Name", target, person);
            Assert.AreEqual(Color.Green, target.FontColor);
        }
    }
}
