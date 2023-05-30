namespace Design_Patterns_Command_CSHARP;

public interface ICommand
{
    void Execute(); // Открытие

    void Undo();  // Отмена
}