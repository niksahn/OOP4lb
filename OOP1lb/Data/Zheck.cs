using OOP1lb.Others;

namespace OOP1lb.Data
{
    /// <summary>
    /// Класс, реализующий ЖЭК
    /// </summary>
    public class Zheck
    {
        /* ПОЛЯ */

        /// <summary>
        /// Регион
        /// </summary>
        string Region;
        /// <summary>
        /// Номер ЖЭК в системе (id)
        /// </summary>
        int Number;
        /// <summary>
        /// Название ЖЭК
        /// </summary>
        string Name;
        /// <summary>
        /// Количество жителей.
        /// </summary>
        double NumberHabitians;
        /// <summary>
        /// Число плательщиков
        /// </summary>
        double NumberPayments;
        /// <summary>
        /// Количество зданий
        /// </summary>
        double NumberOfBuildings;
        /// <summary>
        /// Контактная почта
        /// </summary>
        string ContactEmail;
        /// <summary>
        /// Площадь обслуживания
        /// </summary>
        float ServiceArea;
        /// <summary>
        /// Счетчик элементов класса
        /// </summary>
        public static int counter = 0;

        /* СВОЙСТВА */
        public string Region1
        {
            get => Region;
            set
            {
                if (!Functions.IsString(value)) throw new MyException("Неверное знаение поля регион");
                Region = value;
            }
        }
        public int Number1 { get => Number; }
        public string Name1
        {
            get => Name;
            set
            {
                if (!Functions.IsString(value)) throw new MyException("Неверное знаение поля название");
                Name = value;
            }
        }
        public double NumberHabitians1 { get => NumberHabitians; set => NumberHabitians = value; }
        public double NumberPayments1 { get => NumberPayments; set => NumberPayments = value; }
        public double NumberOfBuildings1 { get => NumberOfBuildings; set => NumberOfBuildings = value; }
        public string ContactEmail1 { get => ContactEmail; set => ContactEmail = value; }
        public float ServiceArea1 { get => ServiceArea; set => ServiceArea = value; }

        /* МЕТОДЫ */

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Zheck()
        {

            Region = Functions.RandomString();
            Number = counter;
            NumberHabitians = 0;
            NumberPayments = 0;
            NumberOfBuildings = 0;
            ContactEmail = Functions.RandomString();
            ServiceArea = 0;
            Name = Functions.RandomString();
            counter++;
        }

        /// <summary>
        /// Конструктор с 7 параметрами
        /// </summary>
        /// /// <param name="region">Регион</param>
        /// <param name="name">Название</param>
        /// <param name="numberHabitians">Количество жителей</param>
        /// <param name="numberPayments">Число плательщиков</param>
        /// <param name="numberOfBuildings">Количество зданий</param>
        /// <param name="contactEmail">Почта</param>
        /// <param name="serviceArea">Площадь обслуживания</param>
        public Zheck(string region, string name, double numberHabitians, double numberPayments, double numberOfBuildings, string contactEmail, float serviceArea)
        {

            Region1 = region;
            Number = counter;
            NumberHabitians1 = numberHabitians;
            NumberPayments1 = numberPayments;
            NumberOfBuildings1 = numberOfBuildings;
            ContactEmail1 = contactEmail;
            ServiceArea1 = serviceArea;
            Name1 = name;
            counter++;
        }
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="name">Название</param>
        public Zheck(string name)
        {

            Region1 = Functions.RandomString();
            Number = counter;
            NumberHabitians1 = 0;
            NumberPayments1 = 0;
            NumberOfBuildings1 = 0;
            ContactEmail1 = Functions.RandomString();
            ServiceArea1 = 0;
            Name1 = name;
            counter++;
        }
        /// <summary>
        /// Конструктор с 2 параметр
        /// </summary>
        /// <param name="region">Регион</param>
        /// <param name="name">Название</param>
        public Zheck(string region, string name)
        {

            Region1 = region;
            Number = counter;
            NumberHabitians1 = 0;
            NumberPayments1 = 0;
            NumberOfBuildings1 = 0;
            ContactEmail1 = Functions.RandomString();
            ServiceArea1 = 0;
            Name1 = name;
            counter++;
        }

        /// <summary>
        /// Получить id в 16 ричной СС
        /// </summary>
        /// <returns>id в 16 ричной СС</returns>
        public string GetNumberInHex()
        {
            return Convert.ToString(Number1, 16);
        }

        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        /// <returns>Строку с информацией о ЖЭК</returns>
        public override string ToString()
        {
            return Number + "\n" + Region + "\n" + Name + "\n" +
                 NumberHabitians + "\n" + NumberPayments + "\n" + NumberOfBuildings + "\n" + ContactEmail + "\n" + ServiceArea;
        }
    }
}
