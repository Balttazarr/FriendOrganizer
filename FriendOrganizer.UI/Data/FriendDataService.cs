using System.Collections.Generic;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            //TODO LOAD DATA FROM DB
            yield return new Friend { FirstName = "Tomasz", LastName = "Lyzwa" };
            yield return new Friend { FirstName = "Faustyna", LastName = "Knasiecka" };

            yield return new Friend { FirstName = "Maciej", LastName = "Cieszynski" };

            yield return new Friend { FirstName = "Wiktor", LastName = "Kucharski" };

        }
    }
}
