using Nulo.Modules.ExtensionManager;

namespace Nulo.Core.Menus {

    [Route("home"), Group(10), Location(0)]
    internal sealed class Home : MenuItem {

        #region Properties

        public override string Text => string.Empty;
        public override Bitmap Icon => Properties.Resources.Icon_Menu_Home;

        #endregion Properties
    }

    [Route("home/exit")]
    internal sealed class HomeExit : MenuItem {

        #region Properties

        public override string Text => Program.MultiLanguageManager.GetText("Menu_Home_Exit");

        #endregion Properties

        #region Methods

        public override void OnClick(object sender, EventArgs args) {
            Application.Exit();
        }

        #endregion Methods
    }
}