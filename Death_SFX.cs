using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Death_SFX : MonoBehaviour
{
    public TextMeshProUGUI textogameover;

    public AudioSource muerte;
    
    public Image barrav;

    public float vidaActual;

    public float vidaMaxima;

    public float daño;

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Mori");
        muerte.Play();
        
    } */

    private void OnTriggerExit2D(Collider2D collision)
    {
            Debug.Log("sali del trigger");
            
            

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("estoy recibiendo daño");
        
        vidaActual -= daño;
        barrav.fillAmount = vidaActual / vidaMaxima;//RANGO ENTRE 0 Y 1
        if (vidaActual == 0)
        {
            muerte.Play();
            Destroy(gameObject);
            textogameover.text = "GAME OVER";
        }
        

    }


    
}
