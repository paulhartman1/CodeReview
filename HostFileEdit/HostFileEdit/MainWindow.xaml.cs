using System;
using System.Collections.Generic;
using System.IO;
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

namespace HostFileEdit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private  string hostLocation = "C:\\windows\\System32\\drivers\\etc\\hosts",
            HOST = "";
        private bool enableIP = false;
        public MainWindow()
        {
            InitializeComponent();
            HOST = GetHostFile(hostLocation);
            HostFile.Text = HOST;
             
        }
        private String GetHostFile(String path)
        {
            StreamReader reader = new StreamReader(hostLocation);
            string file = reader.ReadToEnd();
            reader.Close();
            return file;
        }
       

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void UpdateButton_Checked(object sender, RoutedEventArgs e)
        {
            TopBoxLabel.Content = "TEST";
           

        }

        private void newBtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HostFile.Text = HOST;
        }

        private void removeBtn_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
