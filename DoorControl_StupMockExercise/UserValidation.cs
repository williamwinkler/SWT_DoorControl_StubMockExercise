using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl_StupMockExercise
{
    internal class UserValidation : IUserValidation
    {
        public bool ValidateEntryRequest(int id)
        {
            if (id == 0)
                return false;
            return true;
        }
    }
}
