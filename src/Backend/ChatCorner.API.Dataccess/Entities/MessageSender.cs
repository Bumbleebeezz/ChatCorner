using ChatCorner.DataTransferContract.ChatContracts;

namespace ChatCorner.API.Dataccess.Entities;

public class MessageSender : IMessageSender
{
    public string SenderName { get; set; }
}