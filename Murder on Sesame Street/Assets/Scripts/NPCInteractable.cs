using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    [Header("Character name")]
    public string chara;

    public void Interact()
    {
        // make text objects depending on character
        if(chara.CompareTo("Elmo") == 0)
        {
            ChatBubble.Create(transform.transform, new Vector3(-2.0f, -1.0f, -1.0f), "Hello! Elmo is sorry about Elmo's outburst yesterday. The Wilkins Coffee was just a bit too much for Elmo to handle. Elmo promises to get clean and not drink anymore of Wilkins brand coffee! Elmo also thinks that Rocco might have done it in order to steal Big Bird's spot as one of the most recognizable on Sesame Street!");
        }
        else if(chara.CompareTo("Rocco") == 0)
        {
            ChatBubble.Create(transform.transform, new Vector3(-2.0f, -1.0f, -1.0f), " ...\n(Rocco is suspicious of Elmo)");
        }
        else if(chara.CompareTo("Amy") == 0)
        {
            ChatBubble.Create(transform.transform, new Vector3(-2.0f, -1.0f, -1.0f), "Oh hi there! Rocco and I were together all last night, we didn't see anything. I'm just glad Rocco is safe after Elmo's outburst. Who knows what could have happened!");
        }
        else if(chara.CompareTo("Oscar") == 0)
        {
            ChatBubble.Create(transform.transform, new Vector3(-2.0f, -1.0f, -1.0f), "I heard a rock being thrown near my trashcan last night. That's all I know. Now leave me alone!");
        }
        else if(chara.CompareTo("TheCount") == 0)
        {
            ChatBubble.Create(transform.transform, new Vector3(-2.0f, -1.0f, -1.0f), "Ahh, hello Detective. I can help you count ze wounds on Big Bird's body! \n1 Stab wound, ah, ah, ah, \n2 Stab wounds, ah, ah, ah, \n3 Stab wounds, ah, ah, ah, \n4 Stab wounds, ah, ah, ah! \nThat is all ze stab wounds!");
        }
        else if(chara.CompareTo("CookieMonster") == 0)
        {
            ChatBubble.Create(transform.transform, new Vector3(-2.0f, -1.0f, -1.0f), "*Sigh* Look Detective, I don't know anything. Honestly, I envy Big Bird. He got out the easy way. I am stuck here for another 20 years before my contract runs out. The dental plan isn't enough to cover the amount of sugar and carbs I've been consuming on set. Look, just leave me alone alright, I won't get in your way.");
        }
        else if(chara.CompareTo("Bert") == 0)
        {
            ChatBubble.Create(transform.transform, new Vector3(-2.0f, -1.0f, -1.0f), "*As you approach Bert, you can see the remnants of tears in his eyes \n*Oh, hi detective. What can I do for you? I don't know anything about what happened to Big Bird. But that rat bird got what he deserved! I won't be silenced any longer about what happened! I... I..... \n*He breaks back down into tears*");
        }
        else
        {
            // default or unrecognized name
            ChatBubble.Create(transform.transform, new Vector3(-2.0f, -1.0f, -1.0f), "Who am I?!");
        }

        
    }
}
