using System;
using System.Collections.Generic;

namespace BusinessEntities.Contract
{
    public class ContractEntity
    {
        public ContractInformationEntity ContractInformation { get; set; }
        public ContractBillingEntity ContractBilling { get; set; }
        public ContractPaysheetEntity ContractPaySheet { get; set; }
        public ContractInvoiceheadingtextEntity ContractInvoiceHeadingText { get; set; }
        public List<ContractHumanresourceneedsEntity> ContractHumanResourceNeeds { get; set; }
    }

    public class ContractInformationEntity
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string ContractIds { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int BGAmount { get; set; }
        public string TypeOfWork { get; set; }
        public DateTime ValidityDate { get; set; }
        public string BillingDates { get; set; }
        public string Payment { get; set; }
        public string PaySheetDates { get; set; }
        public string Wages { get; set; }
        public string ContractId { get; set; }
        public bool IsActive { get; set; }
    }

    public class ContractBillingEntity
    {
        public int Id { get; set; }
        public int MaterialCostForMonth { get; set; }
        public int MachineryCostForMonth { get; set; }
        public int ServiceCharge { get; set; }
        public string ContractDescription { get; set; }
        public string ServiceTax { get; set; }
        public string InvoiceDescription { get; set; }
        public bool _75PercentOfSTByClient { get; set; }
        public bool OneSixthReliverCharges { get; set; }
        public bool PDFS { get; set; }
    }

    public class ContractPaysheetEntity
    {
        public int Id { get; set; }
        public int PFPercentage { get; set; }
        public string PFPercentageOf { get; set; }
        public string PFPercentageOn { get; set; }
        public int ESIPercentage { get; set; }
        public string ESIPercentageOf { get; set; }
        public string ESIPercentageOn { get; set; }
        public int PFLimitValue { get; set; }
        public bool PFLimit { get; set; }
        public int ESILimitValue { get; set; }
        public bool ESILimit { get; set; }
        public int OTPercentage { get; set; }
        public string OTAmount { get; set; }
        public bool OJT { get; set; }
        public bool PL { get; set; }
        public int PLValue { get; set; }
        public int OWF { get; set; }
        public int Tds { get; set; }
        public string TDSOn { get; set; }
        public int PONO { get; set; }
        public DateTime ExpectedDateOfReceipt { get; set; }
        public string ESIBranch { get; set; }
    }

    public class ContractInvoiceheadingtextEntity
    {
        public int Id { get; set; }
        public bool DescriptionVisible { get; set; }
        public string DescriptionValue { get; set; }
        public bool NoOfEmpsVisible { get; set; }
        public string NoOfEmpsValue { get; set; }
        public bool NoOfDutiesVisible { get; set; }
        public string NoOfDutiesValue { get; set; }
        public bool PayrateVisible { get; set; }
        public string PayrateValue { get; set; }
        public bool AmountVisible { get; set; }
        public string AmountValue { get; set; }
    }

    public class ContractHumanresourceneedsEntity
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public string Type { get; set; }
        public int DutyHrs { get; set; }
        public int Qty { get; set; }
        public int PR { get; set; }
        public string DT { get; set; }
        public int NoOfDays { get; set; }
        public string Summary { get; set; }
        public string Nots { get; set; }
        public bool RCApplicable { get; set; }
        public int Basic { get; set; }
        public int DA { get; set; }
        public int HRA { get; set; }
    }
}
