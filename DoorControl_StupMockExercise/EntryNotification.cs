using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl_StupMockExercise
{
    internal class EntryNotification : IEntryNotification
    {
        public void NotifyEntryGranted(int id)
        {
            Console.WriteLine("Entry granted for id: " + id);
        }
    }
}
