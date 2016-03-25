namespace SlackAPI.WebSocketMessages
{
    [SlackSocketRouting("message", "me_message")]
    public class MeMessage : NewMessage
    {
        public MeMessage()
            : base("action")
        {
        }
    }
}