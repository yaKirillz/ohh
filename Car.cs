using System; 

namespace test
{
    class Car
    {
        public string color;

        public string model_car;

        public string model_name;

        public int engine_power;

        public Car(string model_car1, string model_name1, int engine_power1)
        {
            model_car = model_car1;
            model_name = model_name1;
            engine_power = engine_power1;
        }
        public void Print()
        {
            Console.WriteLine($"Марка: {model_car}, Модель: {model_name}, Мощность двигателя(л.с): {engine_power}, Матиз тысяча сил, ахуеть как едет");
        }

     









    }
}