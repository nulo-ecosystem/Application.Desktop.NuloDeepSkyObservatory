using Nulo.Core.Utilities;

namespace Nulo.Core.Pages {

    internal partial class SplashScreen : Form {

        public SplashScreen() => InitializeComponent();

        private void SplashScreen_Load(object sender, EventArgs e) {
            NameLabel.Text = NativeMethods.GetProductName();
            VersionLabel.Text = NativeMethods.GetSmallVersion();
            CopyrighLabel.Text = NativeMethods.GetCopyright();
        }

        public void SetStatusLabel(string message) {
            StatusLabel.Text = message;
            Application.DoEvents();
        }
    }
}