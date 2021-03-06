﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Core.Mathematics;

namespace SiliconStudio.Paradox.Rendering.ComputeEffect
{
    public class ComputeShaderBaseKeys
    {   
        public static readonly ParameterKey<Int3> ThreadGroupCountGlobal = ParameterKeys.New<Int3>();
    }
}