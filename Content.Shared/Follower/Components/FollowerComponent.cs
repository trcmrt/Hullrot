using Robust.Shared.GameStates;

namespace Content.Shared.Follower.Components;

[RegisterComponent]
[Access(typeof(FollowerSystem))]
<<<<<<< HEAD
[NetworkedComponent, AutoGenerateComponentState(RaiseAfterAutoHandleState = true)]
=======
[NetworkedComponent, AutoGenerateComponentState(raiseAfterAutoHandleState: true)]
>>>>>>> upstream/master
public sealed partial class FollowerComponent : Component
{
    [AutoNetworkedField, DataField("following")]
    public EntityUid Following;
}
