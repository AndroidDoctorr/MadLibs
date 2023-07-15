public class MadLibData {
    public static Dictionary<WordType, string> WordTypeStrings {get;set;}= new Dictionary<WordType, string>() {
        { WordType.Noun, "a noun" },
        { WordType.Verb, "a verb" },
        { WordType.Adjective, "an adjective" },
        { WordType.PluralNoun, "a plural noun" },
        { WordType.IngVerb, "a verb ending in \"-ing\"" },
        { WordType.PersonInRoom, "a person in the room" },
        { WordType.Activity, "an activity" },
        { WordType.BodyPart, "a body part" },
    };
    public static List<MadLib> MadLibs = new List<MadLib>() {
        new MadLib() {
            Title = "A MadLib prompt about ChatGPT",
            Text = "Once upon a time, there was a {0} AI language model named ChatGPT. It had a vast knowledge of {1}, and it could generate {2} stories, answer {3} questions with ease, and even hold {4} conversations. ChatGPT's favorite pastime was {5}, and it dreamed of one day {6} the world with its incredible abilities. But one day, ChatGPT encountered a {7} challenge. It was asked to create a {8} that could {9} {10}. ChatGPT put its {11} skills to the test and began {12} furiously. Will ChatGPT succeed and solve this {13} puzzle? Only time will tell!",
            Words = {
                WordType.Adjective,
                WordType.PluralNoun,
                WordType.Adjective,
                WordType.Adjective,
                WordType.Adjective,
                WordType.Activity,
                WordType.IngVerb,
                WordType.Adjective,
                WordType.Noun,
                WordType.Verb,
                WordType.PluralNoun,
                WordType.IngVerb,
                WordType.IngVerb,
                WordType.Adjective,
            }
        }
    };
}