using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class PluginTester : MonoBehaviour
{
    [DllImport("MidtermDLL")]
    private static extern float Randomize(float min, float max);

    public List<GameObject> platforms;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < platforms.Count; ++i)
        {
            platforms[i].transform.localScale = new Vector3(Randomize(2.0f, 4.0f), Randomize(2.0f, 4.0f), Randomize(2.0f, 3.0f));
        }
    }
}
