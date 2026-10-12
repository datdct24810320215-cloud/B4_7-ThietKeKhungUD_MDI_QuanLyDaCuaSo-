#nullable disable
using System;
using System.Windows.Forms;

namespace B4_7_MDI_QuanLyDaCuaSo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}
