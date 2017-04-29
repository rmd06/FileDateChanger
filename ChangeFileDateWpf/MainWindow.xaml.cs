using Microsoft.Win32;
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
using Xceed.Wpf.Toolkit;


namespace ChangeFileDateWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitializeDateTimePickers();
            
        }

        private void InitializeDateTimePickers()
        {
            this.DateTimePickerFileCreationDate.DefaultValue = DateTime.Now;
            this.DateTimePickerLastAccessedDate.DefaultValue = DateTime.Now;
            this.DateTimePickerLastWrittenDate.DefaultValue = DateTime.Now;
        }

        private void btnSelectFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                textBoxSelectedFile.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void textBoxSelectedFile_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DateTimePickerFileCreationDate_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }
        private void DateTimePickerLastAccessedDate_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }
        private void DateTimePickerLastWrittenDate_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
