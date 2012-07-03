// -----------------------------------------------------------------------
// <copyright file="Angarius.cs" company="">
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
    public class Angarius
    {
        public static Dictionary<string, IAngariusProvider> RegistredProviders { get; set; }  

        static Angarius()
        {
            RegistredProviders = new Dictionary<string, IAngariusProvider>();
        }

        public static ActionResult RegisterProvider(IAngariusProvider provider)
        {
            StringBuilder stringBuilder = new StringBuilder();
            ActionResult actionResult = new ActionResult();

            foreach (string functionality in provider.Functionalities)
            {
                if (!RegistredProviders.ContainsKey(functionality.ToUpper()))
                {
                    RegistredProviders.Add(functionality.ToUpper(),provider);
                    stringBuilder.AppendLine(String.Format("{0} - Registred", functionality));
                    actionResult.Success = true;
                }
                else
                {
                    stringBuilder.AppendLine(String.Format("{0} - Already Registred", functionality));
                }
            }

            actionResult.Message = stringBuilder.ToString();
            
            return actionResult;
        }

        public static void SendRequest(Message message)
        {
            string functionality = message.Functionality.ToUpper();

            if (RegistredProviders.ContainsKey(functionality))
            {
                IAngariusProvider angariusProvider = RegistredProviders[functionality];
                message.Content = angariusProvider.ProcessMessage(message);
                message.IsReturned = true;
                
                //TODO: Call sender to finalize process;
            }
        }
    }
}
