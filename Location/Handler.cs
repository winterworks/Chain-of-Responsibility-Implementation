using System;

namespace Location
{
    public abstract class Handler
    {
        public Handler nextHandler { private get; set; }

        public void Handle()
        {
            if (execute()) return;
            if (nextHandler != null)
            {
                nextHandler.Handle();
            }
            else
            {
                Console.WriteLine("Reached the end of the chain.");
            }
        }

        protected abstract bool execute();
    }
}