using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMaster : MonoBehaviour
{
    public List<MeshRenderer> renderDebugs;

    public bool IsDebugging = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.F10))
        {
            IsDebugging = !IsDebugging;
            ChangeDebugSetting();
        }
    }

    private void ChangeDebugSetting()
    {
        foreach (MeshRenderer item in renderDebugs)
        {
            item.enabled = IsDebugging;
        }
    }
}
