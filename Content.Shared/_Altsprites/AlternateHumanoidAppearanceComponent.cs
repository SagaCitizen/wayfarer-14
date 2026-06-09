namespace Content.Shared.Humanoid;

public sealed partial class HumanoidAppearanceComponent
{
    [DataField, AutoNetworkedField]
    public string? SpriteAlternate = null;
}
