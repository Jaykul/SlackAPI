namespace SlackAPI.WebSocketMessages
{
    [SlackSocketRouting("message", "channel_topic")]
    public class ChannelTopicMessage : NewMessage
    {
        public ChannelTopicMessage()
            : base("topic")
        {
        }
    }
}