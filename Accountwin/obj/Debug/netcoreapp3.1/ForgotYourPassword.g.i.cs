﻿#pragma checksum "..\..\..\ForgotYourPassword.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3436247E3E887C2F773883CD1C406E4F19D7F22E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Accountwin;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Accountwin {
    
    
    /// <summary>
    /// ForgotYourPassword
    /// </summary>
    public partial class ForgotYourPassword : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\ForgotYourPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label_login;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\ForgotYourPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox input_login;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\ForgotYourPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\ForgotYourPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox input_newpassword;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\ForgotYourPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_accept;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\ForgotYourPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_clear;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Accountwin;V1.0.0.0;component/forgotyourpassword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ForgotYourPassword.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.label_login = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.input_login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btn_cancel = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\ForgotYourPassword.xaml"
            this.btn_cancel.Click += new System.Windows.RoutedEventHandler(this.btn_cancel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.input_newpassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.btn_accept = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\ForgotYourPassword.xaml"
            this.btn_accept.Click += new System.Windows.RoutedEventHandler(this.btn_accept_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_clear = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\ForgotYourPassword.xaml"
            this.btn_clear.Click += new System.Windows.RoutedEventHandler(this.btn_clear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

