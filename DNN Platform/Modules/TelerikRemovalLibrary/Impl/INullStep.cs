﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.Modules.TelerikRemovalLibrary.Impl
{
    /// <summary>
    /// A placeholder step.
    /// </summary>
    internal interface INullStep : IStep
    {
        /// <summary>
        /// Gets or sets the internal step name.
        /// </summary>
        string InternalName { get; set; }
    }
}
