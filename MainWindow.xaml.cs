using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

using HelixToolkit.Wpf;

namespace WpfHelixToolkit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Gyongyos> gyongyosiLista = new List<Gyongyos>();
        public MainWindow()
        {
            InitializeComponent();

            StreamReader streamReader = new StreamReader("gyongyok.txt");
            streamReader.ReadLine();
            while (!streamReader.EndOfStream)
            {
                string[] koordinatak = streamReader.ReadLine().Split(';');
                gyongyosiLista.Add(new Gyongyos(Convert.ToInt32(koordinatak[0]), Convert.ToInt32(koordinatak[1]), Convert.ToInt32(koordinatak[2]), Convert.ToInt32(koordinatak[3])));
            }
            streamReader.Close();

            foreach (Gyongyos gyongyosi in gyongyosiLista)
            {
                SphereVisual3D sphereVisual3D = new SphereVisual3D();
                sphereVisual3D.Center = new Point3D(gyongyosi.X, gyongyosi.Y, gyongyosi.Z);
                Random random = new Random();
                sphereVisual3D.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(random.Next(256)), Convert.ToByte(random.Next(256)), Convert.ToByte(random.Next(256))));
                sphereVisual3D.Radius = gyongyosi.E * 0.2;
                ter.Children.Add(sphereVisual3D);
            }
        }
    }
}