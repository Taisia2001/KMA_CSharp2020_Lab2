using KMA.ProgrammingInCSharp2020.Lab2.ViewModels;
using System.Windows.Controls;

namespace KMA.ProgrammingInCSharp2020.Lab2.Views
{
    /// <summary>
    /// Логика взаимодействия для BirthdayPickerView.xaml
    /// </summary>
    public partial class BirthdayPickerView : UserControl
    {
        public BirthdayPickerView()
        {
            InitializeComponent();
            DataContext = new BirthdayPickerViewModel();
        }
    }
}
