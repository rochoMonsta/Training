namespace UserMsg_ProgramMsg
{
    class Message
    {
        public string Text { get; set; }
        public SendBy SendBy { get; set; }
        public Message(string text, SendBy sendBy)
        {
            this.Text = text;
            this.SendBy = sendBy;
        }
        public Message() { }
    }
}
