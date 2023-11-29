using Lab5_c;

internal class PositionalNumberSystem : NumberSystem
{
    private int _numberOfDigits;
    private bool _isFractional;

    public int NumberOfDigits
    {
        get => _numberOfDigits;
        set
        {
            if (value > 0)
            {
                _numberOfDigits = value;
            }
            else
            {
                throw new FormatException("Incorrect number of digits.");
            }
        }
    }

    public bool IsFractional
    {
        get => _isFractional;
        set => _isFractional = value;
    }

    public PositionalNumberSystem(string systemName, int baseValue, string description, int numberOfDigits, bool isFractional)
        : base(systemName, baseValue, description)
    {
        NumberOfDigits = numberOfDigits;
        IsFractional = isFractional;
    }

    public override string ToString()
    {
        return $"Позиционная система счисления\n{base.ToString()}\nКоличество цифр: {NumberOfDigits}, Дробная: {IsFractional}";
    }
}