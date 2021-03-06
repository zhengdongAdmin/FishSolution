﻿namespace UILibrary.Win32.Com
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), ComVisible(true)]
    public struct DOCHOSTUIINFO
    {
        [MarshalAs(UnmanagedType.U4)]
        public uint cbSize;
        [MarshalAs(UnmanagedType.U4)]
        public uint dwFlags;
        [MarshalAs(UnmanagedType.U4)]
        public uint dwDoubleClick;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pchHostCss;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pchHostNS;
    }
}

