using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsDL
{
    public interface IRelief_UsersService
    {
      public bool AddRealif_User(ReliefUser Reliefuser);
       public List<ReliefUser> GetAllPersonRelief(int userId);
      public  List<ReliefReason> GetallReliefReason();
      public  List<ReliefType> GetAllReliefType();
    }
}