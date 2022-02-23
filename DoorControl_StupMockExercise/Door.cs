using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl_StupMockExercise 
{
    public class Door : IDoor
    {
        public bool doorClosed = true;
        public DoorControl _doorControl;

        public void setDoorControl(DoorControl doorControl)
        {
            _doorControl = doorControl;
        }
        public void Close()
        {
            Console.WriteLine("Door Close() called");
            doorClosed = true;
            _doorControl.DoorClosed();
        }

        public void Open()
        {
            Console.WriteLine("Door Open() called");
            doorClosed= false;
        }

        public bool getDoorClosed()
        {
            return doorClosed;
        }

        public DoorControl getDoorControl()
        {
            return _doorControl;
        }
    }
}
