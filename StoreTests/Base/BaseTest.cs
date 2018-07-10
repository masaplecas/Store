using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Store;

namespace StoreTests
{
    public class BaseTest
    {
        [SetUp]
        public void StartTests()
        {
            if (!Utility.DriverIsStarted)
            {
                Utility.StartChromeDriver(new Uri("http://store.demoqa.com"));
            }
        }

        [TearDown]
        public void StopTests()
        {
            if (Utility.DriverIsStarted)
            {
                Utility.Quit();
            }
           
        }
    }
}
