using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blackjack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Tests
{
    [TestClass()]
    public class BlackjackTests
    {
        [TestMethod()]
        public void ShowCardsTest()
        {
            //arrange
            int yourScore = 20;
            int computerScore = 23;
            string expected = "\nYou Won!";
            ShowCards showCards = new ShowCards();
            //act            
            string actual = showCards.Check(yourScore, computerScore);
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}