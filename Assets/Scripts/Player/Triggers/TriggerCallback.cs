
using System;
using UnityEngine;

public class TriggerCallback: MonoBehaviour {

    Action<Collider2D> enterFunctionToCall;
    Action<Collider2D> exitFunctionToCall;

	void Start () {
	
	}

	void Update () {
		
	}

    public void Init(Action<Collider2D> enter, Action<Collider2D> exit)
    {
        enterFunctionToCall = enter;
        exitFunctionToCall = exit;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enterFunctionToCall(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        exitFunctionToCall(collision);
    }
}
