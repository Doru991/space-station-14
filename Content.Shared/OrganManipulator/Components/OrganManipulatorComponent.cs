using Robust.Shared.GameStates;

namespace Content.Shared.OrganManipulator.Components;

[RegisterComponent, NetworkedComponent]

public sealed class OrganManipulatorComponent : Component
{
    [DataField("slot")]
    public string SlotName = string.Empty;
}
