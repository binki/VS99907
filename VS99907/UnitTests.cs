using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VS99907
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void PassingTest()
        {
            // I couldn’t figure out how to repro it without actually loading the
            // library which causes the issue for me. You must install
            // http://www.opclabs.com/products/quickopc/downloads
            // and reference OpcLabs.EasyOpcClassic before running this.
            // You can repro it with the trial version, no need to get a license.
            new OpcLabs.EasyOpc.DataAccess.EasyDAClient();
        }
    }
}
