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

namespace WpfApp13
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
            Button btn = (Button)sender;
            int id = int.Parse(btn.Uid);
            switch (id)
            {
                case 1:
                    frMyFrame.Navigate(new _Pages.Autch());

                    break;
                case 2:
                    frMyFrame.Navigate(new _Pages.Page1());
                    break;
                case 3:
                    frMyFrame.Navigate(new _Pages.Page2());
                    break;

            }


        }
    }
}
