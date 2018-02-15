using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //Definimos las cosas a usar
    Animator animator;

	// Use this for initialization
	void Start () {
        //Obtenemos el uso, en este caso un animador
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Entradas de teclado
        if (Input.GetKeyDown(KeyCode.D)) {
            //Indicamos que es lo que vamos a cambiar
            animator.SetBool("isWalk", true);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.D)){
            animator.SetBool("isWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.A)){
            //Indicamos que es loq ue vamos a cambiar
            animator.SetBool("isWalk", true);
            //Indicamos que al ir a otro lado se va a girar
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyUp(KeyCode.A)){
            animator.SetBool("isWalk", false);
        }
    }
}
