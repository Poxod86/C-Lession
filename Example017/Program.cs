// Дан текст.
// В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".


string text = "Жила-была маленькая девочка. Мать любила ее без памяти, а бабушка еще больше. "
            + "Ко дню рождения внучки подарила ей бабушка красную шапочку. С тех пор девочка всюду в ней"
            + "ходила. Соседи так про нее и говорили:"
            + "– Вот Красная Шапочка идет!"
            + "Как-то раз испекла мама пирожок и сказала дочке:"
            + "– Сходи-ка, Красная Шапочка, к бабушке, снеси ей пирожок и горшочек масла да узнай,"
            + " здорова ли она.";

string Replace(string text, char oldValue, char newValue)
{
   string result = string.Empty;
   int length = text.Length;
   for (int i = 0; i < length; i++)
   {
    if(text[i] == oldValue)
    {
      result = result + $"{newValue}";
    } else
    {
       result = result + $"{text[i]}";
    }
   }
   return result;
}

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);