using System.Collections.Generic;
using Aiirh.Basic.Utilities;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Aiirh.CommonLibraries.Tests;

[TestFixture]
public class DictionaryUtilityTests
{
    [Test]
    [TestCaseSource(nameof(GetTestData))]
    public void GetValueOrAddDefault(ICollection<string> keys, int count)
    {
        var dict = new Dictionary<string, List<int>>();
        for (var i = 0; i < count; i++)
        {
            foreach (var key in keys)
            {
                var list = dict.GetValueOrAddDefault(key, new List<int>());
                list.Add(i);
            }
        }

        ClassicAssert.AreEqual(keys.Count, dict.Count);
        foreach ((string _, List<int> value) in dict)
        {
            ClassicAssert.AreEqual(count, value.Count);
        }
    }

    private static IEnumerable<TestCaseData> GetTestData()
    {
        yield return new TestCaseData(new List<string> { "AAA", "BBB", "CCC" }, 100);
    }
}