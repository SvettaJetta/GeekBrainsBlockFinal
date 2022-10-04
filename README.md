# GeekBrainsBlockFinal


## Step 1

Инициализируем переменные

`string[] my_string_array_test;` - массив  для проверки

`int flag = 3;` - флаг для условия 

## Step 2

`CheckArray`

Находим кол-во элементов в массиве по условию  `x.Length <= flag`

Возвращаем результат `return n`

> ```c#
> int n = 0;
> foreach (string x in array)
> {
> 	if (x.Length <= flag)
> 	{
> 		n++;
> 	}
> }
> return n;
> ```

## Step 3

`CreateNewStringArray`

Создаем пустой массив  из `n`  для заполения

> ```c#
> string[] str_array_with_three_chars_empty = new string[n];
> ```

## Step  4

`FillEmptyArray`

Заполняем пустой массив элементами

```c#
foreach (string x in array)
{
	if (x.Length <= flag)
	{
		empty_array.SetValue(x, i);
		i++;
	}
}
string[] str_array_with_three_chars = empty_array;
return str_array_with_three_chars;
```

## Step 5 

`PrintArray`

Выводим на печать

```c#
foreach (string x in array)
{
	Console.Write($"{ x } \t");
}
```

![https://github.com/SvettaJetta/GeekBrainsBlockFinal/blob/main/diagram.png](https://github.com/SvettaJetta/GeekBrainsBlockFinal/blob/main/diagram.png)

