using Caliburn.Micro;
using SpecUI.Models;
using SpecUI.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SpecUI.ViewModels
{
    public class MainViewModel : Screen
    {  
        private IWindowManager _windowManager;
        private static Schedule _selectedSchedule;
        private static Category _selectedCatagory;

        private ObservableCollection<Schedule> _scheduleList;
        public ObservableCollection<Schedule> ScheduleList { get; set; }
        public Category SelectedCategory
        {
            get { return _selectedCatagory; }
            set
            {
                _selectedCatagory = value;
                NotifyOfPropertyChange(() => SelectedCategory);
            }
        }
        public object SelectedItem { get; set; }
        public Schedule SelectedSchedule
        {
            get { return _selectedSchedule; }
            set
            {
                _selectedSchedule = value;
                NotifyOfPropertyChange(() => SelectedSchedule);
            }
        }
        public RelayCommand<TreeViewHelper.DependencyPropertyEventArgs> SelectedItem_Changed { get; set; }
        
        

        public MainViewModel()
        {
            _windowManager = new WindowManager();

            SelectedItem_Changed = new RelayCommand<TreeViewHelper.DependencyPropertyEventArgs>(ScheduleSelectionChanged);
            SelectedItem = new object();

            LoadData();

        }

        private void LoadData()
        {
            ScheduleList = new ObservableCollection<Schedule>();
            SelectedSchedule = new Schedule();
        }

        private static void ScheduleSelectionChanged(TreeViewHelper.DependencyPropertyEventArgs e)
        {
            if (e != null && e.DependencyPropertyChangedEventArgs.NewValue != null)
            {
                var selection = e.DependencyPropertyChangedEventArgs.NewValue as Schedule;
                if (selection != null)
                {
                    _selectedSchedule = selection;
                    return;
                }
                
                var selectedCategory = e.DependencyPropertyChangedEventArgs.NewValue as Category;
                if (selectedCategory != null)
                {
                    _selectedCatagory = selectedCategory;
                    _selectedSchedule = selectedCategory.ParentSchedule;
                }
            }

        }

        // Commands

        public void CreateNewSchedule()
        {
            var newSchedule = new Schedule();            
            var categorySelectViewModel = new CategorySelectViewModel(newSchedule);
            _windowManager.ShowDialog(categorySelectViewModel);
           
            ScheduleList.Add(newSchedule);          
        }

        public void EditSchedule()
        {
            var categorySelectViewModel = new CategorySelectViewModel(SelectedSchedule);
            _windowManager.ShowDialog(categorySelectViewModel);

        }

        public void EditCategoryParameters()
        {
            var parameterSelectViewModel = new ParameterSelectViewModel(_selectedCatagory);
            _windowManager.ShowDialog(parameterSelectViewModel);

        }
    }

}

