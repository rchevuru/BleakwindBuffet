/*
 * Author: Zachery Brunner
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 */
using Xunit;

using System;
using System.ComponentModel;
using System.Collections.Generic;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAbleToSetDisplayDate()
        {
            var order = new Order(1);
            string expected = string.Format("{0}", DateTime.Now);

            Assert.Equal(expected, order.DisplayDate);
        }

        [Fact]
        public void SettingDisplayDateShouldNotifyDisplayDatePropertyChanged()
        {
            var order = new Order(1);
            string expected = string.Format("{0}", DateTime.Now);

            Assert.PropertyChanged(order, "DisplayDate", () =>
            {
                order.DisplayDate = expected;
            });
        }

        [Fact]
        public void SettingOrderNumberShouldNotifyOrderNumber()
        {
            uint orderNumberSet = 2;
            var order = new Order(1);
            Assert.PropertyChanged(order, "OrderNumber", () =>
            {
                order.OrderNumber = orderNumberSet;
            });

            Assert.Equal(orderNumberSet, order.OrderNumber);
        }

        [Fact]
        public void SettingSubTotalShouldNotifySubTotal()
        {
            var order = new Order(1);
            Assert.PropertyChanged(order, "SubTotal", () =>
            {
                order.SubTotal = 1;
            });
        }

        [Fact]
        public void SettingSubTotalShouldNotifyTax()
        {
            var order = new Order(1);
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.SubTotal = 1;
            });
        }

        [Fact]
        public void SettingSubTotalShouldNotifyTotal()
        {
            var order = new Order(1);
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.SubTotal = 1;
            });
        }

        [Fact]
        public void ShouldBeAbleToAddItemsToOrder()
        {
            var BB = new BriarheartBurger();
            double taxRate = 0.0895;
            double expectedTax = Math.Round((BB.Price * taxRate), 2);
            double expectedTotal = BB.Price + expectedTax;

            var order = new Order(1);
            order.AddItem = BB;

            Assert.Equal(BB.Price, order.SubTotal);
            Assert.Equal(expectedTax, order.Tax);
            Assert.Equal(expectedTotal, order.Total);
        }

        [Fact]
        public void AddingItemsNotifiesItemsProperty()
        {
            var order = new Order(1);
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(order, "Items", () =>
            {
                order.AddItem = BB;
            });
        }

        [Fact]
        public void ShouldBeAbleToRemoveItemsFromOrder()
        {
            var BB = new BriarheartBurger();

            var order = new Order(1);
            order.AddItem = BB;
            order.RemoveItem = BB;

            Assert.Equal(0, order.SubTotal);
            Assert.Equal(0, order.Tax);
            Assert.Equal(0, order.Total);
        }

        [Fact]
        public void RemovingItemsNotifiesItemsProperty()
        {
            var order = new Order(1);
            var BB = new BriarheartBurger();
            order.AddItem = BB;

            Assert.PropertyChanged(order, "Items", () =>
            {
                order.RemoveItem = BB;
            });
        }
    }
}