using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiniJeu : MonoBehaviour
{
    public float pointageTemps;

    public TextMeshProUGUI Text;

    void Start()
    {
        pointageTemps = 0;
    }


    private void Update()
    {

        Text.text = pointageTemps;

    }
}
