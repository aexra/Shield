﻿#pragma checksum "C:\Users\aexra\source\repos\Shield\Shield.App\Views\AlarmsTableViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "59149E7557A8C926CFFBE53B46C5E08C7538CA50898871E4426DB0C169E49746"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shield.App.Views
{
    partial class AlarmsTableViewPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_CommunityToolkit_WinUI_UI_Controls_DataGrid_ItemsSource(global::CommunityToolkit.WinUI.UI.Controls.DataGrid obj, global::System.Collections.IEnumerable value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.IEnumerable) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.IEnumerable), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(global::Microsoft.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(global::Microsoft.UI.Xaml.UIElement obj, global::Microsoft.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_CalendarDatePicker_MinDate(global::Microsoft.UI.Xaml.Controls.CalendarDatePicker obj, global::System.DateTimeOffset value)
            {
                obj.MinDate = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_CalendarDatePicker_MaxDate(global::Microsoft.UI.Xaml.Controls.CalendarDatePicker obj, global::System.DateTimeOffset value)
            {
                obj.MaxDate = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AlarmsTableViewPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IAlarmsTableViewPage_Bindings
        {
            private global::Shield.App.Views.AlarmsTableViewPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::CommunityToolkit.WinUI.UI.Controls.DataGrid obj2;
            private global::Microsoft.UI.Xaml.Controls.StackPanel obj4;
            private global::Microsoft.UI.Xaml.Controls.CalendarDatePicker obj6;
            private global::Microsoft.UI.Xaml.Controls.CalendarDatePicker obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ItemsSourceDisabled = false;
            private static bool isobj4VisibilityDisabled = false;
            private static bool isobj6IsEnabledDisabled = false;
            private static bool isobj6MinDateDisabled = false;
            private static bool isobj6MaxDateDisabled = false;
            private static bool isobj8IsEnabledDisabled = false;
            private static bool isobj8MinDateDisabled = false;
            private static bool isobj8MaxDateDisabled = false;

            private AlarmsTableViewPage_obj1_BindingsTracking bindingsTracking;

            public AlarmsTableViewPage_obj1_Bindings()
            {
                this.bindingsTracking = new AlarmsTableViewPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 47 && columnNumber == 13)
                {
                    isobj2ItemsSourceDisabled = true;
                }
                else if (lineNumber == 23 && columnNumber == 62)
                {
                    isobj4VisibilityDisabled = true;
                }
                else if (lineNumber == 27 && columnNumber == 21)
                {
                    isobj6IsEnabledDisabled = true;
                }
                else if (lineNumber == 28 && columnNumber == 21)
                {
                    isobj6MinDateDisabled = true;
                }
                else if (lineNumber == 29 && columnNumber == 21)
                {
                    isobj6MaxDateDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 21)
                {
                    isobj8IsEnabledDisabled = true;
                }
                else if (lineNumber == 36 && columnNumber == 21)
                {
                    isobj8MinDateDisabled = true;
                }
                else if (lineNumber == 37 && columnNumber == 21)
                {
                    isobj8MaxDateDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\AlarmsTableViewPage.xaml line 43
                        this.obj2 = global::WinRT.CastExtensions.As<global::CommunityToolkit.WinUI.UI.Controls.DataGrid>(target);
                        break;
                    case 4: // Views\AlarmsTableViewPage.xaml line 23
                        this.obj4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                        break;
                    case 6: // Views\AlarmsTableViewPage.xaml line 25
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CalendarDatePicker>(target);
                        break;
                    case 8: // Views\AlarmsTableViewPage.xaml line 33
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CalendarDatePicker>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IAlarmsTableViewPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::Shield.App.Views.AlarmsTableViewPage>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Shield.App.Views.AlarmsTableViewPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Shield.App.ViewModels.AlarmsTableViewViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Alarms(obj.Alarms, phase);
                        this.Update_ViewModel_EnableSearch(obj.EnableSearch, phase);
                        this.Update_ViewModel_StartDate(obj.StartDate, phase);
                        this.Update_ViewModel_EndDate(obj.EndDate, phase);
                    }
                }
            }
            private void Update_ViewModel_Alarms(global::System.Collections.Generic.List<global::Shield.DataAccess.DTOs.AlarmDto> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AlarmsTableViewPage.xaml line 43
                    if (!isobj2ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_CommunityToolkit_WinUI_UI_Controls_DataGrid_ItemsSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ViewModel_EnableSearch(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_ViewModel_EnableSearch_Cast_EnableSearch_To_Visibility(obj ? global::Microsoft.UI.Xaml.Visibility.Visible : global::Microsoft.UI.Xaml.Visibility.Collapsed, phase);
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AlarmsTableViewPage.xaml line 25
                    if (!isobj6IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(this.obj6, obj);
                    }
                    // Views\AlarmsTableViewPage.xaml line 33
                    if (!isobj8IsEnabledDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(this.obj8, obj);
                    }
                }
            }
            private void Update_ViewModel_EnableSearch_Cast_EnableSearch_To_Visibility(global::Microsoft.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AlarmsTableViewPage.xaml line 23
                    if (!isobj4VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj4, obj);
                    }
                }
            }
            private void Update_ViewModel_StartDate(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AlarmsTableViewPage.xaml line 25
                    if (!isobj6MinDateDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_CalendarDatePicker_MinDate(this.obj6, obj);
                    }
                    // Views\AlarmsTableViewPage.xaml line 33
                    if (!isobj8MinDateDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_CalendarDatePicker_MinDate(this.obj8, obj);
                    }
                }
            }
            private void Update_ViewModel_EndDate(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AlarmsTableViewPage.xaml line 25
                    if (!isobj6MaxDateDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_CalendarDatePicker_MaxDate(this.obj6, obj);
                    }
                    // Views\AlarmsTableViewPage.xaml line 33
                    if (!isobj8MaxDateDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_CalendarDatePicker_MaxDate(this.obj8, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class AlarmsTableViewPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<AlarmsTableViewPage_obj1_Bindings> weakRefToBindingObj; 

                public AlarmsTableViewPage_obj1_BindingsTracking(AlarmsTableViewPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<AlarmsTableViewPage_obj1_Bindings>(obj);
                }

                public AlarmsTableViewPage_obj1_Bindings TryGetBindingObject()
                {
                    AlarmsTableViewPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AlarmsTableViewPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Shield.App.ViewModels.AlarmsTableViewViewModel obj = sender as global::Shield.App.ViewModels.AlarmsTableViewViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Alarms(obj.Alarms, DATA_CHANGED);
                                bindings.Update_ViewModel_EnableSearch(obj.EnableSearch, DATA_CHANGED);
                                bindings.Update_ViewModel_StartDate(obj.StartDate, DATA_CHANGED);
                                bindings.Update_ViewModel_EndDate(obj.EndDate, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Alarms":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Alarms(obj.Alarms, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "EnableSearch":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_EnableSearch(obj.EnableSearch, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "StartDate":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_StartDate(obj.StartDate, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "EndDate":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_EndDate(obj.EndDate, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Shield.App.ViewModels.AlarmsTableViewViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::Shield.App.ViewModels.AlarmsTableViewViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\AlarmsTableViewPage.xaml line 1
                {
                    global::Microsoft.UI.Xaml.Controls.Page element1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Page>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // Views\AlarmsTableViewPage.xaml line 43
                {
                    this.AlarmsDG = global::WinRT.CastExtensions.As<global::CommunityToolkit.WinUI.UI.Controls.DataGrid>(target);
                    ((global::CommunityToolkit.WinUI.UI.Controls.DataGrid)this.AlarmsDG).Sorting += this.DataGrid_Sorting;
                }
                break;
            case 3: // Views\AlarmsTableViewPage.xaml line 58
                {
                    this.ExportMFI = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)this.ExportMFI).Click += this.ExportMFI_Click;
                }
                break;
            case 5: // Views\AlarmsTableViewPage.xaml line 24
                {
                    this.FromTB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 6: // Views\AlarmsTableViewPage.xaml line 25
                {
                    this.FromCDP = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CalendarDatePicker>(target);
                    ((global::Microsoft.UI.Xaml.Controls.CalendarDatePicker)this.FromCDP).DateChanged += this.FromCDP_DateChanged;
                }
                break;
            case 7: // Views\AlarmsTableViewPage.xaml line 32
                {
                    this.UntilTB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 8: // Views\AlarmsTableViewPage.xaml line 33
                {
                    this.UntilCDP = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CalendarDatePicker>(target);
                    ((global::Microsoft.UI.Xaml.Controls.CalendarDatePicker)this.UntilCDP).DateChanged += this.UntilCDP_DateChanged;
                }
                break;
            case 9: // Views\AlarmsTableViewPage.xaml line 21
                {
                    this.ShowAllCB = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.CheckBox)this.ShowAllCB).Checked += this.ShowAllCB_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.CheckBox)this.ShowAllCB).Unchecked += this.ShowAllCB_Unchecked;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\AlarmsTableViewPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    AlarmsTableViewPage_obj1_Bindings bindings = new AlarmsTableViewPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
