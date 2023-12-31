# Контрольная работа №1. Описание работы программы

## Что делает программа
Программа принимает на вход массив из строк. Результатом программы является новый массив,
состоящий из строк, длина которых меньше или равна 3. (Это значение задано переменной *symbolLimit*, и его
можно поменять в тексте программы. Значение *symbolLimit* задаётся в тексте программы перед описанием методов).

При запуске программа запросит длину массива — количество строк данного массива. Далее программа предложит ввести 
эти строки, разделяя их нажатием **Enter**. После того, как пользователь ввёл последнюю строку, программа выведет
исходный массив и новый массив из строк, длина которых меньше *symbolLimit*.

## Описание методов, используемых в программе
### CreateManualStringArray
Этот метод отвечает за ручное задание массива. Принимает на вход количество элементов массива и создаёт массив из элементов, введённых пользователем построчно.

### PrintArray
Выводит на экран массив, заданный в качестве аргумента. Массив выводится в квадратных скобках. Каждый элемент массива отделяется запятой.

### GetSizeModArr
Возвращает количество элементов в данном массиве, длина которых меньше или равна *symbolLimit*. В качестве аргументов на вход принимает исходный массив и значение *symbolLimit*.

**Работа метода заключена в следующем**: с помощью цикла обходится каждый элемент массива, и если длина этого элемента меньше или равна значению *symbolLimit*, счётчик *size* увеличивается на единицу. По завершению цикла метод возвращает значение *size*.

### CutArray
Возвращает новый массив из элементов массива, заданного в качестве аргумента. 

**Элементы формируются следующим образом:**

1. С помощью цикла обходим каждый элемент нового массива (его длина была вычислена методом *GetSizeModArr*).
2. Для каждого этого элемента с помощью цикла обходим каждый элемент исходного массива *sourceArray*, начиная с позиции *startItem*. 
3. Проверяем этот элемент: его длина должна быть меньше или равна *symbolLimit*. Если условие выполнено, данный элемент исходного массива *sourceArray* становится новым элементом *newArray*, а счётчик *startItem* становится равным индексу проверяемого элемента плюс единица, то есть программа запоминает, с какого элемента в старом массиве нужно продолжить поиск элементов. На этом цикл обхода элементов исходного массива обрывается оператором break, и мы переходим к следующему элементу нового массива *newArray*.
4. Если условие *symbolLimit* не выполнено, то идём к следующему элементу исходного массива *sourceArray*.
5. Когда для последнего элемента нового массива найдётся элемент в исходном массиве, который удовлетворяет условию *symbolLimit*, внешний цикл завершится, и программа вернёт новый массив, состоящий из элементов меньших или равных значению *symbolLimit*



