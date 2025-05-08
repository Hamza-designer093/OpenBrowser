using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace OpenBrowser.Windows.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        public ReactiveProperty<string> Title { get; }

        public MainViewModel()
        {
            this.Title = new ReactiveProperty<string>(App.appName).AddTo(this.Disposable);
        }
    }
}
