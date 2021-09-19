using System;
using Xunit;
using Test_Filtering_App;



namespace Test_Filtering_Tests
{

    [Trait("Category","Unit")]
    public class UnitTests 
    {
        [Fact]
        public void AddIntsTest()
        {
            var result = Foo.AddInts(3,1);
            Assert.Equal(4,result);
        }

        [Fact]
        public void SubtractIntsTest()
        {
            var result = Foo.SubtractInts(1,-3);
            Assert.Equal(4,result);
        }

        [Fact]
        public void SubtractInts2Test()
        {
            var result = Foo.SubtractInts(1,0);
            Assert.Equal(1,result);
        }
    }
}
