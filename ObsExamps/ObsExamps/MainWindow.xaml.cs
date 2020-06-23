﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ObsExamps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<String> obs = new ObservableCollection<String>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            obs.Add($"Mục mới thêm {obs.Count + 1}");
            listview.ItemsSource = obs;
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            if (obs.Count > 0)
                obs.RemoveAt(obs.Count - 1);
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            obs.Clear();
        }
    }
}
