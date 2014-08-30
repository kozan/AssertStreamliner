namespace AssertStreamliner
{
	public interface ICodeContractViolationNotifier
	{
		#region Methods
		
		void Notify(CodeContractViolationData violationData);
		
		#endregion Methods
	}
}