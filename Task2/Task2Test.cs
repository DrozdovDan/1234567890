using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(100, 311, 10), Is.EqualTo(10));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(-1034, 11111, 0), Is.EqualTo(-1034));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(-1034, 11111, 0), Is.EqualTo(11111));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(311, 100, 10), Is.EqualTo(311));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(2, 0, 3), Is.EqualTo(3));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void MoreRadDegTests()
    {
        That(Deg2Rad(90.0), Is.EqualTo(Math.PI / 2).Within(1e-5));
        That(Deg2Rad(10.0), Is.EqualTo(Math.PI / 18).Within(1e-5));
        That(Deg2Rad(11.0), Is.EqualTo(Math.PI * 11 / 180).Within(1e-5));
        That(Deg2Rad(720.0), Is.EqualTo(Math.PI * 720 / 180).Within(1e-5));
        That(Deg2Rad(70.12345), Is.EqualTo(Math.PI * 70.12345 / 180).Within(1e-5));
        That(Rad2Deg(Math.PI * 18), Is.EqualTo(180.0 * 18).Within(1e-5));
        That(Rad2Deg(Math.PI / 1.1), Is.EqualTo(180.0 / 1.1).Within(1e-5));
        That(Rad2Deg(Math.PI * 123 + Math.PI / 123), Is.EqualTo(180.0 * 123 + 180.0 / 123).Within(1e-5));
        That(Rad2Deg(Math.PI * 19.1 / 1.23), Is.EqualTo(180.0 * 19.1 / 1.23).Within(1e-5));
        That(Rad2Deg(Math.PI / 1.22), Is.EqualTo(180.0 / 1.22).Within(1e-5));
    }
}