// -----------------------------------------------------------------------
// <copyright file="IAngarius.cs" company="">
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
    public interface IAngariusProvider
    {
        /// <summary>
        /// The functionality being provided
        /// </summary>
        List<string> Functionalities { get; set; }

        void RegisterFunctionalities();
        dynamic ProcessMessage(Message message);
    }
}
