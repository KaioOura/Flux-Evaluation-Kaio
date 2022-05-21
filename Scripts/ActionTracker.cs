using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActionTracker : MonoBehaviour
{
    public static ActionTracker instance;

    private int attacksPerfomed;

    // Event that is called when an attack is performed. Used to send a signal with an int paramater to others observers
    public Action<int> OnAttackPerfomedEvent;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void AddAttackPerformed() // A method that is called by ThirdPersonController.OnAttackEvent()
    {
        attacksPerfomed++;

        OnAttackPerfomedEvent?.Invoke(attacksPerfomed);

        //Debug.Log($"Attacks perfomed: {attacksPerfomed}");
    }

}
