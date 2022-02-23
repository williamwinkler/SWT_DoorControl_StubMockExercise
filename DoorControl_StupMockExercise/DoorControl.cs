using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl_StupMockExercise
{
    public class DoorControl
    {
        private IDoor _door;
        private IEntryNotification _entryNotification;
        private IUserValidation _userValidation;


        public DoorControl(IDoor door, IEntryNotification entryNotification, IUserValidation userValidation)
        {
            _door = door;
            _entryNotification = entryNotification;
            _userValidation = userValidation;
        }

        public void setDoorControl(DoorControl doorControl)
        {
            _door.setDoorControl(doorControl);
        }
        public void RequestEntry(int id)
        {
            Console.WriteLine("Requested entry for id: " + id);
            bool granted = _userValidation.ValidateEntryRequest(id);
            if (granted)
            {
                _door.Open();
                _entryNotification.NotifyEntryGranted(id);
            }
            else
            {
                _door.Close();
            }
        }

        public void DoorOpened()
        {
            Console.WriteLine("DoorOpened() called");
            _door.Close();
        }

        public void DoorClosed()
        {
            Console.WriteLine("DoorClosed() called");
        }
    }
}
