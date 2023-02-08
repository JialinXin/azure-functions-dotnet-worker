﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Functions.Worker
{
    /// <summary>
    /// Operation to remove permission.
    /// </summary>
    public sealed class RevokePermissionAction : WebPubSubAction
    {
        /// <summary>
        /// Targe connectionId.
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// Target permission.
        /// </summary>
        public WebPubSubPermission Permission { get; set; }

        /// <summary>
        /// Target name.
        /// </summary>
        public string TargetName { get; set; }
    }
}
