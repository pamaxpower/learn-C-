﻿/* Алгоритмы в C#. Эффективность алгоритмов. 

- зависимость количества операций от объема данных

y = 1 - константная сложность - независимо от того, какое кол-во данных придет, операция все равно будет выполнена одна.
- сложение, деление, объявление константы, инициализация массива (простая операция)

y = log(n) - логарифмическая сложность
- бинарный поиск - более быстрый поиск (деление на 2)
- ускоряет обычный поиск: например поиск числа из диапазона (0;100). При обычном поиске нужно максимум сделать 100 операция, а при бинарном всего 7

y = n - линейная сложность - чем больше элементов, тем больше операций
- перебор элементов массива, проверить все значения от одного числа до другого

y = n * log(n)
- алгоритм пирамидальной сортировки (сортировка кучкой)
- быстрая сортировка 

y = n^2 - квадратичная сложность
- цикл в цикле
- сортировка выбором

y = 2^n
- разбор множества на подмножества
- поиск дублей, задачки с перебором перебор (распределение игроков по командам)

y = n! - факториальная сложность
- 

Литература:
​ахо хопкрофт ульман структуры данных и алгоритмы pdf
александр шень программирование теоремы и задачи
Алгоритмы на Java | Седжвик Роберт, Джитер Кевин Уэйн

*/

System.Console.WriteLine("Hello world");