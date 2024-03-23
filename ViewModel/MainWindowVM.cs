using Prism.Mvvm;
using PhotoBase.Core;
using System.Linq;
using Prism.Commands;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using PhotoBase.Model;
using PhotoBase.Controls;

namespace PhotoBase.ViewModel
{
    internal class MainWindowVM : BindableBase
    {
        #region Переменные
        private const string _defaultNewName = "ФИО";
        private string _newName;
        /// <summary>
        /// Имя для нового пользователя
        /// </summary>
        public string NewName
        {
            get
            {
                if (string.IsNullOrEmpty(_newName)) return _defaultNewName;
                else return _newName;
            }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Zа-яА-Я]+$"))
                {
                    _newName = value;
                    RaisePropertyChanged(nameof(NewName));
                }
            }
        }

        private ObservableCollection<UsersClass> _users = new ObservableCollection<UsersClass>();
        /// <summary>
        /// Все польователи
        /// </summary>
        public ObservableCollection<UsersClass> Users
        {
            get => _users;
            set
            {
                _users = value;
                RaisePropertyChanged(nameof(Users));
            }
        }


        private UsersClass _currentUser;
        /// <summary>
        /// Простматриваемый пользователь
        /// </summary>
        public UsersClass CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                RaisePropertyChanged(nameof(CurrentUser));
                RaisePropertyChanged(nameof(CurrentUser.Summ));
                RaisePropertyChanged(nameof(CurrentUser.PathPhotos));
            }
        }

        private string _currentPhoto;
        /// <summary>
        /// Просматриваемая фотография
        /// </summary>
        public string CurrentPhoto
        {
            get => _currentPhoto;
            set
            {
                _currentPhoto = value;
                RaisePropertyChanged(nameof(CurrentPhoto));
            }
        }
        #endregion

        #region Команды
        /// <summary>
        /// Завершение приложения
        /// </summary>
        public DelegateCommand AppShutDown { get; }
        private void OnAppShutDown()
        {
            UsersBase.Read();
            if(UsersBase.Values.Count != Users.Count)
                if ((bool)new DialogWindow("Сохранить изменения?", "Внимание", 1).ShowDialog())
                    UsersBase.Save();

            new Commands().ApplicationShutdown.Execute();
        }
        /// <summary>
        /// Добавление пользователя
        /// </summary>
        public DelegateCommand AddUser { get; }
        private void OnAddUser()
        {
            if (NewName != _defaultNewName)
            {
                Users.Add(new UsersClass { Name = NewName });
                CurrentUser = Users.Last();
            }
        }
        /// <summary>
        /// Удаление пользователя
        /// </summary>
        public DelegateCommand DeleteUser { get; }
        private void OnDeleteUser() => Users.Remove(CurrentUser);
        /// <summary>
        /// Добавление фото
        /// </summary>
        public DelegateCommand AddPhoto { get; }
        private void OnAddPhoto()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                if (CurrentUser.PathPhotos == null) CurrentUser.PathPhotos = new ObservableCollection<string>();

                foreach (string path in openFileDialog.FileNames.ToHashSet())
                    CurrentUser.PathPhotos.Add(path);

                CurrentUser = CurrentUser;
            }
        }
        /// <summary>
        /// удаление фото
        /// </summary>
        public DelegateCommand DeletePhoto { get; }
        private void OnDeletePhoto()
        {
            if (!string.IsNullOrEmpty(CurrentPhoto))
            {
                CurrentUser.PathPhotos.Remove(CurrentPhoto);
                CurrentPhoto = null;
                CurrentUser = CurrentUser;
            }
        }
        /// <summary>
        /// Сохранить данные
        /// </summary>
        public DelegateCommand SaveData { get; }
        private void OnSaveData()
        {
            UsersBase.Values = Users;
            UsersBase.Save();
        }
        /// <summary>
        /// Прочитать данные
        /// </summary>
        public DelegateCommand ReadData { get; }
        private void OnReadData()
        {
            UsersBase.Read();
            Users = UsersBase.Values;
        }

        #endregion
        public MainWindowVM()
        {
            //инициализация "базы данных"
            UsersBase.Initialize();
            if(UsersBase.Values != null)
                Users = UsersBase.Values;
            else Users = new ObservableCollection<UsersClass>();

            //привязка команд
            AppShutDown = new DelegateCommand(OnAppShutDown);
            ReadData = new DelegateCommand(OnReadData);
            SaveData = new DelegateCommand(OnSaveData);
            AddUser = new DelegateCommand(OnAddUser);
            DeleteUser = new DelegateCommand(OnDeleteUser);
            AddPhoto = new DelegateCommand(OnAddPhoto);
            DeletePhoto = new DelegateCommand(OnDeletePhoto);

        }
    }
}
