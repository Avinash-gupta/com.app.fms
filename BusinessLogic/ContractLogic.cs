using AutoMapper;
using BusinessEntities.Contract;
using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class ContractLogic
    {
        private readonly UnitOfWork _unitOfWork;

        public ContractLogic()
        {
            _unitOfWork = new UnitOfWork();
            Mapper.CreateMap<ContractInformationEntity, ContractInformation>();
            Mapper.CreateMap<ContractInformation, ContractInformationEntity>();

            Mapper.CreateMap<ContractBillingEntity, ContractBilling>();
            Mapper.CreateMap<ContractBilling, ContractBillingEntity>();

            Mapper.CreateMap<ContractPaysheetEntity, ContractPaysheet>();
            Mapper.CreateMap<ContractPaysheet, ContractPaysheetEntity>();

            Mapper.CreateMap<ContractInvoiceheadingtextEntity, ContractInvoiceHeadingText>();
            Mapper.CreateMap<ContractInvoiceHeadingText, ContractInvoiceheadingtextEntity>();

            Mapper.CreateMap<ContractHumanresourceneedsEntity, ContractHumanResourceNeeds>();
            Mapper.CreateMap<ContractHumanResourceNeeds, ContractHumanresourceneedsEntity>();
        }

        public void CreateContract(ContractEntity contractEntity)
        {
            var _contractHumanResourceNeedsList = new List<ContractHumanResourceNeeds>();
            int Id;
            try
            {
                var contractsForThisClient = _unitOfWork.ContractInformationRepository.GetMany(c => c.ClientId == contractEntity.ContractInformation.ClientId);
                if (contractsForThisClient != null)
                {
                    Id = contractsForThisClient.ToList().Count + 1;
                }
                else
                {
                    Id = 1;
                }
                var contractId = contractEntity.ContractInformation.ClientId + "/" + Id;
                var _contractInformation = Mapper.Map<ContractInformation>(contractEntity.ContractInformation);
                var _contractBilling = Mapper.Map<ContractBilling>(contractEntity.ContractBilling);
                var _contractPaysheet = Mapper.Map<ContractPaysheet>(contractEntity.ContractPaySheet);
                var _contractInvoice = Mapper.Map<ContractInvoiceHeadingText>(contractEntity.ContractInvoiceHeadingText);

                foreach(var humanResourceNeeds in contractEntity.ContractHumanResourceNeeds)
                {
                    if (humanResourceNeeds.MappedEmployees != null)
                    {
                        foreach (var mappedEmployee in humanResourceNeeds.MappedEmployees)
                        {
                            var _employee = _unitOfWork.EmployeePersonalInfoRepository.Get(e => e.EmpId == mappedEmployee.EmpId);
                            _employee.ContractId = contractId;
                            _unitOfWork.EmployeePersonalInfoRepository.Update(_employee);
                        }
                    }
                    var _humanResourceNeeds = Mapper.Map<ContractHumanResourceNeeds>(humanResourceNeeds);
                    _contractHumanResourceNeedsList.Add(_humanResourceNeeds);
                }
                
                _contractInformation.ContractId = contractId;
                _contractInformation.IsActive = true;
                _unitOfWork.ContractInformationRepository.Insert(_contractInformation);
                if (_contractBilling != null)
                {
                    _contractBilling.ContractId = contractId;
                    _unitOfWork.ContractBillingRepository.Insert(_contractBilling);
                }
                if(_contractPaysheet != null)
                {
                    _contractPaysheet.ContractId = contractId;
                    _unitOfWork.ContractPaysheetRepository.Insert(_contractPaysheet);
                }
                if(_contractInvoice != null)
                {
                    _contractInvoice.ContractId = contractId;
                    _unitOfWork.ContractInvoiceHeadingTextRepository.Insert(_contractInvoice);
                }
                foreach(var _humanResourceNeeds in _contractHumanResourceNeedsList)
                {
                    _humanResourceNeeds.ContractId = contractId;
                    _unitOfWork.ContractHumanResourceNeedsRepository.Insert(_humanResourceNeeds);
                }
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ContractEntity GetContractBy(string contractId)
        {
            var contractHumanResourceNeedsList = new List<ContractHumanresourceneedsEntity>();
            try
            {
                var _contractInformation = _unitOfWork.ContractInformationRepository.Get(c => c.ContractId == contractId);
                var _contractBilling = _unitOfWork.ContractBillingRepository.Get(c => c.ContractId == contractId);
                var _contractPaysheet = _unitOfWork.ContractPaysheetRepository.Get(c => c.ContractId == contractId);
                var _contractInvoice = _unitOfWork.ContractInvoiceHeadingTextRepository.Get(c => c.ContractId == contractId);
                var _contractHumanResourceNeeds = _unitOfWork.ContractHumanResourceNeedsRepository.GetMany(c => c.ContractId == contractId);

                var contractInformation = Mapper.Map<ContractInformationEntity>(_contractInformation);
                var contractBilling = Mapper.Map<ContractBillingEntity>(_contractBilling);
                var contractPaysheet = Mapper.Map<ContractPaysheetEntity>(_contractPaysheet);
                var contractInvoice = Mapper.Map<ContractInvoiceheadingtextEntity>(_contractInvoice);
                foreach(var _humanResourceNeeds in _contractHumanResourceNeeds)
                {
                    contractHumanResourceNeedsList.Add(Mapper.Map<ContractHumanresourceneedsEntity>(_humanResourceNeeds));
                }

                return new ContractEntity
                {
                    ContractInformation = contractInformation,
                    ContractBilling = contractBilling,
                    ContractHumanResourceNeeds = contractHumanResourceNeedsList,
                    ContractInvoiceHeadingText = contractInvoice,
                    ContractPaySheet = contractPaysheet
                };
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteContract(string contractId)
        {
            try
            {
                var _contractInforamtion = _unitOfWork.ContractInformationRepository.Get(c => c.ContractId == contractId);
                _contractInforamtion.IsActive = false;
                _unitOfWork.ContractInformationRepository.Update(_contractInforamtion);
                _unitOfWork.Save();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateContract(ContractEntity contractEntity)
        {
            try
            {
                var _contractHumanResourceNeedsList = new List<ContractHumanResourceNeeds>();
                var _contractInformation = Mapper.Map<ContractInformation>(contractEntity.ContractInformation);
                var _contractBilling = Mapper.Map<ContractBilling>(contractEntity.ContractBilling);
                var _contractPaysheet = Mapper.Map<ContractPaysheet>(contractEntity.ContractPaySheet);
                var _contractInvoice = Mapper.Map<ContractInvoiceHeadingText>(contractEntity.ContractInvoiceHeadingText);
                foreach (var humanResourceNeeds in contractEntity.ContractHumanResourceNeeds)
                {
                    var _humanResourceNeeds = Mapper.Map<ContractHumanResourceNeeds>(humanResourceNeeds);
                    _contractHumanResourceNeedsList.Add(_humanResourceNeeds);
                }
                var contractId = contractEntity.ContractInformation.ContractId;
                _unitOfWork.ContractInformationRepository.Update(_contractInformation);
                if (_contractBilling != null)
                {
                    _contractBilling.ContractId = contractId;
                    _unitOfWork.ContractBillingRepository.Update(_contractBilling);
                }
                if (_contractPaysheet != null)
                {
                    _contractPaysheet.ContractId = contractId;
                    _unitOfWork.ContractPaysheetRepository.Update(_contractPaysheet);
                }
                if (_contractInvoice != null)
                {
                    _contractInvoice.ContractId = contractId;
                    _unitOfWork.ContractInvoiceHeadingTextRepository.Update(_contractInvoice);
                }
                foreach (var _humanResourceNeeds in _contractHumanResourceNeedsList)
                {
                    _humanResourceNeeds.ContractId = contractId;
                    if (_humanResourceNeeds.Id == 0)
                    {
                        _unitOfWork.ContractHumanResourceNeedsRepository.Insert(_humanResourceNeeds);
                    }
                    else
                    {
                        _unitOfWork.ContractHumanResourceNeedsRepository.Update(_humanResourceNeeds);
                    }
                }
                _unitOfWork.Save();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<ContractSearchResults> GetAllContracts()
        {
            var contractsList = new List<ContractSearchResults>();
            try
            {
                var _contractsList = _unitOfWork.ContractInformationRepository.GetMany(c => c.IsActive);
                foreach (var _contract in _contractsList)
                {
                    contractsList.Add(new ContractSearchResults
                    {
                        Id = _contract.Id,
                        ClientId = _contract.ClientId,
                        Name = _unitOfWork.ClientInformationRepository.Get(c => c.ClientId == _contract.ClientId).Name,
                        ContractId = _contract.ContractId,
                        ContractStartDate = _contract.StartDate,
                        ContractEndDate = _contract.EndDate

                    });
                }
                return contractsList;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
        
