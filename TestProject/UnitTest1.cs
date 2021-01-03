using System.IO;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {

        private const string Expected = "Hello Worlds!";
        [Fact]
        public void Test1()
        {

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Sample.Program.Main();

                var result = sw.ToString().Trim();
                Assert.Equal(Expected, result);
            }

        }
    }
}
