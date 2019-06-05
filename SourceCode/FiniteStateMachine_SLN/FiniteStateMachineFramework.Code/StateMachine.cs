using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FCT.FiniteStateMachineFramework.Core;


namespace FCT.FiniteStateMachineFramework.Code
{
	public class StateMachine
		: IStateMachine
	{
		private Dictionary<int, IState> m_states;

		public IState CurrentState { get; private set; }


		public StateMachine()
		{
			m_states = new Dictionary<int, IState>();
		}

		public void LoadStateMachine(IEnumerable<IState> states, IEnumerable<ITransition> transitions, int initialStateID)
		{
			if (states == null)
				throw new ArgumentNullException("states");

			if (states.Count() == 0)
				throw new ArgumentException("No states were given.");

			SortedSet<int> stateIDs = new SortedSet<int>();
			foreach(var state in states)
			{
				if (state.ID < 0)
					throw new ArgumentOutOfRangeException("State with ID less than 0 found.");
				if (stateIDs.Contains(state.ID))
					throw new ArgumentException("Multiple instances of StateID: " + state.ID + " found.");

				stateIDs.Add(state.ID);
			}

			if (!stateIDs.Contains(initialStateID))
				throw new ArgumentOutOfRangeException("initialStateID");

			bool noTransitions = (transitions == null) || (transitions.Count() == 0);

			// If no no Transitions (double negative ==> positive). 
			// -FCT
			if (!noTransitions)
			{

				SortedSet<int> transitionIDs = new SortedSet<int>();

			}
		}

		public void Reset() { }
	}
}
