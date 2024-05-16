using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoApp.Contacts;
using DemoApp.dto;

namespace DemoApp;

public interface IContactsApplicationService
{
    public Task CreateContactAsync(CreateContactCmd createContactCmd);

    public Task UpdateContactAsync(UpdateContactCmd updateContactCmd);

    public Task DeleteContactAsync(DeleteContactCmd deleteContactCmd);

    public Task<List<ContactDto>> SearchContacts(SearchContactsQry searchContactsQry);
}