namespace DenominationRoutineLibrary.Domain;

public class BankNotesCombination
{
    public int BankNotesCount { get; set; }
    public int BankNotesValue { get; set; }

    public BankNotesCombination(int noteCount, int noteValue)
    {
        BankNotesCount = noteCount;
        BankNotesValue = noteValue;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        var other = obj as BankNotesCombination;

        return BankNotesCount == other.BankNotesCount && BankNotesValue == other.BankNotesValue;
    }
}
