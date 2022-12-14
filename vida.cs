using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class vida : MonoBehaviour
{
    // Start is called before the first frame update
    public int VidaPlayer;

 
    public Slider vidaVisual;

   

    // Update is called once per frame
    void Update()
    {

        vidaVisual.GetComponent<Slider>().value = VidaPlayer;


 
        if(VidaPlayer <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }


   


}
