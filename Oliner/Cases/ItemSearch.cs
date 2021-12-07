﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Onliner.Cases
{
    class ItemSearch
    {

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void SeacrhItem()
        {
            Thread.Sleep(2000);
            Actions.FillSerachBar();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }



}

