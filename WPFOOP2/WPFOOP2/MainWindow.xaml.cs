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

namespace WPFOOP2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model;
        ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            model = new Model();
            viewModel = new ViewModel(model);
            viewModel.SetDate();
            viewModel.SetRandomNumbers();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = viewModel;
            Count.Text = viewModel.timesClickedString;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.IncrementTimesClicked();
            Count.Text = viewModel.timesClickedString;
        }

        private void Coin_Click(object sender, RoutedEventArgs e)
        {
            if(viewModel.timesFlipped % 2 == 0)
            {
                CoinImage.Opacity = .5;
            }
            else
            {
                CoinImage.Opacity = 1;
            }

            viewModel.GetHeadsOrTails();
            CoinBlock.Text = viewModel.headsTailsString;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {           
            nameBlock.Text = $"Hello, {nameBox.Text}! Today is: {viewModel.dateString}";
        }

        private void mathSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.SetResultString(mathBox.Text);
            resultBlock.Text = viewModel.resultString;
            viewModel.SetRandomNumbers();
            mathBlock.Text = $"What is {viewModel.firstNumber} + {viewModel.secondNumber}?";
        }
    }
}
