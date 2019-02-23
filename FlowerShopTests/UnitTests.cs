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
        public void Test2()
        {
            //Arrange
           
            IOrderDAO d = Substitute.For<IOrderDAO>();
            IClient a = Substitute.For<IClient>();

            Flower f = new Flower(f,"daisy",60,6);
            
            List<Flower> flower = new List<Flower>();
            flower.add(f);
            IOrder o = new Order(y, c, false);


            //Act
            double price = o.Price;

            //Assert
            Assert.AreEqual(o.Price, 72);
        }
    }
}