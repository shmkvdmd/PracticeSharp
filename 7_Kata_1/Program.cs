/*
 Тролли атакуют ваш раздел комментариев!

Распространенный способ справиться с этой ситуацией - удалить все гласные из комментариев троллей, нейтрализовав угрозу.

Ваша задача состоит в том, чтобы написать функцию, которая принимает строку и возвращает новую строку с удаленными всеми гласными.

Например, строка "Этот сайт для неудачников, ЛОЛ!" превратилась бы в "Ths wbst s fr lsrs LL!".

Примечание: в этом ката y не считается гласной.
 */

using System.Text.RegularExpressions;


string Disemvowel(string str)
{
    return Regex.Replace(str, @"[aeiou]", "", RegexOptions.IgnoreCase);
}

string str = "This website is for losers LOL!";
Console.WriteLine(Disemvowel(str));
