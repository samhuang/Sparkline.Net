using NUnit.Framework;
using SparkNet;
using SparkNet.TickProviders;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Spark.TickProvider = new MsGothicTickProvider();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(@"▁▂▄▆█", Spark.Render(new double[] {1, 2, 3, 4, 5}));
            Spark.TickProvider = new VerticalTickProvider();
            Assert.AreEqual(
                @"▏
▎
▍
▌
▋"
                , Spark.Render(new double[] {1, 2, 3, 4, 5}));
        }
    }
}