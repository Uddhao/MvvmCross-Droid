using Cirrious.MvvmCross.ViewModels;
using Fragments.Messages;
using System.Collections.Generic;
using System.Windows.Input;

namespace Fragments.ViewModels
{
    public class MainViewModel
        : MvxViewModel
    {
        private List<Employee> employeeList;
        private ICommand cmdEmployeeSeleceted;

        public ICommand CmdEmployeeSelected
        {
            get
            {
                this.cmdEmployeeSeleceted = this.cmdEmployeeSeleceted ?? (this.cmdEmployeeSeleceted = new MvxCommand<Employee>(E => this.doEmployeeSelected(E)));

                return (this.cmdEmployeeSeleceted);
            }
        }
        public MainViewModel()
        {
            DoInitialize();
        }
        
        /// <summary>
        /// Surface the Employee List
        /// </summary>
        public List<Employee> EmployeeList
        {
            get
            {
                return employeeList;
            }
            set
            {
                employeeList = value;
            }
        }

        /// <summary>
        /// Initialize data
        /// </summary>
        private void DoInitialize()
        {
            this.EmployeeList = new List<Employee>
            {
                new Employee() {Name = "Emp1", Id = 1, PhoneNo = 1234 },
                new Employee() {Name = "Emp2", Id = 2, PhoneNo = 5678 },
                new Employee() {Name = "Emp3", Id = 3, PhoneNo = 7979 }
            };
        }

        private void doEmployeeSelected(Employee employee)
        {
            // Protect...
            if (employee == null)
                return;

            ShowViewModel<EmployeeEditorViewModel>(new InitVMPayload() { EmployeeId = employee.Id });
        }
    }

    /// <summary>
    /// Employee Class
    /// </summary>
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public int PhoneNo { get; set; }
    }
}
