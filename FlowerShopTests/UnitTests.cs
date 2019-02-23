using NUnit.Framework;
using Order;
using IOrder;
using Nsubstitute;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            //Arrange
            IOrder o = Substitute.For<IOrder>();
            IOrderDAO d = Substitute.For<IOrderDAO>();
            IOrder o = new Order(y,c,false);
            
            //Act
            o.IsDelivered = true;

            //Assert
            d.Received().SetDelivered(Arg.Any<IOrder>());



        }
    }
}