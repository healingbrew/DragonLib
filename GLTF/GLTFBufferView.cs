﻿using JetBrains.Annotations;

namespace DragonLib.GLTF
{
    [PublicAPI]
    public class GLTFBufferView : GLTFRootProperty
    {
        public int Buffer { get; set; }
        public uint ByteOffset { get; set; }
        public uint ByteLength { get; set; }
        public uint? ByteStride { get; set; }
        public GLTFBufferViewTarget? Target { get; set; }
    }
}
