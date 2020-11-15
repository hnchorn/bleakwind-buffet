/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using NuGet.Frameworks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Unit tests for the Aretino Apple Juice.
    /// </summary>
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aaj);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemClass()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aaj);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aaj);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.False(aaj.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aaj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Ice = true;
            Assert.True(aaj.Ice);
            aaj.Ice = false;
            Assert.False(aaj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aaj.Size);
            aaj.Size = Size.Large;
            Assert.Equal(Size.Large, aaj.Size);
            aaj.Size = Size.Small;
            Assert.Equal(Size.Small, aaj.Size);
        }


        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Size = size;
            Assert.Equal(price, aaj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Size = size;
            Assert.Equal(cal, aaj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Ice = includeIce;
            if (includeIce) Assert.Contains(" - Add ice", aaj.SpecialInstructions);
            else Assert.Empty(aaj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Size = size;
            Assert.Equal(name, aaj.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.PropertyChanged(aaj, "Size", () =>
            {
                aaj.Size = Size.Small;
            });
            Assert.PropertyChanged(aaj, "Size", () =>
            {
                aaj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aaj, "Size", () =>
            {
                aaj.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.PropertyChanged(aaj, "Price", () =>
            {
                aaj.Size = Size.Small;
            });
            Assert.PropertyChanged(aaj, "Price", () =>
            {
                aaj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aaj, "Price", () =>
            {
                aaj.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.PropertyChanged(aaj, "Calories", () =>
            {
                aaj.Size = Size.Small;
            });
            Assert.PropertyChanged(aaj, "Calories", () =>
            {
                aaj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aaj, "Calories", () =>
            {
                aaj.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.PropertyChanged(aaj, "Ice", () =>
            {
                aaj.Ice = true;
            });
            Assert.PropertyChanged(aaj, "Ice", () =>
            {
                aaj.Ice = false;
            });
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Assert.Equal("Fresh squeezed apple juice.", aaj.Description);
        }
    }
}