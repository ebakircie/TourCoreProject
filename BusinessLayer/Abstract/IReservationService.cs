using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService:IBaseService<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitingApproval(int id);
        List<Reservation> GetListWithReservationByApproved(int id);
        List<Reservation> GetListWithPastReservation(int id);
    } 
}
