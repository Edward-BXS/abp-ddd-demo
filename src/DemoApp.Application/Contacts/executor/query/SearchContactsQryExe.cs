using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper.Internal.Mappers;
using DemoApp.Contacts.gateway;
using DemoApp.Contacts.module.entities;
using DemoApp.dto;

namespace DemoApp.Contacts.executor.query;

public class SearchContactsQryExe
{
    private readonly IContactGateway _contactGateway;

    public SearchContactsQryExe(IContactGateway contactGateway)
    {
        _contactGateway = contactGateway;
    }
    
    public async Task<List<ContactDto>> SearchContacts(SearchContactsQry searchContactsQry)
    {
        List<Contact> contacts = await _contactGateway.SearchContacts(searchContactsQry.Id, searchContactsQry.Name);
        return ObjectMapper.Map<List<Contact>, List<ContactDto>>(contacts);
    }
}