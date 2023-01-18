// Задайте массив из 12 элементов, заполненный случайными числами из промежутка (-9: 9)
// Найти сумму отрицательных и положительных элементов массива
/*
int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array){
    if(el > 0){
        positiveSum += el;
    }
    else{
        negativeSum += el;
    }
}
Console.WriteLine($"Сумма положительных чисел равна {positiveSum}, а сумма отрицательных чисел равна {negativeSum}");

//------МЕТОДЫ заполнения массива--------
int [] GetArray(int size, int minValue, int maxValue){
 int[] res = new int[size];
 for(int i = 0; i < size; i++)
 {
    res[i] = new Random().Next(minValue, maxValue + 1);
 }   
 return res;
}
*/


// Программа замены элементов массива положительных на отрицательные и наоборот
/*
int[] array = GetArray(6, -100, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
for (int i = 0; i < array.Length; i ++){
    array[i] *= -1;
}
Console.WriteLine($"[{String.Join(",", array)}]");
//------МЕТОД заполнения массива--------
int [] GetArray(int size, int minValue, int maxValue){
 int[] res = new int[size];
 for(int i = 0; i < size; i++)
 {
    res[i] = new Random().Next(minValue, maxValue + 1);
 }   
 return res;
}
*/



// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] array = GetArray(10, 1, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if(findElement(array, a)){
    Console.WriteLine("Данное число в массиве есть");
} 
else{
    Console.WriteLine("Данное число в массиве отсутствует");
}

// ----------------Булевый метод, что это?????
bool findElement(int [] array, int a){
foreach (int el in array){
    if(el == a){
        return true;
    }
} return false;
}

//------МЕТОД заполнения массива--------
int [] GetArray(int size, int minValue, int maxValue){
 int[] res = new int[size];
 for(int i = 0; i < size; i++)
 {
    res[i] = new Random().Next(minValue, maxValue + 1);
 }   
 return res;
}
*/




// Задача нахождения количества элементов массива в промежутке от 10 до 99
/*
int[] array = GetArray(123, 0, 1000);
Console.WriteLine($"[{String.Join(",", array)}]");

Console.WriteLine($"Количество элементов в отрезке от 10 до 99 {CountElement(array)}");


//------ Еще какой-то метод-------Нахождение элементов в промежутке
int CountElement(int[] array){
    int count = 0;
    foreach(int el in array){
        if(el >= 10 && el <= 99){
            count ++;
        }
    }
    return count;
}


//------МЕТОД заполнения массива--------
int [] GetArray(int size, int minValue, int maxValue){
 int[] res = new int[size];
 for(int i = 0; i < size; i++)
 {
    res[i] = new Random().Next(minValue, maxValue + 1);
 }   
 return res;
}

*/




// Задача 38: Задайте массив от -10 до 10. Найдите разницу между максимальным и минимальным элементами массива.
/*
int[] array = GetArray(10, -10, 10);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Разница между максимальным и минмальным элементом равна {DifNums(array)}");

//-----метод нахождения разности между максимальным и минимальным элементами
int DifNums(int[] array){
    int min = 0;
    int max = 0;
foreach(int el in array){
    if(el > max){
        max = el;
    }
    if(el < min){
        min = el;
    }
}
return max - min;
}


//------МЕТОД заполнения массива--------
int [] GetArray(int size, int minValue, int maxValue){
 int[] res = new int[size];
 for(int i = 0; i < size; i++)
 {
    res[i] = new Random().Next(minValue, maxValue + 1);
 }   
 return res;
}

*/
