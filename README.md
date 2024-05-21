# Программа сравнивает один массив с другим, и при совпадении элементов формирует третий массив.

### Функция CreateSourceArray
создаёт и возвращает исходный двумерный массив размером 3x4 со следующими значениями:
```c#
        { "Hello", "2", "world", ":-)" },
        { "1234", "1567", "-2", "computer science" },
        { "Russia", "Denmark", "Kazan", "" }
```    
### Функция CreateArrayForCompare
создаёт и возвращает массив для сравнения размером 3x3 со следующими значениями:

```c#
        {"2", ":-)", ""},
        {"", "-2", ""},
        {"", "", ""}
```
### Функция CreateResultArray
принимает два двумерных массива sourceArray и arrayForCompare, и создаёт новый массив resultArray, в котором содержатся совпадающие элементы из sourceArray, найденные в arrayForCompare.
Если совпадений меньше, чем столбцов в arrayForCompare, оставшиеся ячейки заполняются пустыми строками.

### Функция PrintArray
Эта функция выводит содержимое массива в консоль, в зависимости от аргумента.
