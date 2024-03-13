using DenominationRoutineLibrary.Domain;
using DenominationRoutineLibrary.Services;

namespace DenominationRoutineTests.Services;

[TestClass]
public class AtmPayoutsTests
{
    [TestMethod]
    public void PossiblePayouts_30()
    {
        var expected = new List<List<BankNotesCombination>>();
        var possible = new List<BankNotesCombination>
            {
                new BankNotesCombination(3, 10)
            };
        expected.Add(possible);

        var actual = AtmPayouts.PossiblePayouts(30);

        AssertAtmPayouts(actual, expected);
    }

    private void AssertAtmPayouts(List<List<BankNotesCombination>> actual, List<List<BankNotesCombination>> expected)
    {
        Assert.AreEqual(actual.Count, expected.Count);

        for (int i = 0; i < actual.Count; i++)
        {
            Assert.AreEqual(actual[i].Count, expected[i].Count);

            for (int j = 0; j < actual[i].Count; j++)
            {
                Assert.AreEqual(actual[i][j], expected[i][j]);
            }
        }
    }
}
