using UnityEngine;

public class Bolumkecid : MonoBehaviour
{
    public GameObject bolum1;
    public GameObject bolum2;
    public GameObject bolum3;
    public GameObject bolum4;

    void Start()
    {
        bolum1.SetActive(true);
        bolum2.SetActive(false);
        bolum3.SetActive(false);
        bolum4.SetActive(false);
    }


    public void bolum1fun()
    {
        bolum1.SetActive(true);
        bolum2.SetActive(false);
        bolum3.SetActive(false);
        bolum4.SetActive(false);
    }

    public void bolum2fun()
    {
        bolum1.SetActive(false);
        bolum2.SetActive(true);
        bolum3.SetActive(false);
        bolum4.SetActive(false);
    }

    public void bolum3fun()
    {
        bolum1.SetActive(false);
        bolum2.SetActive(false);
        bolum3.SetActive(true);
        bolum4.SetActive(false);
    }

    public void bolum4fun()
    {
        bolum1.SetActive(false);
        bolum2.SetActive(false);
        bolum3.SetActive(false);
        bolum4.SetActive(true);
    }
}
