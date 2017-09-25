﻿using System;
using System.Runtime.InteropServices;

namespace MetroSet_UI.Native
{
    internal class User32
    {
        public AnimateWindowFlags AW_HIDE { get; internal set; }

        #region Flags

        public enum AnimateWindowFlags : uint
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }

        #endregion

        #region Methods

        [DllImport("user32")]
        public static extern bool AnimateWindow(IntPtr hwnd, int time, AnimateWindowFlags flags);

        internal void AnimateWindow(IntPtr handle, int v, object p)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}