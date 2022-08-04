// string s = "test";
//
// if (s == "test")
// {
//     Console.WriteLine(true);
// }
// else
// {
//     Console.WriteLine(false);
// }

// switch (s)
// {
//     case "test": 
//         Console.WriteLine(true);
//         break;
//     case "man":
//         Console.WriteLine(false);
//         break;
//     default:
//         Console.WriteLine("not man or test");
//         break;
// }

// int sum = 0;
// for (int i = 2; i < 10; i++)
// {
//     sum += i;
// }
// Console.WriteLine(sum);

int i = 2;
int sum = 0;
do
{
    sum += i;
    i++;
} while (i < 10);
Console.WriteLine(sum);