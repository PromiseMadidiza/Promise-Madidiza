Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class CustomerTests
    <TestMethod>
    Public Sub AddCustomerTest()
        ' Arrange
        Dim customer = New Customer With {
            .Name = "John",
            .Surname = "Doe",
        .Address = "123 Main St",
        .ID = "638767793",
        .Contact = "555-555-1212"
        }
        Dim expectedCount = 1

        ' Act
        Dim customerRepository = New customerRepository()
        customerRepository.AddCustomer(customer)
        Dim actualCount = customerRepository.GetCustomers().Count()

        ' Assert
        Assert.AreEqual(expectedCount, actualCount)
    End Sub
End Class


