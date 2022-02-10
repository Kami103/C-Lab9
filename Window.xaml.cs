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

namespace lab9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> ListaStudentow { get; set; }
        public MainWindow()
        {
            ListaStudentow = new List<Student>()
            {
                new Student("Natalia", "KOlszewska", 1234, "ASD"),
                new Student("Lucja", "Nowak", 4321, "PO"),
                new Student("Dawid", "Dawid", 34562, "ASD")
            };
            InitializeComponent();
            dgStudent.Columns.Add(new DataGridTextColumn(){Header = "Imię", Binding = new Binding("imie")});
            dgStudent.Columns.Add(new DataGridTextColumn(){Header = "Nazwisko", Binding = new Binding("nazwisko")});
            dgStudent.Columns.Add(new DataGridTextColumn(){Header = "Nr indeksu", Binding = new Binding("NrIndeksu")});
            dgStudent.Columns.Add(new DataGridTextColumn(){Header = "Wydzial", Binding = new Binding("wydzial")});
            dgStudent.AutoGenerateColumns = false;
            dgStudent.ItemsSource = ListaStudentow;
        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();
            if (dialog.ShowDialog() != true) return;
            ListaStudentow.Add(dialog.student);
            dgStudent.Items.Refresh();
        }

        private void ButtonRemove_OnClick(object sender, RoutedEventArgs e)
        {
            if (dgStudent.SelectedItem is Student)
                ListaStudentow.Remove((Student) dgStudent.SelectedItem);
            dgStudent.Items.Refresh();
        }

       
    }
}