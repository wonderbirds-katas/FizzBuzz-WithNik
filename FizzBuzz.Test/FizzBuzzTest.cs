using FluentAssertions;
using Moq;

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
        var pupilMock = new Mock<IPupil>();
        var teacher = new Teacher(pupilMock.Object);
        teacher.WantsAnswers(1);
        pupilMock.Verify(p => p.Answer(), Times.Once);
        pupilMock.Verify(p => p.Praise(), Times.Once);
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
        _pupil.Answer();
        _pupil.Praise();
    }
}

public interface IPupil
{
    int Answer();
    void Praise();
}

public class Pupil : IPupil
{
    private int _count = 1;
    public int Answer()
    {
        return _count ++;
    }

    public void Praise()
    {
        
    }
}