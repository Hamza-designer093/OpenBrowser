using System.ComponentModel;
using System.Reactive.Disposables;
using System.Runtime.CompilerServices;

namespace OpenBrowser.Windows.ViewModels
{
    internal class BaseViewModel : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected CompositeDisposable Disposable { get; } = [];

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void Dispose()
        {
            Disposable.Dispose();
        }
    }
}
