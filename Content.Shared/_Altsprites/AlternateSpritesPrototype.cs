using Robust.Shared.Prototypes;
using Content.Shared.DisplacementMap;

namespace Content.Shared._Altsprites;

[Prototype("alternateBaseSprite")]
public sealed partial class HumanoidSpeciesBaseSpritesAlternatePrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    ///     The species' base sprite to replace
    /// </summary>
    [DataField("baseSpriteId", required: true)]
    public string BaseSprite = default!;

    /// <summary>
    ///     The base sprite that should replace the given baseSprite when this
    ///     alternate is selected.
    /// </summary>
    [DataField("alternateSpriteId", required: true)]
    public string AlternateSpriteId = default!;
}

[Prototype("alternateMarkingSprite")]
public sealed partial class HumanoidSpeciesMarkingAlternatePrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    ///     The species' base sprite to replace
    /// </summary>
    [DataField("baseMarkingId", required: true)]
    public required string BaseMarking;

    /// <summary>
    ///     The base sprite that should replace the given baseSprite when this
    ///     alternate is selected.
    /// </summary>
    [DataField("alternateMarkingId", required: true)]
    public required string AlternateMarkingId;
}

/// <summary>
///     Declares a set of sprite layers that should be replaced when a matching
///     alternate specifier is enabled on the entity
/// </summary>
[Prototype("alternateBaseSprites")]
public sealed partial class HumanoidSpeciesBaseSpritesAlternatesPrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    ///     The species that this alternateBaseSprites applies to.
    /// </summary>
    [DataField("speciesId", required: true)]
    public string Species = default!;

    /// <summary>
    ///     These alternateBaseSprites are used when this specifier is active on
    ///     the entity.
    /// </summary>
    [DataField("specifier", required: true)]
    public required string Specifier;

    /// <summary>
    ///     An alternateSpriteDisplacement object that should be set up when
    ///     this alternateBaseSprites object is in use.
    /// </summary>
    [DataField("displacementId")]
    public required string DisplacementId;

    /// <summary>
    ///     A list of alternateBaseSprite objects specifying the layers to
    ///     replace and the sprites to replace them with.
    /// </summary>
    [DataField("alternateLayerSprites")]
    public List<ProtoId<HumanoidSpeciesBaseSpritesAlternatePrototype>> AlternateLayerSprites { get; private set; } = [];

    [DataField("alternateMarkingSprites")]
    public List<ProtoId<HumanoidSpeciesMarkingAlternatePrototype>> AlternateMarkingSprites { get; private set; } = [];
}

/// <summary>
///     Declares a displacement map that should be applied when an 
///     alternateBaseSprite set is matched
/// </summary>
[Prototype("alternateSpriteDisplacement")]
public sealed partial class AlternateSpriteDisplacementPrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; } = default!;

    /// <summary>
    ///     A hash of
    ///     <sex>: <<layer1>: <displacementData>, <layerX>: <displacementData>...>.
    ///     Sex is the entity's sex that this data matches ("default" matches any sex
    ///     not otherwise specified). Each <layer>: <displacementData> pair is a 
    ///     clothing layer that shall be displaced when this displacement is in use.
    /// </summary>
    [DataField]
    public required Dictionary<string, Dictionary<string, DisplacementData>> Displacements = [];
}
