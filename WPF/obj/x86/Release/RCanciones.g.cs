﻿#pragma checksum "..\..\..\RCanciones.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5293A5FAC2345F9DA4DE2035CB6114B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using WPF;


namespace WPF {
    
    
    /// <summary>
    /// RCanciones
    /// </summary>
    public partial class RCanciones : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\RCanciones.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement myMedia;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\RCanciones.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbCancion;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\RCanciones.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbLista;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\RCanciones.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Salir;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\RCanciones.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider timelineSlider;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\RCanciones.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button muteButt;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF;component/rcanciones.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RCanciones.xaml"
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
            this.myMedia = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 2:
            this.lbCancion = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.cmbLista = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Salir = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.timelineSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 14 "..\..\..\RCanciones.xaml"
            this.timelineSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SeekToMediaPosition);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 16 "..\..\..\RCanciones.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mediaPlay);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 17 "..\..\..\RCanciones.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mediaPause);
            
            #line default
            #line hidden
            return;
            case 8:
            this.muteButt = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\RCanciones.xaml"
            this.muteButt.Click += new System.Windows.RoutedEventHandler(this.mediaMute);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

