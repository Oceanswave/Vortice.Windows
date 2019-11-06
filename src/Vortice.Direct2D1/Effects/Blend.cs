﻿// Copyright (c) Amer Koleci and contributors.
// Distributed under the MIT license. See the LICENSE file in the project root for more information.

using System;

namespace Vortice.Direct2D1.Effects
{
    using Props = BlendProperties;
    public class Blend : ID2D1Effect
    {
        public Blend(ID2D1DeviceContext deviceContext) : base(IntPtr.Zero)
        {
            deviceContext.CreateEffect(EffectGuids.Blend, this);
        }

        public BlendMode Mode
        {
            set => SetValue((int)Props.Mode, value);
            get => GetEnumValue<BlendMode>((int)Props.Mode);
        }
    }
}