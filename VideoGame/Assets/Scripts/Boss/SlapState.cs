using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlapState : State
{
    public StabState stabState;
    public bool slapdone = false;

    public GameObject me1;
    public GameObject me2;

    public void slap()
    {
        int randomValue = Random.Range(1,2);

        if (randomValue == 1)
        {
            me1.SetActive(true);
            slapdone = true;
        }
        else if (randomValue == 2)
        {
            me2.SetActive(true);
            slapdone = true;
        }
    }

    //Can't use ienumerator? waitforseconds bruh 

    public override State RunCurrentState()
    {
        slap();
        if (slapdone)
        {
            return stabState;
        }
        else
        {
            return this;
        }
    }
}
