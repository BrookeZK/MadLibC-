namespace Madlibs.Models
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

    public string{ get => _noun1; set => _noun1 = value; }
    public string{ get => _name; set => _name = value; }
    public string{ get => _location; set => _location = value; }
    public string{ get => _verb1; set => _verb1 = value; }
    public string{ get => _number; set => _number = value; }
    public string{ get => _noun2; set => _noun2 = value; }
    public string{ get => _adjective; set => _adjective = value; }
    public string{ get => _exclamation; set => _exclamation = value; }
    public string{ get => _verb2; set => _verb2 = value; }

  }
}
