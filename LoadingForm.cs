using System.Threading;
using System.Windows.Forms;

namespace MovieTicketBookingManagementSystem
{
    public partial class LoadingForm : Form
    {
        public LoadingForm(int max)
        {
            InitializeComponent();
            progressBar1.Maximum = max;
            progressBar1.Value = 0;
        }

        public void Increment()
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value++;

            progressBar1.Refresh();
            Thread.Sleep(10); // Sleep for 200 milliseconds to visualize progress
        }
    }
}