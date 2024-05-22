﻿using ChatCorner.CommonInterfaces;
using ChatCorner.DataTransferContract.ChatContracts;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChatCorner.API.Dataccess.Entities;

public class ChatMessage : IChatMessage, IEntity<string>
{
    [BsonRepresentation(BsonType.ObjectId), BsonId]
    public string ID { get; set; }
    public IMessageSender Sender { get; set; }
    public string Message { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}