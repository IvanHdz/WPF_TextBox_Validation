using System.Windows;

namespace TextBox.Validation
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Person p = new Person();
            MainGrid.DataContext = p;
        }
    }
}