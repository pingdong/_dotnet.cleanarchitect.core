using System;
using FluentValidation;
using PingDong.CleanArchitect.Core.Validation;
using Xunit;

namespace PingDong.CleanArchitect.Core.UnitTests
{
    public class TestObject
    {
        public TestObject(string email)
        {
            Email = email;
        }

        public string Email { get; set; }
    }

    public class TestValidator : InlineValidator<TestObject>
    {
        public TestValidator (params Action<TestValidator >[] actions)
        {
            foreach (var action in actions)
            {
                action(this);
            }
        }
    }

    public class EmailFromDomainValidatorTests
    {
        [Fact]
        public void EmailFromDomainValidator_Valid()
        {
            var validator = new TestValidator(v => v.RuleFor(obj => obj.Email).SetValidator(new EmailFromDomainValidator("xyz.com")));
            Assert.True(validator.Validate(new TestObject("abc@xyz.com")).IsValid);
        }

        [Fact]
        public void EmailFromDomainValidator_Invalid()
        {
            var validator = new TestValidator(v => v.RuleFor(obj => obj.Email).SetValidator(new EmailFromDomainValidator("xyz.com")));
            Assert.False(validator.Validate(new TestObject("abc@xy.com")).IsValid);
        }

        [Fact]
        public void EmailFromDomainValidator_NotEmail()
        {
            var validator = new TestValidator(v => v.RuleFor(obj => obj.Email).SetValidator(new EmailFromDomainValidator("xyz.com")));
            Assert.False(validator.Validate(new TestObject("abc.xyz.com")).IsValid);
        }
    }
}
