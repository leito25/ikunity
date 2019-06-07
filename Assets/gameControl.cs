using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour
{

    public Animator my_animator;//objeto animador
    public GameObject my_gameCharacter;// el objeto Rbt(dentro tiene el componente transform)

    //Estados de la animación
    bool idle = true;
    bool run = false;
    bool attack = false;

    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        //Mirar a la Izquierda
        if (Input.GetButton("LeftSide"))
        {

            my_gameCharacter.transform.localScale = new Vector3(-1F, this.transform.localScale.y, this.transform.localScale.z);

        }else if (Input.GetButton("RightSide")){//mirar a la derecha

            my_gameCharacter.transform.localScale = new Vector3(1F, this.transform.localScale.y, this.transform.localScale.z);

        }

        //estados con cada botòn del mouse
        if(Input.GetMouseButtonDown(0)){
            run = !run;
            my_animator.SetBool("Run", run);

        }else if (Input.GetMouseButtonDown(1))
        {
            attack = !attack;
            my_animator.SetBool("Attack", attack);
        }

    }
}
