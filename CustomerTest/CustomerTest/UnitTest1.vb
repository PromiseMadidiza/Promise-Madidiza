Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()>
Public Class UnitTest1

    <TestMethod()>
    Public Sub TestMethod1()
        Dim customer = New Customer With {
           .Name = "John",
           .Surname = "Doe",
           .Address = "123 Main St",
           .Email = "johndoe@example.com",
           .Phone = "555-555-1212"
       }
        Dim expectedCount = 1

        ' Act
        Dim customerRepository = New CustomerRepository()
        customerRepository.AddCustomer(customer)
        Dim actualCount = customerRepository.GetCustomers().Count()

        ' Assert
        Assert.AreEqual(expectedCount, actualCount)
    End Sub

End Class