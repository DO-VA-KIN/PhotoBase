﻿#pragma checksum "..\..\..\ViewModel\DialogWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F08C731C06003BF1E20E1AF50F49A22F495C9B2EA5D0144C580087241A3A938A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PhotoBase.ViewModel;
using PhotoBase.Views;
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


namespace PhotoBase.ViewModel {
    
    
    /// <summary>
    /// DialogWindow
    /// </summary>
    public partial class DialogWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\ViewModel\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox GBForm;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ViewModel\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBMessage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ViewModel\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnYes;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ViewModel\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ViewModel\DialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOK;
        
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
            System.Uri resourceLocater = new System.Uri("/PhotoBase;component/viewmodel/dialogwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewModel\DialogWindow.xaml"
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
            
            #line 23 "..\..\..\ViewModel\DialogWindow.xaml"
            ((PhotoBase.ViewModel.DialogWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\ViewModel\DialogWindow.xaml"
            ((PhotoBase.ViewModel.DialogWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GBForm = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.TBMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.BtnYes = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\ViewModel\DialogWindow.xaml"
            this.BtnYes.Click += new System.Windows.RoutedEventHandler(this.BtnYes_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnNo = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\ViewModel\DialogWindow.xaml"
            this.BtnNo.Click += new System.Windows.RoutedEventHandler(this.BtnNo_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnOK = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\ViewModel\DialogWindow.xaml"
            this.BtnOK.Click += new System.Windows.RoutedEventHandler(this.BtnOK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
