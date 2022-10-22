using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Form1.cs;

namespace Lab_2_2
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new lab_2_wpf_.Form1());
            Model model = new Model();
            /*model.ModelSet.Intensity = 0.8;
            model.ModelSet.MinValueOfBurstTime = 3;
            model.ModelSet.MaxValueOfBurstTime = 8;
            model.ModelSet.MinValueOfAddrSpace = 100;
            model.ModelSet.MaxValueOfAddrSpace = 300;
            model.ModelSet.ValueOfRAMSize = 32000;
            model.SaveSettings();

            for (int i = 0; i < 20; i++)
            {
                model.WorkingCycle();
                if (!model.cpu.IsFree())
                {
                    Console.WriteLine("On cpu: {0}", model.cpu.ActiveProcess);
                }

                if (!model.device.IsFree())
                {
                    Console.WriteLine("On device: {0}", model.device.ActiveProcess);
                }
            }*/
        }
    }
}
