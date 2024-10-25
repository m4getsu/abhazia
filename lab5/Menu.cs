using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{

    class Menu
    {
        static void Main(string[] args)
        {
            FitnessProgram fitnessProgram = null;
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Задать имя и план тренировок");
                Console.WriteLine("2. Установить целевую норму калорий");
                Console.WriteLine("3. Задать новый план тренировок");
                Console.WriteLine("4. Поменять план тренировок");
                Console.WriteLine("5. Выполнить упражнение");
                Console.WriteLine("6. Вывести текущую информацию об уровне физической подготовки");
                Console.WriteLine("7. Вывести мотивационное сообщение");
                Console.WriteLine("8. Выход");
                Console.Write("Введите номер действия: ");
                Console.WriteLine("\n  ");

                switch (Console.ReadLine())
                {
                    case "1":
                        if (fitnessProgram == null)
                        {
                            Console.Write("Введите имя пользователя: ");
                            string name = Console.ReadLine();
                            fitnessProgram = new FitnessProgram(name);
                            Console.Write("Введите план тренировок: ");
                            fitnessProgram.ChangeExercisePlan(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Имя уже задано и не может быть изменено.");
                        }
                        break;
                    case "2":
                        Console.Write("Введите целевую норму калорий: ");
                        int targetCalories = int.Parse(Console.ReadLine());
                        fitnessProgram.SetDailyTargetCalories(targetCalories);
                        break;
                    case "3":
                        Console.Write("Введите новый план тренировок: ");
                        fitnessProgram.ChangeExercisePlan(Console.ReadLine());
                        break;
                    case "4":
                        Console.Write("Введите информацию для добавления в план тренировок: ");
                        fitnessProgram.AddToExercisePlan(Console.ReadLine());
                        break;
                    case "5":
                        Console.Write("Введите количество сожженных калорий: ");
                        int calories = int.Parse(Console.ReadLine());
                        fitnessProgram.CompleteExercise(calories);
                        break;
                    case "6":
                        Console.WriteLine($"Уровень физической подготовки: {fitnessProgram.FitnessLevel}");
                        Console.WriteLine($"Предупреждение: {(fitnessProgram.Warning ? "Цель достигнута" : "Цель не достигнута")}");
                        Console.WriteLine($"Текущий план тренировок: {fitnessProgram.ExercisePlan}");
                        Console.WriteLine($"Количество тренировок: {fitnessProgram.TotalExercises}");
                        break;
                    case "7":
                        Console.WriteLine(fitnessProgram.Motivate());
                        break;
                    case "8":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова.");
                        break;
                }
                Console.WriteLine("\n  " );
            }
        }
    }

}
