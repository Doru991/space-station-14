using Robust.Shared.GameStates;

namespace Content.Shared.Weapons.Ranged.Components;

[RegisterComponent, NetworkedComponent]
public sealed partial class GunCleanerComponent : Component
{
    /// <summary>
    /// Speed modifier for how fast the item can clean up a gun.
    /// </summary>
    [DataField]
    public float SpeedModifier = 1f;
}
