﻿#pragma checksum "..\..\..\..\ParametresWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24A043C8BC920B6D3A726BB7C1A820B3A95C9EA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace EasySave_G3_V2_0 {
    
    
    /// <summary>
    /// ParametresWindow
    /// </summary>
    public partial class ParametresWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\ParametresWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_TypeLog;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\ParametresWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNouvelleExtension;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\ParametresWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LstExtensions;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\ParametresWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNouvelleExtensionPrioritaire;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\ParametresWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LstExtensionsPrioritaires;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\ParametresWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNouveauLogiciel;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\ParametresWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LstLogiciels;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\ParametresWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_Langue;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EasySave_G3_V3_0;component/parametreswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ParametresWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CB_TypeLog = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.TxtNouvelleExtension = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 56 "..\..\..\..\ParametresWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AjouterExtension_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 58 "..\..\..\..\ParametresWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SupprimerExtension_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LstExtensions = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.TxtNouvelleExtensionPrioritaire = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 76 "..\..\..\..\ParametresWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AjouterExtensionPrioritaire_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 78 "..\..\..\..\ParametresWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SupprimerExtensionPrioritaire_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LstExtensionsPrioritaires = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.TxtNouveauLogiciel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 100 "..\..\..\..\ParametresWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ParcourirLogiciel_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 102 "..\..\..\..\ParametresWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AjouterLogiciel_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 104 "..\..\..\..\ParametresWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SupprimerLogiciel_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.LstLogiciels = ((System.Windows.Controls.ListBox)(target));
            return;
            case 15:
            this.CB_Langue = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 16:
            
            #line 132 "..\..\..\..\ParametresWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Valider_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 136 "..\..\..\..\ParametresWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Annuler_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

