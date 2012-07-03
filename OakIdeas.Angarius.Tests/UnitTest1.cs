using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OakIdeas.Angarius.Tests.Providers;

namespace OakIdeas.Angarius.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HelloWorldProvider helloWorldProvider = new HelloWorldProvider();

            Angarius.RegisterProvider(helloWorldProvider);


            Message message = new Message();
            message.Functionality = "HelloWorld";
            message.Sender = this;

            Angarius.SendRequest(message);
            
        }
    }
}
