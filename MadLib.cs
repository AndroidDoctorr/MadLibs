
public enum WordType {
    Noun,
    Adjective,
    Verb,
    PluralNoun,
    BodyPart,
    PersonInRoom,
    Activity,
    IngVerb,
}
public class MadLib {
    public string Text = "";
    public string Title = "";
    public List<WordType> Words {get;set;} =  new List<WordType>();
}