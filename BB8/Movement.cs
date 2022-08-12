using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed; //Velocidade em que o esfera vai se movimentar;
    Rigidbody Rig; //Criando uma variável para o component Rigidbody
    // Start is called before the first frame update

    void Start()  // Start is called before the first frame update
    {
      Rig = GetComponent<Rigidbody>(); //Recebendo o Rigidbody da Esfera
    }

    void Update() //Deve ser usado toda vez que for trabalhar com física na Unity, economiza memo e process
    {
        //Acessar > Unity > Edit > Project Set > Input
        Vector3 Position = new Vector3(Input.GetAxisRaw("Horizontal"), 0,  Input.GetAxisRaw("Vertical")); //Variável position recebe o eixo horiz. e vert. da unity
        Rig.velocity = Position * Speed; // Vel é responsável por movimentar o personagem através do Rigidody - ele vai recever a posicao x velocidade
    }
}
