/*
 * Author: Hannah Chorn
 * Class name: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library.
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
    /// Unit tests for the Warrior Water.
    /// </summary>
    public class WarrriorWaterTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemClass()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = false;
            Assert.False(ww.Ice);
            ww.Ice = true;
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(0.00, ww.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal((uint)0, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (!includeIce) Assert.Contains(" - Hold ice", ww.SpecialInstructions);
            else if (includeLemon) Assert.Contains(" - Add lemon", ww.SpecialInstructions);
            else Assert.Empty(ww.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = true;
            });
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = true;
            });
            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = false;
            });
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal("It’s water. Just water.", ww.Description);
        }
    }
}
