using FluentAssertions;

namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [Fact]
    public void Test1()
    {
        var teacher = new Teacher();
        var some = teacher.PointToNextPupil();
        some.Should().Be(0);
    }
}

public class Teacher
{
    public int PointToNextPupil()
    {
        return 0;
    }
}