using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserINterfaceButtons : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGameScene()
    {

        SceneManager.LoadScene(1);
    }

    public void LoadStartMenu()
    {

        SceneManager.LoadScene(0);
    }

    public void LoadOptionsMenu()
    {

        SceneManager.LoadScene(2);

    }

    public void LoadAboutMenu()
    {

        SceneManager.LoadScene(3);
    }
}
