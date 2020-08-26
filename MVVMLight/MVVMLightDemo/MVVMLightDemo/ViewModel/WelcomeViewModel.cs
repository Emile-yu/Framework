﻿using GalaSoft.MvvmLight;
using MVVMLightDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightDemo.ViewModel
{
    public class WelcomeViewModel : ViewModelBase
    {
        public WelcomeViewModel()
        {
            Welcome = new WelcomeModel() { Introduction = "Hello World" };
        }

        private WelcomeModel welcome;

        public WelcomeModel Welcome
        {
            get { return welcome; }
            set { welcome = value; RaisePropertyChanged(); }
        }

    }
}
