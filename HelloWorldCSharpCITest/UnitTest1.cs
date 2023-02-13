namespace HelloWorldCSharpCITest
{
    [TestClass]
    public class UnitTest1
    {
        //private const string Expected = "Hello World of C# CI !";
        private const string Expected = "Hello Unexpected World...";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}