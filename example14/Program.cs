// int Factorial(int n)
// {
//     if(n == 1) return 1;

//     return n * Factorial(n - 1);
// }

// int sum = Factorial(5);
// Console.WriteLine(sum);


// int num1 = 2;

// int result = Switch(num1, 13, 21);
// Console.WriteLine(result);
// int Switch(int num, int a, int b)
// {
// switch (num)
// {
//     case 8:return a * 2;
       
//     case 6: return b * 2;
        
//     case 7: return a + b;
        
//     case 10: return a * 2 - b;
        
//     default: return b * a;
        
// }
// }
// DoOperation(10, 11, Operation.c);

// void DoOperation(int a, int b, Operation n)
// {
//     int result = n switch
//     {
//         Operation.a => a * b,
//         Operation.b => a + b,
//         Operation.c => a - b,
//         Operation.d => a + b
//     };
//     Console.Write(result);
// }

// enum Operation 
// {
//     a,
//     b,
//     c,
//     d 
// };


// string personName = tom.name;
// int personAge = tom.age;
// Console.WriteLine($"Имя: {personName}  Возраст: {personAge}");
Person tom = new ();
Person bob = new ("Bob");
Person sam = new ("Sam", 25);

//tom.name = "Tom";
//tom.age = 37;

// tom.Print();
// bob.Print();
// sam.Print();


// class Person

// {
//     public string name = "Undefined";
//     public int age;

//     public void Print()
//     {
//         Console.WriteLine($"Имя: {name}  Возраст: {age}");
//     }
// }