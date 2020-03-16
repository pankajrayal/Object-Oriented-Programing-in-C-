using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest {
    [TestClass]
    public class CustomerTest {
        [TestMethod]
        public void FullName() {
            //Arrange
            Customer customer = new Customer { 
                FirstName = "Pankaj",
                LastName = "Rayal"
            };
            string expected = "Rayal, Pankaj";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty() {
            // Arrange
            Customer customer = new Customer {
                LastName = "Rayal"
            };
            string expected = "Rayal";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty() {
            //Arrange
            Customer customer = new Customer {
                FirstName = "Pankaj"
            };
            string expected = "Pankaj";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Pankaj";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Pawan";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rajeev";
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid() {
            //Arrange
            var customer = new Customer {
                LastName = "Rayal",
                EmailAddress = "pankajrayal@gmail.com"
            };

            var expected = true;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName() {
            //Arrange
            var customer = new Customer { 
                EmailAddress = "pankajrayal@gmail.com"
            };

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}