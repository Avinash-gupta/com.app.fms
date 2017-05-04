namespace DataAccessLayer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RevertedbackPreviousChange : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.EmployeeAddressDetails");
            DropPrimaryKey("dbo.EmployeeBankDetails");
            DropPrimaryKey("dbo.EmployeeEducationDetails");
            DropPrimaryKey("dbo.EmployeeExService");
            DropPrimaryKey("dbo.EmployeeFamilyDetails");
            DropPrimaryKey("dbo.EmployeeInfo");
            DropPrimaryKey("dbo.EmployeePersonalInfo");
            DropPrimaryKey("dbo.EmployeePhysicalStandard");
            DropPrimaryKey("dbo.EmployeePolicyRecord");
            DropPrimaryKey("dbo.EmployeePreviousExperience");
            DropPrimaryKey("dbo.EmployeeProofs");
            DropPrimaryKey("dbo.EmployeeSalaryDetails");
            AddColumn("dbo.EmployeeAddressDetails", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeeBankDetails", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeeEducationDetails", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeeExService", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeeFamilyDetails", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeeInfo", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeePersonalInfo", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeePhysicalStandard", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeePolicyRecord", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeePreviousExperience", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeeProofs", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.EmployeeSalaryDetails", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeeAddressDetails", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeBankDetails", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeEducationDetails", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeExService", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeFamilyDetails", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeInfo", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeePersonalInfo", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeePhysicalStandard", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeePolicyRecord", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeePreviousExperience", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeProofs", "EmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeSalaryDetails", "EmpId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.EmployeeAddressDetails", "Id");
            AddPrimaryKey("dbo.EmployeeBankDetails", "Id");
            AddPrimaryKey("dbo.EmployeeEducationDetails", "Id");
            AddPrimaryKey("dbo.EmployeeExService", "Id");
            AddPrimaryKey("dbo.EmployeeFamilyDetails", "Id");
            AddPrimaryKey("dbo.EmployeeInfo", "Id");
            AddPrimaryKey("dbo.EmployeePersonalInfo", "Id");
            AddPrimaryKey("dbo.EmployeePhysicalStandard", "Id");
            AddPrimaryKey("dbo.EmployeePolicyRecord", "Id");
            AddPrimaryKey("dbo.EmployeePreviousExperience", "Id");
            AddPrimaryKey("dbo.EmployeeProofs", "Id");
            AddPrimaryKey("dbo.EmployeeSalaryDetails", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.EmployeeSalaryDetails");
            DropPrimaryKey("dbo.EmployeeProofs");
            DropPrimaryKey("dbo.EmployeePreviousExperience");
            DropPrimaryKey("dbo.EmployeePolicyRecord");
            DropPrimaryKey("dbo.EmployeePhysicalStandard");
            DropPrimaryKey("dbo.EmployeePersonalInfo");
            DropPrimaryKey("dbo.EmployeeInfo");
            DropPrimaryKey("dbo.EmployeeFamilyDetails");
            DropPrimaryKey("dbo.EmployeeExService");
            DropPrimaryKey("dbo.EmployeeEducationDetails");
            DropPrimaryKey("dbo.EmployeeBankDetails");
            DropPrimaryKey("dbo.EmployeeAddressDetails");
            AlterColumn("dbo.EmployeeSalaryDetails", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeeProofs", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeePreviousExperience", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeePolicyRecord", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeePhysicalStandard", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeePersonalInfo", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeeInfo", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeeFamilyDetails", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeeExService", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeeEducationDetails", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeeBankDetails", "EmpId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmployeeAddressDetails", "EmpId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.EmployeeSalaryDetails", "Id");
            DropColumn("dbo.EmployeeProofs", "Id");
            DropColumn("dbo.EmployeePreviousExperience", "Id");
            DropColumn("dbo.EmployeePolicyRecord", "Id");
            DropColumn("dbo.EmployeePhysicalStandard", "Id");
            DropColumn("dbo.EmployeePersonalInfo", "Id");
            DropColumn("dbo.EmployeeInfo", "Id");
            DropColumn("dbo.EmployeeFamilyDetails", "Id");
            DropColumn("dbo.EmployeeExService", "Id");
            DropColumn("dbo.EmployeeEducationDetails", "Id");
            DropColumn("dbo.EmployeeBankDetails", "Id");
            DropColumn("dbo.EmployeeAddressDetails", "Id");
            AddPrimaryKey("dbo.EmployeeSalaryDetails", "EmpId");
            AddPrimaryKey("dbo.EmployeeProofs", "EmpId");
            AddPrimaryKey("dbo.EmployeePreviousExperience", "EmpId");
            AddPrimaryKey("dbo.EmployeePolicyRecord", "EmpId");
            AddPrimaryKey("dbo.EmployeePhysicalStandard", "EmpId");
            AddPrimaryKey("dbo.EmployeePersonalInfo", "EmpID");
            AddPrimaryKey("dbo.EmployeeInfo", "EmpId");
            AddPrimaryKey("dbo.EmployeeFamilyDetails", "EmpId");
            AddPrimaryKey("dbo.EmployeeExService", "EmpId");
            AddPrimaryKey("dbo.EmployeeEducationDetails", "EmpId");
            AddPrimaryKey("dbo.EmployeeBankDetails", "EmpId");
            AddPrimaryKey("dbo.EmployeeAddressDetails", "EmpId");
        }
    }
}
