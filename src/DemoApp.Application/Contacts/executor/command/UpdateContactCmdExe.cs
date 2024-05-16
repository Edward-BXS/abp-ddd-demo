using System.Threading.Tasks;
using AutoMapper.Internal.Mappers;
using DemoApp.Contacts.gateway;
using DemoApp.Contacts.module.entities;
using DemoApp.dto;

namespace DemoApp.Contacts.executor.command;

public class UpdateContactCmdExe
{
    private readonly IContactGateway _contactGateway;

    public UpdateContactCmdExe(IContactGateway contactGateway)
    {
        _contactGateway = contactGateway;
    }
    public async Task UpdateContactAsync(UpdateContactCmd updateContactCmd)
    {
        await _contactGateway.UpdateContactAsync(ObjectMapper.Map<UpdateContactCmd, Contact>(updateContactCmd));
    }
}