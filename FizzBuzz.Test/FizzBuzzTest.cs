using FluentAssertions;

namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [Fact]
    public void Test3()
    {
        var pupil = new Pupil();
        pupil.Answer().Should().Be(1);
        pupil.Answer().Should().Be(2);
        pupil.Answer();
        pupil.Answer().Should().Be(4);
    }
}

public class Pupil
{
    private int _count = 1;
    public int Answer()
    {
        
        return _count ++;
    }
}