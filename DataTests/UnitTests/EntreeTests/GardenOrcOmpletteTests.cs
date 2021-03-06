﻿/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Unit tests for the Garden Orc Omelette.
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemClass()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goo);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(goo);
        }

        [Fact]
        public void ShouldIncludeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldIncludeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldIncludeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = false;
            Assert.False(goo.Tomato);
            goo.Tomato = true;
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal((uint)404, goo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, true, true, true)]
        [InlineData(true, false, true, true)]
        [InlineData(true, true, false, true)]
        [InlineData(true, true, true, false)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            goo.Mushrooms = includeMushrooms;
            goo.Tomato = includeTomato;
            goo.Cheddar = includeCheddar;
            if (!includeBroccoli) Assert.Contains(" - Hold broccoli", goo.SpecialInstructions);
            else if (!includeMushrooms) Assert.Contains(" - Hold mushrooms", goo.SpecialInstructions);
            else if (!includeTomato) Assert.Contains(" - Hold tomato", goo.SpecialInstructions);
            else if (!includeCheddar) Assert.Contains(" - Hold cheddar", goo.SpecialInstructions);
            else Assert.Empty(goo.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Broccoli", () =>
            {
                goo.Broccoli = true;
            });
            Assert.PropertyChanged(goo, "Broccoli", () =>
            {
                goo.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Mushrooms", () =>
            {
                goo.Mushrooms = true;
            });
            Assert.PropertyChanged(goo, "Mushrooms", () =>
            {
                goo.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Tomato", () =>
            {
                goo.Tomato = true;
            });
            Assert.PropertyChanged(goo, "Tomato", () =>
            {
                goo.Tomato = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Cheddar", () =>
            {
                goo.Cheddar = true;
            });
            Assert.PropertyChanged(goo, "Cheddar", () =>
            {
                goo.Cheddar = false;
            });
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Vegetarian. Two egg omelette packed with a mix " +
                "of broccoli, mushrooms, and tomatoes. Topped with cheddar " +
                "cheese.", goo.Description);
        }
    }
}