using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace requiredServicesWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string WordFilter(string userInput);

        [OperationContract]
        string getStarted(string url);

        [OperationContract]
        string orderAndTakeTopTen(Dictionary<string, int> difference);

        [OperationContract]
        Dictionary<string, int> addWordsToDictionary();

        [OperationContract]
        Dictionary<string, int> differenceInDictionary(Dictionary<string, int> toDictionary, Dictionary<string, int> englishdictionary);

        [OperationContract]
        Dictionary<string, int> webPageToDictionary(string removeHTMLelements);

        [OperationContract]
        string stripHTML(string webPageAsString);

        [OperationContract]
        string getStringFromURL(string url);
    }
}

