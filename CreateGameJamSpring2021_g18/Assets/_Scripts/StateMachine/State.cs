﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected BattleSystem BattleSystem;

    public State(BattleSystem battleSystem)
    {
        BattleSystem = battleSystem;
    }

    public virtual IEnumerator Start()
    {
        yield break;
    }

    public virtual IEnumerator PlayCard()
    {
        yield break;
    }

    public virtual IEnumerator SetTarget()
    {
        yield break;
    }
}
