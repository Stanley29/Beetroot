using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        #region Type.GetType

        // Type myType = typeof(Person);
        // Console.WriteLine(myType);
        // Person tom = new Person("Tom");
        // Type myType = tom.GetType();
        // Type? myType = Type.GetType("Person", false, true);
        // Console.WriteLine(myType);

        #endregion

        #region GetInterfaces()

        // Type myType = typeof(Person);
        // Console.WriteLine("Реализованные интерфейсы:");
        // foreach (Type i in myType.GetInterfaces())
        // {
        //     Console.WriteLine(i.Name);
        // }

        #endregion

        #region MemberInfo()

        // DeclaredOnly: получает только методы непосредственно данного класса, унаследованные методы не извлекаются
        // Instance: получает только методы экземпляра
        // NonPublic: извлекает не публичные методы
        // Public: получает только публичные методы
        // Static: получает только статические методы

        
        // Type myType = typeof(Person);
        // foreach (MemberInfo member in myType.GetMembers())
        // {
        //     Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
        // }
        //
        // Type myType1 = typeof(Person);
        // foreach (MemberInfo member in myType1.GetMembers(BindingFlags.DeclaredOnly
        //                                                 | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
        // {
        //     Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
        // }
        
        // Type myType = typeof(Person);
        // MemberInfo[] print = myType.GetMember("Print", BindingFlags.Instance | BindingFlags.Public);
        // foreach (MemberInfo member in print)
        // {
        //     Console.WriteLine($"{member.MemberType} {member.Name}");
        // }
        //
        #endregion

        #region GetMethods()

        //     IsAbstract: возвращает true, если метод абстрактный
        //     IsFamily: возвращает true, если метод имеет модификатор доступа protected
        //     IsFamilyAndAssembly: возвращает true, если метод имеет модификатор доступа private protected
        //     IsFamilyOrAssembly: возвращает true, если метод имеет модификатор доступа protected internal
        //     IsAssembly: возвращает true, если метод имеет модификатор доступа internal
        //     IsPrivate: возвращает true, если метод имеет модификатор доступа private
        //     IsPublic: возвращает true, если метод имеет модификатор доступа public
        //     IsConstructor: возвращает true, если метод предоставляет конструктор
        // IsStatic: возвращает true, если метод статический
        //     IsVirtual: возвращает true, если метод виртуальный
        //     ReturnType: возвращает тип возвращаемого значения

        // Type myType = typeof(Printer);
        // Console.WriteLine("Методы:");
        // foreach (MethodInfo method in myType.GetMethods())
        // {
        //     string modificator = "";
        //     // если метод статический
        //     if (method.IsStatic) modificator += "static ";
        //     // если метод виртуальный
        //     if (method.IsVirtual) modificator += "virtual ";
        //     Console.WriteLine($"{modificator}{method.ReturnType.Name} {method.Name} ()");
        // }

        #endregion

        #region GetMethod().Invoke()
        
        // var myPrinter = new Printer("Hello");
        // var print = typeof(Printer).GetMethod("Print");
        // print?.Invoke(myPrinter, parameters: null);

        #endregion

        #region ConstructorInfo

        //     Свойство IsFamily: возвращает true, если конструктор имеет модификатор доступа protected
        //     Свойство IsFamilyAndAssembly: возвращает true, если конструктор имеет модификатор доступа private protected
        //     Свойство IsFamilyOrAssembly: возвращает true, если конструктор имеет модификатор доступа protected internal
        //     Свойство IsAssembly: возвращает true, если конструктор имеет модификатор доступа internal
        //     Свойство IsPrivate: возвращает true, если конструктор имеет модификатор доступа private
        //     Свойство IsPublic: возвращает true, если конструктор имеет модификатор доступа public
        //     Метод GetMethodBody(): возвращает тело конструктора в виде объекта MethodBody
        //     Метод GetParameters(): возвращает массив параметров, где каждый параметр представлен объектом типа ParameterInfo
        //     Метод Invoke(): вызывает конструктор
        
        // Type myType = typeof(Person);
        // Console.WriteLine("Конструкторы:");
        // foreach (ConstructorInfo ctor in myType.GetConstructors(
        //              BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
        // {
        //     string modificator = "";
        //     // получаем модификатор доступа
        //     if (ctor.IsPublic)
        //         modificator += "public";
        //     else if (ctor.IsPrivate)
        //         modificator += "private";
        //     else if (ctor.IsAssembly)
        //         modificator += "internal";
        //     else if (ctor.IsFamily)
        //         modificator += "protected";
        //     else if (ctor.IsFamilyAndAssembly)
        //         modificator += "private protected";
        //     else if (ctor.IsFamilyOrAssembly)
        //         modificator += "protected internal";
        //     Console.Write($"{modificator} {myType.Name}(");
        //     // получаем параметры конструктора
        //     ParameterInfo[] parameters = ctor.GetParameters();
        //     for (int i = 0; i < parameters.Length; i++)
        //     {
        //         var param = parameters[i];
        //         Console.Write($"{param.ParameterType.Name} {param.Name}");
        //         if (i < parameters.Length - 1) Console.Write(", ");
        //     }
        //     Console.WriteLine(")");
        // }

        #endregion

        #region GetFields()

        //     Свойство IsFamily: возвращает true, если поле имеет модификатор доступа protected
        //     Свойство IsFamilyAndAssembly: возвращает true, если поле имеет модификатор доступа private protected
        //     Свойство IsFamilyOrAssembly: возвращает true, если поле имеет модификатор доступа protected internal
        //     Свойство IsAssembly: возвращает true, если поле имеет модификатор доступа internal
        //     Свойство IsPrivate: возвращает true, если поле имеет модификатор доступа private
        //     Свойство IsPublic: возвращает true, если поле имеет модификатор доступа public
        //     Свойство IsStatic: возвращает true, если поле статическое
        //     Метод GetValue(): возвращает значение поля
        //     Метод SetValue(): устанавливает значение поля

        // Type myType = typeof(Person);
        // Console.WriteLine("Поля:");
        // foreach (FieldInfo field in myType.GetFields(
        //              BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
        // {
        //     string modificator = "";
        //     // получаем модификатор доступа
        //     if (field.IsPublic)
        //         modificator += "public ";
        //     else if (field.IsPrivate)
        //         modificator += "private ";
        //     else if (field.IsAssembly)
        //         modificator += "internal ";
        //     else if (field.IsFamily)
        //         modificator += "protected ";
        //     else if (field.IsFamilyAndAssembly)
        //         modificator += "private protected ";
        //     else if (field.IsFamilyOrAssembly)
        //         modificator += "protected internal ";
        //     // если поле статическое
        //     if (field.IsStatic) modificator += "static ";
        //     Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
        // }
        
        #endregion

        #region GetProperties()

            //     Свойство Attributes: возвращает коллекцию атрибутов свойства
            //     Свойство CanRead: возвращает true, если свойство доступно для чтения
            //     Свойство CanWrite: возвращает true, если свойство доступно для записи
            //     Свойство GetMethod: возвращает get-акссесор в виде объекта MethodInfo?
            //     Свойство SetMethod: возвращает set-акссесор в виде объекта MethodInfo?
            //     Свойство PropertyType: возвращает тип свойства
            //     Метод GetValue(): возвращает значение свойства
            //     Метод SetValue(): устанавливает значение свойства

            // Type myType = typeof(Person);
            // foreach (PropertyInfo prop in myType.GetProperties(
            //              BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
            // {
            //     Console.Write($"{prop.PropertyType} {prop.Name} {{");
            //     // если свойство доступно для чтения
            //     if (prop.CanRead) Console.Write("get;");
            //     // если свойство доступно для записи
            //     if (prop.CanWrite) Console.Write("set;");
            //     Console.WriteLine("}");
            // }
            
        #endregion
        
        // Assembly asm = Assembly.LoadFrom("ClassLibrary1.dll");
        // // Type[] types = asm.GetTypes();
        // Type? t = asm.GetType("ClassLibrary1.Class1");
        // if (t is not null)
        // {
        //     // получаем метод Square
        //     MethodInfo? square = t.GetMethod("Square", BindingFlags.NonPublic | BindingFlags.Static);
        //     // вызываем метод, передаем ему значения для параметров и получаем результат
        //     object? result = square?.Invoke(null, new object[] { 7 });
        //     Console.WriteLine(result); // 49
        // }
        
    }
}

// public class Person
// {
//     public string Name { get;}
//     public Person(string name) => Name = name;
// }

// public class Person : IEater, IMovable
// {
//     public string Name { get;}
//     public Person(string name) => Name = name;
//     public void Eat() => Console.WriteLine($"{Name} eats");
//     public void Move()=> Console.WriteLine($"{Name} moves");
// }
// interface IEater
// {
//     void Eat();
// }
// interface IMovable
// {
//     void Move();
// }

// public class Person
// {
//     string name;
//     public int Age { get; set; }
//     public Person(string name, int age)
//     {
//         this.name = name;
//         this.Age = age;
//     }
//     public void Print() => Console.WriteLine($"Name: {name} Age: {Age}");
// }

// class Printer
// {
//     public string Text { get;}
//     public Printer(string text) => Text = text;
//     public void Print() => Console.WriteLine(Text);
// }

// class Person
// {
//     public string Name { get; }
//     public int Age { get; }
//     public Person(string name, int age)
//     {
//         Name = name; Age = age;
//     }
//     public Person(string name) : this(name, 1) { }
//     private Person() : this("Tom") { }
// }

// class Person
// {
//     static int minAge = 0;
//     string name;
//     int age;
//     public Person(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//     }
//     public void Print() => Console.WriteLine($"{name} - {age}");
// }

// class Person
// {
//     public string Name { get; }
//     public int Age { get; set; }
//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
//     public void Print() => Console.WriteLine($"{Name} - {Age}");
// }