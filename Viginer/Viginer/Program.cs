/*
* Шифратор, Дешифратор методом Вижинера
*/

using System;

namespace Vigener
{
	class Program
	{
		
		private static string VigenerEncode(string s, string key)
		{
		    s = s.ToUpper();
		    key = key.ToUpper();
		    
		    char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
							 				 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т',
							 				 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                             'Э', 'Ю', 'Я', ' ',
                                             '1', '2', '3', '4', '5', '6', '7','8', '9', '0' };
		 	int N = characters.Length;
		 	
		    string result = "";
		 
		    int key_index = 0;
		 
		    foreach (char symbol in s)
		    {
		        int c = (Array.IndexOf(characters, symbol) +
		            Array.IndexOf(characters, key[key_index])) % N;
		 
		        result += characters[c];
		 
		        key_index++;
	 
	        if ((key_index + 1) == key.Length)
	            key_index = 0;
	   	 	}	
	    
    		return result;
		}
		
		private static string VigenerDecode(string s, string key)
		{
		    s = s.ToUpper();
		    key = key.ToUpper();
		    
		    char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
							 				 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т',
							 				 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                             'Э', 'Ю', 'Я', ' ',
                                             '1', '2', '3', '4', '5', '6', '7','8', '9', '0' };
		 	int N = characters.Length;
		 
		    string result = "";
		 
		    int key_index = 0;
		 
		    foreach (char symbol in s)
		    {
		        int p = (Array.IndexOf(characters, symbol) + N -
		            Array.IndexOf(characters, key[key_index])) % N;
		 
		        result += characters[p];
		 
		        key_index++;
		 
		        if ((key_index + 1) == key.Length)
		            key_index = 0;
		    }
		 
		    return result;
		}
		
		public static void Main(string[] args)
		{	
			
			
			string s="", ss="", key="";
			
			
			Console.WriteLine("Шифрование строки методом Вижинера. (Используется только кириллица)");
			
			Console.Write("Введите строку для шифрования: ");
			s = Console.ReadLine();
			
			Console.Write("Введите ключ: ");
			key = Console.ReadLine();
			
			ss = VigenerEncode(s, key);
			
			Console.WriteLine("======================");
			Console.WriteLine("Исходная строка:      " + s);
			Console.WriteLine("Ключ:                 " + key);
			Console.WriteLine("Зашифрованная строка: " + ss);
			
			s = VigenerDecode(ss, key);
			
			Console.WriteLine("Расашифрованная строка: " + s);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}