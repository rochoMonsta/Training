using System;

namespace EndWithTest
{
    static class ExpansionMethods
    {
        // Метод розширення для String який виконує перевірку чи закінчується sentences на value
        public static bool EndWith (this String sentences, string value)
        {
            for (int i = value.Length - 1, j = 1; i >= 0; --i, ++j)
                if (sentences[sentences.Length - j] != value[i])
                    return false;
            return true;
        }
        // Метод розширення для String який виконує перевірку чи починається sentences на value
        public static bool StartWith (this String sentences, string value)
        {
            for (int i = 0; i < value.Length; ++i)
                if (sentences[i] != value[i])
                    return false;
            return true;
        }
    }
}
