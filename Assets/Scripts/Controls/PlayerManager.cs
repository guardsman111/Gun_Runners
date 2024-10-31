using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private MovePlayer movePlayer;

    private List<UnitHealth> units = new List<UnitHealth>();

    void Start()
    {
        units.Add(movePlayer.GetComponent<UnitHealth>());

        foreach (UnitHealth unit in movePlayer.GetComponentsInChildren<UnitHealth>())
        {
            units.Add(unit);
            unit.SetManager(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(units.Count <= 0)
        {
            movePlayer.PlayerSpeedModifier = 0;
        }
    }

    public void KillUnit(UnitHealth unit)
    {
        if(units.Contains(unit))
        {
            units.Remove(unit);
        }
    }
}
