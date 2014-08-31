using System;
using FakeItEasy;
using Xunit;

namespace AssertStreamliner.UnitTests
{
	public class LogNotifierTests
	{
		#region Constructor

		public class Constructor
		{
			#region Test methods

			[Fact]
			public void IfNullLoggerThenShouldThrowArgumentNullExceptionWithProperParameterName()
			{
				//Arrange
				ILogger logger = null;
				

				//Act and assert
				var exception = Assert.Throws<ArgumentNullException>(() => new LogNotifier(logger));
				Assert.Equal("logger", exception.ParamName);
			}

			#endregion Test methods
		}

		#endregion Constructor

		#region NotifyMethod

		public class NotifyMethod
		{
			#region Test methods

			[Fact]
			public void ShouldExecuteLogginOnCustomLoggerWithData()
			{
				//Arrange
				var fakeLogger = A.Fake<ILogger>();
				var notifier = new LogNotifier(fakeLogger);
				var violationData = new CodeContractViolationData(null, "a", "a");


				//Act
				notifier.Notify(violationData);


				//Assert
				A.CallTo(() => fakeLogger.LogViolation(violationData)).MustHaveHappened();
			}

			[Fact]
			public void ShouldExecuteLoggingOnCustomLoggerOnlyOnce()
			{
				//Arrange
				var fakeLogger = A.Fake<ILogger>();
				var notifier = new LogNotifier(fakeLogger);
				var violationData = new CodeContractViolationData(null, "a", "a");


				//Act
				notifier.Notify(violationData);


				//Assert
				A.CallTo(() => fakeLogger.LogViolation(null)).WithAnyArguments().MustHaveHappened(Repeated.Exactly.Once);
			}

			#endregion Test methods
		}
		
		#endregion NotifyMethod
	}
}