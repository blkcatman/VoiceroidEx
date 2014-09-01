﻿using System;
using System.Collections.Generic;
using System.Text;

namespace saga.voiceroid
{
    public enum VoiceroidType
    {
        Yukari,
        Maki
    }
    public sealed class VoiceroidInfo
    {
        /*
         * コンストラクタ
         */
        public VoiceroidInfo() {}

        public VoiceroidInfo(VoiceroidType Type, string VoiceroidTitle, string SaveWindowTitle,
            UInt32 Interval, int PlayButtonIndex, int OpenSaveWindowIndex, int AddressToolbarIndex,
            int FileNameTextBoxIndex, int SaveButtonIndex)
        {
            this.Type = Type;
            this.VoiceroidTitle = VoiceroidTitle;
            this.SaveWindowTitle = SaveWindowTitle;
            this.Interval = Interval;
            this.PlayButtonIndex = PlayButtonIndex;
            this.OpenSaveWindowIndex = OpenSaveWindowIndex;
            this.AddressToolbarIndex = AddressToolbarIndex;
            this.FileNameTextBoxIndex = FileNameTextBoxIndex;
            this.SaveButtonIndex = SaveButtonIndex;
        }

        private VoiceroidType _Type;
        public VoiceroidType Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string _VoiceroidTitle;
        public string VoiceroidTitle
        {
            get { return _VoiceroidTitle; }
            set { _VoiceroidTitle = value; }
        }

        private string _SaveWindowTitle;
        public string SaveWindowTitle
        {
            get { return _SaveWindowTitle; }
            set { _SaveWindowTitle = value; }
        }

        private UInt32 _Interval;
        public UInt32 Interval
        {
            get { return _Interval; }
            set { _Interval = value; }
        }

        private int _PlayButtonIndex;
        public int PlayButtonIndex
        {
            get { return _PlayButtonIndex; }
            set { _PlayButtonIndex = value; }
        }

        private int _OpenSaveWindowIndex;
        public int OpenSaveWindowIndex
        {
            get { return _OpenSaveWindowIndex; }
            set { _OpenSaveWindowIndex = value; }
        }

        private int _AddressToolbarIndex;
        public int AddressToolbarIndex
        {
            get { return _AddressToolbarIndex; }
            set { _AddressToolbarIndex = value; }
        }
        private int _FileNameTextBoxIndex;
        public int FileNameTextBoxIndex
        {
            get { return _FileNameTextBoxIndex; }
            set { _FileNameTextBoxIndex = value; }
        }

        private int _SaveButtonIndex;
        public int SaveButtonIndex
        {
            get { return _SaveButtonIndex; }
            set { _SaveButtonIndex = value; }
        }

    }
}