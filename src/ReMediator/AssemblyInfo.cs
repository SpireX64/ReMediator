using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ReMediator.UnitTests")]

namespace ReMediator
{
	using System.Reflection;

	internal static class AssemblyInfo
	{
		internal static Assembly GetAssembly() =>
			Assembly.GetAssembly(typeof(AssemblyInfo)) ?? Assembly.GetExecutingAssembly();
	}
}
