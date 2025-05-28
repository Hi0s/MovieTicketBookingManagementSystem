using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBookingManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new LoginForm());
            Application.Run(new DetailMovie());
            //Application.Run(new AddShowtimeForm());
            //Application.Run(new userdashboard());
            // Application.Run(new SeatSelection());
        }
    }
}
