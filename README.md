# Создание и вывод нового массива
*Данная программа позволяет принимать на вход одномерный массив из строковых значенй и из строк длинной до 4х символов формирует и выводит в консоль новый массив.*

    Примеры:
    Hello, 2, world, :-) → [“2”, “:-)”]
    1234, 1567, -2, computer science” → [“-2”]
    Russia, Denmark, Kazan” → []

## Инструкция по работе с программой

1. Запуск программы осуществляется вводом команды.

        dotnet run
2. Далее следуя инструкциям в консоли необходимо в одну строку ввести элементы массива с типом string (строка), разделителем для значений должны являться запятая и пробел (", ").

        Например:
        1, hgjgf, 523, 456v, 5454, 1, sefs4ef35, 0

3. Программа следующей строкой выведет массив из заданных значений.

        Ваш массив имеет вид: [1; hgjgf; 523; 456v; 5454; 1; sefs4ef35; 0]

4. В последней строке будет отображен новый полученный массив. Массив будет содержать лишь строки, которые соответствуют условию (длина строки должна быть меньше 4х символов). 


        Новый массив -> [1; 523; 10]

Если ни одно из значений не выполняет условие, то будет выведен пустой массив.

        Новый массив -> []

__Для досрочного выхода из программы для Windows необходимо нажать сочетание клавиш "CTRL + C".__

Ниже приведен скриншот примера работы программы:

![Пример работы программы](Primer.png)
...

Глебова Яна - студент Geekbrains