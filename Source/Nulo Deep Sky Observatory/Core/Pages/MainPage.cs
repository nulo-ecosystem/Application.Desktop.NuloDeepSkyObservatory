using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Core.Pages {

    internal partial class MainPage : Form {

        public MainPage(ToolStripItem[] menuItems) {
            InitializeComponent();
            MenuStrip.Items.AddRange(menuItems);

            DockPanel.Controls.Add(Program.WorkspaceManager.DockPanel);
            Program.WorkspaceManager.Style = WorkspaceManager_Style;
            Program.WorkspaceManager.SetToolStripWorkspaces(ToolStripWorkspaces);
            //Program.WorkspaceManager.SetMenuStripWorkspaces(MenuStripWindow, MenuStripWindowWorkspaces);
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
            MenuStripWindow.Text = Program.MultiLanguageManager.GetText("Menu_Window");
            MenuStripWindowWorkspaces.Text = Program.MultiLanguageManager.GetText("Menu_Window_Workspaces");
            Program.WorkspaceManager.TextsUpdate();
        }
    }
}