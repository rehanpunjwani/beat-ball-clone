using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameSettingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (MenuManager.Instance != null)
            GetComponent<Text>().text = "Best Score: " + MenuManager.Instance.name + ":" + MenuManager.Instance.highScore;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
