using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player_move : MonoBehaviour
{
    //Variables para almacenar las cantidades de movimiento
    public float derecha;
    public float izquierda;
    public float salto_force;

    public bool IsJumping=false; //variable que nos ayuda a saber si esta saltando el player
    private int puntuacion;
    public TextMeshProUGUI puntuacionText; //

    //rb
    Rigidbody2D rigi;
   
     
    // Start is called before the first frame update
    
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
                
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento derecha
        if(Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)){
            transform.eulerAngles = new Vector3(0, 180, 0);
            rigi.AddForce(new Vector2(derecha, 0f) *Time.deltaTime);
        }
        //movimiento derecha
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            rigi.AddForce(new Vector2(izquierda, 0f) * Time.deltaTime);
        }
        //salto del player con barra espaciadora o clic del mouse
        if (Input.GetKeyDown(KeyCode.Space)  && !IsJumping) //se verifica si presiona la barra espaciadora
        {
            rigi.AddForce(new Vector2(0f,salto_force),ForceMode2D.Impulse);

            IsJumping = true;

        }
           }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "capsula")
        {
            puntuacion += 5;
            puntuacionText.text = "Puntos: " + puntuacion.ToString();

        }
        if (collision.gameObject.tag=="Suelo") //camabia valor de variable al tocar el suelo
        {
            IsJumping = false;
        }
    }

   




}
