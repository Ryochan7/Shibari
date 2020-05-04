using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Runtime.InteropServices;
using PInvoke;

namespace Shibari.Sub.Core.Util
{
    [SuppressUnmanagedCodeSecurity]
    public static class NativeMethodsShibari
    {
        [DllImport(nameof(Kernel32), SetLastError = true)]
        public static extern bool DeviceIoControl(Kernel32.SafeObjectHandle hDevice, int dwIoControlCode, IntPtr inBuffer, int nInBufferSize, IntPtr outBuffer, int nOutBufferSize, out int pBytesReturned, IntPtr lpOverlapped);

        [DllImport(nameof(Kernel32), SetLastError = true)]
        public static extern bool ReadFile(Kernel32.SafeObjectHandle hFile, IntPtr lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, IntPtr lpOverlapped);

        [DllImport(nameof(Kernel32), SetLastError = true)]
        public static extern bool GetOverlappedResult(Kernel32.SafeObjectHandle hFile, IntPtr lpOverlapped, out int lpNumberOfBytesTransferred, bool bWait);

        [DllImport(nameof(Kernel32), SetLastError = true)]
        public static extern bool WriteFile(Kernel32.SafeObjectHandle hFile, IntPtr lpBuffer, int nNumberOfBytesToWrite, ref int lpNumberOfBytesWritten, IntPtr lpOverlapped);
    }
}
