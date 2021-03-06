#pragma checksum "..\..\..\..\Views\AuthorizationWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "732679535DCAB0AD3925B61C1DC6D6C1B9489EFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FilmCatalog.Views;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace FilmCatalog.Views {
    
    
    /// <summary>
    /// AuthorizationWindow
    /// </summary>
    public partial class AuthorizationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 70 "..\..\..\..\Views\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordLoginBox;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\Views\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordRegisterBox;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\Views\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox confirmPasswordRegisterBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FilmCatalog;component/views/authorizationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AuthorizationWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\..\Views\AuthorizationWindow.xaml"
            ((FilmCatalog.Views.AuthorizationWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 39 "..\..\..\..\Views\AuthorizationWindow.xaml"
            ((System.Windows.Controls.TabControl)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TabControlSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.passwordLoginBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 71 "..\..\..\..\Views\AuthorizationWindow.xaml"
            this.passwordLoginBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.passwordLoginBoxPasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 88 "..\..\..\..\Views\AuthorizationWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoginButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.passwordRegisterBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 124 "..\..\..\..\Views\AuthorizationWindow.xaml"
            this.passwordRegisterBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.passwordRegisterBoxPasswordChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.confirmPasswordRegisterBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 139 "..\..\..\..\Views\AuthorizationWindow.xaml"
            this.confirmPasswordRegisterBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.confirmPasswordRegisterBoxPasswordChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 156 "..\..\..\..\Views\AuthorizationWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RegisterButtonClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 171 "..\..\..\..\Views\AuthorizationWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

