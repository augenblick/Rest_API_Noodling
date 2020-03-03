using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace RestTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Debug.WriteLine("TEST");
            TraceListenerCollection listeners = Debug.Listeners;
            foreach (TraceListener listener in listeners) {
                Console.WriteLine(listener.Attributes);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormRestTest());
        }
    }
}
