using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl_StupMockExercise
{
    public interface IDoor
    {
        void Open();
        void Close();

        void setDoorControl(DoorControl control);

        bool getDoorClosed();

        DoorControl getDoorControl();
    }
}
