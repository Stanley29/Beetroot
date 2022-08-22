// private: закрытый или приватный компонент класса или структуры. Приватный компонент доступен только в рамках своего класса или структуры.
// private protected: компонент класса доступен из любого места в своем классе или в производных классах, которые определены в той же сборке.
// protected: такой компонент класса доступен из любого места в своем классе или в производных классах. При этом производные классы могут располагаться в других сборках.
// internal: компоненты класса или структуры доступен из любого места кода в той же сборке, однако он недоступен для других программ и сборок.
// protected internal: совмещает функционал двух модификаторов protected и internal. Такой компонент класса доступен из любого места в текущей сборке и из производных классов, которые могут располагаться в других сборках.
// public: публичный, общедоступный компонент класса или структуры. Такой компонент доступен из любого места в коде, а также из других программ и сборок.

using Incapsulation;

// Example example = new Example();
// Console.WriteLine("Please, enter the integer number:");
//
// // example.Set(int.Parse(Console.ReadLine()));
// // Console.WriteLine("You enter:");
// // Console.WriteLine(example.Get());
//
// example.Num = int.Parse(Console.ReadLine());
// Console.WriteLine("You enter:");
// Console.WriteLine(example.Num);

// Person person = new Person();
// person.Age = -23;
// Console.WriteLine(person.Age);
//
// Person1 person1 = new Person1();
//
// // свойство для чтения - можно получить значение
// Console.WriteLine(person1.Name);  // Tom
// // но нельзя установить
// // person1.Name = "Bob";    // ! Ошибка
// // свойство для записи - можно устновить значение
// person1.Age = 37;
// // но нелзя получить
// //Console.WriteLine(person1.Age);  // ! Ошибка
//
// person1.Print();

// Person2 tom = new("Tom", "Smith");
// Console.WriteLine(tom.Name);    // Tom Smith

// Person3 tom = new("Tom");
// // Ошибка - set объявлен с модификатором private
// // tom.Name = "Bob";
// Console.WriteLine(tom.Name);    // Tom

Person4 tom = new Person4("Denis", 18);
Console.WriteLine(tom.Name);    // Denis
Console.WriteLine(tom.Age);    // 18