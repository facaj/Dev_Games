using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Importar
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class load : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
       
        DadosQueQueroSalvar2 posicao;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/JogoSAlvo.gd", FileMode.Open);
        posicao = (DadosQueQueroSalvar2)bf.Deserialize(file);
        file.Close();
        print(Application.persistentDataPath);
        collision.transform.SetPositionAndRotation(new Vector3(posicao.x,posicao.y,posicao.z),collision.transform.rotation);

            //TransformVector(posicao.x, posicao.y, posicao.z);
        print(collision.transform.position.x);
        print(posicao.x);
        print("Carregou");
    }
}
