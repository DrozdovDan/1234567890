using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task3.Task3;

namespace Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(-111.0), Is.EqualTo(0.0).Within(1e-5));
        That(F(1.5), Is.EqualTo(-1.0).Within(1e-5));
        That(F(Math.Sqrt(111)), Is.EqualTo(1.0).Within(1e-5));
        That(F(13.5), Is.EqualTo(-1.0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(2100), Is.EqualTo(365));
        That(NumberOfDays(2016), Is.EqualTo(366));
        That(NumberOfDays(2000), Is.EqualTo(366));
        That(NumberOfDays(20001), Is.EqualTo(365));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        That(Rotate2('Ю', 1, 2), Is.EqualTo('З'));
        That(Rotate2('З', -1, 2), Is.EqualTo('Ю'));
        That(Rotate2('В', 2, 1), Is.EqualTo('Ю'));
        That(Rotate2('С', 2, -1), Is.EqualTo('З'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(20), Is.EqualTo("двадцать лет"));
        That(AgeDescription(37), Is.EqualTo("тридцать семь лет"));
        That(AgeDescription(51), Is.EqualTo("пятьдесят один год"));
        That(AgeDescription(64), Is.EqualTo("шестьдесят четыре года"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}