﻿// Copyright (c) IEvangelist. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Microsoft.Azure.CosmosRepository.Pagination
{
    /// <inheritdoc />
    public class PagedResult<T> : ListResult<T>
    {
        /// <inheritdoc />
        public long TotalCount { get; internal set; }

        /// <summary>
        /// Creates a new <see cref="PagedResult{T}"/> object.
        /// </summary>
        public PagedResult() { }

        /// <summary>
        /// Creates a new <see cref="PagedResult{T}"/> object.
        /// </summary>
        /// <param name="totalCount">Total count of Items</param>
        /// <param name="items">List of items in current page</param>
        public PagedResult(long totalCount, IReadOnlyList<T> items)
            : base(items) =>
            TotalCount = totalCount;
    }
}
