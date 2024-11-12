using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Cource;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class CourceInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CourceInstallerModule>();
        });
    }
}
