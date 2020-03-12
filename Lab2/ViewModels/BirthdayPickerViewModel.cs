using KMA.ProgrammingInCSharp2020.Lab2.Models;
using KMA.ProgrammingInCSharp2020.Lab2.Tools;
using KMA.ProgrammingInCSharp2020.Lab2.Tools.Managers;
using KMA.ProgrammingInCSharp2020.Lab2.Tools.MVVM;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace KMA.ProgrammingInCSharp2020.Lab2.ViewModels
{
    class BirthdayPickerViewModel : BaseViewModel
    {
        #region Fields
        private Person _person;
        private string _name;
        private string _surname;
        private string _email;
        private string _info;
        private DateTime? _date;
        private RelayCommand<object> _submitCommand;
        #endregion

        #region Properties
      
        public DateTime? Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public string Info
        {
            get { return _info; }
            set
            {
                _info = value;
                OnPropertyChanged();
            }
        }
        public Person Person
        {
            get { return _person; }
            set
            {
                _person = value;
                OnPropertyChanged();
            }
        }



        public RelayCommand<object> SubmitCommand
        {
            get
            {
                return _submitCommand ?? (_submitCommand = new RelayCommand<object>(
                           SubmitImplementation, o => CanExecuteCommand()));
            }
        }
        #endregion
        internal BirthdayPickerViewModel()
        {
           
            Date = DateTime.Today;
        }
        private async void SubmitImplementation(object obj)
        {
            LoaderManager.Instance.ShowLoader();
            await Task.Run(() =>
            {
                try
                {
                    _person = new Person(Name, Surname, Email, (DateTime)Date);
                    Info = $"Name: {_person.Name}\nSurname: {_person.Surname}\nEmail: {_person.Email}\nBirthday: {((DateTime)Date).Day}.{((DateTime)Date).Month}.{((DateTime)Date).Year}\nSun Sign: {_person.SunSign}" +
                    $"\nChinese Sign: {_person.ChineseSign}\nIs Adult: {_person.IsAdult}\nIs Birthday: {_person.IsBirthday}";
                    LoaderManager.Instance.HideLoader();
                    if (_person.IsBirthday)
                    {
                        MessageBox.Show("Happy Birthday! I wish you to enjoy your special day, relax and let yourself be spoiled, you deserve it!");
                    }
                   
                }
                catch (Exception e)
                {
                    Info = "";
                    LoaderManager.Instance.HideLoader();
                    MessageBox.Show(e.Message);
                }

            });

        }
        private bool CanExecuteCommand()
        {
            return !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Surname)&& Date !=null;
        }
    }
}
