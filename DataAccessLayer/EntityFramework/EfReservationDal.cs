using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : BaseRepository<Reservation>, IReservationDal
    {

        public List<Reservation> GetListWithReservationByWaitingApproval(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Waiting for Approval"&& x.AppUserId==id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByApproved(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Approved" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithPastReservation(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Completed" && x.AppUserId == id).ToList();
            }
        }
    }
}
