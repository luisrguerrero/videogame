using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // libreria para usar el elemento textmeshpro
public class timer : MonoBehaviour
{
    public AudioSource muerte;
    public float tiempo;
    public TextMeshProUGUI textoTimer;
    public TextMeshProUGUI textogameover;
    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        textoTimer.text = "" + tiempo.ToString("f0");
       
        if (tiempo < 0)
        {
            textogameover.text = "GAME OVER";
            muerte.Play();
            Destroy(gameObject);
        }
    }

}
