using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var client = Mapper.Map<ClientInformation>(clientEntity.clientInformation);
                client.IsActive = true;
                client.CreatedDateTime = DateTime.Now;
                client.UpdatedDateTim = DateTime.Now;
                var i = _unitOfWork.ClientInformationRepository.GetCount() + 1;
                var clientId = "C" + i;
                client.ClientId = clientId;
                var billing = Mapper.Map<BillingDetails>(clientEntity.billingDetails);
                billing.ClientId = clientId;
                _unitOfWork.ClientInformationRepository.Insert(client);
                _unitOfWork.BillingDetailsRepository.Insert(billing);
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


                var clientInformation = _unitOfWork.ClientInformationRepository.GetSingle(c => c.ClientId == clientId);
                var billingDetails = _unitOfWork.BillingDetailsRepository.GetSingle(b => b.ClientId == clientId);
                return new ClientEntity
                {
                    clientInformation = new ClientInformationEntity
                    {
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
                    billingDetails = new BillingDetailsEntity
                    {
                        LineOne = billingDetails.LineOne,
                        LineTwo = billingDetails.LineTwo,
                        LineThree = billingDetails.LineThree,
                        LineFour = billingDetails.LineFour,
                        LineFive = billingDetails.LineFive,
                        LineSix = billingDetails.LineSix,
                        Description = billingDetails.Description,
                        SubUnit = billingDetails.SubUnit,
                        MainUnit = billingDetails.MainUnit,
                        Invoice = billingDetails.Invoice,
                        PaySheet = billingDetails.PaySheet,
                        Location = billingDetails.Location
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
                        ClientId = client.ClientId,
                        Name = client.Name,
                        Segment = client.Segment,
                        PhoneNos = client.PhoneNos,
                        EmailId = client.EmailId
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
                int Id = 0;
                var clientInformation = Mapper.Map<ClientInformation>(clientEntity.clientInformation);
                var billingDetails = Mapper.Map<BillingDetails>(clientEntity.billingDetails);
                using (var context = new FMSGlobalDbContext())
                {
                    var clientList = context.ClientInformation.ToList();
                    foreach (var client in clientList)
                    {
                        if (client.ClientId == clientEntity.clientInformation.ClientId)
                        {
                            Id = client.Id;
                            break;
                        }
                    }
                }
                clientInformation.Id = Id;
                clientInformation.UpdatedDateTim = DateTime.Now;
                billingDetails.Id = Id;
                _unitOfWork.ClientInformationRepository.Update(clientInformation);
                _unitOfWork.BillingDetailsRepository.Update(billingDetails);
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
                var client = _unitOfWork.ClientInformationRepository.GetSingle(c => c.ClientId == clientId);
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
