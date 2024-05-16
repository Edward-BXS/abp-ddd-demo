using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoApp.Contacts.module.entities;

namespace DemoApp.Contacts.gateway;

public interface IContactGateway
{
    public Task CreateContactAsync(Contact contact);
    
    public Task UpdateContactAsync(Contact contact);

    public Task<List<Contact>> SearchContacts(Guid id, string name);
}