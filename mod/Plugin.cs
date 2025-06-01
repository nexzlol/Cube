using BepInEx;
using Photon.Pun;
using UnityEngine;
namespace mod
{
    [BepInPlugin("mod","mod","1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            GorillaTagger.OnPlayerSpawned(PlayerSpawned);
        }
        public void PlayerSpawned()
        {
            var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
            obj.transform.position = Camera.main.transform.position + Camera.main.transform.forward;
        }
    }
}