﻿

namespace FCT.FiniteStateMachineFramework.Core
{
	public interface ITransition
	{
		int		ID					{ get; set; }
		string	Name				{ get; set; }
		string	Event				{ get; set; }
		string	Description			{ get; set; }
		int		SourceStateID		{ get; set; }
		int		DestinationStateID	{ get; set; }


		void OnTransition();
	}
}
