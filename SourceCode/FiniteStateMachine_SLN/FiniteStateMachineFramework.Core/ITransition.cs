

namespace FCT.FiniteStateMachineFramework.Core
{
	public interface ITransition
	{
		int		ID					{ get; set; }
		string	Name				{ get; set; }
		string	Event				{ get; set; }
		string	Description			{ get; set; }
		IState	SourceState			{ get; set; }
		IState	DestinationState	{ get; set; }


		void OnTransition();
	}
}
