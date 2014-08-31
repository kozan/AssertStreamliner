using Xunit;

namespace AssertStreamliner.UnitTests
{
	public class ExceptionNotifierTests
	{
		#region NotifyMethod

		public class NotifyMethod
		{
			#region Test methods

			[Fact]
			public void ShouldThrowCodeContractViolationException()
			{
				//Arrange
				var notifier = new ExceptionNotifier();


				//Act and assert
				Assert.Throws<CodeContractViolationException>(() => notifier.Notify(TestDataFactory.CreateViolationData()));
			}

			[Fact]
			public void ThrownExceptionShouldHaveMessageFromData()
			{
				//Arrange
				const string expectedErrorMessage = "ExpectedErrorMessage";
				var notifier = new ExceptionNotifier();
				

				//Act
				var exception = Assert.Throws<CodeContractViolationException>(() => notifier.Notify(TestDataFactory.CreateViolationData(errorMessage: expectedErrorMessage)));


				//Assert
				Assert.Equal(expectedErrorMessage, exception.Message);
			}

			[Fact]
			public void ThrownExceptionShouldHaveValueFromData()
			{
				//Arrange
				const int expectedValue = 123456;
				var notifier = new ExceptionNotifier();


				//Act
				var exception = Assert.Throws<CodeContractViolationException>(() => notifier.Notify(TestDataFactory.CreateViolationData(expectedValue)));


				//Assert
				Assert.Equal(expectedValue, exception.Value);
			}

			[Fact]
			public void ThrownExceptionShouldHaveNameFromData()
			{
				//Arrange
				const string expectedName = "VariableName";
				var notifier = new ExceptionNotifier();


				//Act
				var exception = Assert.Throws<CodeContractViolationException>(() => notifier.Notify(TestDataFactory.CreateViolationData(name: expectedName)));


				//Assert
				Assert.Equal(expectedName, exception.Name);
			}

			#endregion Test methods
		}

		#endregion NotifyMethod
	}
}