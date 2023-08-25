using FluentAssertions;

namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [Fact]
    public void Test1()
    {
        var teacher = new Teacher();
        var pupil = teacher.InquirePupil();
        pupil.Should().Be(1);
    }
}

public class Teacher
{
    public int InquirePupil()
    {
        return 1;
    }
}