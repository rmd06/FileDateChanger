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

using ChangeFileDateLib;

namespace ChangeFileDateWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private FileDateChanger _fileDateChanger;
        public MainWindow()
        {
            InitializeComponent();

            _fileDateChanger = null;
            InitializeDateTimePickers();
        }

        private void InitializeDateTimePickers()
        {
            this.DateTimePickerFileCreationDate.DefaultValue = DateTime.Now;
            this.DateTimePickerLastAccessedDate.DefaultValue = DateTime.Now;
            this.DateTimePickerLastWrittenDate.DefaultValue = DateTime.Now;

            this.DateTimePickerFileCreationDate.Value = this.DateTimePickerFileCreationDate.DefaultValue;
            this.DateTimePickerLastAccessedDate.Value = this.DateTimePickerLastAccessedDate.DefaultValue;
            this.DateTimePickerLastWrittenDate.Value = this.DateTimePickerLastWrittenDate.DefaultValue;

        }

        private void btnSelectFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                textBoxSelectedFile.Text = openFileDialog.FileName;
            }
        }

        private void textBoxSelectedFile_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            _fileDateChanger = new FileDateChanger(textBox.Text);
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
            if (_fileDateChanger == null)
            {
                System.Windows.MessageBox.Show("Please Select a file to change the file date info", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (this.DateTimePickerFileCreationDate.Value.HasValue)
            {
                _fileDateChanger.CreationTime = this.DateTimePickerFileCreationDate.Value.Value;
            }
            if (this.DateTimePickerLastAccessedDate.Value.HasValue)
            {
                _fileDateChanger.LastAccessTime = this.DateTimePickerLastAccessedDate.Value.Value;
            }
            if (this.DateTimePickerLastWrittenDate.Value.HasValue)
            {
                _fileDateChanger.LastWriteTime = this.DateTimePickerLastWrittenDate.Value.Value;
            }
            _fileDateChanger.ChangeTimes();

            System.Windows.MessageBox.Show($"File's date info was changed to " +
                $"\nCreation Time: {_fileDateChanger.CreationTime}" +
                $"\nLast Access Time: {_fileDateChanger.LastAccessTime}" +
                $"\nLast Write Time: {_fileDateChanger.LastWriteTime}", 
                "Success", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}