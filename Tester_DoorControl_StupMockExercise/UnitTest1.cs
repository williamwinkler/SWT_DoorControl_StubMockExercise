using NUnit.Framework;
using DoorControl_StupMockExercise;

namespace Tester_DoorControl_StupMockExercise 
{
    public class Tests 
    {
        private DoorControl uut;
        private IDoor door;
        private IUserValidation userValidation;
        private IEntryNotification entryNotification;
       

        [SetUp]
        public void Setup()
        {
            door = new Door();
            userValidation = new UserValidation();
            entryNotification = new EntryNotification();

            uut = new DoorControl(door, entryNotification, userValidation);
            uut.setDoorControl(uut);
        }

        [Test]
        public void SendValidRequest_resultDoorOpen()
        {
            uut.RequestEntry(1);

            Assert.AreEqual(false, door.getDoorClosed());
            
        }
    }
}