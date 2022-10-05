﻿// Двумерный массив: рисунок и его закрашивание

Console.Clear();

int[,] pic = new int[,]                                     // Определяем двумерный массив, но не указывает количество строк и столбцов, тк у нас есть указанный данные далее
{                                                           // проще говоря: картинка и есть наши данные
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0},
    {0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
};

void PrintImage (int [,] image)                             // Метод печати рисунка
{
    for (int i = 0; i < image.GetLength(0); i++)           
    {
        for (int j = 0; j < image.GetLength(1); j++)       
        {
            if (image[i,j] == 0) Console.Write($" ");       // Если значение в массиве равно 0, то на выводе будет пусто, если 1, то будет +
            else Console.Write($"+");          
        }
    Console.WriteLine();                                    
    }
}

void FillImage (int row, int col)                           // Метод закрашивания рисунка 
{                                                           // указываем позицию элемента, с которого мы начинаем закраску (должен находится внутри контура)
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);                // ячейка сверху
        FillImage(row, col - 1);                // ячейка слева
        FillImage(row + 1, col);                // ячейка снизу
        FillImage(row, col + 1);                // ячейка справа
    }
}

PrintImage(pic);
FillImage(6,6);             // Начальная точка находится внутри контура рисунка
PrintImage(pic);