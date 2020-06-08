using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecUI.Models
{
    public class Schedule : PropertyChangedBase
    {
        private ObservableCollection<Category> _categories;
        private string _name = "(новая спецификации)";
        protected bool _isSelected;
        public bool IsSelected
        {
            set
            {
                _isSelected = value;
                NotifyOfPropertyChange(() => IsSelected);
            }
            get
            {
                return _isSelected;
            }
        }
        public ObservableCollection<Category> Categories
        {

            get
            {
                return _categories;
            }
            set
            {
                _categories = value;
                NotifyOfPropertyChange(() => Categories);
            }
        }
        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }
    }
}
