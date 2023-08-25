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

    [Fact]
    public void Test4()
    {
        var teacher = new Teacher(new Pupil());
        teacher.WantsAnswers(1);
    }
}

public class Teacher
{
    private readonly IPupil _pupil;

    public Teacher(IPupil pupil)
    {
        _pupil = pupil;
    }

    public void WantsAnswers(int numberOfAnswers)
    {
        // _pupil.Answer();
    }
}

public interface IPupil
{
    int Answer();
}

public class Pupil : IPupil
{
    private int _count = 1;
    public int Answer()
    {
        return _count ++;
    }
}