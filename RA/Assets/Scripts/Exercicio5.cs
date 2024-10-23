using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    public float _velocidade;
    private GameObject rodaA;
    private GameObject rodaB;
    private GameObject rodaC;
    private GameObject rodaD;
    // Start is called before the first frame update
    void Start()
    {
        rodaA = transform.Find(n:"RodaA").gameObject;
        rodaB = transform.Find(n:"RodaB").gameObject;
        rodaC = transform.Find(n:"RodaC").gameObject;
        rodaD = transform.Find(n:"RodaD").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            this.transform.Translate(0,0,_velocidade*Time.deltaTime);
            
            rodaA.transform.Rotate(xAngle: _velocidade,yAngle: 0,zAngle: 0);
            rodaB.transform.Rotate(xAngle: _velocidade,yAngle: 0,zAngle: 0);
            rodaC.transform.Rotate(xAngle: _velocidade,yAngle: 0,zAngle: 0);
            rodaD.transform.Rotate(xAngle: _velocidade,yAngle: 0,zAngle: 0);
        }
        if(Input.GetKey("s")){
            this.transform.Translate(0,0,-_velocidade*Time.deltaTime);
            
            rodaA.transform.Rotate(xAngle: -_velocidade,yAngle: 0,zAngle: 0);
            rodaB.transform.Rotate(xAngle: -_velocidade,yAngle: 0,zAngle: 0);
            rodaC.transform.Rotate(xAngle: -_velocidade,yAngle: 0,zAngle: 0);
            rodaD.transform.Rotate(xAngle: -_velocidade,yAngle: 0,zAngle: 0);
        }
        if(Input.GetKey("a")){
            this.transform.Translate(-_velocidade*Time.deltaTime,0,0);
            
            rodaA.transform.Rotate(xAngle: 0,yAngle: 0,zAngle: _velocidade);
            rodaB.transform.Rotate(xAngle: 0,yAngle: 0,zAngle: _velocidade);
            rodaC.transform.Rotate(xAngle: 0,yAngle: 0,zAngle: _velocidade);
            rodaD.transform.Rotate(xAngle: 0,yAngle: 0,zAngle: _velocidade);
        }
        if(Input.GetKey("d")){
            this.transform.Translate(_velocidade*Time.deltaTime,0,0);
            
            rodaA.transform.Rotate(xAngle: 0,yAngle: 0,zAngle: -_velocidade);
            rodaB.transform.Rotate(xAngle: 0,yAngle: 0,zAngle: -_velocidade);
            rodaC.transform.Rotate(xAngle: 0,yAngle: 0,zAngle: -_velocidade);
            rodaD.transform.Rotate(xAngle: 0,yAngle: 0,zAngle: -_velocidade);
        }
        if(Input.GetKeyDown(name: "space")){
            Debug.Log("teste");
            this.GetComponent<Rigidbody>().AddForce(force: Vector3.up *900f);
        }
    }
}
