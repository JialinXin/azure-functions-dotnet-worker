﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Text.Json.Serialization;

namespace Microsoft.Azure.Functions.Worker
{
    /// <summary>
    /// Web PubSub permissions.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WebPubSubPermission
    {
        /// <summary>
        /// Permission to send messages to a group.
        /// </summary>
        SendToGroup = 1,

        /// <summary>
        /// Permission to join and leave a group.
        /// </summary>
        JoinLeaveGroup = 2
    }
}
