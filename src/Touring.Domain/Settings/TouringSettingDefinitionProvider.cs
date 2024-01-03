using Volo.Abp.Settings;

namespace Touring.Settings;

public class TouringSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TouringSettings.MySetting1));
    }
}
