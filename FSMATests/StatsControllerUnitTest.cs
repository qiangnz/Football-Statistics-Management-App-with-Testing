﻿using NUnit.Framework;
using FootballStatisticsManagementApp.Controllers;
using FootballStatisticsManagementApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Tests
{
    public class StatsControllerUnitTest
    {
        HSD6503_ProjectSD6503_Project_DBDatabaseFSMDBmdfContext databaseContext;

        [SetUp]
        public void Setup()
        {
            // Creates a new database context in memory for each test, this ensures that nothing is kept
            //  between tests that could interfere with the testing or give incorrent results.
            var options = new DbContextOptionsBuilder<HSD6503_ProjectSD6503_Project_DBDatabaseFSMDBmdfContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;
            databaseContext = new HSD6503_ProjectSD6503_Project_DBDatabaseFSMDBmdfContext(options);
            databaseContext.Database.EnsureCreated();
        }

        [Test]
        public void ValidResponseIndex()
        {
            // Create the Stats controller
            StatsController controller = new StatsController(databaseContext);

            // Call the Index page and wait for a response
            var resultTask = controller.Index();
            resultTask.Wait();
            IActionResult result = resultTask.Result as IActionResult;

            // Check that the controller returned a valid response
            Assert.IsNotNull(result);
        }

        [Test]
        public void ValidResponseDetails()
        {
            // Create the Stats controller
            StatsController controller = new StatsController(databaseContext);

            // Call the Details page and wait for a response
            var resultTask = controller.Details(1);
            resultTask.Wait();
            IActionResult result = resultTask.Result as IActionResult;

            // Check that the controller returned a valid response
            Assert.IsNotNull(result);
        }

        [Test]
        public void ValidResponseCreate()
        {
            // Create the Stats controller
            StatsController controller = new StatsController(databaseContext);

            // Call the Create page
            IActionResult result = controller.Create() as IActionResult;

            // Check that the controller returned a valid response
            Assert.IsNotNull(result);
        }

        [Test]
        public void ValidResponseEdit()
        {
            // Create the Stats controller
            StatsController controller = new StatsController(databaseContext);

            // Call the Edit page and wait for a response
            var resultTask = controller.Edit(1);
            resultTask.Wait();
            IActionResult result = resultTask.Result as IActionResult;

            // Check that the controller returned a valid response
            Assert.IsNotNull(result);
        }

        [Test]
        public void ValidResponseDelete()
        {
            // Create the Stats controller
            StatsController controller = new StatsController(databaseContext);

            // Call the Delete page and wait for a response
            var resultTask = controller.Delete(1);
            resultTask.Wait();
            IActionResult result = resultTask.Result as IActionResult;

            // Check that the controller returned a valid response
            Assert.IsNotNull(result);
        }
    }
}