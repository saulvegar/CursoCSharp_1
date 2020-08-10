using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

namespace CursoCSharp_2_interfaz_IDisposable {

    class BaseClass : IDisposable {
        bool disposed = false;

        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing) {
            if (disposed)
                return;
            if (disposing) {
                handle.Dispose();
                // Free any other managed objects here.
            }
        }
    }

    class DerivedClass : BaseClass {
        bool disposed = false;

        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing) {
            if (disposed)
                return;
            if (disposing) {
                handle.Dispose();
                // Free any other managed objects here.
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
