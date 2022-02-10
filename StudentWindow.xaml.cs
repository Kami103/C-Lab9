using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace lab09;

public partial class StudentWindow : Window
{
    public Student student;
    public StudentWindow()
    {
        InitializeComponent();
    }

    public StudentWindow(Student student = null) : this()
    {
        if (student != null)
        {
            nameBox.Text = student.imie;
            surnameBox.Text = student.nazwisko;
            albumNrBox.Text = student.NrIndeksu.ToString();
            wydzialBox.Text = student.wydzial;
        }

        this.student = student ?? new Student();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        if (!Regex.IsMatch(nameBox.Text, "\\w+") || !Regex.IsMatch(surnameBox.Text, "\\w+") ||
            !Regex.IsMatch(albumNrBox.Text, "\\d+") || !Regex.IsMatch(wydzialBox.Text, "\\w+"))
        {
            MessageBox.Show("niepoprawne dane");
            return;
        }
        try
        {
            student.imie = nameBox.Text;
            student.nazwisko = surnameBox.Text;
            student.NrIndeksu = Convert.ToInt32(albumNrBox.Text);
            student.wydzial = wydzialBox.Text;
            DialogResult = true;
        }
        catch { }
    }
}