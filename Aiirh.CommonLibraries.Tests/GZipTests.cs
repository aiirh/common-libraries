using Aiirh.Basic.Utilities;
using NUnit.Framework;
using System.Collections.Generic;

namespace Aiirh.CommonLibraries.Tests
{
    [TestFixture]
    public class GZipTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        [TestCaseSource(nameof(GetTestCases))]
        public void CompressAndDecompress(string value)
        {
            var bytes = value.ToByteArray();
            var compressed = bytes.GZipCompress();
            var decompressed = compressed.GZipDecompress();
            var result = decompressed.FromByteArray();
            Assert.AreEqual(value, result);
        }

        private static IEnumerable<TestCaseData> GetTestCases()
        {
            yield return new TestCaseData("eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=eyJQZXJzb25hbENvZGUiOiI2MDAwMTAxOTkwNiIsIkZpcnN0TmFtZSI6Ik1hcnkgw4RubiIsIkxhc3ROYW1lIjoiT+KAmWNvbm5lxb4txaB1c2xpayBUZXN0bnVtYmVyIiwiQmlydGhkYXkiOiIyMDAwLTAxLTAxIiwiQ291bnRyeSI6IkVFIn0=");
        }
    }
}