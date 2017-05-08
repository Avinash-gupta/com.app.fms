using DataAccessLayer;
using System;
using System.Collections.Generic;
using AutoMapper;
using BusinessEntities;
using DataAccessLayer.Models;

namespace BusinessLogic
{
    public class ClientLogic
    {
        private readonly UnitOfWork _unitOfWork;

        public ClientLogic()
        {
            _unitOfWork = new UnitOfWork();
            Mapper.CreateMap<ClientInformationEntity,ClientInformation>();
            Mapper.CreateMap<ClientInformation, ClientInformationEntity>();
            Mapper.CreateMap<BillingDetailsEntity, BillingDetails>();
            Mapper.CreateMap<BillingDetails, BillingDetailsEntity>();
        }

        public void CreateNewClient(ClientEntity clientEntity)
        {
            try
            {
                var client = Mapper.Map<ClientInformation>(clientEntity.ClientInformation);
                client.IsActive = true;
                var i = _unitOfWork.ClientInformationRepository.GetCount() + 1;
                var clientId = "C" + i;
                client.ClientId = clientId;
                var billing = Mapper.Map<BillingDetails>(clientEntity.BillingDetails);
                if(billing != null)
                {
                    billing.ClientId = clientId;
                    _unitOfWork.BillingDetailsRepository.Insert(billing);
                }
                _unitOfWork.ClientInformationRepository.Insert(client);
                _unitOfWork.Save();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ClientEntity GetClientBy(string clientId)
        {
            try
            {
                var clientInformation = _unitOfWork.ClientInformationRepository.Get(c => c.ClientId == clientId);
                var billingDetails = _unitOfWork.BillingDetailsRepository.Get(b => b.ClientId == clientId);
                return new ClientEntity
                {
                    ClientInformation = new ClientInformationEntity
                    {
                        Id = clientInformation.Id,
                        ClientId = clientInformation.ClientId,
                        Name = clientInformation.Name,
                        ShortName = clientInformation.ShortName,
                        Segment = clientInformation.Segment,
                        ContactPerson = clientInformation.ContactPerson,
                        PersonDesignation = clientInformation.PersonDesignation,
                        PhoneNos = clientInformation.PhoneNos,
                        LandLineNo = clientInformation.LandLineNo,
                        EmailId = clientInformation.EmailId,
                        FaxNo = clientInformation.FaxNo
                    },
                    BillingDetails = new BillingDetailsEntity
                    {
                        Id = (billingDetails == null)? 0: billingDetails.Id,
                        LineOne = billingDetails?.LineOne,
                        LineTwo = billingDetails?.LineTwo,
                        LineThree = billingDetails?.LineThree,
                        LineFour = billingDetails?.LineFour,
                        LineFive = billingDetails?.LineFive,
                        LineSix = billingDetails?.LineSix,
                        Description = billingDetails?.Description,
                        SubUnit = billingDetails?.SubUnit,
                        MainUnit = billingDetails?.MainUnit,
                        Invoice = billingDetails?.Invoice,
                        Paysheet = billingDetails?.PaySheet,
                        Location = billingDetails?.Location
                    }
                };
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        public IList<ClientSearchResults> GetClientSearchResults()
        {
            try
            {
                var clients = _unitOfWork.ClientInformationRepository.GetMany(c => c.IsActive);
                List<ClientSearchResults> clientResults = new List<ClientSearchResults>();
                foreach (var client in clients)
                {
                    clientResults.Add(new ClientSearchResults
                    {
                        Id = client.Id,
                        ClientId = client.ClientId,
                        ClientName = client.Name,
                        PhoneNo = client.PhoneNos,
                        Status = client.IsActive ? "Active" : "Inactive"
                    });
                }
                return clientResults;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateClient(ClientEntity clientEntity)
        {
            try
            {
                var _clientInformation = Mapper.Map<ClientInformation>(clientEntity.ClientInformation);
                var _billingDetails = Mapper.Map<BillingDetails>(clientEntity.BillingDetails);
                _billingDetails.ClientId = _clientInformation.ClientId;
                _clientInformation.IsActive = true;
                _unitOfWork.ClientInformationRepository.Update(_clientInformation);
                if(_billingDetails != null)
                {
                    _billingDetails.ClientId = _clientInformation.ClientId;
                    if(_billingDetails.Id == 0)
                    {
                        _unitOfWork.BillingDetailsRepository.Insert(_billingDetails);
                    }
                    else
                    {
                        _unitOfWork.BillingDetailsRepository.Update(_billingDetails);
                    }
                }
                _unitOfWork.Save();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteClient(string clientId)
        {
            try
            {
                var client = _unitOfWork.ClientInformationRepository.Get(c => c.ClientId == clientId);
                client.IsActive = false;
                _unitOfWork.ClientInformationRepository.Update(client);
                _unitOfWork.Save();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
