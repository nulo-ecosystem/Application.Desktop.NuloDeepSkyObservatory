using Nulo.Modules.MultiLanguageManager;
using Nulo.Modules.WorkspaceManager;
using Nulo.Core.Pages;

namespace Nulo {

    internal static class Program {
        public static MultiLanguageManager<LanguageData> MultiLanguageManager;
        public static WorkspaceManager<WorkspaceTheme, WorkspaceData> WorkspaceManager;

        [STAThread]
        private static void Main() {
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Loading Modules

            var splash = new SplashScreen();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(500);

            #region Multi-Language Manager

            splash.SetStatusLabel("...");
            MultiLanguageManager = new MultiLanguageManager<LanguageData>("Nulo.Modules.MultiLanguageManager.Language");

            Application.DoEvents();
            Thread.Sleep(500);

            #endregion Multi-Language Manager

            #region Workspace Manager

            splash.SetStatusLabel(MultiLanguageManager.GetText("Pages_SplashScreen_WorkspaceManager"));
            WorkspaceManager = new WorkspaceManager<WorkspaceTheme, WorkspaceData>();

            Application.DoEvents();
            Thread.Sleep(500);

            #endregion Workspace Manager

            splash.SetStatusLabel(string.Empty);
            Application.DoEvents();
            Thread.Sleep(500);
            splash.Dispose();

            #endregion Loading Modules

            Application.Run(new MainPage());
        }
    }
}