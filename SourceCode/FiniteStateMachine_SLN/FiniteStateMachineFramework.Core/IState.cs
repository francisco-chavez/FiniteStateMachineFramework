

namespace FiniteStateMachineFramework.Core
{
	public interface IState
	{
		int		ID				{ get; set; }
		string	Name			{ get; set; }
		string	Description		{ get; set; }
		bool	ExecuteOnLoop	{ get; set; }


		void OnEnter(bool wasLoop = false);
		void OnExit(bool isLoop = false);
	}
}
