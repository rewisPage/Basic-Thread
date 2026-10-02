namespace BasicThread
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            // Runs from 0 through 5 to match the sample console output
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);

                // Suspend the current thread for 1.5 seconds (1500 ms)
                Thread.Sleep(1500);
            }
        }
    }
}