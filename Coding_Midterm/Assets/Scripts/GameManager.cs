using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Variables 
    public static GameManager instance;

    private bool canstart = true;

    public TextMeshProUGUI level;

    public int lvl_num;

    private void Awake()
    {
        //A singleton must only have one instance check to make sure this is the only instance 
        //if it is make sure it is not destroyed, if its not destroy this instance.
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        level.text = "Level:" + lvl_num;
    }
    public void StartGame()
    {
        if (canstart)
        {
            SceneManager.LoadScene(1);
            canstart = false;
        }
    }
}
