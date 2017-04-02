
using System;
using UnityEngine;

public class HitboxCallback : MonoBehaviour {

    public Player parentPlayer;

    Action<Collider2D> enterFunctionToCall;
    Action<Collider2D> exitFunctionToCall;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Init(Action<Collider2D> enter, Action<Collider2D> exit, Player parentPlayer)
    {
        enterFunctionToCall = enter;
        exitFunctionToCall = exit;
        this.parentPlayer = parentPlayer;
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
