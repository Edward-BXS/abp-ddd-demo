using Microsoft.AspNetCore.Builder;
using DemoApp;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<DemoAppWebTestModule>();

public partial class Program
{
}
