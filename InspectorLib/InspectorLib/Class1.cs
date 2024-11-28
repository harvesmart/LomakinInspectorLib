using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private string CarInspection = "Автоинспекция г. Чита";
        private string  MainInspector= "Васильев Василий Иванович";
        private List<string> Workers = new List<string> { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };

        // Метод возвращает ФИО главного инспектора
        public string GetInspector()
        {
            return MainInspector;
        }

        // Метод возвращает название автоинспекции
        public string GetСarInspection()
        {
            return CarInspection;
        }

        // Метод изменяет ФИО главного инспектора (если он есть в списке сотрудников)
        public bool SetInspector(string fullname)
        {
            if (Workers.Contains(fullname))
            {
                MainInspector = fullname;
                return true;
            }
            return false;
        }

        // Метод генерирует госномер в формате SYMBOLnumber_CODE
        public string GenerateNumber(int number, char symbol, int code = 75)
        {
            string formattedSymbol = char.ToUpper(symbol).ToString();
            return $"{formattedSymbol}{number:D4}_{code:D2}";
        }

        // Метод возвращает список сотрудников
        public List<string> GetWorker()
        {
            return new List<string>(Workers);
        }

        // Метод добавляет нового сотрудника
        public void AddWorker(string fullname)
        {
            Workers.Add(fullname);
        }
    }
}
