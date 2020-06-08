using Caliburn.Micro;
using SpecUI.Models;
using SpecUI.Services;
using SpecUI.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SpecUI.Extensions;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SpecUI.ViewModels
{
    public class CategorySelectViewModel : Screen
    {
        private static Category _selectedCategoryFirst;
        private static Category _selectedCategorySecond;        
        private Schedule _schedule;

        public ObservableCollection<Category> AvailableCategories { get; set; }
        public ObservableCollection<Category> ScheduleCategories {get; set;}

        public object AvailableCategoriesSelectedItem { get; set; }
        public object ScheduleCategoriesSelectedItem { get; set; }



        public RelayCommand<TreeViewHelper.DependencyPropertyEventArgs> AvailableCategoriesSelectedItem_Changed { get; set; }
        public RelayCommand<TreeViewHelper.DependencyPropertyEventArgs> ScheduleCategoriesSelectedItem_Changed { get; set; }


        #region Constructors
        // Constructors        
        public CategorySelectViewModel(Schedule schedule)
        {
            _schedule = schedule;

            AvailableCategories = RevitCategoryService.GetCategoryList();

            // If new schedule is being created
            if (schedule.Categories == null)
            {
                ScheduleCategories = new ObservableCollection<Category>();
            }
            // Edit already created schedule
            else
            {
                ScheduleCategories = schedule.Categories.Clone();
            }

            Initialize();
        }
        #endregion

        private void Initialize()
        {
            AvailableCategoriesSelectedItem_Changed = new RelayCommand<TreeViewHelper.DependencyPropertyEventArgs>(AvailableCategoriesChanged);
            ScheduleCategoriesSelectedItem_Changed = new RelayCommand<TreeViewHelper.DependencyPropertyEventArgs>(ScheduleCategoriesChanged);

            AvailableCategoriesSelectedItem = new object();
            ScheduleCategoriesSelectedItem = new object();
        }

        #region Dependency property
        //public static object GetIsSelectedMonitor(DependencyObject obj)
        //{
        //    return (object)obj.GetValue(IsSelectedMonitorProperty);
        //}

        //public static void SetIsSelectedMonitor(DependencyObject obj, object value)
        //{
        //    obj.SetValue(IsSelectedMonitorProperty, value);
        //}

        //// Using a DependencyProperty as the backing store for IsSelectedMonitor.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty IsSelectedMonitorProperty =
        //    DependencyProperty.RegisterAttached("IsSelectedMonitor", typeof(object), typeof(CategorySelectViewModel), new PropertyMetadata(true, IsSelectedMonitorProperty_Chaged));


        //private static void IsSelectedMonitorProperty_Chaged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{

        //    TreeView treeView = FindParentTreeView(d);
        //    if (treeView != null)
        //    {
        //        if (treeView.Name == "CategoryList")
        //            _selectedCategoryFirst = e.NewValue as Category;
        //        else if (treeView.Name == "SelectedCategoryList")
        //            _selectedCategorySecond = e.NewValue as Category;
        //    }
        //}

        //private static TreeView FindParentTreeView(object child)
        //{
        //    try
        //    {
        //        var parent = VisualTreeHelper.GetParent(child as DependencyObject);
        //        while ((parent as TreeView) == null)
        //        {
        //            parent = VisualTreeHelper.GetParent(parent);
        //        }
        //        return parent as TreeView;
        //    }
        //    catch (System.Exception e)
        //    {
        //        //could not find a parent of type TreeViewItem
        //        return null;
        //    }
        //}

        #endregion

        private static void AvailableCategoriesChanged(TreeViewHelper.DependencyPropertyEventArgs e)
        {
            setSelection(e, ref _selectedCategoryFirst);
        }
        private static void ScheduleCategoriesChanged(TreeViewHelper.DependencyPropertyEventArgs e)
        {
            setSelection(e, ref _selectedCategorySecond);
        }

        private static void setSelection(TreeViewHelper.DependencyPropertyEventArgs e, ref Category refToProperty)
        {
            if (e != null && e.DependencyPropertyChangedEventArgs.NewValue != null)
            {
                var selection = e.DependencyPropertyChangedEventArgs.NewValue as Category;
                if (selection != null)
                {
                    refToProperty = selection;
                }
            }
        }

        public void AddCategory()
        {
            if (_selectedCategoryFirst != null)
            {
                // Set parrent schedule
                _selectedCategoryFirst.ParentSchedule = _schedule;

                ScheduleCategories.Add(_selectedCategoryFirst);
                AvailableCategories.Remove(_selectedCategoryFirst);

               

                NotifyOfPropertyChange(() => CanRemoveCategory);
            }
        }

        public bool CanRemoveCategory
        {
            get
            {
                if (ScheduleCategories == null) return false;
                return ScheduleCategories.Count != 0;
            }
        }

        public void RemoveCategory()
        {
            AvailableCategories.Add(_selectedCategorySecond);
            ScheduleCategories.Remove(_selectedCategorySecond);
            NotifyOfPropertyChange(() => CanRemoveCategory);
        }

        public void ApplyClicked()
        {
            _schedule.Categories = ScheduleCategories;
            this.TryClose();
        }

    }
}
