using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HideFileInMusic
{
    class FileMusicDecoder
    {
        private List<byte> message_list = new List<byte>();
        public FileMusicDecoder() { }
        /// <summary>
        /// 
        /// This method decodes the file and retrieves the encoded message;
        /// 
        /// </summary>
        /// <param string name="path" - the path to the file where it is stored:></param>
        /// <param int name="message_len" - the length of the sentence encoded in the file;></param>
        /// <param int name="info_key" - a unique key that will be used to decode the file;></param>
        /// <returns></returns>
        public string GetMessageFromFile(string path, int message_len, int info_key)
        {
            byte[] file_byte_array = File.ReadAllBytes(path);

            for (int i = 0; i < message_len; ++i)
                message_list.Add(file_byte_array[i + info_key]);
            file_byte_array = message_list.ToArray();

            return Encoding.UTF8.GetString(file_byte_array);
        }
    }
}
