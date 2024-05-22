using ChatCorner.API.Dataccess.Entities;
using MongoDB.Driver; 

namespace ChatCorner.API.Dataccess;

public class ChatMessageRepository : IChatMessageRepository
{
    private readonly IMongoDatabase _database;
    private string _collectionName;

    public ChatMessageRepository()
    {
        IMongoClient client = new MongoClient("mongodb://localhost:27017");
        _database = client.GetDatabase("ChatCorner");
        _collectionName = "Lobby";
    }

    public async Task<ChatMessage> GetByIdAsync(string ID)
    {
        var collection = _database.GetCollection<ChatMessage>(_collectionName);
        var messages = await collection.FindAsync(ID);
        var message = messages.FirstOrDefault();
        return message;
    }

    /// <summary>
    /// Cheese
    /// </summary>
    /// <param name="start"></param>
    /// <param name="count">Count set to 0, get all remaining messages</param>
    /// <returns>Collection of messages in specified range</returns>
    public async Task<IEnumerable<ChatMessage>> GetManyAsync(int start, int count)
    {
        var collection = _database.GetCollection<ChatMessage>(_collectionName);
        var messages = await collection
            .Find(_ => true)
            .Skip(start)
            .Limit(count)
            .ToListAsync();
        return messages;
    }

    public async Task AddOneAsync(ChatMessage item)
    {
        var collection = 
            _database.GetCollection<ChatMessage>(
                _collectionName, 
                new MongoCollectionSettings()
                {
                    AssignIdOnInsert = true
                });
        await collection.InsertOneAsync(item);
    }

    public void SetCollectionName(string name)
    {
        _collectionName = name;
    }
}