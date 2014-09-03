using System.Diagnostics;

namespace AssertStreamliner
{
	public class DebugAssertNotifier : ICodeContractViolationNotifier
	{
		#region Methods

		public void Notify(CodeContractViolationData violationData)
		{
			Debug.Assert(false, violationData.ErrorMessage);
		}

		#endregion Methods
	}
}