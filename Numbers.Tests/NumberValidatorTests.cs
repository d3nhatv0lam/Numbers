using Numbers.Models;

namespace Numbers.Tests;

public class NumberValidatorTests
{
    [Theory]
    [InlineData("0")]
    [InlineData("7")]
    [InlineData("12345")]
    [InlineData("007")]
    [InlineData("+7")]
    [InlineData("-7")]
    [InlineData("\u22127")]
    [InlineData("+0")]
    public void GetNumberKind_IntegerInputs_ReturnsInteger(string input)
    {
        Assert.Equal(NumberKind.Integer, NumberValidator.GetNumberKind(input));
    }

    [Theory]
    [InlineData("3.14")]
    [InlineData("0.5")]
    [InlineData("-0.5")]
    [InlineData("+0.5")]
    [InlineData("\u221212.75")]
    [InlineData(".5")]
    [InlineData("+.5")]
    [InlineData("-.5")]
    [InlineData("0.000")]
    [InlineData("123.456")]
    public void GetNumberKind_DecimalInputs_ReturnsDecimal(string input)
    {
        Assert.Equal(NumberKind.Decimal, NumberValidator.GetNumberKind(input));
    }

    [Theory]
    // Chỉ có dấu
    [InlineData("+")]
    [InlineData("-")]
    [InlineData("\u2212")]
    // Chỉ có dấu chấm
    [InlineData(".")]
    [InlineData("+.")]
    [InlineData("-.")]
    // Thiếu phần thập phân
    [InlineData("5.")]
    [InlineData("-5.")]
    [InlineData("+12.")]
    // Hai dấu chấm
    [InlineData("1.2.3")]
    [InlineData("..5")]
    [InlineData("1..2")]
    // Dấu sai vị trí
    [InlineData("1+2")]
    [InlineData("12-")]
    [InlineData("5-3")]
    [InlineData("1.5+")]
    // Hai dấu liên tiếp
    [InlineData("+-1")]
    [InlineData("--5")]
    [InlineData("++1")]
    // Ký tự lạ
    [InlineData("abc")]
    [InlineData("1e5")]
    [InlineData("1,5")]
    [InlineData("0x1F")]
    [InlineData("\u0661\u0662\u0663")]
    // Phủ thêm các đường chuyển trạng thái
    [InlineData(".+5")]
    [InlineData("1.5a")]
    [InlineData("+a")]
    [InlineData(".a")]
    [InlineData("5a")]
    // Khoảng trắng giữa hoặc chỉ có khoảng trắng
    [InlineData(" ")]
    [InlineData("   ")]
    [InlineData("1 2")]
    [InlineData("- 5")]
    [InlineData("3. 14")]
    public void GetNumberKind_InvalidInputs_ReturnsNotNumber(string input)
    {
        Assert.Equal(NumberKind.NotNumber, NumberValidator.GetNumberKind(input));
    }

    [Theory]
    [InlineData(" 5")]
    [InlineData("5 ")]
    [InlineData(" 5 ")]
    [InlineData("  5")]
    [InlineData(" -5")]
    [InlineData(" 3.14")]
    [InlineData("3.14 ")]
    [InlineData(" .5 ")]
    [InlineData("\t5")]
    [InlineData("5\n")]
    [InlineData("\r\n5")]
    [InlineData("5\u00A0")]
    public void GetNumberKind_SurroundingWhitespace_ReturnsNotNumber(string input)
    {
        Assert.Equal(NumberKind.NotNumber, NumberValidator.GetNumberKind(input));
    }

    [Fact]
    public void GetNumberKind_Null_ReturnsNotNumber()
    {
        Assert.Equal(NumberKind.NotNumber, NumberValidator.GetNumberKind(null));
    }

    [Fact]
    public void GetNumberKind_EmptyString_ReturnsNotNumber()
    {
        Assert.Equal(NumberKind.NotNumber, NumberValidator.GetNumberKind(string.Empty));
    }

    [Fact]
    public void GetNumberKind_UnicodeMinus_IsTreatedAsSign()
    {
        Assert.Equal(NumberKind.Integer, NumberValidator.GetNumberKind("\u22125"));
    }

    [Fact]
    public void GetNumberKind_VeryLongInteger_ReturnsInteger()
    {
        var input = new string('9', 10000);

        Assert.Equal(NumberKind.Integer, NumberValidator.GetNumberKind(input));
    }

    [Theory]
    [InlineData("7", true)]
    [InlineData("-3.14", true)]
    [InlineData(".5", true)]
    [InlineData("5.", false)]
    [InlineData("abc", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void IsNumber_ReturnsTrueOnlyForNumbers(string? input, bool expected)
    {
        Assert.Equal(expected, NumberValidator.IsNumber(input));
    }
}