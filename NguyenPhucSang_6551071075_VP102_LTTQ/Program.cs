using NguyenPhucSang_6551071075_VP102_LTTQ;
using System;
using System.Windows.Forms;

namespace QLDuLieu
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}