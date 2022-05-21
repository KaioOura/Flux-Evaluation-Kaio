using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI attackPerfomedTMP;
    bool alreadyDisabled = false;

    // Start is called before the first frame update
    void Start()
    {
        ActionTracker.instance.OnAttackPerfomedEvent += UpdateAttacksPerformedUI;
    }

    private void OnEnable()
    {
        if (alreadyDisabled)
            ActionTracker.instance.OnAttackPerfomedEvent += UpdateAttacksPerformedUI;
    }

    private void OnDisable()
    {
        alreadyDisabled = true;
        ActionTracker.instance.OnAttackPerfomedEvent -= UpdateAttacksPerformedUI;
    }

    public void UpdateAttacksPerformedUI(int attacks)
    {
        attackPerfomedTMP.text = $"Attacks: {attacks}";
    }
}
