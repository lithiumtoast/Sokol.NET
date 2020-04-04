// Copyright (c) Lucas Girouard-Stranks. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

namespace Sokol.Graphics
{
    /// <summary>
    ///     Reflection information about an <see cref="Image" /> that will be as input to the
    ///     <see cref="Shader" /> in the "per-fragment processing" stage. Apart of <see cref="ShaderDescription" />.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <see cref="ShaderImageDescription" /> is blittable to the C `sg_shader_image_desc` struct found in
    ///         `sokol_gfx`.
    ///     </para>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8, CharSet = CharSet.Ansi)]
    public struct ShaderImageDescription
    {
        /// <summary>
        ///     The pointer to a C style string containing the name of the sampler in the "per-fragment processing"
        ///     stage source code. Required for <see cref="GraphicsBackend.OpenGLES2" />. Optional for every other
        ///     <see cref="GraphicsBackend" /> implementation.
        /// </summary>
        [FieldOffset(0)]
        public IntPtr Name;

        /// <summary>
        ///     The <see cref="ImageType" /> of the <see cref="Image" /> that will be as input.
        /// </summary>
        [FieldOffset(8)]
        public ImageType Type;
    }
}
