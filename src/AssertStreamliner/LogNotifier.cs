using System;
using System.Diagnostics;

namespace AssertStreamliner
{
	public class LogNotifier : ICodeContractViolationNotifier
	{
		#region Fields

		private readonly ILogger _logger;

		#endregion Fields

		#region Constructors

		public LogNotifier(ILogger logger)
		{
			if (logger == null) throw new ArgumentNullException("logger");

			this._logger = logger;
		}

		#endregion Constructors

		#region Methods

		public void Notify(CodeContractViolationData violationData)
		{
			Debug.Assert(violationData != null, string.Format(CodeContractMessages.CannotBeNull, "violationData"));

			this._logger.LogViolation(violationData);
		}

		#endregion Methods
	}
}