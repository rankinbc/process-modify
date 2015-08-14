using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ProcessModify
{
    public class MemoryModifier
    {
        private Process process;
        private IntPtr processHandle;

        private const int PROCESS_READ = 0x0010;
        private const int PROCESS_WRITE = 0x1F0FFF;
        
        public bool successfulLoad { get; set; } 

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess,
               bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress,
          byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess,
          int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        public MemoryModifier(Process process)
        {
            setProcess(process);
        }

        public void setProcess(Process p)
        {
            try
            {
                //Open process
                this.process = p;
                processHandle = OpenProcess(PROCESS_WRITE, false, process.Id);
                successfulLoad = true;
            }
            catch
            {
                successfulLoad = false;
            }
        }


        //Write single byte
        public void WriteToAddress(Int32 address, byte value)
        {
            if (successfulLoad)
            {
                int bytesWritten = 0;
                byte[] buffer = new byte[1];
                buffer[0] = value;
                WriteProcessMemory((int)processHandle, address, buffer, buffer.Length, ref bytesWritten);
            }
        }

        //Write UInt16
        public void WriteToAddress(Int32 address, UInt16 value)
        {
            if (successfulLoad)
            {
                int bytesWritten = 0;
                byte[] buffer = new byte[2];
                buffer = BitConverter.GetBytes(value);
                WriteProcessMemory((int)processHandle, address, buffer, buffer.Length, ref bytesWritten);
            }
        }

        //Write Int16
        public void WriteToAddress(Int32 address, Int16 value)
        {
            if (successfulLoad)
            {
                int bytesWritten = 0;
                byte[] buffer = new byte[2];
                buffer = BitConverter.GetBytes(value);
                WriteProcessMemory((int)processHandle, address, buffer, buffer.Length, ref bytesWritten);
            }
        }

        //Write float
        public void WriteToAddress(Int32 address, float value)
        {
            if (successfulLoad)
            {
                int bytesWritten = 0;
                byte[] buffer = new byte[4];
                buffer = BitConverter.GetBytes(value);
                WriteProcessMemory((int)processHandle, address, buffer, buffer.Length, ref bytesWritten);
            }
        }

        //Write double
        public void WriteToAddress(Int32 address, double value)
        {
            if (successfulLoad)
            {
                int bytesWritten = 0;
                byte[] buffer = new byte[8];
                buffer = BitConverter.GetBytes(value);
                WriteProcessMemory((int)processHandle, address, buffer, buffer.Length, ref bytesWritten);
            }
        }

        //Read bytes
        public byte[] ReadFromAddress(Int32 address, int bytes)
        {
            if (successfulLoad)
            {
                IntPtr processHandle = OpenProcess(PROCESS_READ, false, process.Id);
                int bytesRead = 0;
                byte[] buffer = new byte[bytes];
                ReadProcessMemory((int)processHandle, address, buffer, buffer.Length, ref bytesRead);
                return buffer;
            }
            else
                return null;
        }

    }
}
