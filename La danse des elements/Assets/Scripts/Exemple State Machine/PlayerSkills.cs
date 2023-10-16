using KinematicCharacterController.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    public ExamplePlayer examplePlayer;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            switch (examplePlayer.currentElement) 
            {
                case 1:
                    NormalAttackFire();
                    break;
                case 2:
                    NormalAttackEarth();
                    break;
                case 3:
                    NormalAttackWind();
                    break;
                case 4:
                    NormalAttackWater();
                    break;
            }
        }
    }
    public void NormalAttackFire()
    {
        print("attaque de feu");
    }
    public void NormalAttackWater()
    {
        print("attaque d'eau");
    }
    public void NormalAttackEarth()
    {
        print("attaque de terre");
    }
    public void NormalAttackWind()
    {
        print("attaque de vent");
    }
}
