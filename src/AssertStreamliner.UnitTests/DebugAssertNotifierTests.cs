using System.Diagnostics;
using System.Linq;
using Xunit;

namespace AssertStreamliner.UnitTests
{
	public class DebugAssertNotifierTests
	{
		#region NotifyMethod

		public class NotifyMethod
		{
			#region Test methods

			[Fact]
			public void ShouldExecuteDebugAssertWithErrorMessage()
			{
				//Arrange
				var copyOfListners = Debug.Listeners.Cast<TraceListener>().ToArray();
				Debug.Listeners.Clear();
				var testListener = new TestTraceListner();
				Debug.Listeners.Add(testListener);

				const string expectedErrorMessage = "DebugAssertErrorMessage";
				var notifier = new DebugAssertNotifier();


				//Act
				notifier.Notify(TestDataFactory.CreateViolationData(errorMessage: expectedErrorMessage));


				//Assert
				Debug.Listeners.Clear();
				Debug.Listeners.AddRange(copyOfListners);
				
				Assert.Equal(expectedErrorMessage, testListener.LastMessage);
			}

			#endregion Test methods
		}

		#endregion NotifyMethod
	}
}