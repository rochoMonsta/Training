using System.Collections.Generic;

namespace UserMsg_ProgramMsg
{
    class Forbidden
    {
        #region Fields
        private List<string> forbidden_words_list = new List<string>()
        {
            "suck", "dick", "pussy", "nigga", "moron", "fuck", "noob"
        };
        #endregion

        #region Methods
        /// <summary>
        /// Replaces all forbidden words in the text with asterisks
        /// </summary>
        /// <param name="text" text entered by users></param>
        /// <returns></returns>
        public string CheckForForbiddenWord(string text)
        {
            text = text.ToLower();
            foreach (var element in forbidden_words_list)
                if (text.Contains(element))
                    text = text.Replace(element, new string('*', element.Length));
            return text;
        }
        public string CheckForForbiddenWord(Message message)
        {
            if (message.SendBy is User)
            {
                message.Text = message.Text.ToLower();
                foreach (var element in forbidden_words_list)
                    if (message.Text.Contains(element))
                        message.Text = message.Text.Replace(element, new string('*', element.Length));
                return message.Text;
            }
            return message.Text;
        }
        #endregion
    }
}
