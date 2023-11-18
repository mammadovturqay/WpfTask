using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WordpadClone
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewFile_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Text = string.Empty;
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string filename = openFileDialog.FileName;
                string fileText = File.ReadAllText(filename);
                txtEditor.Text = fileText;
            }
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename, txtEditor.Text);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
};
