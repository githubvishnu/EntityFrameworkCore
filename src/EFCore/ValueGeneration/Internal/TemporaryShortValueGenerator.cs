// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Microsoft.EntityFrameworkCore.ValueGeneration.Internal
{
    /// <summary>
    ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public class TemporaryShortValueGenerator : TemporaryNumberValueGenerator<short>
    {
        private int _current = short.MinValue + 100;

        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public override short Next(EntityEntry entry) => (short)Interlocked.Increment(ref _current);
    }
}
