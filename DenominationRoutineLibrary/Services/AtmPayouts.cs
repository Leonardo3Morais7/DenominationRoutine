using DenominationRoutineLibrary.Domain;
using System.Collections.Generic;

namespace DenominationRoutineLibrary.Services;

public static class AtmPayouts
{
    private static List<int> cartridges =  new List<int>() {10,50,100};

    public static List<List<BankNotesCombination>> PossiblePayouts(int payment)
    {
        cartridges = cartridges.OrderByDescending(i => i).ToList();

        if (payment % cartridges.Min() != 0)
            throw new Exception("Payment cannot be divided by the current notes.");

        var possibilities = GetPossibilities(payment, 0);
        for (int i = 0; i < possibilities.Count; i++)
        {
            possibilities[i] = possibilities[i].OrderByDescending(i => i.BankNotesValue).ToList();
        }

        return possibilities;
    }

    private static List<List<BankNotesCombination>> GetPossibilities(int payment, int currentCartridge)
    {
        var possibilities = new List<List<BankNotesCombination>>();
        var note = cartridges[currentCartridge];
        var notePossibilities = payment / note;

        if (cartridges.Count - 1 == currentCartridge)
        {
            possibilities.Add(new List<BankNotesCombination>() { new BankNotesCombination(notePossibilities, note)});
            return possibilities;
        }

        for (int i = 0; i <= notePossibilities; i++)
        {
            var remaining = payment - (i * note);

            if (remaining == 0) 
            {
                possibilities.Add(new List<BankNotesCombination>() { new BankNotesCombination(i, note) });
                continue;
            }

            var insidePossibilities = GetPossibilities(remaining, currentCartridge + 1);
            foreach (var possibility in insidePossibilities) 
            {
                if(i > 0)
                    possibility.Add(new BankNotesCombination(i, note));
                possibilities.Add(possibility);
            }
        }

        return possibilities;
    }
}
