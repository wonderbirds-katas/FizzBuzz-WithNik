using FluentAssertions;

namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [Fact]
    public void Test3()
    {
        var teacher = new Teacher();
        teacher.InquirePupil().Should().Be(1);
        teacher.InquirePupil().Should().Be(2);
        teacher.InquirePupil();
        teacher.InquirePupil().Should().Be(4);
    }
}

public class Teacher
{
    private int _count = 1;
    public int InquirePupil()
    {
        
        return _count ++;
    }
}