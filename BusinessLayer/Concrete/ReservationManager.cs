using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }
        public void Add(Reservation entity)
        {
            _reservationDal.Add(entity);
        }

        public void Delete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByWaitingApproval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitingApproval(id);
        }

        public Reservation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByApproved(int id)
        {
            return _reservationDal.GetListWithReservationByApproved(id);
        }

        public List<Reservation> GetListWithPastReservation(int id)
        {
            return _reservationDal.GetListWithPastReservation(id);
        }
    }
}
