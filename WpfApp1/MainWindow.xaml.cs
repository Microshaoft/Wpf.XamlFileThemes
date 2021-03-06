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
using Microshaoft;
using WPF.Themes.Demo;

namespace WpfApp1
{

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Person> SouthPark = new List<Person>() {
            new Person() { Name = "Eric", Surname="Cartman" },
            new Person() { Name = "Stan", Surname="Marsh" },
            new Person() { Name = "Kyle", Surname="Broflovski" },
            new Person() { Name = "Kenny", Surname="McCormick" },
            new Person() { Name = "Bebe", Surname="Stevens" },
            new Person() { Name = "Clyde", Surname="Donovan" },
            new Person() { Name = "Craig", Surname="Tucker" },
            new Person() { Name = "Jimmy", Surname="Vulmer" },
            new Person() { Name = "Pip", Surname="Pirrup" },
            new Person() { Name = "Token", Surname="Black" },
            new Person() { Name = "Tweek", Surname="Tweak" },
            new Person() { Name = "Wendy", Surname="Testaburger" },
            new Person() { Name = "Annie", Surname="Polk" },
            new Person() { Name = "Randy", Surname="Marsh" },
            new Person() { Name = "Sharon", Surname="Marsh" },
            new Person() { Name = "Shelley", Surname="Marsh" },
            new Person() { Name = "Marvin", Surname="Marsh" },
            new Person() { Name = "Jimbo", Surname="Kern" },
            new Person() { Name = "Gerald", Surname="Broflovski" },
            new Person() { Name = "Sheila", Surname="Broflovski" },
            new Person() { Name = "Ike", Surname="Broflovski" },
            new Person() { Name = "Kyle", Surname="Schwartz" },
            new Person() { Name = "Liane", Surname="Cartman" },
            new Person() { Name = "Stuart", Surname="McCormick" },
            new Person() { Name = "Carol", Surname="McCormick" },
            new Person() { Name = "Kevin", Surname="McCormick" },
            new Person() { Name = "Stephen", Surname="Stotch" },
            new Person() { Name = "Linda", Surname="Stotch" },
            new Person() { Name = "Richard", Surname="Tweak" }
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            themes.ItemsSource = ThemesManager
                                        .GetThemes
                                            (
                                                //@"D:\MyGitHub\Wpf.MEF.Themes\WpfApp1\Themes"
                                                @"D:\MyGitHub\Wpf.XamlFileThemes\ThemesResources\Themes"
                                            );

            comboBox.ItemsSource = SouthPark;
            listBox.ItemsSource = SouthPark;
        }

        private void themes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                string theme = e.AddedItems[0].ToString();

                //Window Level
                // this.ApplyTheme(theme);

                //Application Level
                Application.Current.ApplyTheme(theme);
                
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Window2().Show();

            new RibbonWindow1().Show();
            //new MyFirstWindow().Show();
        }
    }
}
