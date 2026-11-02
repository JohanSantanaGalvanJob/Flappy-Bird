using UnityEngine;

public class ParallaxEffect : MonoBehaviour {
    public float velocidadParallax = 0.5f;
    public Camera camara;
    public Camera camara2;
    private Vector3 posicionInicial;

    private float anchoImagen;


    void Start() {
        posicionInicial = transform.position;
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        anchoImagen = renderer.bounds.size.x;
    }
    void Update() {
        if(camara.isActiveAndEnabled) {
            float desplazamiento = camara.transform.position.x * velocidadParallax;
            transform.position = (Vector2)posicionInicial + (Vector2.right * desplazamiento);
            if (camara.transform.position.x - transform.position.x >= anchoImagen) {
                posicionInicial += Vector3.right * anchoImagen;
            } else if (transform.position.x - camara.transform.position.x >= anchoImagen) {
                posicionInicial -= Vector3.right * anchoImagen;
            }
        } else if(camara2.isActiveAndEnabled) {
            float desplazamiento = camara2.transform.position.x * velocidadParallax;
            transform.position = (Vector2)posicionInicial + (Vector2.right * desplazamiento);
            if (camara2.transform.position.x - transform.position.x >= anchoImagen) {
                posicionInicial += Vector3.right * anchoImagen;
            } else if (transform.position.x - camara2.transform.position.x >= anchoImagen) {
                posicionInicial -= Vector3.right * anchoImagen;
            }

        }
        
    }
}
