using System.Diagnostics;

namespace AssertStreamliner
{
	public class CodeContractViolationData
	{
		#region Constructors

		public CodeContractViolationData(object value, string name, string errorMessage)
		{
			Debug.Assert(string.IsNullOrEmpty(name), string.Format(CodeContractMessages.CannotBeNullOrEmpty, "name"));
			Debug.Assert(string.IsNullOrEmpty(errorMessage), string.Format(CodeContractMessages.CannotBeNullOrEmpty, "errorMessage"));

			this.Value = value;
			this.Name = name;
			this.ErrorMessage = errorMessage;
		}

		#endregion Constructors

		#region Properties

		public object Value { get; private set; }

		public string Name { get; private set; }

		public string ErrorMessage { get; private set; }

		#endregion Properties
	}
}