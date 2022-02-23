using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl_StupMockExercise
{
    public interface IEntryNotification
    {
        public void NotifyEntryGranted(int id);
    }
}
