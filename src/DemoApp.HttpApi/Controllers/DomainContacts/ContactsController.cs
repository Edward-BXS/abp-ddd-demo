using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Asp.Versioning;
using DemoApp.Contacts;
using DemoApp.dto;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace DemoApp.Controllers.DomainContacts;

[RemoteService]
[Area("app")]
[ControllerName("Contacts")]
[Route("api/app/contact")]
public class ContactsController
{
    private readonly IContactsApplicationService _contactsAppService;

    public ContactsController(IContactsApplicationService contactsApplicationService)
    {
        _contactsAppService = contactsApplicationService;
    }
    
    [HttpPost]
    public async Task<string> CreateAsync(CreateContactCmd input)
    { 
        await _contactsAppService.CreateContactAsync(input);
        return "success";
    }
    
    [HttpPut("{id}")]
    public async Task<string> UpdateAsync(Guid id, UpdateContactCmd input)
    {
        input.id = id;
        await _contactsAppService.UpdateContactAsync(input);
        return "success";
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(Guid id)
    {
        var deleteContactCmd = new DeleteContactCmd
        {
            Id = id
        }; 
        await _contactsAppService.DeleteContactAsync(deleteContactCmd);
    }

    [HttpGet]
    public async Task<List<ContactDto>> SearchContacts(SearchContactsQry searchContactsQry)
    {
        return await _contactsAppService.SearchContacts(searchContactsQry);
    }
}