using System;

namespace Location
{
    public abstract class Handler
    {
        public Handler NextHandler { private get; set; }
        protected abstract bool execute();

        public void Handle()
        {
            // If the executing is a success there is no need to continue handling, instead return
            if (execute()) return;
            // If it is the end of the chain
            if (NextHandler != null)
            {
                NextHandler.Handle();
            }
            else
            {
                Console.WriteLine("Reached the end of the chain.");
            }
        }

    }
}