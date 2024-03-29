﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAppEx2
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

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            string line = testInput.Text;
            line = line.Replace(",", " y:");
            line = "x:" + line;

            formattedText.Text = line;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Buffer to hold a line read from the file on standard input
            string line;

            // Loop until the end of the file
            while ((line = Console.ReadLine()) != null)
            {
                // Format the data in the buffer
                line = line.Replace(",", " y:");
                line = "x:" + line + "\n";

                // Put the results into the TextBlock
                formattedText.Text += line;
            }
        }
    }
}
