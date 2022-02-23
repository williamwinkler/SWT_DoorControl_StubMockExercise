using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl_StupMockExercise 
{
    public class Door : IDoor
    {
        public void Close()
        {
            Console.WriteLine("Door Close() called");
        }

        public void Open()
        {
            Console.WriteLine("Door Open() called");
        }
    }
}
