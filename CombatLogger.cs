public class CombatLogger 
{
    string filename = "C:\\Users\\bennisry\\Desktop\\DNDCombatLog\\combatlog.txt";

    public void checkforExistingFile()
    {
        if (!File.Exists(filename))
        {
            File.Create(filename).Close();
        }
        else 
        {
            File.Delete(filename);
            File.Create(filename).Close();
        }
    }
    public void logAttack(string message)
    {
        //checkforExistingFile();
        using (StreamWriter sw = File.AppendText(filename))
        {
            sw.WriteLine(message);

        }
        
    }




}