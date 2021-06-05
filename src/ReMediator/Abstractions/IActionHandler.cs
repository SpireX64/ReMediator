namespace ReMediator.Abstractions
{
	using System.Threading;
	using System.Threading.Tasks;

	public interface IActionHandler<in TAction, TResult>
		where TAction : IAction<TResult>
	{
		Task<TResult> Handle(TAction action, CancellationToken cancellationToken);
	}
}
