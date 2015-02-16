﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace knockknock.readify.net
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://KnockKnock.readify.net", ConfigurationName = "IRedPill")]
    public interface IRedPill
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        System.Guid WhatIsYourToken();

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException), Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeException" +
            "Fault", Name = "ArgumentOutOfRangeException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        long FibonacciNumber(long n);

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        knockknock.readify.net.TriangleType WhatShapeIsThis(int a, int b, int c);

        [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction = "http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException), Action = "http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault", Name = "ArgumentNullException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        string ReverseWords(string s);
    }
}
