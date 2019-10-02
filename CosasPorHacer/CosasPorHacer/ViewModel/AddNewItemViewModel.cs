using CosasPorHacer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CosasPorHacer.ViewModel
{
   public class AddNewItemViewModel
    {
        public EventHandler<Model.TodoItem> NewItemAdded;
        public AddNewItemViewModel()
        {
            SaveNewItem = new Command(() =>

            { NewItemAdded(this, new TodoItem { Description = Description });

                Description = "";
                (Application.Current as App).MainPage.Navigation.PopModalAsync();
            });
            Cancel = new Command(() => (Application.Current as App).MainPage.Navigation.PopModalAsync());
        }
        public Command SaveNewItem { get; set; }
        public Command Cancel { get; set; }
        public string Description { get; set; }
    }
}
