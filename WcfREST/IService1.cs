using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract] 
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "Get", //http metode, her bruger vi get
            RequestFormat = WebMessageFormat.Json, //hvilket format vi ønsker at sende ud
            ResponseFormat = WebMessageFormat.Json, //hvilket format vi ønsker at sende ind
            UriTemplate = "/Ben" //eks ligesmo vi gjorde i api/person
        )]

        //metode
        String GetSomething(String str);


        //----NOTER: ANNOTATION----
        //[ServiceContract]
        ////Hele interface

        //[OperationContract]
        ////hver enkelt metode

        //[WebInvoke]
        ////metode
        ////RequestFormat json/xml
        ////ResponseFormat json/xml
        ////UriTemplate
    }


}
