using System;
using Xunit;
using AutoFixture;

namespace CustomSpecimenBuilder.Tests
{
    public class AnnotationsDemos
    {
        [Fact]
        public void BasicString()
        {
            // arrange
            var fixture = new Fixture();

            var player = fixture.Create<PlayerCharacter>();


            // act and assert phases...
        }
    }
}
