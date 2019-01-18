using System;

namespace flower
{
    class Surely
    {
        /// <summary>
        /// Validation
        /// </summary>
        public static void Approve()
        {
            // It could still be right? But it can't and rules dont let it? I get it and yet I don't because I might not be right
            if (Console.ReadLine() == "flower")
            {
                Console.WriteLine("...");
            }
            else // this is meant to be
            {
                // No
                Environment.Exit(13);
            } // the keratin shines
        }
    }
}