using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera camara;
    public Camera camara2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            if (camara.isActiveAndEnabled) {
                camara.gameObject.SetActive(false);
                camara2.gameObject.SetActive(true);
            } else if (camara2.isActiveAndEnabled) {
                camara2.gameObject.SetActive(false);
                camara.gameObject.SetActive(true);
            }
        }
    }
}
