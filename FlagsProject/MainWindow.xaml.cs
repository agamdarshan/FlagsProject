﻿using System;
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

namespace FlagsProject
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void italyBtn_Click(object sender, RoutedEventArgs e)
        {
            this.rec1.Fill = new SolidColorBrush(Colors.Green);
            this.rec2.Fill = new SolidColorBrush(Colors.White);
            this.rec3.Fill = new SolidColorBrush(Colors.Red);
        }

        private void franceBtn_Click(object sender, RoutedEventArgs e)
        {
            this.rec1.Fill = new SolidColorBrush(Colors.Blue);
            this.rec2.Fill = new SolidColorBrush(Colors.White);
            this.rec3.Fill = new SolidColorBrush(Colors.Red);
        }

        private void belgiumBtn_Click(object sender, RoutedEventArgs e)
        {
            this.rec1.Fill = new SolidColorBrush(Colors.Black);
            this.rec2.Fill = new SolidColorBrush(Colors.Yellow);
            this.rec3.Fill = new SolidColorBrush(Colors.Red);

        }
    }
}


