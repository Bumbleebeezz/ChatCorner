using ChatCorner.API.Dataccess.Entities;
using ChatCorner.CommonInterfaces;
using ChatCorner.DataTransferContract.ChatContracts;

namespace ChatCorner.API.Dataccess;

public interface IChatMessageRepository : IRepository<ChatMessage, string>
{
    void SetCollectionName(string name);
}