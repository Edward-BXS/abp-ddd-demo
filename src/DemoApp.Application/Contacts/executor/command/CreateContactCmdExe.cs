using System.Threading.Tasks;
using AutoMapper.Internal.Mappers;
using DemoApp.Contacts.gateway;
using DemoApp.Contacts.module.entities;
using DemoApp.dto;

namespace DemoApp.Contacts.executor.command;

public class CreateContactCmdExe
{
    private readonly IContactGateway _contactGateway;
    public async Task CreateContactAsync(CreateContactCmd createContactCmd)
    {
        //some parameter validation logic
        
        //some scheduling logic, including cross entity scenarios
        
        //execute at the persistence layer
        await _contactGateway.CreateContactAsync(ObjectMapper.Map<CreateContactCmd, Contact>(createContactCmd));
    }
}