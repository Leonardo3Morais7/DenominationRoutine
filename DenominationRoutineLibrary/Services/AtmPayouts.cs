using DenominationRoutineLibrary.Domain;
using System.Collections.Generic;

namespace DenominationRoutineLibrary.Services;

public static class AtmPayouts
{
    private static List<int> cartridges =  new List<int>() {10,50,100};

    public static List<List<BankNotesCombination>> PossiblePayouts(int payment)
    {
        throw new NotImplementedException();
    }
}
