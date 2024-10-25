using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{

    public class FitnessProgram
    {
        private string _name;
        private string _exercisePlan;
        private int _caloriesBurned;
        private int _totalExercises;
        private int _dailyTargetCalories;

        public string Name => _name; 
        public string ExercisePlan => _exercisePlan; 
        public int CaloriesBurned => _caloriesBurned; 
        public int TotalExercises => _totalExercises; 
        public int DailyTargetCalories => _dailyTargetCalories; 

        public string FitnessLevel
        {
            get
            {
                if (_dailyTargetCalories > 2000)
                    return "Спортсмен";
                else if (_dailyTargetCalories > 1000)
                    return "Активный";
                else
                    return "Новичок";
            }
        }

        
        
        public FitnessProgram(string name)
        {
            _name = name;
            _exercisePlan = "Не установлен";
            _caloriesBurned = 0;
            _totalExercises = 0;
            _dailyTargetCalories = 0;
        }

        public void CompleteExercise(int calories)
        {
            _caloriesBurned += calories;
            _totalExercises++;
        }

        public void ChangeExercisePlan(string newPlan)
        {
            _exercisePlan = newPlan;
        }

        public void AddToExercisePlan(string additionalInfo)
        {
            _exercisePlan += ", " + additionalInfo;
        }

        public void SetDailyTargetCalories(int target)
        {
            _dailyTargetCalories = target;
        }
        public bool Warning => _caloriesBurned > _dailyTargetCalories; 

        public string Motivate()
        {
            string[] messages = {
            "Ты сможешь!",
            "Продолжай в том же духе!",
            "У тебя все получится",
            "Не останавливайся!",
        };
            Random rand = new Random();
            return messages[rand.Next(messages.Length)];
        }
    }
}

