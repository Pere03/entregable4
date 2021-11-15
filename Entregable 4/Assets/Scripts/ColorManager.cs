using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color RandomColor;
    public Vector3 RandomScale;
    public Vector3 RandomPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
  
    }

    private void OnMouseDown()
    {
        //Cambiar el color cuando se pulse encima del objeto
        RandomColor = new Color(Random.RandomRange(0f, 1f),
        Random.RandomRange(0f, 1f), Random.RandomRange(0f, 1f));

        GetComponent<MeshRenderer>().material.color = RandomColor;

        //Cambiar la escala cuando se pulse encima del objeto
        RandomScale = new Vector3(Random.RandomRange(-1f, 1f),
        Random.RandomRange(-1f, 1f), Random.RandomRange(-1f, 1f));

        transform.localScale = RandomScale;

        //Cambiar la posicion cuando se pulse encima del objeto
        RandomPosition = new Vector3(Random.RandomRange(-5f, 5f),
        Random.RandomRange(-5f, 5f));

        transform.position = RandomPosition;
       
    }
}
