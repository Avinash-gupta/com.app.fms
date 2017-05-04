namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedTablesForContracts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContractBilling",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractId = c.String(nullable: false),
                        MaterialCostForMonth = c.Int(nullable: false),
                        MachineryCostForMonth = c.Int(nullable: false),
                        ServiceCharge = c.Int(nullable: false),
                        ContractDescription = c.String(),
                        ServiceTax = c.String(),
                        InvoiceDescription = c.String(),
                        _75PercentOfSTByClient = c.Boolean(nullable: false),
                        OneSixthReliverCharges = c.Boolean(nullable: false),
                        PDFS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContractHumanResourceNeeds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractId = c.String(nullable: false),
                        Designation = c.String(),
                        Type = c.String(),
                        DutyHrs = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                        PR = c.Int(nullable: false),
                        DT = c.String(),
                        NoOfDays = c.Int(nullable: false),
                        Summary = c.String(),
                        Nots = c.String(),
                        RCApplicable = c.Boolean(nullable: false),
                        Basic = c.Int(nullable: false),
                        DA = c.Int(nullable: false),
                        HRA = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContractInformation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractId = c.String(nullable: false),
                        ClientId = c.String(),
                        ContractIds = c.String(),
                        StartDate = c.String(),
                        EndDate = c.String(),
                        BGAmount = c.Int(nullable: false),
                        TypeOfWork = c.String(),
                        ValidityDate = c.String(),
                        BillingDates = c.String(),
                        Payment = c.String(),
                        PaySheetDates = c.String(),
                        Wages = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContractInvoiceHeadingText",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractId = c.String(nullable: false),
                        DescriptionVisible = c.Boolean(nullable: false),
                        DescriptionValue = c.String(),
                        NoOfEmpsVisible = c.Boolean(nullable: false),
                        NoOfEmpsValue = c.String(),
                        NoOfDutiesVisible = c.Boolean(nullable: false),
                        NoOfDutiesValue = c.String(),
                        PayrateVisible = c.Boolean(nullable: false),
                        PayrateValue = c.String(),
                        AmountVisible = c.Boolean(nullable: false),
                        AmountValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContractPaysheet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractId = c.String(nullable: false),
                        PFPercentage = c.Int(nullable: false),
                        PFPercentageOf = c.String(),
                        PFPercentageOn = c.String(),
                        ESIPercentage = c.Int(nullable: false),
                        ESIPercentageOf = c.String(),
                        ESIPercentageOn = c.String(),
                        PFLimitValue = c.Int(nullable: false),
                        PFLimit = c.Boolean(nullable: false),
                        ESILimitValue = c.Int(nullable: false),
                        ESILimit = c.Boolean(nullable: false),
                        OTPercentage = c.Int(nullable: false),
                        OTAmount = c.String(),
                        OJT = c.Boolean(nullable: false),
                        PL = c.Boolean(nullable: false),
                        PLValue = c.Int(nullable: false),
                        OWF = c.Int(nullable: false),
                        Tds = c.Int(nullable: false),
                        TDSOn = c.String(),
                        PONO = c.Int(nullable: false),
                        ExpectedDateOfReceipt = c.String(),
                        ESIBranch = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContractPaysheet");
            DropTable("dbo.ContractInvoiceHeadingText");
            DropTable("dbo.ContractInformation");
            DropTable("dbo.ContractHumanResourceNeeds");
            DropTable("dbo.ContractBilling");
        }
    }
}
