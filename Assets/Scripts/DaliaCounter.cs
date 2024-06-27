using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DaliaCounter : MonoBehaviour
{
    public TextMeshProUGUI x;
    public static int dCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        x.text = "Score: "+dCounter.ToString() ;

    }
    private void FixedUpdate()
    {
        dCounter++;
    }

}
