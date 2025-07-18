namespace PointsBet_Backend_Online_Code_Test
{
    [TestClass]
    public class StringFormatterTests
    {
        [DataTestMethod]
        [DataRow(new[] { "Melbourne" }, "\"", "\"Melbourne\"", DisplayName = "Single item with double quote")]
        [DataRow(new[] { "Melbourne", "Sydney", "Ho Chi Minh" }, "\"", "\"Melbourne\", \"Sydney\", \"Ho Chi Minh\"", DisplayName = "Multiple strings with double quote")]
        [DataRow(new[] { "Melbourne", "Sydney" }, "'", "'Melbourne', 'Sydney'", DisplayName = "Multiple strings with single quote")]
        [DataRow(new[] { "Melbourne", "Sydney" }, "", "Melbourne, Sydney", DisplayName = "Multiple strings with empty quote")]
        [DataRow(new[] { "Melbourne", null, "Ho Chi Minh" }, "\"", "\"Melbourne\", \"\", \"Ho Chi Minh\"", DisplayName = "String with nulls")]
        [DataRow(new[] { "Ho Chi Minh City", "Hanoi", "Da Nang" }, "\"", "\"Ho Chi Minh City\", \"Hanoi\", \"Da Nang\"", DisplayName = "String with special characters")]

        //Valid Inputs
        public void ToCommaSeparatedList_ValidInputs_ReturnsExpectedResult(string[] items, string quote, string expected)
        {
            var result = StringFormatter.ToCommaSeparatedList(items, quote);
            Assert.AreEqual(expected, result);
        }

        //invalid Inputs
        [TestMethod]
        public void ToCommaSeparatedList_NullQuote_ReturnsUnquotedList()
        {
            var items = new[] { "Melbourne", "Sydney" };
            var expected = "Melbourne, Sydney";
            var result = StringFormatter.ToCommaSeparatedList(items, null);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ToCommaSeparatedList_NullItems_ThrowsArgumentNullException()
        {
            StringFormatter.ToCommaSeparatedList(null, "\"");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ToCommaSeparatedList_EmptyItems_ThrowsArgumentException()
        {
            StringFormatter.ToCommaSeparatedList(Array.Empty<string>(), "\"");
        }

        //Extreme Cases to test performance
        [TestMethod]
        public void ToCommaSeparatedList_LargeArray_PerformsWell()
        {
            var items = Enumerable.Range(0, 1000).Select(i => $"City{i}").ToArray();
            var result = StringFormatter.ToCommaSeparatedList(items, "\"");

            Assert.IsTrue(result.StartsWith("\"City0\""));
            Assert.IsTrue(result.EndsWith("\"City999\""));
            Assert.AreEqual(999, result.Count(c => c == ','));
        }

       
    }
}