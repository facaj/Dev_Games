using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Importar
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class savepoint : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        DadosQueQueroSalvar2 prasalvar = new DadosQueQueroSalvar2();
        prasalvar.x = collision.transform.position.x;
        prasalvar.y = collision.transform.position.y;
        prasalvar.z = collision.transform.position.z;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/JogoSAlvo.gd");
        bf.Serialize(file, prasalvar);
        file.Close();
        print("Salvei");
    }
}

[System.Serializable]
public class DadosQueQueroSalvar2
{
   
    public float x;
    public float y;
    public float z;

}
