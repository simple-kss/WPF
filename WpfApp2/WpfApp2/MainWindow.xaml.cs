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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            WpfApp2.TestWindow tw = new WpfApp2.TestWindow();

            // 모달리스 : 뒤에있는 창으로 이동 가능
            tw.Show();
        }
        private void ButtonShowDialog_Click(object sender, RoutedEventArgs e)
        {
            WpfApp2.TestWindow tw = new WpfApp2.TestWindow();

            // 모달 : 해당 창을 닫기 전까지는 뒤에 있는 창으로 이동 못함
            tw.ShowDialog();
        }
    }
}
