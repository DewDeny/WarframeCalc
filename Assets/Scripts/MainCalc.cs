using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCalc : MonoBehaviour
{
    public InputField ccField, cdField, scField ,d1Field;
    public InputField ccModField, cdModField, scModField, dModField;
    public float cc, cd, sc, d1;
    public float ccMod, cdMod, scMod, dMod;
    public float ccTotal, cdTotal, scTotal, dTotal;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cc = float.Parse(ccField.text);
        cd = float.Parse(cdField.text);
        sc = float.Parse(scField.text);

        ccMod = float.Parse(ccModField.text);
        cdMod = float.Parse(cdModField.text);
        scMod = float.Parse(scModField.text);

        ccTotal = cc * (100% + ccMod);
        cdTotal = cd * (100% + cdMod);
        scTotal = sc * (100% + scMod);
    }
}
