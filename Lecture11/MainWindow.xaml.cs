﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture11
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

        private void btnOpenWindowTwo_Click(object sender, RoutedEventArgs e)
        {
            //Open SecondWindow.xaml
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.Show();

            listBoxNames.ItemsSource = Data.names;
        }

        private void btnAddName_Click(object sender, RoutedEventArgs e)
        {
            Data.names.Add(txtBoxAddName.Text);
        }

        private void txtBoxAddName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}