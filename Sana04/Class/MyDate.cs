using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04.Class;

public class MyDate
{
    protected int Year;
    protected int Month;
    protected int Day;
    protected int Hours;
    protected int Minutes;

    public MyDate() { }

    public MyDate(int year, int month, int day, int hours, int minutes)
    {
        SetYear(year);
        SetMonth(month);
        SetDay(day);
        SetHours(hours);
        SetMinutes(minutes);
    }
    public MyDate(int day, int hours, int minutes)
    {
        SetYear(2025);
        SetMonth(1);
        SetDay(day);
        SetHours(hours);
        SetMinutes(minutes);
    }
    public MyDate(MyDate other)
    {
        Year = other.Year;
        Month = other.Month;
        Day = other.Day;
        Hours = other.Hours;
        Minutes = other.Minutes;
    }
    public static int GetTotalMinutes(MyDate date)
    {
        return (date.Month - 1) * 31 * 24 * 60 
            + (date.Day - 1) * 24 * 60
            + date.Hours * 60
            + date.Minutes;
    }
    public void SetYear(int year)
    {
        if (year < 2025) throw new Exception("Wrong year");
        Year = year;
    }
    public int GetYear() => Year;
    public void SetMonth(int month)
    {
        if (month < 1 || month > 12) throw new Exception("Wrong month");
        Month = month;
    }
    public int GetMonth() => Month;
    public void SetDay(int day) 
    {
        if (day < 1 || day > 31) throw new Exception("Wrong day");
        Day = day;
    }
    public int GetDay() => Day;
    public void SetHours(int hours)
    {
        if (hours < 0 || hours > 23) throw new Exception("Wrong hours");
        Hours = hours;
    }
    public int GetHours() => Hours;
    public void SetMinutes(int minutes)
    {
        if (minutes < 1 || minutes > 59) throw new Exception("Wrong minutes");
        Minutes = minutes;
    }
    public int GetMinutes() => Minutes;
}
