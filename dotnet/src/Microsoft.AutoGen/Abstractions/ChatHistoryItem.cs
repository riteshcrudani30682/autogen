// Copyright (c) Microsoft Corporation. All rights reserved.
// ChatHistoryItem.cs

namespace Microsoft.AutoGen.Abstractions;

[Serializable]
public class ChatHistoryItem
{
    public required string Message { get; set; }
    public ChatUserType UserType { get; set; }
    public int Order { get; set; }
}
