using UnityEngine;

public class ExpectedValue : MonoBehaviour
{
    [Header("Numero de cartas")]
    [SerializeField] private int n_As = 4;
    [SerializeField] private int n_Tres = 4, n_Rey = 4, n_Caballo = 4, n_Sota = 4, n_Siete = 4, n_Seis = 4, n_Cinco = 4, n_Cuatro = 4, n_Dos = 4;

    [Header("Valores de cartas")]
    [SerializeField] private float v_As = 11;
    [SerializeField] private float v_Tres = 10, v_Rey = 4, v_Caballo = 3, v_Sota = 2, v_Siete = 0, v_Seis = 0, v_Cinco = 0, v_Cuatro = 0, v_Dos = 0;

    void Start()
    {

    }

    public void CalcularProbabilidades()
    {
        float probabilidad = 4f / 10f;
        probabilidad = (float)System.Math.Round(probabilidad, 2);

        float esperanza_As = probabilidad * v_As;
        esperanza_As = (float)System.Math.Round(esperanza_As, 2);

        float esperanza_Tres = probabilidad * v_Tres;
        esperanza_Tres = (float)System.Math.Round(esperanza_Tres, 2);

        float esperanza_Rey = probabilidad * v_Rey;
        esperanza_Rey = (float)System.Math.Round(esperanza_Rey, 2);

        float esperanza_Caballo = probabilidad * v_Caballo;
        esperanza_Caballo = (float)System.Math.Round(esperanza_Caballo, 2);

        float esperanza_Sota = probabilidad * v_Sota;
        esperanza_Sota = (float)System.Math.Round(esperanza_Sota, 2);

        float esperanza_Siete = probabilidad * v_Siete;
        esperanza_Siete = (float)System.Math.Round(esperanza_Siete, 2);

        float esperanza_Seis = probabilidad * v_Seis;
        esperanza_Seis = (float)System.Math.Round(esperanza_Seis, 2);

        float esperanza_Cinco = probabilidad * v_Cinco;
        esperanza_Cinco = (float)System.Math.Round(esperanza_Cinco, 2);

        float esperanza_Cuatro = probabilidad * v_Cuatro;
        esperanza_Cuatro = (float)System.Math.Round(esperanza_Cuatro, 2);

        float esperanza_Dos = probabilidad * v_Dos;
        esperanza_Dos = (float)System.Math.Round(esperanza_Dos, 2);

        Debug.Log("La probabilidad de que salga cualquier carta es de " + probabilidad * 100f + "%");
        Debug.Log("La esperanza de cada carta es la siguiente:\n As: " + esperanza_As + "\nTres: " + esperanza_Tres + "\nRey: " + esperanza_Rey + "\nCaballo: " +
            esperanza_Caballo + "\nSota: " + esperanza_Sota + "\nSiete: " + esperanza_Siete + "\nSeis: " + esperanza_Seis + "\nCinco: " + esperanza_Cinco + "\nCuatro: " +
            esperanza_Cuatro + "\nDos: " + esperanza_Dos);
    }

    public void Restart()
    {
        n_As = 4;
        n_Tres = 4;
        n_Rey = 4;
        n_Caballo = 4;
        n_Sota = 4;
        n_Siete = 4;
        n_Seis = 4;
        n_Cinco = 4;
        n_Cuatro = 4;
        n_Dos = 4;
    }
}