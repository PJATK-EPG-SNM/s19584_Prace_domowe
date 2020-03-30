using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Praca_domowa : MonoBehaviour{
  
     void Start() {

  int intA = 5;
  float floatie = 3;
  bool boolA = true;
  bool boolB = false;
  string strA = "Programuję w C#";
  string strB = "EPG";

   Debug.Log("intA: " + intA + " floatie: " + floatie + " boolA: " + boolA + " boolB: " + boolB + " strA: " + strA + " strB: " + strB);
      
      if (intA == floatie){
       Debug.Log = "Tak";
           } else {
       Debug.Log = "Nie";
       }

       if (intA != floatie){
       Debug.Log = "Tak"
           } else {
       Debug.Log = "Nie";
      }


       if (intA > floatie){
       Debug.Log = "Tak";
          } else {
       Debug.Log = "Nie";
      }

       if (intA >= floatie){
       Debug.Log = "Tak";
          } else {
       Debug.Log = "Nie";
      }
        
         if (intA < floatie){
       Debug.Log = "Tak";
          } else {
       Debug.Log = "Nie";
      }

       if (intA <= floatie){
       Debug.Log = "Tak";
          } else {
       Debug.Log = "Nie";
      }

    if (pierwszy.Equals(drugi))
        {
        } else {
            Debug.Log = "różne";
        }


        if ((logiczna && nie) == true)
        {
            Debug.Log = "True";
        } else if ((logiczna || nie) == false)
        {
            Debug.Log = "false";
        }



    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
