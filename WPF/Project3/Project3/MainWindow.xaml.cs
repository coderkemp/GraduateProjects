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
using Project3.ViewModels;

namespace Project3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        AboutViewModel avm;
        UGDegreesViewModel dvm;
        GradDegreesViewModel gdvm;
        MinorsViewModel mvm;
        PeopleViewModel pvm;
        NewsViewModel nvm;
        public MainWindow()
        {
            InitializeComponent();
            avm = new AboutViewModel();
            dvm = new UGDegreesViewModel();
            gdvm = new GradDegreesViewModel();
            mvm = new MinorsViewModel();
            pvm = new PeopleViewModel();
            nvm = new NewsViewModel();

            this.DataContext = avm;
            this.DataContext = dvm;
            this.DataContext = gdvm;
            this.DataContext = mvm;
            this.DataContext = pvm;
            this.DataContext = nvm;

        
        }

        private void About_Button_Click(object sender, RoutedEventArgs e)
        {

            avm.GetAboutdata();
            AbouttxtOutput.Text = avm.aboutData;
        }

        private void UGDegrees_Button_Click(object sender, RoutedEventArgs e)
        {

            dvm.GetDegreesData();
            DegreestxtOutput.Text = dvm.UGDegreesData;
        }

        private void GradDegrees_Button_Click(object sender, RoutedEventArgs e)
        {

            gdvm.GetDegreesData();
            GradDegreestxtOutput.Text = gdvm.GradDegreesData;
        }

        private void Minors_Button_Click(object sender, RoutedEventArgs e)
        {

            mvm.GetMinorsData();
            MinorstxtOutput.Text = mvm.MinorsData;
        }

  

      private void Map_Button_Click(object sender, RoutedEventArgs e)
        {

            this.MainBrowser.Navigate("http://ist.rit.edu/api/map/");
        }
     

        private void People_Button_Click(object sender, RoutedEventArgs e)
        {

            pvm.GetPeopledata();
            list1.ItemsSource = pvm.pitem;

        }

        private void News_Button_Click(object sender, RoutedEventArgs e)
        {

            nvm.getNewsData();
            NewstxtOutput.Text = nvm.newsData;
        }

        private void We_Button_Click(object sender, RoutedEventArgs e)
        {

          
        }

    }
}
