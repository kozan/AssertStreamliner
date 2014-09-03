using System.Diagnostics;

namespace AssertStreamliner.UnitTests
{
	public class TestTraceListner : TraceListener
	{
		#region Properties

		/// <summary>
		/// Gets or sets the last message delivered to this instance via <see cref="Fail"/> methods
		/// </summary>
		public string LastMessage { get; private set; }

		#endregion Properties

		#region Methods

		/// <summary>
		/// Emits an error message to the listener you create when you implement the <see cref="T:System.Diagnostics.TraceListener"/> class.
		/// </summary>
		/// <param name="message">A message to emit.</param>
		public override void Fail(string message)
		{
			this.LastMessage = message;
		}

		/// <summary>
		/// When overridden in a derived class, writes the specified message to the listener you create in the derived class.
		/// </summary>
		/// <param name="message">A message to write.</param>
		public override void Write(string message)
		{
			
		}

		/// <summary>
		/// When overridden in a derived class, writes a message to the listener you create in the derived class, followed by a line terminator.
		/// </summary>
		/// <param name="message">A message to write.</param>
		public override void WriteLine(string message)
		{
			
		}

		#endregion Methods
	}
}