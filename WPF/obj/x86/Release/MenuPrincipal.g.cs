﻿#pragma checksum "..\..\..\MenuPrincipal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2BAA7EA0D0BC0E9FF72F1682C4EC8E04"
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


namespace WPF {
    
    
    /// <summary>
    /// MenuPrincipal
    /// </summary>
    public partial class MenuPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Menu;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenArchivo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenProductos;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenListas;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenCanciones;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenReproductorMusica;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenMovimientos;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenReproductor;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF;component/menuprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MenuPrincipal.xaml"
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
            this.Menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.MenArchivo = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.MenProductos = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\..\MenuPrincipal.xaml"
            this.MenProductos.Click += new System.Windows.RoutedEventHandler(this.MenProductos_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MenListas = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\..\MenuPrincipal.xaml"
            this.MenListas.Click += new System.Windows.RoutedEventHandler(this.MenListas_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MenCanciones = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\MenuPrincipal.xaml"
            this.MenCanciones.Click += new System.Windows.RoutedEventHandler(this.MenCanciones_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MenReproductorMusica = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\MenuPrincipal.xaml"
            this.MenReproductorMusica.Click += new System.Windows.RoutedEventHandler(this.MenReproductorMusica_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MenMovimientos = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 8:
            this.MenReproductor = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\MenuPrincipal.xaml"
            this.MenReproductor.Click += new System.Windows.RoutedEventHandler(this.MenReproductor_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 20 "..\..\..\MenuPrincipal.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

