using EmployeeManagement.BAL.Interface;
using EmployeeManagement.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BAL.Implementation
{
   public class EmployeeManagementService : IEmployeeManagementService
    {
        private EmployeeManagementEntities _context = new EmployeeManagementEntities();
        public List<PersonalDetail> GetAll()
        {
            return _context.PersonalDetails.ToList();
        }

        public void Save(PersonalDetail personalDetail)
        {
            _context.PersonalDetails.Add(personalDetail);

            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
