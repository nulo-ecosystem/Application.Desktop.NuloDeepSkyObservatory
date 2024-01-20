using Nulo.Modules.ExtensionManager;

namespace Nulo.Core.Menus {

    [Route("window"), Group(20), Location(90)]
    internal sealed class Window : MenuItem {

        #region Properties

        public override string Text => Program.MultiLanguageManager.GetText("Menu_Window");

        #endregion Properties
    }

    [Route("window/workspaces")]
    internal sealed class WindowWorkspaces : MenuItem {

        #region Properties

        public override string Text => Program.MultiLanguageManager.GetText("Menu_Window_Workspaces");

        public override Bitmap Icon => Properties.Resources.Icon_Menu_Window_Workspaces;

        #endregion Properties
    }
}