using BasicThread;

namespace Basic_Thread
{
    public partial class FrmBasicThread : Form
    {

        public FrmBasicThread()
        {
            InitializeComponent();
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
