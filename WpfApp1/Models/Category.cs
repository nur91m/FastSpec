using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecUI.Models
{
    public class Category : PropertyChangedBase, ICloneable
    {
        private string _name;
        private string _builtInCategory;

        protected bool _isSelected = false;
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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Schedule ParentSchedule { get; set; }

        public Category(string name, string builtInCategory)
        {
            _builtInCategory = builtInCategory;
            _name = name;
        }

        public object Clone()
        {
            var clone = new Category(_name, _builtInCategory);
            clone.ParentSchedule = ParentSchedule;
            return clone;
        }
    }
}
