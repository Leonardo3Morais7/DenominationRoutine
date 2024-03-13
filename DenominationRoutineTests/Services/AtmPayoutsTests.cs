using DenominationRoutineLibrary.Domain;
using DenominationRoutineLibrary.Services;

namespace DenominationRoutineTests.Services;

[TestClass]
public class AtmPayoutsTests
{
    [TestMethod]
    public void PossiblePayouts_30()
    {
        var expected = new List<List<BankNotesCombination>>() 
        {
            new List<BankNotesCombination>() 
            {
                new BankNotesCombination(3, 10)
            }
        };

        var actual = AtmPayouts.PossiblePayouts(30);

        AssertAtmPayouts(actual, expected);
    }

    [TestMethod]
    public void PossiblePayouts_50()
    {
        var expected = new List<List<BankNotesCombination>>()
        {
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(5, 10)
            },
            new List<BankNotesCombination>() 
            {
                new BankNotesCombination(1, 50)
            }
        };

        var actual = AtmPayouts.PossiblePayouts(50);

        AssertAtmPayouts(actual, expected);
    }

    [TestMethod]
    public void PossiblePayouts_60()
    {
        var expected = new List<List<BankNotesCombination>>()
        {
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(6, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(1, 50),
                new BankNotesCombination(1, 10)
            }
        };

        var actual = AtmPayouts.PossiblePayouts(60);

        AssertAtmPayouts(actual, expected);
    }

    [TestMethod]
    public void PossiblePayouts_80()
    {
        var expected = new List<List<BankNotesCombination>>()
        {
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(8, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(1, 50),
                new BankNotesCombination(3, 10)
            }
        };

        var actual = AtmPayouts.PossiblePayouts(80);

        AssertAtmPayouts(actual, expected);
    }

    [TestMethod]
    public void PossiblePayouts_140()
    {
        var expected = new List<List<BankNotesCombination>>()
        {
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(14, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(1, 50),
                new BankNotesCombination(9, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(2, 50),
                new BankNotesCombination(4, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(1, 100),
                new BankNotesCombination(4, 10)
            }
        };

        var actual = AtmPayouts.PossiblePayouts(140);

        AssertAtmPayouts(actual, expected);
    }

    [TestMethod]
    public void PossiblePayouts_230()
    {
        var expected = new List<List<BankNotesCombination>>()
        {
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(23, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(1, 50),
                new BankNotesCombination(19, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(2, 50),
                new BankNotesCombination(13, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(3, 50),
                new BankNotesCombination(8, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(4, 50),
                new BankNotesCombination(3, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(1, 100),
                new BankNotesCombination(13, 10)
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(1, 100),
                new BankNotesCombination(1, 50),
                new BankNotesCombination(8, 10),
            },
            new List<BankNotesCombination>()
            {
                new BankNotesCombination(1, 100),
                new BankNotesCombination(2, 50),
                new BankNotesCombination(3, 10),
            }
        };

        var actual = AtmPayouts.PossiblePayouts(230);

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
