# Итоговое задание - Блок 1

## Задача.
*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## Пояснение

Код разбит на два блока - основной блок и методы.

**Основной блок:**

* Запрашиваем у пользователя количество элементов массива.
* Вызов метода FillArray-  для заполнения массива с запросом всех элементов массива у пользователя.
* Вызов метода RemoveUnsuitElem - для создания нового массива, который проверяет введенные пользователем элементы массива на соответствие требованию задачи (не более 3х символов в элементе)
* Вывод на экран исходного и конечного массивов.

**Методы:**

1. Метод FillArray 
* На вход принимаем целое число n - количество элементов в массиве.
* Создаем пустой массив, длиной n, который будет содержать заданные пользователем элементы типа string.

* Строка - запрос у пользователя (выводится в консоль)
* Цикл for -ограничиваем кол-во итераций значением n, получаем от пользователя значения элементов и записываем их в созданный массив.
* Возвращаем получившийся массив.


2. Метод RemoveUnsuitElem 
* На вход принимаем массив newArray, полученный методом FillArray, и целое число num - максимальное допустимое количество символов в элементах итогового массива.
* Вводим счетчик count для подсчета кол-ва элементов, удовлетворяющих условию
* Вводим новый массив with_restrictions, куда будут вноситься подходящие элементы.

1- Подсчет и запоминание подходящих элементов

* Цикл for -  количество итераций ограниченно длинной массива newArray;
* В нем - цикл if - проверяем если длинна проверяемого элемента исходного массива меньше трех и вписываем подходящие элементы в новый массив with_restrictions.


2- Записываем и выводим результат.
* Создаем новый массив resultArray длинной count 
* В цикле for - количество итераций ограниченно количеством отобранных элементов (count) 
* Записываем в новый массив resultArray выбранные элементы по индексам, содержащимся в массиве with_restrictions.
* Возвращает полученный итоговый массив.

