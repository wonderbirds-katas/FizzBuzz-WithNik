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

    [Fact]
    public void Test5()
    {
        var pupilMock = new Mock<IPupil>();
        var teacher = new Teacher(pupilMock.Object);
        teacher.WantsAnswers(2);
        pupilMock.Verify(p => p.Answer(), Times.Exactly(2));
        pupilMock.Verify(p => p.Praise(), Times.Exactly(2));
    }

    [Fact]
    public void Test6()
    {
        var pupilMock = new Mock<IPupil>();
        var teacher = new Teacher(pupilMock.Object);
        teacher.WantsAnswers(3);
        pupilMock.Verify(p => p.Answer(), Times.Exactly(3));
        pupilMock.Verify(p => p.Praise(), Times.Exactly(3));
    }
    [Theory]
    [InlineData(2,2)]
    public void Test7(int numberOfAnswers, int expectedPraises)
    {
        var pupilMock = new Mock<IPupil>();
        var teacher = new Teacher(pupilMock.Object);
        teacher.WantsAnswers(numberOfAnswers);
        pupilMock.Verify(p => p.Answer(), Times.Exactly(expectedPraises));
        pupilMock.Verify(p => p.Praise(), Times.Exactly(expectedPraises));
    }
    // Hemingway
    // Give the Teacher a mockPupil which returns 1,2,3 -> Expect 2 Praises
    // Give the Teacher a mockPupil which returns 1,2,fizz -> Expect 3 Praises
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
        for (var counter = 0; counter < numberOfAnswers; counter++)
        {
            _pupil.Answer();
            _pupil.Praise();
        }
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