using Sana04.Class;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

const int EndOfMonthThreshold = 27;
const float DefaultPhoneWeightGrams = 170f;

int c, year1 = 2025, month1 = 1, day1, hours1, minutes1,
    year2, month2, day2, hours2, minutes2;
Console.WriteLine("Введіть час відбуття:");
Console.WriteLine("Рік та місяць: \n1)За замовчуванням(2025.01)\n2)Ввести");
c = int.Parse(Console.ReadLine());
if (c == 2)
{
    Console.Write("Рік -  ");
    year1 = int.Parse(Console.ReadLine());
    Console.Write("Місяць -  ");
    month1 = int.Parse(Console.ReadLine());
} 
Console.Write("День -  ");
day1 = int.Parse(Console.ReadLine());
Console.Write("Година -  ");
hours1 = int.Parse(Console.ReadLine());
Console.Write("Хвилина -  ");
minutes1 = int.Parse(Console.ReadLine());

year2 = year1;
month2 = month1;

Console.WriteLine("Введіть час прибуття:");
if (c == 2 && month1 == 12 && day1 == 31)
{
    Console.Write("Рік -  ");
    year2 = int.Parse(Console.ReadLine());
}
if (day1 > EndOfMonthThreshold)
{
    Console.Write("Місяць -  ");
    month2 = int.Parse(Console.ReadLine());
}

Console.Write("День -  ");
day2 = int.Parse(Console.ReadLine());
Console.Write("Година -  ");
hours2 = int.Parse(Console.ReadLine());
Console.Write("Хвилина -  ");
minutes2 = int.Parse(Console.ReadLine());

MyDate startDate = new MyDate(year1, month1, day1, hours1, minutes1);
MyDate finishDate;
if (month1 == 12 && day1 > EndOfMonthThreshold)
{
    finishDate = new MyDate(year2, month2, day2, hours2, minutes2);
}
else
{
    finishDate = new MyDate(day2, hours2, minutes2);
}

c = 0;
string startCity = "Житомир", finishCity;
Console.WriteLine("Місто відбуття: \n1) Житомир \n2) Інше\n");
c = int.Parse(Console.ReadLine());
if (c == 2)
{
    Console.Write("Введіть місто відбуття:");
    startCity = Console.ReadLine();
}
Console.Write("Введіть місто прибуття: ");
finishCity = Console.ReadLine();

Airplane plane01;

if (c == 2)
{
   plane01 = new Airplane(startCity, finishCity, startDate, finishDate);
} else
{
    plane01 = new Airplane(finishCity, startDate, finishDate);
}

Console.WriteLine($"Сумарний час подорожі: {plane01.GetTotalTime()} хвилин");
Console.WriteLine($"Прибуття в день відбуття? {plane01.IsArrivingToday()}\n");

string CurName = "USD";
float CurCost;
c = 0;
Console.WriteLine("Валюта:\n1)За замовчуванням(USD)\n2)Інша");
if (c == 2)
{
    Console.WriteLine("Введіть назву валюти: ");
    CurName = Console.ReadLine();
}
Console.WriteLine("Введіть вартість у гривнях (гривні та копійки)");
CurCost = float.Parse(Console.ReadLine());
Currency Cur;
if (c == 2)
{
    Cur = new Currency(CurName, CurCost);
}
else
{
     Cur = new Currency(CurCost);
}


float ProductCost, ProductWeight = DefaultPhoneWeightGrams;
int ProductAmount;
Product phone;
Console.Write("Введіть дані:\n Вартість товару: ");
ProductCost = float.Parse(Console.ReadLine());
Console.Write("Кількість на складі: ");
ProductAmount = int.Parse(Console.ReadLine());
c = 0;
Console.WriteLine($"Вага товару: \n1)За замовчуванням({DefaultPhoneWeightGrams}г)\n2)Інша");
c = int.Parse(Console.ReadLine());
if (c == 2)
{
    Console.Write("Вага одиниці товару (у грамах): ");
    ProductWeight = float.Parse(Console.ReadLine());
}

if (c == 2)
{
    phone = new Product("Телефон", ProductCost, Cur, ProductAmount, "Apple", ProductWeight);
}
else
{
    phone = new Product("Телефон", ProductCost, Cur, ProductAmount, "Apple");
}

Console.WriteLine($"Вартість в гривнях: {phone.GetPriceInUAH}\n" +
    $"Загальна вартість усіх товарів даного виду на складі: {phone.GetTotalPriceInUAH}\n" +
    $"Загальна вага усіх товарів даного виду на складі: {phone.GetTotalWeight}")
