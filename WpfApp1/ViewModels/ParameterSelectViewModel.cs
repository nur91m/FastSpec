using SpecUI.Models;
using SpecUI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecUI.ViewModels
{
    public class ParameterSelectViewModel : Caliburn.Micro.Screen
    {
        private Parameter _availableParametersSelectedItem;
        private Parameter _scheduleParametersSelectedItem;
        private ObservableCollection<Parameter> _availableParameters;
        private ObservableCollection<Parameter> _scheduleParameters;
        private Category _category;

        public Parameter AvailableParametersSelectedItem
        {
            get { return _availableParametersSelectedItem; }
            set
            {
                _availableParametersSelectedItem = value;
                NotifyOfPropertyChange(() => AvailableParametersSelectedItem);
            }
        }
        public Parameter ScheduleParametersSelectedItem
        {
            get { return _scheduleParametersSelectedItem; }
            set
            {
                _scheduleParametersSelectedItem = value;
                NotifyOfPropertyChange(() => ScheduleParametersSelectedItem);
            }
        }


        public ObservableCollection<Parameter> AvailableParameters
        {
            get { return _availableParameters; }
            set 
            { 
                _availableParameters = value;
                NotifyOfPropertyChange(() => AvailableParameters);
            }
        }
        public ObservableCollection<Parameter> ScheduleParameters
        {
            get { return _scheduleParameters; }
            set 
            {
                _scheduleParameters = value;
                NotifyOfPropertyChange(() => ScheduleParameters);
            }
        }


        public ParameterSelectViewModel(Category category)
        {
            _category = category;
            RevitParameterService.GetParameters();
        }

        public void AddParameter()
        {
            if (AvailableParametersSelectedItem != null)
            {

                ScheduleParameters.Add(AvailableParametersSelectedItem);
                NotifyOfPropertyChange(() => CanRemoveParameter);
            }
        }

        public bool CanRemoveParameter
        {
            get
            {
                if (ScheduleParameters == null) return false;
                return ScheduleParameters.Count != 0;
            }
        }

        public void RemoveParameter()
        {
            ScheduleParameters.Remove(ScheduleParametersSelectedItem);
            NotifyOfPropertyChange(() => CanRemoveParameter);
        }

        public void ApplyClicked()
        {
            
            this.TryClose();
        }
    }
}
