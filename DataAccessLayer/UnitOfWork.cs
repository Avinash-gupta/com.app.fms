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
        private GenericRepository<EmployeePersonalInfo> _EmployeePersonalInfoRepository;
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
        public GenericRepository<EmployeePersonalInfo> EmployeePersonalInfoRepository
        {
            get
            {
                if (this._EmployeePersonalInfoRepository == null)
                    this._EmployeePersonalInfoRepository = new GenericRepository<EmployeePersonalInfo>(_context);
                return _EmployeePersonalInfoRepository;
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
