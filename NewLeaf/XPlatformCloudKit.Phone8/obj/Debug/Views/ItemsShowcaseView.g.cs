﻿#pragma checksum "C:\Users\dallasbrittany\Documents\GitHub\NewLeaf\NewLeaf\XPlatformCloudKit.Phone8\Views\ItemsShowcaseView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB6963E28FE1338753E31ED7DF6E9BFD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cirrious.MvvmCross.WindowsPhone.Views;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace XPlatformCloudKit {
    
    
    public partial class ItemsShowcaseView : Cirrious.MvvmCross.WindowsPhone.Views.MvxPhonePage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBox SearchBox;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.LongListSelector longListSelector;
        
        internal System.Windows.Controls.Grid TrialBlocker;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/XPlatformCloudKit.Phone8;component/Views/ItemsShowcaseView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.SearchBox = ((System.Windows.Controls.TextBox)(this.FindName("SearchBox")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.longListSelector = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("longListSelector")));
            this.TrialBlocker = ((System.Windows.Controls.Grid)(this.FindName("TrialBlocker")));
        }
    }
}

