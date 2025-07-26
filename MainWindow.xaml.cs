using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Dashboard.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Dashboard
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Al iniciar, navegamos a HomePage
            ContentFrame.Navigate(typeof(HomePage));

            // Evento al cambiar selección en el menú
            NavView.SelectionChanged += OnNavigationViewSelectionChanged;
        }

        private void OnNavigationViewSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItemContainer is NavigationViewItem item && item.Tag is string tag)
            {
                switch (tag)
                {
                    case "home":
                        ContentFrame.Navigate(typeof(HomePage));
                        break;
                    case "reports":
                        ContentFrame.Navigate(typeof(ReportsPage));
                        break;
                    case "settings":
                        ContentFrame.Navigate(typeof(SettingsPage));
                        break;
                }
            }
        }
    }
}
