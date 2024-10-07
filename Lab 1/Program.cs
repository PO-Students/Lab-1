using System;

int szerokosc = 40;  // ширина таблицы
int wysokosc = 20;   // высота таблицы

for (int i = 0; i < wysokosc; i++)  // цикл по строкам таблицы
{
    string wiersz = "";  // строка, которая будет построена и напечатана

    for (int j = 0; j < szerokosc; j++)  // цикл по столбцам таблицы
    {
        if (i < wysokosc / 2 && j < szerokosc / 2)  // верхняя левая часть таблицы
        {
            wiersz += ">";  // заполняем символами ">"
        }
        else if (i < wysokosc / 2 && j >= szerokosc / 2)  // верхняя правая часть таблицы
        {
            wiersz += "#";  // заполняем символами "#"
        }
        else if (i >= wysokosc / 2 && j < szerokosc / 2)  // нижняя левая часть таблицы
        {
            wiersz += "#";  // заполняем символами "#"
        }
        else  // нижняя правая часть таблицы
        {
            wiersz += "<";  // заполняем символами "<"
        }
    }
    Console.WriteLine(wiersz);  // выводим строку на экран
}
