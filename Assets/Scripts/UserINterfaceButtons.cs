using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserINterfaceButtons : MonoBehaviour
{
        [SerializeField] SliderJoint2D VolumeSlider;

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
        GameManager.lives = 3;
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
    /*
   public void VolumeSlider()
    {
        GameManager.musicVolume;

        musicVolume = GameObject.Find("Canvas").GetComponent<AudioSource>();

        
    }
  
    public void setVolume()
    {
        musicVolume.volume = volumeSlider.value;
    }
    */

}
