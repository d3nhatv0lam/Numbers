namespace Numbers.Models;

public enum NumberKind
{
    NotNumber,
    Integer,
    Decimal
}

public static class NumberValidator
{
    private enum NumberState
    {
        Start,
        AfterSign,
        IntegerPart,
        DecimalPoint,
        FractionPart,
        Invalid
    }

    private enum CharacterClass
    {
        Digit,
        Sign,
        Dot,
        Other
    }


    public static bool IsNumber(string? input) => GetNumberKind(input) != NumberKind.NotNumber;


    public static NumberKind GetNumberKind(string? input)
    {
        if (string.IsNullOrEmpty(input)) return NumberKind.NotNumber;

        var state = NumberState.Start;
        foreach (var character in input)
        {
            state = Transition(state, Classify(character));
            if (state == NumberState.Invalid) return NumberKind.NotNumber;
        }

        return state switch
        {
            NumberState.IntegerPart => NumberKind.Integer,
            NumberState.FractionPart => NumberKind.Decimal,
            _ => NumberKind.NotNumber
        };
    }

    private static CharacterClass Classify(char character) => character switch
    {
        >= '0' and <= '9' => CharacterClass.Digit,
        '+' or '-' or '\u2212' => CharacterClass.Sign,
        '.' => CharacterClass.Dot,
        _ => CharacterClass.Other
    };

    /// <summary>Hàm chuyển trạng thái δ, theo bảng chuyển trong kế hoạch.</summary>
    private static NumberState Transition(NumberState state, CharacterClass character) =>
        (state, character) switch
        {
            (NumberState.Start, CharacterClass.Digit) => NumberState.IntegerPart,
            (NumberState.Start, CharacterClass.Sign) => NumberState.AfterSign,
            (NumberState.Start, CharacterClass.Dot) => NumberState.DecimalPoint,

            (NumberState.AfterSign, CharacterClass.Digit) => NumberState.IntegerPart,
            (NumberState.AfterSign, CharacterClass.Dot) => NumberState.DecimalPoint,

            (NumberState.IntegerPart, CharacterClass.Digit) => NumberState.IntegerPart,
            (NumberState.IntegerPart, CharacterClass.Dot) => NumberState.DecimalPoint,

            (NumberState.DecimalPoint, CharacterClass.Digit) => NumberState.FractionPart,

            (NumberState.FractionPart, CharacterClass.Digit) => NumberState.FractionPart,

            _ => NumberState.Invalid
        };
}
