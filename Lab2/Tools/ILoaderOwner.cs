﻿using System.ComponentModel;
using System.Windows;

namespace KMA.ProgrammingInCSharp2020.Lab2.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}
