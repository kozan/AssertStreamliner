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
				Assert.Throws<CodeContractViolationException>(() => notifier.Notify(ExceptionNotifierTests.GetViolationData()));
			}

			[Fact]
			public void ThrownExceptionShouldHaveMessageFromData()
			{
				//Arrange
				const string expectedErrorMessage = "ExpectedErrorMessage";
				var notifier = new ExceptionNotifier();
				

				//Act
				var exception = Assert.Throws<CodeContractViolationException>(() => notifier.Notify(ExceptionNotifierTests.GetViolationData(errorMessage: expectedErrorMessage)));


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
				var exception = Assert.Throws<CodeContractViolationException>(() => notifier.Notify(ExceptionNotifierTests.GetViolationData(expectedValue)));


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
				var exception = Assert.Throws<CodeContractViolationException>(() => notifier.Notify(ExceptionNotifierTests.GetViolationData(name: expectedName)));


				//Assert
				Assert.Equal(expectedName, exception.Name);
			}

			#endregion Test methods
		}

		#endregion NotifyMethod

		#region Helpers

		private static CodeContractViolationData GetViolationData(object value = null, string name = "Name", string errorMessage = "ErrorMessage")
		{
			return new CodeContractViolationData(value, name, errorMessage);
		}


		#endregion Helpers

	}
}