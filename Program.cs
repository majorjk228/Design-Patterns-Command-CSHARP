namespace Design_Patterns_Command_CSHARP
{
    // Программа по работе с пультом, через паттерн Команда. 
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV(); // Создаем телик
            Pult pult = new Pult(); // Создаем пуль

            pult.SetCommand(new TVOnCommand(tv)); // Выполни команду для телика в которой хранится телик.

        }
    }
}