 using Microsoft.VisualStudio.TestTools.UnitTesting;
using Integration_tasting_ef_core;
using FluentAssertions;
using System;


namespace TestProject
{
    [TestClass]
    public class EFCoreTest
    {
        [TestMethod]
        public void ADDuser_Should_Save()
        {

            User user = new User
            {
                Name = "Mahmoud",
                LastName = "Khleif",
                City= "Göteborg",
                Birthday= new DateTime(1989, 02, 10), 
            };
            DataAccess dataAccess = new DataAccess(new context());
            dataAccess.AddUser(user);
            User usertofind = dataAccess.GetUser("Mahmoud");
            usertofind.Should().BeEquivalentTo(user);
        }
    }
}
