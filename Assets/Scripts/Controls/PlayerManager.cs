using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private MovePlayer movePlayer;

    private List<UnitHealth> units = new List<UnitHealth>();

    void Start()
    {
        foreach (UnitHealth unit in movePlayer.GetComponentsInChildren<UnitHealth>())
        {
            units.Add(unit);
            unit.SetManager(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void KillUnit(UnitHealth unit)
    {
        if(units.Contains(unit))
        {
            units.Remove(unit);
            Debug.Log("Unit Removed");
        }

        if (units.Count <= 0)
        {
            movePlayer.PlayerSpeedModifier = 0;
        }
    }
}
