using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    public string _nome;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Executa uma vez só! Criado por: "+_nome);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: "Cada frame, eu volto! Nome: "+ _nome);
    }
}
