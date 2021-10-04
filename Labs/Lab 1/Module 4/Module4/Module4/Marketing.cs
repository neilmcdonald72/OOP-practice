using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Marketing
    {
        public void Start()
        {
            Program.Posted += HasPosted;
        }
        void HasPosted()
        {
            Console.WriteLine("Thank you for completing the survey. You are new subscribed to ten of our newsletters.");
        }
    }
}
