// -----------------------------------------------------------------------
// <copyright file="AngariusProviderBase.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace OakIdeas.Angarius
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public abstract class AngariusProviderBase : IAngariusProvider
    {

        public List<string> Functionalities
        {
            get; set; }

        public AngariusProviderBase()
        {
            Functionalities = new List<string>();
            
        }

        public abstract void RegisterFunctionalities();
        public abstract dynamic ProcessMessage(Message message);
    }
}
