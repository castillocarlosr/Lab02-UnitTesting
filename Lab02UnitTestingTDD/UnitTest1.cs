using System;
using Xunit;
using Lab02_UnitTesting;

namespace Lab02UnitTestingTDD
{
    public class UnitTest1
    {
        [Fact]
        public void SmallWithdraw()
        {
            Assert.Equal(4998, Program.WithdrawInput(2));
        }


        [Fact]
        public void LittleDeposit()
        {
            Assert.Equal(5002, Program.DepositMoneyInput(2));
        }


        [Fact]
        public void BigWithdraw()
        {
            Assert.Equal(2, Program.WithdrawInput(4998));
        }


        [Fact]
        public void BigDeposit()
        {
            Assert.Equal(5400, Program.DepositMoneyInput(400));
        }

    }
}
