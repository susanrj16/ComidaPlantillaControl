
using System.Collections.Generic;
using System.Windows;


namespace ComidaPlantillaControl
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            platosListBox.DataContext = Plato.GetSamples("Imagenes/");
            List<string> tipos = new List<string> { "China", "Americana", "Mexicana" };
            tipoComboBox.ItemsSource = tipos;
        }
    }
}
