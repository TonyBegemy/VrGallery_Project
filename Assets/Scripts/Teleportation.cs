using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class Teleportation : MonoBehaviour
{
    public GameObject TP01;
    public GameObject TP02;
    public GameObject TP03;

    private Vector3 TP01Location;
    private Vector3 TP02Location;
    private Vector3 TP03Location;

    void Start()
    {
        TP01Location = TP01.transform.position;
        TP02Location = TP02.transform.position;
        TP03Location = TP03.transform.position;
    }

    public void TeleportToTP01()
    {
        Debug.Log("Teleportt Gallery");
        TeleportPlayer(TP01Location);
    }

    public void TeleportToTP02()
    {
        Debug.Log("Teleportt nefertiti");
        TeleportPlayer(TP02Location);
    }

    public void TeleportToTP03()
    {
        Debug.Log("Teleportt sculptures");
        TeleportPlayer(TP03Location);
    }

    private void TeleportPlayer(Vector3 location)
    {
        transform.position = location;
        Debug.Log(location + " Teleportt!!");
    }
}
