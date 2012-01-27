using System;
using System.Collections.Generic;

namespace Kamilla.Network.Protocols.Wow.Latest.Game
{
    /// <summary>
    /// Most parts of this class are in UpdateFields.Generated.cs
    /// </summary>
    public partial class UpdateFields : SortedDictionary<uint, uint>
    {
        public static UpdateField GetUpdateField(uint index, ObjectTypeId type)
        {
            if (index < (uint)ObjectUpdateFields.End)
                return GetUpdateField((ObjectUpdateFields)index);

            switch (type)
            {
                // Complicated cases
                case ObjectTypeId.Player:
                    if (index < (uint)UnitUpdateFields.End)
                        return GetUpdateField((UnitUpdateFields)index);
                    else
                        return GetUpdateField((PlayerUpdateFields)index);
                case ObjectTypeId.Container:
                    if (index < (uint)ItemUpdateFields.End)
                        return GetUpdateField((ItemUpdateFields)index);
                    else
                        return GetUpdateField((ContainerUpdateFields)index);

                // Simple cases
                case ObjectTypeId.Unit:
                    return GetUpdateField((UnitUpdateFields)index);
                case ObjectTypeId.GameObject:
                    return GetUpdateField((GameObjectUpdateFields)index);
                case ObjectTypeId.DynamicObject:
                    return GetUpdateField((DynamicObjectUpdateFields)index);
                case ObjectTypeId.Corpse:
                    return GetUpdateField((CorpseUpdateFields)index);
                case ObjectTypeId.Item:
                    return GetUpdateField((ItemUpdateFields)index);
                case ObjectTypeId.AreaTrigger:
                    return GetUpdateField((AreaTriggerUpdateFields)index);

                // Must never happen
                default:
                    Console.WriteLine("Error: Called GetUpdateField(index={0}, type={1})", index, type);
                    return GetUpdateField((ObjectUpdateFields)index);
            }
        }

        public static uint GetCount(ObjectTypeId type, uint lastUpdateFieldIndex)
        {
            switch (type)
            {
                case ObjectTypeId.Container:
                    return (uint)ContainerUpdateFields.End;
                case ObjectTypeId.Corpse:
                    return (uint)CorpseUpdateFields.End;
                case ObjectTypeId.DynamicObject:
                    return (uint)DynamicObjectUpdateFields.End;
                case ObjectTypeId.GameObject:
                    return (uint)GameObjectUpdateFields.End;
                case ObjectTypeId.Item:
                    return (uint)ItemUpdateFields.End;
                case ObjectTypeId.Object:
                default:
                    return (uint)ObjectUpdateFields.End;
                case ObjectTypeId.Player:
                    if (lastUpdateFieldIndex > (uint)PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD)
                        return (uint)PlayerUpdateFields.End;
                    else
                        return (uint)PlayerUpdateFields.PLAYER_FIELD_INV_SLOT_HEAD + 1;
                case ObjectTypeId.Unit:
                    return (uint)UnitUpdateFields.End;
            }
        }

    }
}
