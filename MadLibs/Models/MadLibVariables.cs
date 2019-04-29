namespace MadLibs.Models
{
  public class MadLibVariable
  {
    private string _noun1;
    private string _name;
    private string _location;
    private string _verb1;
    private string _number;
    private string _noun2;
    private string _adjective;
    private string _exclamation;
    private string _verb2;

    public string Noun1{ get => _noun1; set => _noun1 = value; }
    public string Name{ get => _name; set => _name = value; }
    public string Location{ get => _location; set => _location = value; }
    public string Verb1{ get => _verb1; set => _verb1 = value; }
    public string Number{ get => _number; set => _number = value; }
    public string Noun2{ get => _noun2; set => _noun2 = value; }
    public string Adjective{ get => _adjective; set => _adjective = value; }
    public string Exclamation{ get => _exclamation; set => _exclamation = value; }
    public string Verb2{ get => _verb2; set => _verb2 = value; }

  }
}
