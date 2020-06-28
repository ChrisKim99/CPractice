using System;
using System.Collections.Generic;
using System.Text;

namespace CPractice.Concepts
{
    public class ProcessBusinessLogic // publisher
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<bool> ProcessCompleted;
        public void StartProcess()
        {
            try
            {
                Console.WriteLine("Process Started!");
                OnProcessCompleted(true);
            }
            catch (Exception ex)
            {
                OnProcessCompleted(false);
            }
        }
        protected virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this, IsSuccessful);
        }
    }

    public class Program
    {
        public static void eve()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
        }

        // event handler
        public static void bl_ProcessCompleted(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
        }
    }
}
