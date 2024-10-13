using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public int speed = 20;
    public GameManager gameManager;
    public AudioClip choque;
    // Start is called before the first frame update
    void Start()
    {
        //impulso inicial
        GetComponent<Rigidbody2D>().velocity =
            Vector2.right * speed;
    }

    float reboteY(Vector2 bolaPos, Vector2 raquetaPos,
 float alturaRaqueta)
    {
        // || 1 <- parte superior de la raqueta
        // ||
        // || 0 <- parte media de la raqueta
        // ||
        // || -1 <- parte inferior de la raqueta
        return (bolaPos.y - raquetaPos.y) / alturaRaqueta;

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //col es el objecto que recibe la colisión de la pelota
        if (col.gameObject.name == "paloIzq")
        {
            // Calculamos la dirección de rebote
            float y = reboteY(
            transform.position,//posicion de la pelota
            col.transform.position, //posicion de la raqueta
            col.collider.bounds.size.y);//tamaño de la raqueta
                                        // Calculamos la dirección, lo normalizamos para que el tamaño
                                        //del vector sea 1al chocar con la raqueta izda
                                        //la dirección x será 1 (hacia la derecha)
            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;

            AudioSource.PlayClipAtPoint(choque, transform.position);
        }
        // golpea la raqueta derecha
        if (col.gameObject.name == "paloDer")
        {
            // Calculate hit Factor
            float y = reboteY(transform.position,
            col.transform.position,
           col.collider.bounds.size.y);
            // en este caso se mueve hacia la izda (x=-1)
            Vector2 dir = new Vector2(-1, y).normalized;
            // se aplica la velocidad
            GetComponent<Rigidbody2D>().velocity = dir * speed;

            AudioSource.PlayClipAtPoint(choque, transform.position);
        }

        if(col.gameObject.name == "MuroIzq")
        {
            gameManager.PuntosJugador2();
        }

        if(col.gameObject.name == "MuroDer")
        {
            gameManager.PuntosJugador1();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
