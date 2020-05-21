using System;

namespace HideFileInMusic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileMusicСoncealment
            //Console.Write("Enter path to your file: ");
            //string path = Console.ReadLine();

            //FileMusicСoncealment codder = new FileMusicСoncealment(path);

            //Console.Write("Enter sentences: ");
            //string sentences = Console.ReadLine();

            //Console.Write("Enter the path where you want to save the file: ");
            //path = Console.ReadLine();

            //Console.Write("Enter file name: ");
            //string file_name = Console.ReadLine();

            //codder.EncodeTheFileAndSaveIt(sentences, path, file_name);
            #endregion
            #region FileMusicDecoder
            Console.Write("Enter path to your file: ");
            string path = Console.ReadLine();

            Console.Write("Enter your info_key: ");
            int info_key = Int32.Parse(Console.ReadLine());

            Console.Write("Enter your message lenth: ");
            int message_len = Int32.Parse(Console.ReadLine());

            FileMusicDecoder music_decoder = new FileMusicDecoder();
            Console.WriteLine(music_decoder.GetMessageFromFile(path, message_len, info_key));
            #endregion

            Console.ReadLine();
        }
    }
}
