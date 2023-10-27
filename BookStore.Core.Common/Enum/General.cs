using System.ComponentModel;

namespace BookStore.Core.Common.Enum
{
    public enum Category
    {
        Book
    }
    public enum Publisher
    {
        [Description("Bantam Classics")]
        BantamClassics
    }
    public enum GlobalLanguage
    { 
       ARM,
       RU,
       ENG
    }
    public enum Language
    {
        Armenian,
        Russian,
        English
    }
    public enum Genre
    { 
        Fantasy,
        Classic,
        Historical,
    }
}
