using Cirrious.MvvmCross.ViewModels;
using Fragments.Messages;
using System.Collections.Generic;
using System.Linq;

namespace Fragments.ViewModels
{
    public class EmployeeEditorViewModel
        : MvxViewModel
    {
        private int empId;
        private Employee employee;

        public Employee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public EmployeeEditorViewModel()
        {

        }

        /// <summary>
        ///  Method called with any payload. We get the Employee Id that we are about to display
        /// </summary>
        /// <param name="vmPayload"></param>
        public void Init(InitVMPayload vmPayload)
        {
            if(vmPayload != null)
            {
                empId = vmPayload.EmployeeId;
            }          

            DoDataInitialize();
        }

        /// <summary>
        /// Initialize data
        /// </summary>
        private void DoDataInitialize()
        {
            var empList = new List<Employee>()
           {
               new Employee() {Name = "EMp1", Address ="USA", Id = 1, PhoneNo = 1234 },
               new Employee() {Name = "Emp2", Address ="UK", Id = 2, PhoneNo = 5678 },
               new Employee() {Name = "EMp3", Address ="SA", Id = 3, PhoneNo = 7979 }
           };

            this.Employee = empList.Where(e => e.Id == empId).FirstOrDefault();
        }
    }
}
