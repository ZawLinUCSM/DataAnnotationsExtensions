﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAnnotationsExtensions.Tests.ValidationAttributes
{
    [TestClass]
    public class UrlAttributeTests
    {
        [TestMethod]
        public void IsValidTests()
        {
            var attribute = new UrlAttribute();
            
            Assert.IsTrue(attribute.IsValid(null));  // Optional values are always valid
            Assert.IsTrue(attribute.IsValid("http://foo.bar"));
            Assert.IsTrue(attribute.IsValid("https://foo.bar"));
            Assert.IsTrue(attribute.IsValid("ftp://foo.bar"));
            Assert.IsFalse(attribute.IsValid("file:///foo.bar"));
            Assert.IsFalse(attribute.IsValid("http://user%password@foo.bar/"));
            Assert.IsFalse(attribute.IsValid("foo.png"));
        }
    }
}