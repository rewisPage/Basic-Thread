# Basic Threading in C# Windows Forms

An implementation of multithreading in a C# Windows Forms Application demonstrated as part of the IT1811 laboratory coursework. This project illustrates thread creation, thread suspension, lifecycle management, thread synchronization using `Join()`, and native Win32 console allocation within a desktop GUI.

<img width="756" height="343" alt="image" src="https://github.com/user-attachments/assets/bb457fad-953f-4176-a934-0e5a5e5f70e7" />

---

## 📌 Project Overview

The objective of this application is to demonstrate how multiple threads execute concurrently and communicate their execution state. A Windows Form interface triggers the background operations, while an allocated Win32 console tracks the real-time execution steps and interleaving of two worker threads.

### Key Features
* **Thread Creation & Delegation:** Instantiates and executes separate worker threads using `ThreadStart` delegates referencing static worker methods.
* **Lifecycle Suspension:** Demonstrates thread state transitions to `WaitSleepJoin` by suspending thread execution for 1.5 seconds per cycle via `Thread.Sleep()`.
* **Thread Synchronization:** Blocks the calling (UI) thread using `.Join()` until both background threads terminate.
* **Native Console Output:** Uses P/Invoke with `kernel32.dll` to spawn a console window directly from a Windows Forms Application.

---

## 🛠️ Tech Stack & Requirements

* **Language:** C#
* **Framework:** .NET Framework / .NET Windows Forms
* **IDE:** Visual Studio 2015 or higher
* **OS:** Windows

---

## 🚀 How It Works

1. **Console Allocation:** On form load (`FrmBasicThread_Load`), `AllocConsole()` from `kernel32.dll` is invoked to attach a standard console to the GUI process.
2. **Thread Instantiation:** Clicking the **Run** button creates two distinct threads: `Thread A` and `Thread B`. Both target the static method `MyThreadClass.Thread1`.
3. **Concurrent Execution:**
   * Each thread iterates through a loop (`0` to `5`).
   * On each iteration, the thread outputs its name and loop count, then suspends execution for 1,500 ms (1.5 seconds).
4. **Thread Joining:** The main thread calls `.Join()` on both worker threads, waiting for both to finish before continuing.
5. **Completion:** Once both threads terminate, a completion message is written to the console and the status label updates to `-End of Thread-`.

---

## 🖥️ Expected Output

### Console Output
```text
-Before starting thread-
Name of Thread: Thread A Process = 0
Name of Thread: Thread B Process = 0
Name of Thread: Thread B Process = 1
Name of Thread: Thread A Process = 1
Name of Thread: Thread B Process = 2
Name of Thread: Thread A Process = 2
Name of Thread: Thread A Process = 3
Name of Thread: Thread B Process = 3
Name of Thread: Thread B Process = 4
Name of Thread: Thread A Process = 4
Name of Thread: Thread A Process = 5
Name of Thread: Thread B Process = 5
-End of Thread-
```
*(Note: Exact thread interleaving may vary based on CPU thread scheduling).*

### Form UI States
* **Initial State:** Label displays `-Before starting thread-`
* **Final State:** Label updates to `-End of Thread-` after execution completes

---

## 📂 Project Structure

```text
├── FrmBasicThread.cs       # Form UI logic, P/Invoke, and thread orchestration
├── FrmBasicThread.Designer.cs
├── MyThreadClass.cs        # Static worker method containing the loop & sleep logic
└── Program.cs              # Application entry point
```

---

## ⚙️ Setup and Installation

1. Clone this repository:
   ```bash
   git clone [https://github.com/your-username/your-repo-name.git](https://github.com/your-username/your-repo-name.git)
   ```
2. Open the solution file (`.sln`) in **Visual Studio**.
3. Ensure the target framework matches your installed .NET version.
4. Press **F5** or click **Start** to build and run the application.
