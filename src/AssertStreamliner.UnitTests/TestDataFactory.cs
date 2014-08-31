namespace AssertStreamliner.UnitTests
{
	public static class TestDataFactory
	{
		#region Methods

		public static CodeContractViolationData CreateViolationData(object value = null, string name = "Name", string errorMessage = "ErrorMessage")
		{
			return new CodeContractViolationData(value, name, errorMessage);
		}

		#endregion Methods
	}
}