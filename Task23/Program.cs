
// уть задачи вот в чем: есть файл в котором записан некоторый текст на английском языке. 
// Требуется вывести в алфавитном порядке все буквы которые встречаются в файле. Каждую букву выводить только один раз.

string path = @"C:\Users\РомаиЛиля\Desktop\C#Task23\Task23\e.txt";
string text = File.ReadAllText(path); // чтение файла

string temp = text.ToLower(); // привожу к нижнему регистру, потому что если будут символы верхнего регистра, то они не будут удалены как дубликаты.
char[] txt = temp.ToArray();
txt = txt.Distinct().ToArray();
Array.Sort(txt);

Console.WriteLine(txt);   
