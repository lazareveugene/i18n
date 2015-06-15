using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using i18n.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace i18n.Domain.Entities.Tests
{
    [TestClass()]
    public class PluralsDictionaryTests
    {
        [TestMethod()]
        public void calcPluralIndexTest()
        {
            var actual = PluralsDictionary.calcPluralIndex("ru", 0);
            Assert.AreEqual(2, actual);
            actual = PluralsDictionary.calcPluralIndex("ru", 1);
            Assert.AreEqual(0, actual);
            actual = PluralsDictionary.calcPluralIndex("ru", 2);
            Assert.AreEqual(1, actual);
            actual = PluralsDictionary.calcPluralIndex("ru", 3);
            Assert.AreEqual(1, actual);
            actual = PluralsDictionary.calcPluralIndex("ru", 5);
            Assert.AreEqual(2, actual);
            actual = PluralsDictionary.calcPluralIndex("ru", 26);
            Assert.AreEqual(2, actual);
            
            actual = PluralsDictionary.calcPluralIndex("en", 1);
            Assert.AreEqual(0, actual);
            actual = PluralsDictionary.calcPluralIndex("en", 26);
            Assert.AreEqual(1, actual);
        }
    }
}
