using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using CosasPorHacer.Model;
using CosasPorHacer.View;

namespace CosasPorHacer.ViewModel
{
    public class TodoListViewModel
    {
        public TodoListViewModel()
        {
            var VM = new AddNewItemViewModel
            {
                NewItemAdded = (sender, item) => Items.Add(item)
            };
            AddItem = new Command(async () =>
            {
                await GetCurrentNavigation().PushModalAsync(new AddNewItemPage { BindingContext = VM });
            });
        }

        private INavigation GetCurrentNavigation()
        {
            return (Application.Current as App).MainPage.Navigation;
        }

        public ObservableCollection<TodoItem> Items { get; } = new ObservableCollection<TodoItem>();
        public Command AddItem { get; set; }
    }
}
