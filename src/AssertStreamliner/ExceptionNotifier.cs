using System.Diagnostics;

namespace AssertStreamliner
{
	public class ExceptionNotifier : ICodeContractViolationNotifier
	{
		#region Methods
		
		public void Notify(CodeContractViolationData violationData)
		{
			Debug.Assert(violationData != null, string.Format(CodeContractMessages.CannotBeNull, "violationData"));

			throw new CodeContractViolationException(violationData);
		}

		#endregion Methods
	}
}