using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviourClass
{
    private PlayerView playerView;

    private void SetDependencies()
    {
        playerView = SetView<PlayerView>();
    }
    
}
