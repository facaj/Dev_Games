using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour {
    //[SerializeField]
    public int x, y;
    //[SerializeField]
    public int z;
    
    public void salva()
    {
        PlayerPrefs.SetInt("valorX", x);
        PlayerPrefs.SetInt("valorY", y);
        PlayerPrefs.SetInt("valorZ", z);
        PlayerPrefs.Save();
    }
    public void carrega()
    {
        if (PlayerPrefs.HasKey("valorX"))
        {
            x = PlayerPrefs.GetInt("valorX");
        }
        y = PlayerPrefs.GetInt("valorY");
        z = PlayerPrefs.GetInt("valorZ");
    }
    

    

}
