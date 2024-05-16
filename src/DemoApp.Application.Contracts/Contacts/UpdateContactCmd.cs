using System;

namespace DemoApp.Contacts;

public class UpdateContactCmd
{
    public Guid id { get; set; }
    
    public string Name { get; set; }
    
    public string Address { get; set; }
}