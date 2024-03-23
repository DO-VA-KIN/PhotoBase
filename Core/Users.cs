using System;
using Prism.Mvvm;
using System.Collections.ObjectModel;


namespace PhotoBase.Core
{
    [Serializable]
    public class UsersClass:BindableBase
    {
        public string Name { get; set; }
        public int Summ { get; set; }
        public ObservableCollection<string> PathPhotos { get; set; }
        
    }
}
