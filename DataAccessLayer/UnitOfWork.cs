using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace DataAccessLayer
{
    public class UnitOfWork : IDisposable
    {
        #region Private member variables...
        private FMSGlobalDbContext _context = null;
        private GenericRepository<EmployeeAddressDetails> _EmployeeAddressDetailsRepository;
        private GenericRepository<EmployeeBankDetails> _EmployeeBankDetailsRepository;
        private GenericRepository<EmployeeEducationDetails> _EmployeeEducationDetailsRepository;
        private GenericRepository<EmployeeExService> _EmployeeExServiceRepository;
        private GenericRepository<EmployeeFamilyDetails> _EmployeeFamilyDetailsRepository;
        private GenericRepository<EmployeeInfo> _EmployeeInfoRepository;
        private GenericRepository<EmployeePersonalInfo> _EmployeePersonalInfoRepository;
        private GenericRepository<EmployeePhysicalStandard> _EmployeePhysicalStandardRepository;
        private GenericRepository<EmployeePolicyRecord> _EmployeePolicyRecordRepository;
        private GenericRepository<EmployeePreviousExperience> _EmployeePreviousExperienceRepository;
        private GenericRepository<EmployeeProofs> _EmployeeProofsRepository;
        private GenericRepository<EmployeeSalaryDetails> _EmployeeSalaryDetailsRepository;
        private GenericRepository<ClientInformation> _ClientInformationRepository;
        private GenericRepository<BillingDetails> _BillingDetailsRepository;
        private GenericRepository<ContractBilling> _ContractBillingRepository;
        private GenericRepository<ContractHumanResourceNeeds> _ContractHumanResourceNeedsRepository;
        private GenericRepository<ContractInformation> _ContractInformationRepository;
        private GenericRepository<ContractInvoiceHeadingText> _ContractInvoiceHeadingTextRepository;
        private GenericRepository<ContractPaysheet> _ContractPaysheetRepository;
        private GenericRepository<Designations> _DesignationsRepository;
        private GenericRepository<Attendance> _AttendanceRepository;


        #endregion
        #region Implementing IDiosposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        public UnitOfWork()
        {
            _context = new FMSGlobalDbContext();
        }

        #region Public Repository Creation properties...
        /// <summary>
        /// Get/Set Property for Courses repository.
        /// </summary>
        public GenericRepository<EmployeeAddressDetails> EmployeeAddressDetailsRepository
        {
            get
            {
                if (this._EmployeeAddressDetailsRepository == null)
                    this._EmployeeAddressDetailsRepository = new GenericRepository<EmployeeAddressDetails>(_context);
                return _EmployeeAddressDetailsRepository;
            }
        }

        public GenericRepository<EmployeeBankDetails> EmployeeBankDetailsRepository
        {
            get
            {
                if (this._EmployeeBankDetailsRepository == null)
                    this._EmployeeBankDetailsRepository = new GenericRepository<EmployeeBankDetails>(_context);
                return _EmployeeBankDetailsRepository;
            }
        }

        public GenericRepository<EmployeeEducationDetails> EmployeeEducationDetailsRepository
        {
            get
            {
                if (this._EmployeeEducationDetailsRepository == null)
                    this._EmployeeEducationDetailsRepository = new GenericRepository<EmployeeEducationDetails>(_context);
                return _EmployeeEducationDetailsRepository;
            }
        }

        public GenericRepository<EmployeeExService> EmployeeExServiceRepository
        {
            get
            {
                if (this._EmployeeExServiceRepository == null)
                    this._EmployeeExServiceRepository = new GenericRepository<EmployeeExService>(_context);
                return _EmployeeExServiceRepository;
            }
        }

        public GenericRepository<EmployeeFamilyDetails> EmployeeFamilyDetailsRepository
        {
            get
            {
                if (this._EmployeeFamilyDetailsRepository == null)
                    this._EmployeeFamilyDetailsRepository = new GenericRepository<EmployeeFamilyDetails>(_context);
                return _EmployeeFamilyDetailsRepository;
            }
        }

        public GenericRepository<EmployeeInfo> EmployeeInfoRepository
        {
            get
            {
                if (this._EmployeeInfoRepository == null)
                    this._EmployeeInfoRepository = new GenericRepository<EmployeeInfo>(_context);
                return _EmployeeInfoRepository;
            }
        }

        public GenericRepository<EmployeePersonalInfo> EmployeePersonalInfoRepository
        {
            get
            {
                if (this._EmployeePersonalInfoRepository == null)
                    this._EmployeePersonalInfoRepository = new GenericRepository<EmployeePersonalInfo>(_context);
                return _EmployeePersonalInfoRepository;
            }
        }

        public GenericRepository<EmployeePhysicalStandard> EmployeePhysicalStandardRepository
        {
            get
            {
                if (this._EmployeePhysicalStandardRepository == null)
                    this._EmployeePhysicalStandardRepository = new GenericRepository<EmployeePhysicalStandard>(_context);
                return _EmployeePhysicalStandardRepository;
            }
        }

        public GenericRepository<EmployeePolicyRecord> EmployeePolicyRecordRepository
        {
            get
            {
                if (this._EmployeePolicyRecordRepository == null)
                    this._EmployeePolicyRecordRepository = new GenericRepository<EmployeePolicyRecord>(_context);
                return _EmployeePolicyRecordRepository;
            }
        }

        public GenericRepository<EmployeePreviousExperience> EmployeePreviousExperienceRepository
        {
            get
            {
                if (this._EmployeePreviousExperienceRepository == null)
                    this._EmployeePreviousExperienceRepository = new GenericRepository<EmployeePreviousExperience>(_context);
                return _EmployeePreviousExperienceRepository;
            }
        }

        public GenericRepository<EmployeeProofs> EmployeeProofsRepository
        {
            get
            {
                if (this._EmployeeProofsRepository == null)
                    this._EmployeeProofsRepository = new GenericRepository<EmployeeProofs>(_context);
                return _EmployeeProofsRepository;
            }
        }

        public GenericRepository<EmployeeSalaryDetails> EmployeeSalaryDetailsRepository
        {
            get
            {
                if (this._EmployeeSalaryDetailsRepository == null)
                    this._EmployeeSalaryDetailsRepository = new GenericRepository<EmployeeSalaryDetails>(_context);
                return _EmployeeSalaryDetailsRepository;
            }
        }

        public GenericRepository<ClientInformation> ClientInformationRepository
        {
            get
            {
                if (this._ClientInformationRepository == null)
                    this._ClientInformationRepository = new GenericRepository<ClientInformation>(_context);
                return _ClientInformationRepository;
            }
        }

        public GenericRepository<BillingDetails> BillingDetailsRepository
        {
            get
            {
                if (this._BillingDetailsRepository == null)
                    this._BillingDetailsRepository = new GenericRepository<BillingDetails>(_context);
                return _BillingDetailsRepository;
            }
        }

        public GenericRepository<ContractBilling> ContractBillingRepository
        {
            get
            {
                if (this._ContractBillingRepository == null)
                    this._ContractBillingRepository = new GenericRepository<ContractBilling>(_context);
                return _ContractBillingRepository;
            }
        }

        public GenericRepository<ContractHumanResourceNeeds> ContractHumanResourceNeedsRepository
        {
            get
            {
                if (this._ContractHumanResourceNeedsRepository == null)
                    this._ContractHumanResourceNeedsRepository = new GenericRepository<ContractHumanResourceNeeds>(_context);
                return _ContractHumanResourceNeedsRepository;
            }
        }

        public GenericRepository<ContractInformation> ContractInformationRepository
        {
            get
            {
                if (this._ContractInformationRepository == null)
                    this._ContractInformationRepository = new GenericRepository<ContractInformation>(_context);
                return _ContractInformationRepository;
            }
        }

        public GenericRepository<ContractInvoiceHeadingText> ContractInvoiceHeadingTextRepository
        {
            get
            {
                if (this._ContractInvoiceHeadingTextRepository == null)
                    this._ContractInvoiceHeadingTextRepository = new GenericRepository<ContractInvoiceHeadingText>(_context);
                return _ContractInvoiceHeadingTextRepository;
            }
        }

        public GenericRepository<ContractPaysheet> ContractPaysheetRepository
        {
            get
            {
                if (this._ContractPaysheetRepository == null)
                    this._ContractPaysheetRepository = new GenericRepository<ContractPaysheet>(_context);
                return _ContractPaysheetRepository;
            }
        }

        public GenericRepository<Designations> DesignationsRepository
        {
            get
            {
                if (this._DesignationsRepository == null)
                    this._DesignationsRepository = new GenericRepository<Designations>(_context);
                return _DesignationsRepository;
            }
        }

        public GenericRepository<Attendance> AttendanceRepository
        {
            get
            {
                if (this._AttendanceRepository == null)
                    this._AttendanceRepository = new GenericRepository<Attendance>(_context);
                return _AttendanceRepository;
            }
        }

        #endregion
        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        #region Public member methods...
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format("{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
