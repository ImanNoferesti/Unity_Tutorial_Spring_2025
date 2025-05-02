using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    public List<GameObject> DeactivatedObjs = new List<GameObject>();

    public List<GameObject> DeactivatedObjs2 = new List<GameObject>();

    public AudioClip[] audioClips;

    [HideInInspector]public bool StarHit;
    [HideInInspector]public bool CheckpointHit;
}
