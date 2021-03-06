﻿using ProtoBuf;
using System.ComponentModel;

namespace Sandbox.Common.ObjectBuilders
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_ConveyorPacket : MyObjectBuilder_Base
    {
        [ProtoMember(1)]
        public MyObjectBuilder_InventoryItem Item;

        [ProtoMember(2), DefaultValue(0)]
        public int LinePosition = 0;
        public bool ShouldSerializeLinePosition() { return LinePosition != 0; }
    }
}
