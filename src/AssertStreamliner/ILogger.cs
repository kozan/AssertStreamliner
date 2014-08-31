namespace AssertStreamliner
{
	public interface ILogger
	{
		#region Methods

		void LogViolation(CodeContractViolationData violationData);

		#endregion Methods
	}
}