// Copyright (c) Lucas Girouard-Stranks. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable once CheckNamespace
namespace Sokol
{
    /// <summary>
    ///     Represents associated shaders, vertex-layouts, and render states as a single GPU resource.
    /// </summary>
    /// <remarks>
    ///    <para>
    ///         <see cref="Pipeline" /> is blittable to the C `sg_pipeline` struct found in `sokol_gfx`.
    ///     </para>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct Pipeline
    {
        /// <summary>
        ///     A number which uniquely identifies this <see cref="Pipeline"/>.
        /// </summary>
        [FieldOffset(0)]
        public uint Identifier;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Identifier}";
        }
    }
}
