﻿#pragma checksum "C:\Users\aexra\source\repos\Shield\Shield.App\Views\ProfilePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4787C9F983F05048D5896BC2ABA392116EA454B3780769E57D3FF65DB20A0B0A"
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
    partial class ProfilePage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(global::Microsoft.UI.Xaml.UIElement obj, global::Microsoft.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ProfilePage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IProfilePage_Bindings
        {
            private global::Shield.App.Views.ProfilePage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.StackPanel obj2;
            private global::Microsoft.UI.Xaml.Controls.StackPanel obj3;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj5;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj6;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj7;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2VisibilityDisabled = false;
            private static bool isobj3VisibilityDisabled = false;
            private static bool isobj5TextDisabled = false;
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;

            private ProfilePage_obj1_BindingsTracking bindingsTracking;

            public ProfilePage_obj1_Bindings()
            {
                this.bindingsTracking = new ProfilePage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 15 && columnNumber == 21)
                {
                    isobj2VisibilityDisabled = true;
                }
                else if (lineNumber == 25 && columnNumber == 21)
                {
                    isobj3VisibilityDisabled = true;
                }
                else if (lineNumber == 17 && columnNumber == 24)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 19 && columnNumber == 24)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 21 && columnNumber == 24)
                {
                    isobj7TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\ProfilePage.xaml line 15
                        this.obj2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                        break;
                    case 3: // Views\ProfilePage.xaml line 25
                        this.obj3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                        break;
                    case 5: // Views\ProfilePage.xaml line 17
                        this.obj5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 6: // Views\ProfilePage.xaml line 19
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 7: // Views\ProfilePage.xaml line 21
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
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

            // IProfilePage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::Shield.App.Views.ProfilePage>(newDataRoot);
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
            private void Update_(global::Shield.App.Views.ProfilePage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_IsLoggedIn(obj.IsLoggedIn, phase);
                        this.Update_IsNotLoggedIn(obj.IsNotLoggedIn, phase);
                        this.Update_Profile(obj.Profile, phase);
                    }
                }
            }
            private void Update_IsLoggedIn(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_IsLoggedIn_Cast_IsLoggedIn_To_Visibility(obj ? global::Microsoft.UI.Xaml.Visibility.Visible : global::Microsoft.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_IsLoggedIn_Cast_IsLoggedIn_To_Visibility(global::Microsoft.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ProfilePage.xaml line 15
                    if (!isobj2VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj2, obj);
                    }
                }
            }
            private void Update_IsNotLoggedIn(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_IsNotLoggedIn_Cast_IsNotLoggedIn_To_Visibility(obj ? global::Microsoft.UI.Xaml.Visibility.Visible : global::Microsoft.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_IsNotLoggedIn_Cast_IsNotLoggedIn_To_Visibility(global::Microsoft.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ProfilePage.xaml line 25
                    if (!isobj3VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility(this.obj3, obj);
                    }
                }
            }
            private void Update_Profile(global::Shield.DataAccess.DTOs.ProfileInfoDto obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Profile_UserName(obj.UserName, phase);
                        this.Update_Profile_Email(obj.Email, phase);
                        this.Update_Profile_Id(obj.Id, phase);
                    }
                }
            }
            private void Update_Profile_UserName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ProfilePage.xaml line 17
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_Profile_Email(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ProfilePage.xaml line 19
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                }
            }
            private void Update_Profile_Id(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ProfilePage.xaml line 21
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ProfilePage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ProfilePage_obj1_Bindings> weakRefToBindingObj; 

                public ProfilePage_obj1_BindingsTracking(ProfilePage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ProfilePage_obj1_Bindings>(obj);
                }

                public ProfilePage_obj1_Bindings TryGetBindingObject()
                {
                    ProfilePage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ProfilePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Shield.App.Views.ProfilePage obj = sender as global::Shield.App.Views.ProfilePage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_IsLoggedIn(obj.IsLoggedIn, DATA_CHANGED);
                                bindings.Update_IsNotLoggedIn(obj.IsNotLoggedIn, DATA_CHANGED);
                                bindings.Update_Profile(obj.Profile, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsLoggedIn":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_IsLoggedIn(obj.IsLoggedIn, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsNotLoggedIn":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_IsNotLoggedIn(obj.IsNotLoggedIn, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Profile":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Profile(obj.Profile, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::Shield.App.Views.ProfilePage obj)
                {
                    ProfilePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
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
            case 1: // Views\ProfilePage.xaml line 2
                {
                    global::Microsoft.UI.Xaml.Controls.Page element1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Page>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 4: // Views\ProfilePage.xaml line 27
                {
                    global::Microsoft.UI.Xaml.Controls.Button element4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element4).Click += this.LoginButton_Click;
                }
                break;
            case 8: // Views\ProfilePage.xaml line 22
                {
                    this.LogoutButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.LogoutButton).Click += this.LogoutButton_Click;
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
            case 1: // Views\ProfilePage.xaml line 2
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    ProfilePage_obj1_Bindings bindings = new ProfilePage_obj1_Bindings();
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
