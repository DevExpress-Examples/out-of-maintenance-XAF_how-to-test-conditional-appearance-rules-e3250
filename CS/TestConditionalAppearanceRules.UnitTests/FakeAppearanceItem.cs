using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using DevExpress.ExpressApp.Editors;

namespace TestConditionalAppearanceRules.UnitTests {
    public class FakeAppearanceTarget : 
        IAppearanceFormat, IAppearanceEnabled, IAppearanceVisibility {
        #region IAppearanceFormat Members
        private Color backColor;
        public Color BackColor { 
            get { return backColor; } 
            set { backColor = value; } 
        }
        private Color fontColor;
        public Color FontColor { 
            get { return fontColor; } 
            set { fontColor = value; } 
        }
        private FontStyle fontstyle;
        public FontStyle FontStyle { 
            get { return FontStyle; } 
            set { fontstyle = value; } 
        }
        public void ResetFontStyle() {
            FontStyle = FontStyle.Regular;
        }
        public void ResetFontColor() {
            FontColor = new Color();
        }
        public void ResetBackColor() {
            FontColor = new Color();
        }
        #endregion
        #region IAppearanceEnabled Members
        private bool enabled;
        public bool Enabled { 
            get { return enabled; } 
            set { enabled = value; } 
        }
        public void ResetEnabled() {
            Enabled = true;
        }
        #endregion
        #region IAppearanceVisibility Members
        private ViewItemVisibility visibility = ViewItemVisibility.Show;
        public ViewItemVisibility Visibility {
            get { return visibility; }
            set {
                if (visibility != value) {
                    visibility = value;
                }
            }
        }
        public void ResetVisibility() {
            Visibility = ViewItemVisibility.Show;
        }
        #endregion
    }
}
