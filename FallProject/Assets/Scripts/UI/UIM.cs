using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIM : MonoBehaviour
{
    private static UIM instance = null;
    //public static UIM inst { get { return instance; } }

    public GameObject Shop;
    public GameObject Stats;
    public GameObject Inventory;
    public GameObject Settings;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadWindow(GameObject Panel)
    {
        Panel.SetActive(true);
    }


    public void exitGame()
    {
        Application.Quit();
    }
}
