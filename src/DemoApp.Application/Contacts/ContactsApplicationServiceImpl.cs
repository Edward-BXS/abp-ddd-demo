using System.Collections.Generic;
using System.Threading.Tasks;
using DemoApp.Contacts.executor.command;
using DemoApp.Contacts.executor.query;
using DemoApp.dto;

namespace DemoApp.Contacts;

public class ContactsApplicationServiceImpl : IContactsApplicationService
{
    private readonly CreateContactCmdExe _createContactCmdExe;
    private readonly UpdateContactCmdExe _updateContactCmdExe;
    private readonly DeleteContactCmdExe _deleteContactCmdExe;
    private readonly SearchContactsQryExe _searchContactsQryExe;
        
        
    ContactsApplicationServiceImpl(CreateContactCmdExe createContactCmdExe,
        UpdateContactCmdExe updateContactCmdExe,
        DeleteContactCmdExe deleteContactCmdExe,
        SearchContactsQryExe searchContactsQryExe)
    {
        _createContactCmdExe = createContactCmdExe;
        _updateContactCmdExe = updateContactCmdExe;
        _deleteContactCmdExe = deleteContactCmdExe;
        _searchContactsQryExe = searchContactsQryExe;
    }


    public async Task CreateContactAsync(CreateContactCmd createContactCmd)
    {
        await _createContactCmdExe.CreateContactAsync(createContactCmd);
    }

    public async Task UpdateContactAsync(UpdateContactCmd updateContactCmd)
    {
        await _updateContactCmdExe.UpdateContactAsync(updateContactCmd);
    }

    public async Task DeleteContactAsync(DeleteContactCmd deleteContactCmd)
    {
        throw new System.NotImplementedException();
    }

    public async Task<List<ContactDto>> SearchContacts(SearchContactsQry searchContactsQry)
    {
        await _searchContactsQryExe
    }
}