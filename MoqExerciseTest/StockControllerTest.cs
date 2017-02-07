using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoqExercise;
using System.Collections.Generic;
using Moq;
using FluentAssertions;

namespace MoqExerciseTest
{
    [TestClass]
    public class StockControllerTest
    {
        [TestMethod]
        public void MethodToTest()
        {
            // create list of stocks to return
            var lstOfStocks = new List<Stock>();
            lstOfStocks.Add(new Stock
            {
                Ticker = "TMUS",
                Name = "T-Mobile",
                StockExchange = "NASDAQ",
                StockPrice = 62.05M
            });
            
            Mock<IRepository> mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.GetStocks()).Returns(new List<Stock>(lstOfStocks));
            var stockController = new StockController(mockRepository.Object);
            stockController.MethodToTest();
            stockController.Should().NotBeNull();
        }
    }
}
