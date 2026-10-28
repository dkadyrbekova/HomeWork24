//Задание 1. Приветствие
//Объяви делегат MessageHandler, который принимает строку и ничего не возвращает.
//Создай метод SayHello, который принимает имя и выводит приветствие.
//Создай переменную типа MessageHandler.
//Присвой переменной метод SayHello.
//Вызови делегат, передав имя.
//Создай метод SayGoodbye с такой же сигнатурой.
//Присвой делегату метод SayGoodbye и вызови его повторно.
//Результат: ты должен уметь присваивать делегату разные методы с подходящей сигнатурой.
//delegate void MessageHandler(string message);
//class Program
//{
//    static void SayHello(string name)
//    {
//        Console.WriteLine($"Hello, {name}!");
//    }
//    static void SayGoodbye(string name)
//    {
//        Console.WriteLine($"Goodbye, {name}!");
//    }
//    static void Main()
//    {
//        MessageHandler handler;
//        handler = SayHello;
//        handler("Alice");
//        handler = SayGoodbye;
//        handler("Bob");
//    }
//}

//Задание 2. Несколько обработчиков
//Объяви делегат NotificationHandler, который принимает строку и ничего не возвращает.
//Создай три метода:
//SendEmail выводит сообщение об отправке email.
//SendSms выводит сообщение об отправке SMS.
//WriteToLog выводит сообщение о записи в лог.
//Создай переменную типа NotificationHandler.
//Добавь метод SendEmail с помощью +=.
//Добавь SendSms и WriteToLog таким же способом.
//Вызови делегат один раз.
//Удали SendSms с помощью -=.
//Вызови делегат повторно.
//Удали SendEmail и вызови делегат ещё раз.
//Результат: проследи, какие методы вызываются после каждого добавления и удаления.
//delegate void NotificationHandler(string message);
//class Program
//{
//    static void SendEmail(string message)
//    {
//        Console.WriteLine("Sending email: " + message);
//    }
//    static void SendSms (string message)
//    {
//        Console.WriteLine("Sending SMS: " + message);
//    }
//    static void WriteLOg(string message)
//    {
//        Console.WriteLine("Writing to log:" + message);
//    }
//    static void Main()
//    {
//        NotificationHandler handler=null;
//        handler += SendEmail;
//        handler += SendSms;
//        handler += WriteLOg;
//        handler("Hello, world!");
//        handler -= SendSms;
//        handler("Hello again!");
//        handler -= SendEmail;
//        handler("Hello for the last time!");
//    }
//}


//Задание 3. Делегат с возвращаемым значением
//Объяви делегат NumberHandler, который принимает целое число и возвращает целое число.
//Создай метод DoubleNumber, возвращающий число, умноженное на два.
//Создай метод SquareNumber, возвращающий квадрат числа.
//Создай переменную типа NumberHandler.
//Присвой ей DoubleNumber и вызови делегат.
//Присвой ей SquareNumber и вызови делегат повторно.
//Передай в оба вызова одно и то же число и сравни результаты.
//Результат: пойми, как делегат получает аргументы и возвращает результат метода.

//delegate int NumberHandler(int number);
//class Program
//{
//    static int DoubleNumber(int number)
//    {
//        return number * 2;
//    }
//    static int SguareNumber(int number)
//    {
//        return number * number;
//    }
//    static void Main()
//    {
//        NumberHandler handler;
//        handler = DoubleNumber;
//        Console.WriteLine(handler(12));
//        handler = SguareNumber;
//        Console.WriteLine(handler(12));
//    }
//}


//Часть 2. Встроенные делегаты
//Задание 4. Action: действия с сообщениями
//Создай метод ShowMessage, который принимает строку и выводит её.
//Создай переменную типа Action<string>.
//Присвой ей метод ShowMessage.
//Вызови действие с произвольным сообщением.
//Создай лямбда-выражение, которое принимает строку и выводит её в верхнем регистре.
//Присвой лямбда-выражение той же переменной и вызови его.
//Результат: научись использовать Action с обычным методом и лямбда-выражением.

//class Program
//{
//    static void ShowMessage(string message)
//    {
//        Console.WriteLine(message);
//    }
//    static void Main()
//    {
//        Action<string> action;
//        action = ShowMessage;
//        action("Hello, Action!");
//        action = message => Console.WriteLine(message.ToUpper());
//        action("Hello, Action!");
//    }
//}



//Задание 5. Func: преобразование чисел
//Создай переменную типа Func<int, int>.
//Присвой ей лямбда-выражение, которое прибавляет к числу 10.
//Вызови его с несколькими числами и выведи результаты.
//Измени лямбда-выражение так, чтобы оно умножало число на три.
//Вызови его повторно.
//Создай переменную типа Func<string, int>.
//Присвой ей лямбда-выражение, возвращающее длину строки.
//Проверь его на нескольких строках.
//Результат: пойми разницу между входным типом и типом возвращаемого значения в Func.

//class Program
//{
//    static void Main()
//    {
//        Func<int, int> func;
//        func = number => number + 10;
//        Console.WriteLine(func(5));
//        Console.WriteLine(func(15));
//        func = number => number * 3;
//        Console.WriteLine(func(5));
//        Func<string, int> stringsize;
//        stringsize = text => text.Length;
//        Console.WriteLine("Task with string");
//        Console.WriteLine(stringsize("Hello, Func!"));
//        Console.WriteLine(stringsize("C# is awesome!"));
//    }
//}


//Задание 6. Predicate: проверка чисел
//Создай переменную типа Predicate<int>.
//Присвой ей лямбда-выражение, которое проверяет, является ли число чётным.
//Проверь несколько чисел и выведи результаты.
//Измени условие так, чтобы оно проверяло, больше ли число 100.
//Проверь несколько значений повторно.
//Создай массив целых чисел.
//Пройди по массиву циклом и с помощью предиката выведи только числа, прошедшие проверку.
//Результат: научись использовать Predicate < T > для условий, возвращающих true или false.

//class Program
//{
//    static void Main()
//    {
//        Predicate<int> predicate = number => number % 2 == 0;
//        Console.WriteLine(predicate(4)); 
//        Console.WriteLine(predicate(7));
//        Console.WriteLine(predicate(3));
//        predicate = number => number > 100;
//        Console.WriteLine(predicate(150));
//        Console.WriteLine(predicate(50));
//        int[] numbers = { 10, 25, 50, 75, 100, 125, 150 };
//        Console.WriteLine("Numbers greater than 100:");
//        foreach (int number in numbers)
//        {
//            if (predicate(number))
//            {
//                Console.WriteLine(number);
//            }
//        }
//    }
//}



//Часть 3. Закрепление
//Задание 7. Обработка списка имён
//Создай список из пяти имён.
//Напиши метод ProcessNames, который принимает список имён и Action<string>.
//Внутри метода пройди по списку и вызывай переданное действие для каждого имени.
//Вызови метод с действием, которое выводит имя.
//Вызови метод повторно с действием, которое выводит имя в верхнем регистре.

//class Program
//{
//    static void ProcessNames(List<string> names, Action<string> action)
//    {
//        foreach (string name in names)
//        {
//            action(name);
//        }
//    }
//    static void Main()
//    {
//        List<string> names = new List<string> { "Дина", "Айжан", "Бекзат", "Мария", "Тимур" };

//        Console.WriteLine("Просто имена:");
//        ProcessNames(names, name => Console.WriteLine(name));

//        Console.WriteLine("Верхний регистр:");
//        ProcessNames(names, name => Console.WriteLine(name.ToUpper()));
//    }
//}