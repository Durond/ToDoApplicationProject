﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Логика взаимодействия для AddCategoryPage.xaml
    /// </summary>
    public partial class AddCategoryPage : Page
    {
        qweEntities context;
        public AddCategoryPage(qweEntities cont)
        {
            InitializeComponent();
            context = cont;
            UserTextBox.ItemsSource = cont.Users.ToList();

        }



        //Добавлекние категории в базу данных
        private void AddCategory(object sender, RoutedEventArgs e)
        {
            Categories categories = new Categories()
            {
                id = Convert.ToInt32(NumberTextbox.Text),
                name = CategoryTextBox.Text,
                user_id = (UserTextBox.SelectedItem as Users).id,
            };
            context.Categories.Add(categories);
            context.SaveChanges();

            MessageBox.Show("Категория добавлена", "Успешно", MessageBoxButton.OK);
            NavigationService.Navigate(new ShowPage.CategoryPage());

        }

        //Возврат на страницу категорий 
        private void BackCategory(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowPage.CategoryPage());
        }
    }
}
