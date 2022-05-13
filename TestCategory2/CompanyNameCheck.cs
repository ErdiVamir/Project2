using DBConfirm.Core.Data;
using DBConfirm.Core.DataResults;
using DBConfirm.Core.Parameters;
using DBConfirm.Packages.SQLServer.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Category2
{
    [TestFixture]
    public class CompanyName : NUnitBase
    {
      



        [Test]
        [Category("Category2")]
        [Property("testKey", "Test-2002")]
        public async Task CompanyNameSanityCheck()
        {

            QueryResult data = await TestRunner.ExecuteCommandAsync(@"SELECT 'Test-2002' as 'testKey','Category2' as CategoryType, 'Sanity' as TestType, CompanyName, CASE WHEN CompanyName like 'Progressive SportsTestTestTest' THEN 'PASS' ELSE 'FAIL' END as Result 
                                                                        FROM SalesLT.Customer WHERE CustomerID = 2", new DataSetRow
            { }
            );

            data
                .AssertColumnCount(5)
                .AssertRowCount(1)
                .AssertRowExists(new DataSetRow

                {
                    {"testKey","Test-2002"},
                    {"CategoryType","Category2"},
                    {"TestType","Sanity"},
                    {"CompanyName","Progressive Sports"},
                    {"Result","PASS"}

                }

                );

        }






    }
}