using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace cardgame
{
    public static class Garsas
    {
        [DllImport("winmm.dll", SetLastError = true)]
        public static extern bool PlaySound(byte[] ptrToSound, System.UIntPtr hmod, uint fdwSound);

        [DllImport("winmm.dll", SetLastError = true)]
        public static extern bool PlaySound(IntPtr ptrToSound, System.UIntPtr hmod, uint fdwSound);

        static private GCHandle? gcHandle = null;
        private static byte[] bytesToPlay = null;
        private static byte[] BytesToPlay
        {
            get { return bytesToPlay; }
            set
            {
                FreeHandle();
                bytesToPlay = value;
            }
        }

        public static void PlaySound(System.IO.Stream stream)
        {
            PlaySound(stream, SoundFlags.SND_MEMORY | SoundFlags.SND_ASYNC);
        }

        public static void PlaySound(System.IO.Stream stream, SoundFlags flags)
        {
            LoadStream(stream);
            flags |= SoundFlags.SND_ASYNC;
            flags |= SoundFlags.SND_MEMORY;
            flags |= SoundFlags.SND_NOSTOP;

            if (BytesToPlay != null)
            {
                gcHandle = GCHandle.Alloc(BytesToPlay, GCHandleType.Pinned);
                PlaySound(gcHandle.Value.AddrOfPinnedObject(), (UIntPtr)0, (uint)flags);
            }
            else
            {
                PlaySound((byte[])null, (UIntPtr)0, (uint)flags);
            }
        }

        private static void LoadStream(System.IO.Stream stream)
        {
            if (stream != null)
            {
                byte[] bytesToPlay = new byte[stream.Length];
                stream.Read(bytesToPlay, 0, (int)stream.Length);
                BytesToPlay = bytesToPlay;
            }
            else
            {
                BytesToPlay = null;
            }
        }

        private static void FreeHandle()
        {
            if (gcHandle != null)
            {
                PlaySound((byte[])null, (UIntPtr)0, (uint)0);
                gcHandle.Value.Free();
                gcHandle = null;
            }
        }
    }

    [Flags]
    public enum SoundFlags : int
    {
        SND_SYNC = 0x0000,        
        SND_ASYNC = 0x0001,       
        SND_NODEFAULT = 0x0002,   
        SND_MEMORY = 0x0004,   
        SND_LOOP = 0x0008,        
        SND_NOSTOP = 0x0010,     
        SND_NOWAIT = 0x00002000,       
        SND_ALIAS = 0x00010000,        
        SND_ALIAS_ID = 0x00110000,        
        SND_FILENAME = 0x00020000,        
    }
}