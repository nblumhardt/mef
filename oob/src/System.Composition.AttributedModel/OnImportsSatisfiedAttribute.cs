﻿// -----------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------------------

using System;

namespace System.Composition
{
    /// <summary>
    /// When applied to a void, parameterless instance method on a part,
    /// MEF will call that method when composition of the part has
    /// completed. The method must be public or internal.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited=false)]
    public sealed class OnImportsSatisfiedAttribute : Attribute
    {
    }
}
