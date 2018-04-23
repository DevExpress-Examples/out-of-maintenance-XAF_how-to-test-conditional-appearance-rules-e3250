using DevExpress.ExpressApp.Model;
using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.BaseImpl;

namespace TestConditionalAppearanceRules.Module {
    [DefaultClassOptions, ImageName("BO_Person"), ModelDefault("Caption", "Person")]
    public class MyPerson : BaseObject {
        public MyPerson(Session session) : base(session) { }
        private string name;
        [Appearance("NameFontIsRed", Criteria="IsMarried", FontColor="Red")]
        [Appearance("NameFontIsGreen", Criteria="!IsMarried", FontColor = "Green")]
        public string Name {
            get { return name; }
            set { SetPropertyValue("Name", ref name, value); }
        }
        private bool isMarried;
        [ImmediatePostData]
        public bool IsMarried {
            get { return isMarried; }
            set { 
                SetPropertyValue("IsMarried", ref isMarried, value);
                if (!String.IsNullOrEmpty(SpouseName) && !value) SpouseName = String.Empty;
            }
        }
        private string spouseName;
        [Appearance("DisableSpouseName", Criteria="!IsMarried", Enabled=false)]
        public string SpouseName {
            get { return spouseName; }
            set { SetPropertyValue("SpouseName", ref spouseName, value); }
        }
    }
}
