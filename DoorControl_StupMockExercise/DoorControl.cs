using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl_StupMockExercise
{
    internal class DoorControl
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

        void RequestEntry(int id)
        {
            bool status = _userValidation.ValidateEntryRequest(id);
            if (status)
            {
                _door.Open();
                _entryNotification.NotifyEntryGranted(id);
            }
            else
            {
                _door.Close();
            }
        }

        void DoorOpened()
        {
            _door.Close();
            _doorClosed = false;

        }

        void DoorClosed()
        {
            _doorClosed = true;
        }
    }
}
