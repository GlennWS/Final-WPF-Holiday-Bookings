﻿#pragma checksum "..\..\ExtrasPrompt.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6FA6E7582654F22A31229CF7CF270F8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CW2;
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


namespace CW2 {
    
    
    /// <summary>
    /// ExtrasPrompt
    /// </summary>
    public partial class ExtrasPrompt : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ExtrasPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPromptBooking;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ExtrasPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBookYes;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ExtrasPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBookNo;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ExtrasPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEnterRef;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ExtrasPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtReturnRef;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ExtrasPrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
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
            System.Uri resourceLocater = new System.Uri("/CW2;component/extrasprompt.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ExtrasPrompt.xaml"
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
            this.lblPromptBooking = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnBookYes = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\ExtrasPrompt.xaml"
            this.btnBookYes.Click += new System.Windows.RoutedEventHandler(this.btnBookYes_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnBookNo = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\ExtrasPrompt.xaml"
            this.btnBookNo.Click += new System.Windows.RoutedEventHandler(this.btnBookNo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblEnterRef = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtReturnRef = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ExtrasPrompt.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
