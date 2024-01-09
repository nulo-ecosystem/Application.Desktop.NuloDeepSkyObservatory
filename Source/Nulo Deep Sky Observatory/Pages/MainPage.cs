using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Pages {

    public partial class MainPage : Form {

        public MainPage() {
            InitializeComponent();
            DockPanel.Controls.Add(Program.WorkspaceManager.DockPanel);
            Program.WorkspaceManager.Style = WorkspaceManager_Style;
            Program.WorkspaceManager.SetToolStripWorkspaces(ToolStripWorkspaces);
            Program.WorkspaceManager.SetMenuStripWorkspaces(MenuStripWindow, MenuStripWindowWorkspaces);
            Program.WorkspaceManager.Init();

            Program.MultiLanguageManager.SwitchLanguage += MultiLanguageManager_SwitchLanguage;
            Program.MultiLanguageManager.Update();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e) {
            Program.WorkspaceManager.Dispose();
        }

        private void WorkspaceManager_Style(ToolStripExtender style) {
            BackColor = Program.WorkspaceManager.Theme.ColorPalette.CommandBarMenuDefault.Background;

            style.SetStyle(MenuStrip);
            style.SetStyle(ToolStrip);
            style.SetStyle(StatusStrip);
        }

        private void MultiLanguageManager_SwitchLanguage() {
            MenuStripWindow.Text = Program.MultiLanguageManager.GetText("MenuWindow");
            MenuStripWindowWorkspaces.Text = Program.MultiLanguageManager.GetText("MenuWindowWorkspaces");
            Program.WorkspaceManager.TextsUpdate();
        }
    }
}