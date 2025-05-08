using System.Reflection;
using System.Windows;

namespace OpenBrowser
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public static readonly string appName = Assembly.GetExecutingAssembly().GetName().Name ?? "OpenBrowser";
        public static readonly string appVersion = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? string.Empty;

        public App() => InitializeComponent();
    }
}
