/*
 * Author: Hannah Chorn
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
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

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Unit tests for the Menu.
    /// </summary>
    public class MenuTests
    {
        [Fact]
        public void MenuReturnsAllEntrees()
        {
            Assert.Contains(Menu.Entrees(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThugsTBone; });
        }

        [Fact]
        public void MenuReturnsAllSides()
        {
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Fried Miraak"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Vokun Salad"); });
        }

        [Fact]
        public void MenuReturnsAllDrinks()
        {
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Warrior Water"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });
        }

        [Fact]
        public void MenuReturnsAllItems()
        {
            Assert.Contains(Menu.FullMenu(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is ThugsTBone; });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Vokun Salad"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });
        }

        [Theory]
        [InlineData("entree")]
        [InlineData("side")]
        [InlineData("drink")]
        public void MenuCanBeFilteredByCategory(string type)
        {
            List<IOrderItem> menu = (List<IOrderItem>)Menu.FullMenu();
            List<string> typeName = new List<string>();
            typeName.Add(type);

            List<IOrderItem> menuUpdate = (List<IOrderItem>)Menu.FilterByCategory(menu, typeName);
            
            if (type == "entree")
            {
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item is BriarheartBurger; });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item is DoubleDraugr; });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item is ThalmorTriple; });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item is GardenOrcOmelette; });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item is PhillyPoacher; });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item is SmokehouseSkeleton; });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item is ThugsTBone; });

                Assert.Equal(7, menuUpdate.Count);
            }
            if(type == "side")
            {
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Fried Miraak"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Fried Miraak"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Vokun Salad"); });

                Assert.Equal(12, menuUpdate.Count);
            }
            if(type == "drink")
            {
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Markarth Milk"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Warrior Water"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Warrior Water"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
                Assert.Contains(Menu.FilterByCategory(menuUpdate, typeName), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });

                Assert.Equal(30, menuUpdate.Count);
            }

        }

        [Theory]
        [InlineData("small")]
        [InlineData("burg")]
        [InlineData("vok")]
        [InlineData("wa")]
        public void MenuCanBeSearched(string search)
        {
            List<IOrderItem> menu = (List<IOrderItem>)Menu.FullMenu();
            List<IOrderItem> menuUpdate = (List<IOrderItem>)Menu.Search(menu, search);
            if (search == "small")
            {
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Fried Miraak"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Vokun Salad"); });

                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Markarth Milk"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
                Assert.Contains(menuUpdate, (item) => { return item.ToString().Equals("Small Warrior Water"); });

                Assert.Equal(14, menuUpdate.Count);
            }
            if(search == "burg")
            {
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Briarheart Burger"); });
                Assert.Single(menuUpdate);
            }
            if (search == "vok")
            {
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Large Vokun Salad"); });
                Assert.Equal(3, menuUpdate.Count);
            }
            if (search == "wa")
            {
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Small Warrior Water"); });
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Large Warrior Water"); });
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
                Assert.Contains(Menu.Search(menuUpdate, search), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });
                Assert.Equal(9, menuUpdate.Count);
            }
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(null, 100)]
        [InlineData(800, null)]
        [InlineData(200, 250)]
        public void MenuCanBeFilteredByCalories(int? caloriesMin, int? caloriesMax)
        {
            List<IOrderItem> menu = (List<IOrderItem>)Menu.FullMenu();
            List<IOrderItem> menuUpdate = (List<IOrderItem>)Menu.FilterByCalories(menu, caloriesMin, caloriesMax);

            if (caloriesMin == null && caloriesMax == null)
            {
                Assert.Equal(49, menuUpdate.Count);
            }
            if(caloriesMin == null && caloriesMax != null)
            {
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Vokun Salad"); });

                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });

                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Markarth Milk"); });

                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Small Warrior Water"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Warrior Water"); });

                Assert.Equal(17, menuUpdate.Count);

            }
            if (caloriesMin != null && caloriesMax == null)
            {
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item is DoubleDraugr; });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item is ThalmorTriple; });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item is ThugsTBone; });

                Assert.Equal(3, menuUpdate.Count);
            }
            if(caloriesMin != null && caloriesMax != null)
            {
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });

                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });
                Assert.Contains(Menu.FilterByCalories(menuUpdate, caloriesMin, caloriesMax), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });

                Assert.Equal(7, menuUpdate.Count);
            }
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(null, 1)]
        [InlineData(7, null)]
        [InlineData(1.50, 2)]
        public void MenuCanBeFilteredByPrice(double? priceMin, double? priceMax)
        {
            List<IOrderItem> menu = (List<IOrderItem>)Menu.FullMenu();
            List<IOrderItem> menuUpdate = (List<IOrderItem>)Menu.FilterByPrice(menu, priceMin, priceMax);
            if (priceMin == null && priceMax == null)
            {
                Assert.Equal(49, menuUpdate.Count);
            }
            if(priceMin == null && priceMax != null)
            {
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Small Vokun Salad"); });

                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });

                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });

                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Small Warrior Water"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Large Warrior Water"); });

                Assert.Equal(10, menuUpdate.Count);
            }
            if (priceMin != null && priceMax == null)
            {
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item is DoubleDraugr; });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item is ThalmorTriple; });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item is PhillyPoacher; });

                Assert.Equal(3, menuUpdate.Count);
            }
            if(priceMin != null && priceMax != null)
            {
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Small Fried Miraak"); });

                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Large Vokun Salad"); });

                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
                Assert.Contains(Menu.FilterByPrice(menuUpdate, priceMin, priceMax), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });

                Assert.Equal(11, menuUpdate.Count);
            }
        }
    }
}
