﻿//Требуется написать систему бухгалтерского учета, дабы пс/шериф/цк могли менять должности через консоль

using Robust.Shared.GameStates;

namespace Content.Server._Lua.AutoSalarySystem;

[RegisterComponent]
public sealed partial class SalaryTrackingComponent : Component
{
    [ViewVariables] [DataField]
    public EntityUid Station;
    [ViewVariables] [DataField]
    public string JobId = string.Empty;
}
