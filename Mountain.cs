using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gyakhalo
{
    public class Mountain : INotifyPropertyChanged
    {
        private string _name;
        private int _height;
        private bool _climbed;
        private Color _textcolor;
        public string Name
        {
            get => _name;
            set
            {
                if(_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Height
        {
            get => _height;
            set
            {
                if(_height != value)
                {
                    _height = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool Climbed
        {
            get => _climbed;
            set
            {
                if( _climbed != value)
                {
                    _climbed = value;
                    OnPropertyChanged();
                }
            }
        }

        public Color TextColor
        {
            get => _textcolor;
            set
            {
                if (_textcolor != value)
                {
                    _textcolor = value;
                    OnPropertyChanged();
                }
            }
        }
        public Mountain(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
