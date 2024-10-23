using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
    public float _movimento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(name: "w")){
            this.transform.Translate(x:0,0,_movimento);
        }
        if(Input.GetKeyUp("s")){
            this.transform.Translate(0,0,-_movimento);
        }
        if(Input.GetKey("a")){
            this.transform.Translate(-_movimento,0,0);
        }
        if(Input.GetKeyDown("d")){
            this.transform.Translate(_movimento,0,0);
        }
    }
}
