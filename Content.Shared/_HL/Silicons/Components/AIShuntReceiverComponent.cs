using Robust.Shared.GameStates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Content.Shared._HL.Silicons.Components
{
    [RegisterComponent, NetworkedComponent]
    public sealed partial class AIShuntReceiverComponent : Component
    {
        [ViewVariables]
        [DataField]
        public EntityUid? AssignedGrid = null;
    }
}
