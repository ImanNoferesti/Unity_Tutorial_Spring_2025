using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<GameObject> DeActivatedObjs = new List<GameObject>();
    public List<GameObject> DeActivatedObjs2 = new List<GameObject>();

    public AudioClip[] audioClips;

    [HideInInspector] public bool StarHit;
    [HideInInspector] public bool CheckPointHit;

}
