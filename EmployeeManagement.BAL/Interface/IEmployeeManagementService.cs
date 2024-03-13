using EmployeeManagement.Data;
using System.Collections.Generic;


namespace EmployeeManagement.BAL.Interface
{
   public interface IEmployeeManagementService
    {
        List<PersonalDetail> GetAll();
        void Save(PersonalDetail personalDetail);
    }
}
