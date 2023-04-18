using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskTwo
{
    internal class Schedule
    {
        public string[] Week = new string[]
        {
            "Понидельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница"
        };

        public string[,] Create(Lesson[] lessons) 
        {
            if (lessons == null || 
                lessons.Length == 0)
            {
                throw new Exception("Нет уроков");
            }

            var countLessons = lessons.Sum(x => x.Count);
            if (countLessons > 25)
            {
                throw new Exception("Больше 25 уроков");
            }

            List<string> lessonsList = new List<string>();
            
            
            foreach (Lesson lesson in lessons)
            {
                if (lessonsList.Count > 25) break;
                lessonsList.AddRange(LessonToArray(lesson.Name, lesson.Count));
            }
            while (lessonsList.Count > 25)
                lessonsList.RemoveAt(lessonsList.Count-1);
            while (lessonsList.Count < 25)
                lessonsList.Add(string.Empty);

            Random random = new Random();
            string[,] matrix = new string[5, 5]; 
            for ( var i = 0; i < 5; i++)
                for ( var j = 0; j < 5; j++)
                {
                    int index = random.Next(0, lessonsList.Count - 1);
                    matrix[i, j] = lessonsList[index];
                    lessonsList.RemoveAt(index);
                }

            return matrix;
        }
        public string From(string[,] matrix)
        {
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < 5; i++)
            {
                builder.AppendLine(Week[i] + ":");
                for(int j = 0;j < 5; j++)
                {
                    builder.AppendLine($"\t{j+1}. " + matrix[i, j]);
                }
            }

            return builder.ToString();
        }
        private string[] LessonToArray(string word, int count)
        {
            var temp = new string[count];
            for (int i = 0;i < count; i++)
            {
                temp[i] = word;
            }
            return temp;
        }
        public Lesson ArrayToLesson(string[] array)
        {
            string temp = string.Empty;
            for (int i = 0; i < array.Length - 1; i++)
            {
                temp += array[i] + ' ';
            }
            return new Lesson()
            {
                Name = temp,
                Count = int.Parse(array[array.Length - 1])
            };
        }
    }
}
