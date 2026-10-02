using BasicThread;
using System.Runtime.InteropServices;

namespace Basic_Thread
{
    public partial class FrmBasicThread : Form
    {
        // Import AllocConsole from kernel32.dll to spawn the console window
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {
            // Allocate the console window when the form opens
            AllocConsole();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Print initial state to console
            Console.WriteLine("-Before starting thread-");

            // Initialize ThreadA and ThreadB with Thread1 static method
            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread1));

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";

            // Start both threads
            threadA.Start();
            threadB.Start();

            // Wait for both threads to finish execution
            threadA.Join();
            threadB.Join();

            // Notify console and update labelStatus when threads have completed
            Console.WriteLine("-End of Thread-");
            lblStatus.Text = "End of Thread";
        }
    }
}
