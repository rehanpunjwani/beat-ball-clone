using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public  void StartNew()
    {
        SceneManager.LoadScene(1);
    }



    public void SaveData(Text name)
    {

        MenuManager.Instance.name = name.text;
    }

}
