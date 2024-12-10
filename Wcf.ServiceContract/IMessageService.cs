using System;
using System.Collections.Generic;
using System.ServiceModel;
using Wcf.Models;

namespace Wcf.ServiceContract
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        List<Invoice> GetInvoices();

        [OperationContract]
        void CreateInvoice(Invoice invoice);

        [OperationContract]
        Invoice GetInvoice(Guid id);

        [OperationContract]
        bool UpdateInvoice(Invoice invoice);

        [OperationContract]
        bool DeleteInvoice(Guid id);
    }
}
