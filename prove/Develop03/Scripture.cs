public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
       _words = text.Split(' ').Select(t => new Word(t)).ToList();
       _random = new Random();
    }
    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;
        while (hiddenCount < numberToHide && _words.Any(w => !w.IsHidden()))
        {
            var wordIndex = _random.Next(_words.Count);
            var word = _words[wordIndex];
            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }
     public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}