using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /// <summary>
        /// implementerer metoden fra interface
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string GetSomething (string str)
        {
            return str + " har ben"; //når man kører kan man skrive evt et navn ind i value og teksten bliver eks. tas har ben.
        }

    }
}
