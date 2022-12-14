using ChitChat.Shared;

namespace ChitChat.Client.Manager;

public interface IChatManager
{
    Task<List<ApplicationUser>> GetUsersAsync();
    Task SaveMessageAsync(ChatMessage message);
    Task<List<ChatMessage>> GetConversationAsync(string contactId);
    Task<ApplicationUser> GetUserDetailsAsync(string userId);
}
