namespace Content.Shared._NF.Bank.Components;

/// <summary>
/// This is used for applying a pricing modifier to things like vending machines.
/// It's used to ensure that a purchased product costs more than it is actually worth.
/// </summary>
[RegisterComponent]
public sealed partial class MarketModifierComponent : Component
{
    /// <summary>
    /// The amount to multiply an item's price by
    /// </summary>
    [DataField("mod")] // LoP edit
    public float Mod { get; set; } = new();

    /// <summary>
    /// True if the modifier is for purchase (e.g. on a vendor)
    /// Currently used for examine strings.
    /// </summary>
    [DataField]
    public bool Buy { get; set; } = true;

    // LOP edit start

    [DataField("MinMod")]
    public float MinMod { get; set; } = 1.0f;

    [DataField("MaxMod")]
    public float MaxMod { get; set; } = 1.0f;

    // LOP edit end
}
