namespace ChatCorner.DataTransferContract.ChatContracts;

public interface IChatMessage
{
    IMessageSender Sender { get; set; }
    string Message { get; set; }
    DateTime CreatedAt { get; set; }
}