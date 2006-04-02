using System;

namespace BLToolkit.DataAccess
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class ActionSprocNameAttribute : Attribute
	{
		public ActionSprocNameAttribute(string actionName, string procedureName)
		{
			_actionName    = actionName;
			_procedureName = procedureName;
		}

		private string _actionName;
		public  string  ActionName
		{
			get { return _actionName; }
		}

		private string _procedureName;
		public  string  ProcedureName
		{
			get { return _procedureName; }
		}
	}
}