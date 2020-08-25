using FluentAssertions;
using Moq;
using RTManager.App.Abstract;
using RTManager.App.Concrete;
using RTManager.App.Managers;
using RTManager.Domian.Entity;
using System;
using System.Net.Cache;
using Xunit;

namespace RTManager.App.Tests
{
    public class Tests
    {
        [Fact]
        public void CanAddNewRequest()
        {
            //Arrange
            Request request = new Request(1, 1, "Test", DateTime.Now);
            //var mockService = new Mock<RequestService>();
            var rService = new RequestService();

            //Act
            rService.AddItem(request);

            //mockService.Object.AddItem(request);

            //Assert
            rService.Items.Should().HaveCount(1);
            rService.Items[0].Should().Be(request);
            rService.Items[0].RequestDescription.Should().Be("Test");

            //mockService.Object.Items.Should().HaveCount(1);
            //mockService.Object.Items[0].Should().Be(request);
            //mockService.Object.Items[0].RequestDescription.Should().Be("Test");
        }
    }
}
