using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class C_AnimationEventExposer : MonoBehaviour {

	[SerializeField]
	private UnityEvent[] g_ClipEvents;

	/// <summary>
	/// Called from animation event.
	/// </summary>
	/// <param name="eventID">A integer that connects a animation event to unity event.Should be assigned to in animation event.</param>
	public void InvokeEvent(int eventID)
	{
		g_ClipEvents[eventID].Invoke();
	}
	
}
