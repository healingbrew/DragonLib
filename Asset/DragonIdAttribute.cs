﻿using System;
using JetBrains.Annotations;

namespace DragonLib.Asset
{
    [PublicAPI]
    public class DragonIdAttribute : Attribute
    {
        public DragonIdAttribute() { }

        public DragonIdAttribute(DragonAssetSectionId id) => Id = id;

        public DragonAssetSectionId Id { get; } = DragonAssetSectionId.Null;
        public override object TypeId => Id;

        public override bool Equals(object? obj) =>
            obj switch
            {
                DragonIdAttribute attr => attr.Id.Equals(Id),
                DragonAssetSectionId id => id.Equals(Id),
                ulong number => number.Equals((ulong) Id),
                _ => base.Equals(obj)
            };

        public override int GetHashCode() => Id.GetHashCode();
        public override bool Match(object? obj) => Equals(obj);
        public override string ToString() => $"[DragonAssetSection {Id:G}]";
        public override bool IsDefaultAttribute() => Id == DragonAssetSectionId.Null;
    }
}
