using ChatCorner.DataTransferContract.DataTransferObjects;

namespace ChatCorner.DataTransferContract.ChatContracts;

public interface IChatMessage
{
    MessageSenderDTO Sender { get; set; }
    string Message { get; set; }
    DateTime CreatedAt { get; set; }
}