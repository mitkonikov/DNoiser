﻿#pragma checksum "..\..\Library.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "213124DECCB28721BF07250C467DF0B53401EA3E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace DNoiser {
    
    
    /// <summary>
    /// Library
    /// </summary>
    public partial class Library : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button import_dir;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button import_img;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox queue_list;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clear_lib;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DNoiser;component/library.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Library.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.import_dir = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Library.xaml"
            this.import_dir.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.import_dir_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.import_img = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Library.xaml"
            this.import_img.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.import_img_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.queue_list = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.clear_lib = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Library.xaml"
            this.clear_lib.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.clear_lib_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

