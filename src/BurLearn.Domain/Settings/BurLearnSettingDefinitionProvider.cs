using Volo.Abp.Settings;

namespace BurLearn.Settings;

public class BurLearnSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BurLearnSettings.MySetting1));
    }
}
