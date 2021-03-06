﻿using System.Linq;
using JetBrains.Annotations;

namespace DragonLib.Numerics
{
    [PublicAPI]
    public struct Vector3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vector3(params float[] values)
        {
            X = values.ElementAtOrDefault(0);
            Y = values.ElementAtOrDefault(1);
            Z = values.ElementAtOrDefault(2);
        }

        public System.Numerics.Vector3 ToNumerics() => new System.Numerics.Vector3(X, Y, Z);
        public float[] ToArray() => new[] { X, Y, Z };
    }
}
