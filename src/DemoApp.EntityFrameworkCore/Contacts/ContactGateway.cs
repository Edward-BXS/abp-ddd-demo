using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoApp.Contacts.gateway;
using DemoApp.Contacts.module.entities;

namespace DemoApp.Contacts;

public class ContactGateway : IContactGateway
{
    public async Task CreateContactAsync(Contact contact)
    {
        //execute mysql logic
        throw new NotImplementedException();
    }

    public async Task UpdateContactAsync(Contact contact)
    {
        //execute mysql logic
        throw new NotImplementedException();
    }

    public async Task<List<Contact>> SearchContacts(Guid id, string name)
    {
        //execute mysql logic
        
        //convert ContactDo to Contact
        
        throw new NotImplementedException();
    }
}