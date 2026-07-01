using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static DoorManager ManageDoor;
    public bool doorAlreadyOpened = false;

    private void Awake()
    {
        ManageDoor = this;
    }
}