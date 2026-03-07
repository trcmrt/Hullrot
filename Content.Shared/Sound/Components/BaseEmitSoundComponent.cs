using Robust.Shared.Audio;

namespace Content.Shared.Sound.Components;
<<<<<<< HEAD

/// <summary>
/// Base sound emitter which defines most of the data fields.
/// Accepts both single sounds and sound collections.
/// </summary>
public abstract partial class BaseEmitSoundComponent : Component
{
    public static readonly AudioParams DefaultParams = AudioParams.Default.WithVolume(-2f);

    [AutoNetworkedField]
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField(required: true)]
    public SoundSpecifier? Sound;

=======

/// <summary>
/// Base sound emitter which defines most of the data fields.
/// Accepts both single sounds and sound collections.
/// </summary>
public abstract partial class BaseEmitSoundComponent : Component
{
    /// <summary>
    /// The <see cref="SoundSpecifier"/> to play.
    /// </summary>
    [DataField(required: true), AutoNetworkedField]
    public SoundSpecifier? Sound;

>>>>>>> upstream/master
    /// <summary>
    /// Play the sound at the position instead of parented to the source entity.
    /// Useful if the entity is deleted after.
    /// </summary>
<<<<<<< HEAD
    [DataField]
=======
    [DataField, AutoNetworkedField]
>>>>>>> upstream/master
    public bool Positional;
}
