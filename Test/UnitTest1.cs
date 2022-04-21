using Frogmi.dataset;
using Frogmi.models;
using NUnit.Framework;
using System;

namespace Test
{
    public class Tests
    {
        private Store testStore;
        [SetUp]
        public void Setup()
        {
            testStore = new Store
            {
                Incidents = ExampleData.TestIncidents,
            };
        }

        [Test]
        public void NoIncidentsTest()
        {
            StoreResponse expected = new StoreResponse
            {
                OpenCases = 0,
                SolvedCases = 0,
                AvgSolveTime = 0,
                MaximumSolution = 0
            };

            StoreResponse actual = testStore.IncidentStatus(DateTime.Now.Date, DateTime.Now.Date);

            Assert.IsTrue(actual.Equals(expected));
        }

        [Test]
        public void ThreeIncidentsTest()
        {
            StoreResponse expected = new StoreResponse
            {
                OpenCases = 1,
                SolvedCases = 2,
                AvgSolveTime = 0,
                MaximumSolution = 0
            };

            StoreResponse actual = testStore.IncidentStatus(DateTime.Now.Date, DateTime.Now.Date);

            Assert.IsTrue(actual.Equals(expected));
        }

        [Test]
        public void AvgIsFiveTest()
        {
            StoreResponse expected = new StoreResponse
            {
                OpenCases = 1,
                SolvedCases = 3,
                AvgSolveTime = 5,
                MaximumSolution = 5
            };

            StoreResponse actual = testStore.IncidentStatus(new DateTime(2022, 02, 20), new DateTime(2022, 02, 26));

            Assert.IsTrue(actual.Equals(expected));
        }

        [Test]
        public void AllFieldsTest()
        {
            StoreResponse expected = new StoreResponse
            {
                OpenCases = 3,
                SolvedCases = 6,
                AvgSolveTime = 2,
                MaximumSolution = 5
            };

            StoreResponse actual = testStore.IncidentStatus(new DateTime(2022, 02, 01), new DateTime(2022, 04, 30));

            Assert.IsTrue(actual.Equals(expected));
        }
    }
}