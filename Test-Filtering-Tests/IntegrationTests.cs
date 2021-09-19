using System;
using Xunit;
using Test_Filtering_App;


namespace Test_Filtering_Tests
{

    [Trait("Category","Integration")]
    public class IntegrationTests 
    {
        [Fact]
        public void UpdateDatabaseTest()
        {
            //Arrange //Act
            var result = Foo.UpdateDatabase();

            Assert.True(result);
        }

    }
}
