using System;


namespace DoorControl_StupMockExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var door = new Door();

            var doorControl = new DoorControl(door,
                                            new EntryNotification(),
                                            new UserValidation());

            door.setDoorControl(doorControl);
            doorControl.RequestEntry(1);

            door.getDoorControl().DoorOpened(); // tester
        }
    }
}
