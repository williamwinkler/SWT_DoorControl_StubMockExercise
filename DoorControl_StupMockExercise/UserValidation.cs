using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl_StupMockExercise
{
    public class UserValidation : IUserValidation
    {
        public bool ValidateEntryRequest(int id)
        {
            if (id == 0)
            {
                Console.WriteLine("Validation denied");
                return false;
            }
            Console.WriteLine("Validation granted");
            return true;
        }
    }
}
