using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Manager_saveload : MonoBehaviour
{
    public TMPro.TextMeshProUGUI tmp;
    [HideInInspector]
    public float coins;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(coins);
        tmp.text = coins.ToString();
    }
}
