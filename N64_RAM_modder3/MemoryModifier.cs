using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace N64_RAM_modder3
{
    public class MemoryModifier
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess,
               bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress,
          byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess,
          int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        const int PROCESS_READ = 0x0010;
        const int PROCESS_WRITE = 0x1F0FFF;

        Process process;
        IntPtr processHandle; 

        public MemoryModifier(Process process)
        {
            this.process = process;
            processHandle = OpenProcess(PROCESS_WRITE, false, process.Id);
        }

        public void WriteToAddress(Int32 address, byte value)
        {
            int bytesWritten = 0;
            byte[] buffer = new byte[1];
            buffer[0] = value;
            WriteProcessMemory((int)processHandle, address, buffer, buffer.Length, ref bytesWritten);
        }
        public void WriteToAddress(Int32 address, float value)
        {
            int bytesWritten = 0;
            byte[] buffer = new byte[3]; 
            buffer = BitConverter.GetBytes(value);
            WriteProcessMemory((int)processHandle, address, buffer, buffer.Length, ref bytesWritten);
        }
        public byte[] ReadFromAddress(Int32 address, int bytes)
        {
            IntPtr processHandle = OpenProcess(PROCESS_READ, false, process.Id);

            int bytesRead = 0;
            byte[] buffer = new byte[bytes];
            ReadProcessMemory((int)processHandle,address, buffer, buffer.Length, ref bytesRead);

            return buffer;
        }



  

    }
}
