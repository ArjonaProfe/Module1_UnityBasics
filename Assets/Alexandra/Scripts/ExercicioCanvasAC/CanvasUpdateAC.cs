using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //tenemos acceso a un tipo de variable que es text.
                            //Es una librer�a. Y nos dar� error Text public si no lo ponemos

public class CanvasUpdateAC : MonoBehaviour
{
    public Text score;
    public int scorepoints;     //har� que convertir� un n�mero entero a scorepoints para cadenas de texto. Pasarlo de string a text y de text a string.
                                //string y text es como lo de decimal y entero y poderlos imprimirlos en pantalla
                                //ahora iremos al script del cubo
    public void ScoreUpdate()      //actualizar la puntuaci�n. Coid es nulo que est� vac�a.
    {

        scorepoints = scorepoints +1;
        score.text = scorepoints.ToString();

    }
}
