using DBConfirm.Core.Data;
using DBConfirm.Core.DataResults;
using DBConfirm.Core.Parameters;
using DBConfirm.Packages.SQLServer.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Category1
{
    [TestFixture]
    public class ProductModel : NUnitBase
    {
        [Test]
        [Category("Category1")]
        [Property("testKey", "Test-1002")]
        public async Task ProductModelSanityCheck()
        {

            QueryResult data = await TestRunner.ExecuteTableAsync("[SalesLT].[ProductModel]");

            data
                .AssertColumnCount(5)
                .AssertColumnsExist("ProductModelID", "Name", "CatalogDescription", "rowguid", "ModifiedDate");

        }




    }
}