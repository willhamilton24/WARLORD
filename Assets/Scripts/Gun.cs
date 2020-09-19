using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int maxAmmo;
    public int currentAmmo;
    public int reloadTime;
    public int drawTime;
    public int recoil;
    public string cartridge;
    public PlayerController wielder;

    void Awake() {
        maxAmmo = 30;
        currentAmmo = maxAmmo;
    }

    void Update() {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    void Fire() 
    {
        if(currentAmmo > 0)
        {
            // Instantiate GameObject of Type "Projectile"
            currentAmmo--;
            // Apply Recoil
            Debug.Log("Bullet Fired!");
        }
        else 
        {
            Debug.Log("Weapon Empty");
        }
    }

    void Reload() {
        // Reduce Player Ammo Pool
        // Wait Reload Time
        currentAmmo = maxAmmo;
    }

    void Draw() {
        // Wait Draw Time
        // Draw
    }
}
