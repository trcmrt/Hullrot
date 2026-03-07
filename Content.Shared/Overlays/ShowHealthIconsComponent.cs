// SPDX-FileCopyrightText: 2024 PrPleGoo <prplegoo@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 gluesniffler <159397573+gluesniffler@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 gluesniffler <linebarrelerenthusiast@gmail.com>
// SPDX-FileCopyrightText: 2024 sleepyyapril <***>
// SPDX-FileCopyrightText: 2025 sleepyyapril <123355664+sleepyyapril@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later AND MIT

using Content.Shared.Damage.Prototypes;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Overlays;

/// <summary>
/// This component allows you to see health status icons above damageable mobs.
/// </summary>
<<<<<<< HEAD
[RegisterComponent, NetworkedComponent]
=======
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(true)]
>>>>>>> upstream/master
public sealed partial class ShowHealthIconsComponent : Component
{
    /// <summary>
    /// Displays health status icons of the damage containers.
    /// </summary>
    [DataField]
    public List<ProtoId<DamageContainerPrototype>> DamageContainers = new()
    {
        "Biological"
    };
}
