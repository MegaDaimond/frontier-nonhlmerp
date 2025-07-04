using Content.Shared._DV.CCVars;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Configuration;
using Content.Shared._NewParadise; // LOP edit

namespace Content.Client._DV.Options.UI.Tabs;

[GenerateTypedNameReferences]
public sealed partial class DeltaTab : Control
{
    [Dependency] private readonly IConfigurationManager _cfg = default!;

    public DeltaTab()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);

        DisableFiltersCheckBox.OnToggled += OnCheckBoxToggled;
        DisableFiltersCheckBox.Pressed = _cfg.GetCVar(DCCVars.NoVisionFilters);

        // LOP edit START
        ChatIconsEnableCheckBox.OnToggled += OnCheckBoxToggled;
        ChatIconsEnableCheckBox.Pressed = _cfg.GetCVar(NewParadiseCvars.ChatIconsEnable);
        // LOP edit END

        ApplyButton.OnPressed += OnApplyButtonPressed;
        UpdateApplyButton();
    }

    private void OnCheckBoxToggled(BaseButton.ButtonToggledEventArgs args)
    {
        UpdateApplyButton();
    }

    private void OnApplyButtonPressed(BaseButton.ButtonEventArgs args)
    {
        _cfg.SetCVar(DCCVars.NoVisionFilters, DisableFiltersCheckBox.Pressed);
        _cfg.SetCVar(NewParadiseCvars.ChatIconsEnable, ChatIconsEnableCheckBox.Pressed); // LOP edit

        _cfg.SaveToFile();
        UpdateApplyButton();
    }

    private void UpdateApplyButton()
    {
        var isNoVisionFiltersSame = DisableFiltersCheckBox.Pressed == _cfg.GetCVar(DCCVars.NoVisionFilters);
        // LOP edit START
        var isNoVisionJobIconChat = ChatIconsEnableCheckBox.Pressed == _cfg.GetCVar(NewParadiseCvars.ChatIconsEnable);

        ApplyButton.Disabled = isNoVisionFiltersSame && isNoVisionJobIconChat;
        // LOP edit END
    }
}
