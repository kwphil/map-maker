using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateNewFile_Click(object sender, RoutedEventArgs e)
        {
            // Add logic to create a new file
            MessageBox.Show("Creating a new file. Add your logic here.");
        }

        private void LoadExistingFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                // Add logic to load an existing file
                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    MessageBox.Show($"Loaded file content:\n\n{fileContent}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file:\n\n{ex.Message}");
                }
            }
        }
    }
}
