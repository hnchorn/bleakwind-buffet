/*
 * Author: Hannah Chorn
 * Class: ComboTests.cs
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

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldBeAssignableToIOrderItemClass()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
        }

        [Fact]
        public void ChangingContentsNotifiesPriceProperty()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side = new VokunSalad();
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink = new MarkarthMilk();
            });
        }

        [Fact]
        public void ChangingContentsNotifiesCaloriesProperty()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = new VokunSalad();
            });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink = new MarkarthMilk();
            });
        }

        [Fact]
        public void ChangingContentsNotifiesSpecialInstructionsProperty()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Side = new VokunSalad();
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Drink = new MarkarthMilk();
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesEntreeProperty()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = new DoubleDraugr();
            });
        }

        [Fact]
        public void ChangingSideNotifiesSideProperty()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = new VokunSalad();
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesDrinkProperty()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = new MarkarthMilk();
            });
        }

        [Fact]
        public void ShouldReturnCorrectEntree()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.Equal("Briarheart Burger", combo.Entree.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectSide()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.Equal("Small Dragonborn Waffle Fries", combo.Side.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectDrink()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.Equal("Small Warrior Water", combo.Drink.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.Equal(entree.Price + side.Price + drink.Price - 1, combo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.Equal(entree.Calories + side.Calories + drink.Calories, combo.Calories);
        }

        [Fact]
        public void ChangingContentsPriceNotifiesPriceProperty()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side.Size = Size.Medium;
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingContentsSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            BriarheartBurger entree = new BriarheartBurger();
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            Combo combo = new Combo(entree, side, drink);
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Side.Size = Size.Medium;
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Drink.Size = Size.Large;
            });
        }

        [Fact]
        public void MenuReturnsAllSpecialInstructions()
        {
            BriarheartBurger entree = new BriarheartBurger();
            entree.Ketchup = false;
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            WarriorWater drink = new WarriorWater();
            drink.Lemon = true;
            Combo combo = new Combo(entree, side, drink);
            Assert.Contains(combo.SpecialInstructions, (item) => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(combo.SpecialInstructions, (item) => { return item.ToString().Equals(" - Hold ketchup"); });
            Assert.Contains(combo.SpecialInstructions, (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(combo.SpecialInstructions, (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(combo.SpecialInstructions, (item) => { return item.ToString().Equals(" - Add lemon"); });
        }


    }
}
