using System;

namespace AssertStreamliner
{
	public class CodeContractViolationException : Exception
	{
		#region Constructors
		
		public CodeContractViolationException(CodeContractViolationData violationData)
			: base(violationData.ErrorMessage)
		{
			this.Value = violationData.Value;
			this.Name = violationData.Name;
		}

		#endregion Constructors

		#region Properties
		
		public object Value { get; private set; }

		public string Name { get; private set; }

		#endregion Properties
	}
}