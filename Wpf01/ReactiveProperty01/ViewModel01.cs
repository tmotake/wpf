using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactive.Bindings;
using System.ComponentModel;

namespace ReactiveProperty01
{
    class ViewModel01: INotifyPropertyChanged
    {
        public ReactiveProperty<string> Name { get; set; }

        public ViewModel01()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
