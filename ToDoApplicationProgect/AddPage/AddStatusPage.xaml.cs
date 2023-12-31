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

namespace ToDoApplicationProgect.AddPage
{
    /// <summary>
    /// Логика взаимодействия для AddStatusPage.xaml
    /// </summary>
    public partial class AddStatusPage : Page
    {
        //Работа с базой
        qweEntities context;
        public AddStatusPage(qweEntities cont)
        {
            InitializeComponent();
            context = cont;
        }

        //Добавление статуса в базу данных
        private void AddStatus(object sender, RoutedEventArgs e)
        {
            Status status = new Status()
            {
                statusid = Convert.ToInt32(NumberTextbox.Text),
                status1 = StatusTextBox.Text,
            };
            context.Status.Add(status);
            context.SaveChanges();
            MessageBox.Show("Статус добавлен", "Успешно", MessageBoxButton.OK);
            NavigationService.Navigate(new ShowPage.StatusPage());
        }

        //Возвращение к окну статуса
        private void BackStatus(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowPage.StatusPage());
        }
    }
}
