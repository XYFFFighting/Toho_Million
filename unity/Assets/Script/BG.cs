using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public Texture backGround;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backGround);
        if (GUI.Button(new Rect(Screen.width / 2 - 100f, Screen.height / 2 - 30f, 200f, 60f), "Start Game"))
        {
            Application.LoadLevel(2);
        }
    }
}

