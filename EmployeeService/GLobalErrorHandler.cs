using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    public class GLobalErrorHandler : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            //In this method we write the code to log the actual exception to a database file or xml and so on. 
            //this method gets called asynchronously. 

            //for the purpose of simplicity here we are just returning true. 
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            //Exception logging can also be done here but remember, doing it here will make your client to wait for the logging
            // to be completed before throwing the exception which is not an idle scenario. Logging of exceptions should be avoided here. 
            if (error is FaultException)
            {
                return;
            }
            //Version tells about the message version whether we want SOAP 1.1 or SOAP 1.2
            //the fault parameter is a reference parameter that stores the fault message 
            //which gets returned to the client who called the service
            FaultException faultException = new FaultException("A general service error occured.");
            MessageFault messageFault = faultException.CreateMessageFault();
            fault = Message.CreateMessage(version, messageFault, null);
        }
    }
}
