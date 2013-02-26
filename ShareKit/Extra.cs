using System;
using System.Runtime.InteropServices;

namespace ShareKit
{
    public partial class SHKItem
    {
        public string this[string key]
        {
            get
            {
                return CustomValueForKey (key);
            }
            set
            {
                SetCustomValue (value, key);
            }
        }
    }

    public partial class SHK
    {
        /*
        public void Error (string description, params object[] args)
        {
            var pNativeArr = Marshal.AllocHGlobal(args.Length * IntPtr.Size);
            for (int i = 1; i < workers.Length; ++i)
                Marshal.WriteIntPtr (pNativeArr, (i - 1) * IntPtr.Size, workers[i].Handle);
            
            // Null termination
            Marshal.WriteIntPtr (pNativeArr, (workers.Length - 1) * IntPtr.Size, IntPtr.Zero);
            
            // the signature for this method has gone from (IntPtr, IntPtr) to (Worker, IntPtr)
            WorkerManager.AppendWorkers(workers[0], pNativeArr);
            Marshal.FreeHGlobal(pNativeArr);
        }
        */
    }
}

