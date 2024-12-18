using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UIElements;

public class Panels : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;

    public void Hello()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);
    }

    public void World()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(true);
    }

    public void MainMenu()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
    }

    public void ExitNo()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
    }


    //public void ExitYes()
    //{
    //    Panel1.SetActive(false);
    //    Panel2.SetActive(false);
    //}
}

