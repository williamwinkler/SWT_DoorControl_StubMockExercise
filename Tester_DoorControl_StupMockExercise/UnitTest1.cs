using NUnit.Framework;
using DoorControl_StupMockExercise;
using NSubstitute;

namespace Tester_DoorControl_StupMockExercise 
{
    public class Tests 
    {
        private DoorControl uut;
        private IDoor _door;
        private IUserValidation _userValidation;
        private IEntryNotification _entryNotification;
       

        [SetUp]
        public void Setup()
        {
            _door = Substitute.For<IDoor>();
            _userValidation = Substitute.For<IUserValidation>();
            _entryNotification = Substitute.For<IEntryNotification>();

            uut = new DoorControl(_door, _entryNotification, _userValidation);
            uut.setDoorControl(uut);
        }

        [TestCase(1)]
        public void SendRequestWithId1_resultDoorOpenCalledOnce(int id)
        {
            _userValidation.ValidateEntryRequest(id).Returns(true);
            // Act
            uut.RequestEntry(id);

            //Assert
            _door.Received(1).Open();
            _entryNotification.Received(1).NotifyEntryGranted(id);
        }

        [Test]
        public void SendRequestWithId0_resultDoorCloseCalledOnce()
        {
            // Arrange
            int id = 0;
            _userValidation.ValidateEntryRequest(id).Returns(false);

            // Act
            uut.RequestEntry(id);

            //Assert
            _door.Received(1).Close();
        }

        [Test]
        public void DoorOpened_doorCloseCalledOnce()
        {
            // Arrange       

            // Act
            uut.DoorOpened();

            //Assert
            _door.Received(1).Close();
        }

        [Test]
        public void DoorClosed_doorOpenCalledZeroTimes()
        {
            // Arrange       

            // Act
            uut.DoorClosed();

            //Assert
            _door.Received(0).Open();
        }
    }
}