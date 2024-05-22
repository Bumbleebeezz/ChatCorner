using ChatCorner.DataTransferContract.ChatContracts;

namespace ChatCorner.DataTransferContract.DataTransferObjects;

public class MessageSenderDTO : IMessageSender
{
    public string SenderName { get; set; }
}