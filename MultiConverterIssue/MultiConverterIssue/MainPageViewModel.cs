using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MultiConverterIssue
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private SomeEnum _enumValue;

        public SomeEnum EnumValue
        {
            get => _enumValue;
            set
            {
                _enumValue = value; 
                OnPropertyChanged();
            }
        }

        public List<SomeEnum> EnumValues => Enum.GetValues(typeof(SomeEnum)).Cast<SomeEnum>().ToList();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum SomeEnum
    {
        A,
        B,
        C
    }
}