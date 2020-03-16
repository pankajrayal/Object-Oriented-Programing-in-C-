using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL {
    public class Customer {
        public Customer() {

        }

        public Customer( int customerId) {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public static int InstanceCount { get; set; }
        public string FullName {
            get {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName)) {
                    if (!string.IsNullOrWhiteSpace(fullName)) {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        private string _lastName;
        public string LastName {
            get {
                return _lastName;
            }
            set {
                _lastName = value;
            }
        }

        public bool Validate() {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public Customer Retrieve(int customerId) {
            //Code that retrieves the defined customer

            return new Customer();
        }

        public List<Customer> Retrieve() {
            //Code that retrieves all of the customers
            return new List<Customer>();
        }

        public bool Save() {
            //Code that saves the defined customer
            return true;
        }

    }
}