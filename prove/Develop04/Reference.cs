public class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse = 0)
    {
        this.book = book;  // This "this" refers to the current instance of the class. 
        // I do not know if it is good grammar. I read that and vaguely remember from in class
        // that it helps the compiler assume that you are refering to the instance variables.
        // or the current object.
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse == 0 ? startVerse : endVerse;
    }

    public override string ToString()
    {
        return endVerse == startVerse 
            ? $"{book} {chapter}:{startVerse}" 
            : $"{book} {chapter}:{startVerse}-{endVerse}";
    }
}
