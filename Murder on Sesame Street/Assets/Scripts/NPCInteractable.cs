using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    public void Interact()
    {
        //ChatBubble.Create(transform.transform, new Vector3(-.3f, 1.7f, 0f), "Simp boi");
        ChatBubble.Create(transform.transform, new Vector3(-2.0f, -1.0f, -1.0f), "Simp boi");
    }
}
