using DBConfirm.Core.Data;
using DBConfirm.Core.DataResults;
using DBConfirm.Core.Parameters;
using DBConfirm.Packages.SQLServer.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Category2
{
    [TestFixture]
    public class LastName : NUnitBase
    {
        [Test]
        [Category("Category2")]
        [Property("testKey", "Test-2001")]
        public async Task LastNameSanityCheck()
        {

            QueryResult data = await TestRunner.ExecuteCommandAsync(@"SELECT 'Test-2001' as 'testKey','Category2' as CategoryType, 'Sanity' as TestType, LastName, CASE WHEN LastName like 'Gee' THEN 'PASS' ELSE 'FAIL' END as Result 
                                                                        FROM SalesLT.Customer WHERE CustomerID = 1", new DataSetRow
            { }
            );

            data
                .AssertColumnCount(5)
                .AssertRowCount(1)
                .AssertRowExists(new DataSetRow

                {
                    {"testKey","Test-2001"},
                    {"CategoryType","Category2"},
                    {"TestType","Sanity"},
                    {"LastName","Gee"},
                    {"Result","PASS"}

                }

                );

        }










    }
}