/*
 * Author: Hannah Chorn
 * Class: OrderTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 */

using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.Intrinsics.X86;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldIncreaseOrderNumber()
        {
            Order tempOrder = new Order();
            Assert.Equal(1, tempOrder.Number);
            Order tempOrder2 = new Order();
            Assert.Equal(2, tempOrder2.Number);
            Order tempOrder3 = new Order();
            Assert.Equal(3, tempOrder3.Number);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void ShouldBeAssignableToObservableCollection()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<ObservableCollection<IOrderItem>>(order);
        }
        
        [Fact]
        public void ShouldReturnCorrectSubtotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            BriarheartBurger bb2 = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            SailorSoda ssoda = new SailorSoda();
            order.Add(bb);
            order.Add(bb2);
            order.Add(vs);
            order.Add(ssoda);
            Assert.Equal(bb.Price + bb2.Price + vs.Price + ssoda.Price, order.Subtotal);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            BriarheartBurger bb2 = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            SailorSoda ssoda = new SailorSoda();
            order.Add(bb);
            order.Add(bb2);
            order.Add(vs);
            order.Add(ssoda);
            Assert.Equal(bb.Calories + bb2.Calories + vs.Calories + ssoda.Calories, order.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSalesTaxRate()
        {
            Order order = new Order();
            Assert.Equal(0.12, order.SalesTaxRate);
        }

        [Fact]
        public void ShouldReturnCorrectOrderTax()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            BriarheartBurger bb2 = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            SailorSoda ssoda = new SailorSoda();
            order.Add(bb);
            order.Add(bb2);
            order.Add(vs);
            order.Add(ssoda);
            Assert.Equal(Math.Round((bb.Price + bb2.Price + vs.Price + ssoda.Price) * 0.12, 2), order.Tax);
        }

        [Fact]
        public void ShouldReturnCorrectTotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            BriarheartBurger bb2 = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            SailorSoda ssoda = new SailorSoda();
            order.Add(bb);
            order.Add(bb2);
            order.Add(vs);
            order.Add(ssoda);
            double subtotal = Math.Round(bb.Price + bb2.Price + vs.Price + ssoda.Price, 2);
            double total = Math.Round((subtotal * 0.12) + subtotal, 2);
            Assert.Equal(total, order.Total);
        }

        [Fact]
        public void ChangingContentsPriceNotifiesAllPriceProperties()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            BriarheartBurger bb2 = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            SailorSoda ssoda = new SailorSoda();
            order.Add(bb);
            order.Add(bb2);
            order.Add(vs);
            order.Add(ssoda);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                vs.Size = Size.Medium;
            });
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                ssoda.Size = Size.Large;
            });
            Assert.PropertyChanged(order, "Tax", () =>
            {
                vs.Size = Size.Medium;
            });
            Assert.PropertyChanged(order, "Tax", () =>
            {
                ssoda.Size = Size.Large;
            });
            Assert.PropertyChanged(order, "Total", () =>
            {
                vs.Size = Size.Medium;
            });
            Assert.PropertyChanged(order, "Total", () =>
            {
                ssoda.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingContentsCaloriesNotifiesCaloriesProperty()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            BriarheartBurger bb2 = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            SailorSoda ssoda = new SailorSoda();
            order.Add(bb);
            order.Add(bb2);
            order.Add(vs);
            order.Add(ssoda);
            Assert.PropertyChanged(order, "Calories", () =>
            {
                vs.Size = Size.Medium;
            });
            Assert.PropertyChanged(order, "Calories", () =>
            {
                ssoda.Size = Size.Large;
            });
        }

        [Fact]
        public void AddingItemToOrderUpdatesProperties()
        {
            Order order = new Order();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            SmokehouseSkeleton ss2 = new SmokehouseSkeleton();
            order.Add(aaj);
            order.Add(ss);
            order.Add(ss2);
            double subtotal = aaj.Price + ss.Price + ss2.Price;
            double tax = Math.Round(subtotal * 0.12, 2);
            double total = Math.Round(tax + subtotal, 2);
            uint calories = aaj.Calories + ss.Calories + ss2.Calories;
            Assert.Equal(subtotal, order.Subtotal);
            Assert.Equal(tax, order.Tax);
            Assert.Equal(total, order.Total);
            Assert.Equal(calories, order.Calories);

            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = Size.Large;
            order.Add(mog);
            double subtotal2 = subtotal + mog.Price;
            double tax2 = Math.Round(subtotal2 * 0.12, 2);
            double total2 = Math.Round(subtotal2 + tax2, 2);
            uint calories2 = calories + mog.Calories;
            Assert.Equal(subtotal2, order.Subtotal);
            Assert.Equal(tax2, order.Tax);
            Assert.Equal(total2, order.Total);
            Assert.Equal(calories2, order.Calories);
        }

        [Fact]
        public void RemovingItemToOrderUpdatesProperties()
        {
            Order order = new Order();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            SmokehouseSkeleton ss2 = new SmokehouseSkeleton();
            order.Add(aaj);
            order.Add(ss);
            order.Add(ss2);
            double subtotal = aaj.Price + ss.Price + ss2.Price;
            double tax = Math.Round(subtotal * 0.12, 2);
            double total = Math.Round(tax + subtotal, 2);
            uint calories = aaj.Calories + ss.Calories + ss2.Calories;
            Assert.Equal(subtotal, order.Subtotal);
            Assert.Equal(tax, order.Tax);
            Assert.Equal(total, order.Total);
            Assert.Equal(calories, order.Calories);

            order.Remove(ss2);
            double subtotal2 = Math.Round(subtotal - ss2.Price, 2);
            double tax2 = Math.Round(subtotal2 * 0.12, 2);
            double total2 = Math.Round(subtotal2 + tax2, 2);
            uint calories2 = calories - ss2.Calories;
            Assert.Equal(subtotal2, order.Subtotal);
            Assert.Equal(tax2, order.Tax);
            Assert.Equal(total2, order.Total);
            Assert.Equal(calories2, order.Calories);
        }

    }
}