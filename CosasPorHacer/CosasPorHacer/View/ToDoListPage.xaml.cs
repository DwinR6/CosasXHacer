﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CosasPorHacer.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ToDoListPage : ContentPage
	{
		public ToDoListPage ()
		{
			InitializeComponent ();
		}
	}
}