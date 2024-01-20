using Nulo.Modules.ExtensionManager;

namespace Nulo.Core.Menus {

    [Route("miscellaneous"), Group(20), Location(70)]
    internal sealed class Miscellaneous : MenuItem {

        #region Properties

        public override string Text => Program.MultiLanguageManager.GetText("Menu_Miscellaneous");

        #endregion Properties
    }
}