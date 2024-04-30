using Sort;


var rnd =new Random();

int [] ints = new int[10];
for (int i = 0; i < ints.Length; i++)
    ints[i] = rnd.Next(0, 100);   

foreach (int i in ints) Console.Write(i + " ");

// Сортировка пузырьком
//var resultBubbleSorting = Sort<int>.BubbleSorting(ints);

// Шейкерная сортировка
//var resultShakerSorting = Sort<int>.ShakerSorting(ints);

//сортировка вставками

var resultMakeSorting = Sort<int>.MakeSorting(ints);

Console.WriteLine();

foreach (int i in resultMakeSorting) Console.Write(i + " ");


