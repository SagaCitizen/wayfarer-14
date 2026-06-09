namespace Content.Shared.Humanoid;

public sealed partial class HumanoidCharacterAppearance
{
    [DataField]
    public string? SpriteAlternate = null;

    public HumanoidCharacterAppearance WithSpriteAlternate(string newSpriteAlternate)
    {
        return new HumanoidCharacterAppearance(this)
        {
            SpriteAlternate = newSpriteAlternate
        };
    }

    //TODO: How do we modify isValid, the constructors, MemberwiseEquals, and GetHashCode?
}
