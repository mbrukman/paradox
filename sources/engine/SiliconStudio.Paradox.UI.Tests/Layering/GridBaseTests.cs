﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using NUnit.Framework;

using SiliconStudio.Paradox.UI.Panels;

namespace SiliconStudio.Paradox.UI.Tests.Layering
{
    /// <summary>
    /// A class that contains test functions for layering of the <see cref="GridBase"/> class.
    /// </summary>
    [TestFixture]
    [System.ComponentModel.Description("Tests for GridBase layering")]
    public class GridBaseTests : GridBase
    {
        /// <summary>
        /// Test the invalidations generated object property changes.
        /// </summary>
        [Test]
        public void TestBasicInvalidations()
        {
            var grid = new UniformGrid { Rows = 2, Columns = 2, Layers = 2 };
            var child = new UniformGrid();
            grid.Children.Add(child);

            // - test the properties that are not supposed to invalidate the object layout state
            UIElementLayeringTests.TestMeasureInvalidation(grid, () => child.DependencyProperties.Set(ColumnPropertyKey, 2));
            UIElementLayeringTests.TestMeasureInvalidation(grid, () => child.DependencyProperties.Set(RowPropertyKey, 2));
            UIElementLayeringTests.TestMeasureInvalidation(grid, () => child.DependencyProperties.Set(LayerPropertyKey, 2));
            UIElementLayeringTests.TestMeasureInvalidation(grid, () => child.DependencyProperties.Set(ColumnSpanPropertyKey, 2));
            UIElementLayeringTests.TestMeasureInvalidation(grid, () => child.DependencyProperties.Set(RowSpanPropertyKey, 2));
            UIElementLayeringTests.TestMeasureInvalidation(grid, () => child.DependencyProperties.Set(LayerSpanPropertyKey, 2));
        }
    }
}