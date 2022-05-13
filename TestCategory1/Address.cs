using DBConfirm.Core.Data;
using DBConfirm.Core.DataResults;
using DBConfirm.Core.Parameters;
using DBConfirm.Packages.SQLServer.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Category1
{
    [TestFixture]
    public class Address : NUnitBase
    {
        [Test]
        [Category("Category1")]
        [Property("testKey", "Test-1001")]
        public async Task AddressSanityCheck()
        {

            QueryResult data = await TestRunner.ExecuteTableAsync("[SalesLT].[Address]");

            data
                .AssertColumnCount(9)
                .AssertColumnsExist("AddressLine1", "AddressLine2", "City", "StateProvince", "CountryRegion", "PostalCode", "rowguid", "ModifiedDate");

        }





    }
}