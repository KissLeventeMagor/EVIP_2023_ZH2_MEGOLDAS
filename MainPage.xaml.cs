using System.Collections.ObjectModel;
using System.ComponentModel;

namespace gyakhalo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public ObservableCollection<Mountain> Mountains { get; set; } = new ObservableCollection<Mountain>();
      
        private Mountain _selecteditem;
        public Mountain SelectedItem
        {
            get => _selecteditem;
            set
            {
                if(_selecteditem != value)
                {
                    _selecteditem = value;
                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

            Mountains.Add(new Mountain("János-hegy",527));
            Mountains.Add(new Mountain("Kis-Hárs-hegy",362));
            Mountains.Add(new Mountain("Nagy-Hárs-hegy",454));
            Mountains.Add(new Mountain("Hármashatár-hegy",495));
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            foreach(Mountain a in Mountains)
            {
                a.Climbed = false;
            }
        }
    }

}
