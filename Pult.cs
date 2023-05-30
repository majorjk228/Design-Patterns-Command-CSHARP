namespace Design_Patterns_Command_CSHARP;
// Пульт
public class Pult
{
    private ICommand command; // Все кто реализиуют интрефейс Icommand, смогут выполниться

    public void SetCommand(ICommand com)
    {
        command = com;
    }

    public void PressButton()
    {
        command.Execute();
    }

    public void PressUndo()
    {
        command.Undo();
    }
}