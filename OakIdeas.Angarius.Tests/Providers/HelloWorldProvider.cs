// -----------------------------------------------------------------------
// <copyright file="HelloWorldProvider.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System.Diagnostics;

namespace OakIdeas.Angarius.Tests.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class HelloWorldProvider : AngariusProviderBase
    {

        public HelloWorldProvider()
        {
            RegisterFunctionalities();
        }

        public override void RegisterFunctionalities()
        {
           this.Functionalities.Add("HelloWorld");
        }

        

        public override dynamic ProcessMessage(Message message)
        {
            //throw new NotImplementedException();

            message.Content = "Hello World";


            Debug.Write("Hello World");

            return message.Content;
        }
    }
}
