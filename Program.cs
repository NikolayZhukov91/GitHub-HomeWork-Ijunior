using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeReception = 10;
            int numberOfPatients;
            int minutsInHour = 60;
            int waitingTimeHours;
            int waitingTimeMinutes;
            Console.WriteLine("Привет добро пожаловать выздоравливать!");
            Console.WriteLine("Введите количество пациентов в очереди:");
            numberOfPatients = Convert.ToInt32(Console.ReadLine());
            waitingTimeHours = (numberOfPatients * timeReception) / minutsInHour;
            waitingTimeMinutes = (numberOfPatients* timeReception) % minutsInHour;
            Console.WriteLine($"Ваше время ожидания: {waitingTimeHours} часов и {waitingTimeMinutes} минут");
            Console.ReadKey();

        }
    }
}
