using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ThatsMandarin
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Probelem 1
           //Almost solved this challenege but I cannot get the occurance of words to print
           //I am only able to get characters to print
           //The problem is this sentence has English and Chinese but how words are made differ
           //Chinese words consist of one or two characters and English words have many characters
           //This is a Chinese sentence which has no spacing between words
            string str = "你好\r\n我叫John，\r\n我是美国人。\r\n我喜欢中国。";                   
            str = Regex.Replace(str, @"[^\w]", string.Empty);
            var result = str.ToArray()
                            .GroupBy(word => word)
                            .Select(grp => new
                            {
                                Word = grp.Key,
                                Count = grp.Count()
                            });

            foreach (var item in result)
            {
                
                Console.WriteLine("Word: {0} Count:{1}", item.Word, item.Count);
            }

            Console.ReadLine();




        }
    }
    
}
