using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HideFileInMusic
{
    class FileMusicСoncealment
    {
        private static List<byte> music_byte_list;
        private int music_byte_list_len;
        public FileMusicСoncealment(string path)
        {
            music_byte_list = new List<byte>(File.ReadAllBytes(path));
            music_byte_list_len = music_byte_list.Count;
        }
        /// <summary>
        /// 
        /// This method creates a bit representation of the user's sentence;
        /// Then inserts its elements on the corresponding key;
        /// 
        /// </summary>
        /// <param string name="sentences" - the message the user wants to encode;></param>
        /// <returns></returns>
        private byte[] PlaceTheFileInMusic(string sentences)
        {
            byte[] sentences_byte_array = Encoding.UTF8.GetBytes(sentences);
            int sentences_byte_array_len = sentences_byte_array.Length;

            int info_key = music_byte_list_len / sentences_byte_array_len;

            for (int i = 0; i < sentences_byte_array_len; ++i)
                music_byte_list.Insert(i + info_key, sentences_byte_array[i]);
            Console.WriteLine($"Your file has been created successfully.\n\tYour info_key: {info_key}\n\tYour message_lenth: {sentences_byte_array_len}\n");

            sentences_byte_array = music_byte_list.ToArray();
            return sentences_byte_array;
        }
        /// <summary>
        /// 
        /// This method stores the encoded file in mp3 format;
        /// 
        /// </summary>
        /// <param string name="saving_path" - the path where the file will be stored;></param>
        /// <param byte array name="encoded_file" - bit representation of the file;></param>
        /// <param string name="name" - file name;></param>
        private void SaveEncodedFile(string saving_path, byte[] encoded_file, string name)
        {
            string full_path = saving_path + "/" + name + ".mp3";
            using (FileStream fileSaver = File.Create(full_path))
                fileSaver.Write(encoded_file, 0, encoded_file.Length);
            Console.Write($"\nYour file saved successfully by path: {full_path}");
        }
        /// <summary>
        /// 
        /// The method encodes the text in the song and saves the resulting file;
        /// 
        /// </summary>
        /// <param string name="sentences" - the message the user wants to encode;></param>
        /// <param string name="saving_path" - the path where the file will be stored;></param>
        /// <param string name="file_name" - file name;></param>
        public void EncodeTheFileAndSaveIt(string sentences, string saving_path, string file_name)
        {
            Console.Clear();
            var encoded_file = PlaceTheFileInMusic(sentences);
            SaveEncodedFile(saving_path, encoded_file, file_name);
        }
    }
}
