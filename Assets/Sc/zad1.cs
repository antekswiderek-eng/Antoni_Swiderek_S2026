using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad1 : MonoBehaviour
{
    public List<GameObject> obiekty = new List<GameObject>();    
    public int i;

    public Gradient gr;
    public int devide;
    public float angle;

    void Start()
    {
        
    }

    void SortObj()
    {
        foreach (GameObject go in obiekty)
        {
            if (go.GetComponent<SpriteRenderer>() != null)
            {
                sprite(go.GetComponent<SpriteRenderer>());
                //Debug.Log(go.name + " 2D");
            }
            else if(go.GetComponent<MeshRenderer>() != null)
            {
                Cube(go.transform);
                //Debug.Log(go.name + " 3D");
            }
        }
    }

    void sprite(SpriteRenderer sprite)
    {
        sprite.color = gr.Evaluate(sprite.gameObject.transform.position.y / devide);
    }

    void Cube(Transform tran){
        
        tran.Rotate(angle, 0, 0);
        tran.position = new Vector3(tran.position.x,tran.position.y +1 * Time.deltaTime,0);
    }

    // Update is called once per frame
    void Update()
    {
        SortObj();
    }
}
