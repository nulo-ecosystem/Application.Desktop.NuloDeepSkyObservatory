using Nulo.Utilities;

namespace Nulo.Pages {

    public partial class SplashScreen : Form {

        public SplashScreen() => InitializeComponent();

        private void SplashScreen_Load(object sender, EventArgs e) {
            NameLabel.Text = DataAssembly.GetProductName();
            VersionLabel.Text = DataAssembly.GetSmallVersion();
            CopyrighLabel.Text = DataAssembly.GetCopyright();
        }
    }
}