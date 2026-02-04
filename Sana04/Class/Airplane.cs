using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04.Class;
public class Airplane
{
    protected string StartCity;
    protected string FinishCity;
    protected MyDate StartDate;
    protected MyDate FinishDate;

    public Airplane() { }

    public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
    {
        SetStartCity(startCity);
        SetFinishCity(finishCity);
        SetStartDate(startDate);
        SetFinishDate(finishDate);
    }
    public Airplane(string finishCity, MyDate startDate, MyDate finishDate)
    {
        SetStartCity("Житомир");
        SetFinishCity(finishCity);
        SetStartDate(startDate);
        SetFinishDate(finishDate);
    }

    public Airplane(Airplane other)
    {
        StartCity = other.StartCity;
        FinishCity = other.FinishCity;
        StartDate = other.StartDate;
        FinishDate = other.FinishDate;
    }

    public void SetStartCity(string startCity)
    {
        if (string.IsNullOrEmpty(startCity))
            throw new Exception("Start city isn't specified");
        StartCity = startCity;
    }

    public void SetFinishCity(string finishCity)
    {
        if (string.IsNullOrEmpty(finishCity))
            throw new Exception("Finish city isn't specified");
        FinishCity = finishCity;
    }

    public void SetStartDate(MyDate startDate) => StartDate = startDate;
    public MyDate GetStartDate() => StartDate;
    public void SetFinishDate(MyDate finishDate) => FinishDate = finishDate;
    public MyDate GetFinishDate() => FinishDate;
    public int GetTotalTime()
    {
        return MyDate.GetTotalMinutes(FinishDate) - MyDate.GetTotalMinutes(StartDate);
    }
    
    public bool IsArrivingToday()
    {
        return StartDate.GetYear() == FinishDate.GetYear() &&
               StartDate.GetMonth() == FinishDate.GetMonth() &&
               StartDate.GetDay() == FinishDate.GetDay();
    }
}
