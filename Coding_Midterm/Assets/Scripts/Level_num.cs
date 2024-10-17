using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level_num : MonoBehaviour
{
    //Variables 
    public TextMeshProUGUI level;

    public int lvl_num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        level.text = "Level: " + lvl_num;
    }
}
