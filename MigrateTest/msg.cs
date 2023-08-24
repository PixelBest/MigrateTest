using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Lims.Models
{
    [Serializable]
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }
    }

    public class Header { }

    public class Body
    {
        [XmlElement(ElementName = "ProccessMessage", Namespace = "http://tempuri.org/")]
        public ProccessMessage ProccessMessage { get; set; }
    }

    [Serializable]
    public class ProccessMessage
    {
        [XmlElement(ElementName = "msg", Namespace = "http://tempuri.org/")]
        public msg msg { get; set; }
    }

    [Serializable]
    public class msg
    {
        [Key]
        public int? Id { get; set; }
        [XmlElement(ElementName = "Descriptions", Namespace = "http://schemas.datacontract.org/2004/07/Dipipe.IF")]
        public string Descriptions { get; set; }
        [XmlElement(ElementName = "DocumentDate", Namespace = "http://schemas.datacontract.org/2004/07/Dipipe.IF")]
        public DateTime DocumentDate { get; set; }
        [XmlArray(ElementName = "DocumentRouteSteps", Namespace = "http://schemas.datacontract.org/2004/07/Dipipe.IF")]
        public List<DocumentRouteStepT> DocumentRouteSteps { get; set; }
        [XmlElement(ElementName = "DstUnitCode", Namespace = "http://schemas.datacontract.org/2004/07/Dipipe.IF")]
        public decimal DstUnitCode { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "http://schemas.datacontract.org/2004/07/Dipipe.IF")]
        public decimal Name { get; set; }
        [XmlElement(ElementName = "No", Namespace = "http://schemas.datacontract.org/2004/07/Dipipe.IF")]
        public decimal No { get; set; }
        [XmlElement(ElementName = "TestOrderGuid", Namespace = "http://schemas.datacontract.org/2004/07/Dipipe.IF")]
        public string TestOrderGuid { get; set; }
        [XmlArray(ElementName = "TestOrderLines", Namespace = "http://schemas.datacontract.org/2004/07/Dipipe.IF")]
        public List<TestOrderLineT> TestOrderLines { get; set; }
        [XmlElement(ElementName = "UnitCode", Namespace = "http://schemas.datacontract.org/2004/07/Dipipe.IF")]
        public decimal UnitCode { get; set; }

        public msg() { }

        public msg(string descriptions, DateTime documentDate, List<DocumentRouteStepT> documentRouteSteps, decimal dstUnitCode, decimal name, decimal no, string testOrderGuid, List<TestOrderLineT> testOrderLines, decimal unitCode)
        {
            Descriptions = descriptions;
            DocumentDate = documentDate;
            DocumentRouteSteps = documentRouteSteps;
            DstUnitCode = dstUnitCode;
            Name = name;
            No = no;
            TestOrderGuid = testOrderGuid;
            TestOrderLines = testOrderLines;
            UnitCode = unitCode;
        }
    }


    [Serializable]
    public class DocumentRouteStepT
    {
        [Key]
        public int Id { get; set; }
        public string DocumentRouteStepGuid { get; set; }
        public string DocumentStatus { get; set; }
        public decimal No { get; set; }
        public decimal OperationCode { get; set; }
        public DateTime OperationDate { get; set; }
        public string UnitCode { get; set; }
        public int msgId { get; set; }

        public DocumentRouteStepT() { }

    }
    [Serializable]
    public class TestOrderLineT
    {
        [Key]
        public int Id { get; set; }
        public decimal MaxValue { get; set; }
        public decimal MinValue { get; set; }
        public string RefGuid { get; set; }
        public string StringValue { get; set; }
        public DateTime TestDate { get; set; }
        public string TestOrderLineGuid { get; set; }
        public string TestResultGuid { get; set; }
        public string TestTypeGuid { get; set; }
        public string TestTypeKindGuid { get; set; }
        public int UnitMeas { get; set; }
        public int msgId { get; set; }
        public List<Desc> Descriptions { get; set; }

        public TestOrderLineT() { }
    }

    [Serializable]
    public class Desc
    {
        [Key]
        public int Id { get; set; }
        public DateTime BeginDate { get; set; }
        public string DescGuid { get; set; }
        public string DescTypeGuid { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MaxValue { get; set; }
        public decimal MinValue { get; set; }
        public string RefGuid { get; set; }
        public string StringValue { get; set; }
        public int UnitMeas { get; set; }
        public int TestOrderLineTId { get; set; }
        public int msgId { get; set; }


        public Desc() { }
    }
}


