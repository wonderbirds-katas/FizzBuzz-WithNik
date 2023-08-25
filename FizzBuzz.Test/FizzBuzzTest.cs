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
    
    [Fact]
    public void Test2()
    {
        var teacher = new Teacher();
        teacher.InquirePupil();
        var pupil = teacher.InquirePupil();
        pupil.Should().Be(2);
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