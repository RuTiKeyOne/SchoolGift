using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolGift
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            
        }
       private void EngClick(object sender, RoutedEventArgs e)
        {
            Eng eng = new Eng();
            eng.Show();
        }
        private void PhysClick(object sender, RoutedEventArgs e)
        {
            Phys phys = new Phys();
            phys.Show();
        }
        private void GeogClick(object sender, RoutedEventArgs e)
        {
            Geog geog = new Geog();
            geog.Show();
        }
        private void HisClick(object sender, RoutedEventArgs e)
        {
            His his = new His();
            his.Show();
        }
        private void TechClick(object sender, RoutedEventArgs e)
        {
            Tech tech = new Tech();
            tech.Show();
        }
        private void RusClick(object sender, RoutedEventArgs e)
        {
            Rus rus = new Rus();
            rus.Show();
        }
        private void MathClick(object sender, RoutedEventArgs e)
        {
            Math math = new Math();
            math.Show();
        }
        private void CulClick(object sender, RoutedEventArgs e)
        {
            Cul cul = new Cul();
            cul.Show();
        }
        private void ChemClick(object sender, RoutedEventArgs e)
        {
            Chem chem = new Chem();
            chem.Show();
        }
        private void BioClick(object sender, RoutedEventArgs e)
        {
            Bio bio = new Bio();
            bio.Show();
        }
        private void InfClick(object sender, RoutedEventArgs e)
        {
            Inf inf = new Inf();
            inf.Show();
        }
        private void ArtClick(object sender, RoutedEventArgs e)
        {
            Art art = new Art();
            art.Show();
        }
        private void SecClick(object sender, RoutedEventArgs e)
        {
            Sec sec = new Sec();
            sec.Show();
        }
    }
}
