// -----------------------------------------------------------------------
// <copyright file="Message.cs" company="">
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
    public class Message
    {
        public string Functionality { get; set; }
        public dynamic Sender { get; set; }
        public dynamic Content { get; set; }
        public dynamic SenderCallBack(Func<IAngariusProvider,dynamic> senderMethod)
        {
            return senderMethod(Content);
        }

        private bool _isReturned;

        public bool IsReturned
        {
            get { return _isReturned; }
            set
            {
                if (_isReturned != value)
                {
                    _isReturned = value;
                }

                
            }
        }
    }
}
