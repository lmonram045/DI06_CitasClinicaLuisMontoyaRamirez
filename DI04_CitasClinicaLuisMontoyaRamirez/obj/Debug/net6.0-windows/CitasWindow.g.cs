﻿#pragma checksum "..\..\..\CitasWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2E65E98C4CBAC771822FA37A28AD23CBFBC4E952"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DI04_CitasClinicaLuisMontoyaRamirez;
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


namespace DI04_CitasClinicaLuisMontoyaRamirez {
    
    
    /// <summary>
    /// CitasWindow
    /// </summary>
    public partial class CitasWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CitasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridAddCita;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\CitasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DpFecha;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\CitasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbHora;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\CitasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbPaciente;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\CitasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbMotivo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\CitasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbObservaciones;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\CitasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbMetodoPago;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\CitasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddCita;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\CitasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancelCita;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DI04_CitasClinicaLuisMontoyaRamirez;component/citaswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CitasWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.gridAddCita = ((System.Windows.Controls.Grid)(target));
            
            #line 10 "..\..\..\CitasWindow.xaml"
            this.gridAddCita.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 2:
            this.DpFecha = ((System.Windows.Controls.DatePicker)(target));
            
            #line 28 "..\..\..\CitasWindow.xaml"
            this.DpFecha.CalendarClosed += new System.Windows.RoutedEventHandler(this.DpFecha_OnCalendarClosed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CbHora = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.CbPaciente = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.TbMotivo = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\CitasWindow.xaml"
            this.TbMotivo.LostFocus += new System.Windows.RoutedEventHandler(this.TbMotivo_OnLostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TbObservaciones = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CbMetodoPago = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.BtnAddCita = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\CitasWindow.xaml"
            this.BtnAddCita.Click += new System.Windows.RoutedEventHandler(this.BtnAddCita_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnCancelCita = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\CitasWindow.xaml"
            this.BtnCancelCita.Click += new System.Windows.RoutedEventHandler(this.BtnCancelCita_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

