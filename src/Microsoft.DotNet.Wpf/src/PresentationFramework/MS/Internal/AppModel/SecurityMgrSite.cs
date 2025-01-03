// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Description:
//              The SecurityMgrSite is an implementation of Urlmon's IInternetSecurityMgrSite. 
//
//              It is primarily used to supply an hwnd to be modal to- when a ProcessUrlAction call
//              is required to show UI. 

using MS.Win32;
using System.Windows;

namespace MS.Internal
{
    internal class SecurityMgrSite : NativeMethods.IInternetSecurityMgrSite
    {
        internal SecurityMgrSite()
        {
        }

        public void GetWindow( /* [out] */ ref IntPtr phwnd)
        {
            phwnd = IntPtr.Zero;

            if (Application.Current != null)
            {
                Window curWindow = Application.Current.MainWindow;
                if (curWindow != null)
                {
                    phwnd = curWindow.Handle;
                }
            }
        }

        public void EnableModeless( /* [in] */ bool fEnable)
        {
        }
    }
}
