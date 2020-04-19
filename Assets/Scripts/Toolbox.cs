﻿// using System;
// using System.Collections.Generic;
// using UnityEngine;
 
// public class Toolbox : Singleton<Toolbox>
// {
//     // Used to track any global components added at runtime.

//      private PlayerData m_PlayerData = new PlayerData(); //this creates a new instance of PlayerData

//     private Dictionary<string, Component> m_Components = new Dictionary<string, Component>();

//     public static object Instance { get; internal set; }


//     // Prevent constructor use.
//     protected Toolbox() { }
 
 
//     private void Awake()
//     {
//         // Put initialization code here.
//     }
 
 
//     // Define all required global components here. These are hard-codded components
//     // that will always be added. Unlike the optional components added at runtime.
 
 
//     // The methods below allow us to add global components at runtime.
//     // TODO: Convert from string IDs to component types.
//     public Component AddGlobalComponent(string componentID, Type component)
//     {
//         if (m_Components.ContainsKey(componentID))
//         {
//             Debug.LogWarning("[Toolbox] Global component ID \""
//                 +componentID + "\" already exist! Returning that." );
//             return GetGlobalComponent(componentID);
//         }
 
//         var newComponent = gameObject.AddComponent(component);
//         m_Components.Add(componentID, newComponent);
//         return newComponent;
//     }
 
 
//     public void RemoveGlobalComponent(string componentID)
//     {
//         Component component;
 
//         if (m_Components.TryGetValue(componentID, out component))
//         {
//             Destroy(component);
//             m_Components.Remove(componentID);
//         }
//         else
//         {
//             Debug.LogWarning("[Toolbox] Trying to remove nonexistent component ID \""
//                 + componentID + "\"! Typo?");
//         }
//     }
 
 
//     public Component GetGlobalComponent(string componentID)
//     {
//         Component component;
 
//         if (m_Components.TryGetValue(componentID, out component))
//         {
//             return component;
//         }
 
//         Debug.LogWarning("[Toolbox] Global component ID \""
//     + componentID + "\" doesn't exist! Typo?");
//         return null;
//     }
//      public PlayerData GetPlayerData(){
//         return m_PlayerData;
//     }

//      void Update()
//     {
//         //Add & Get a Global Component
//         var playerData =Toolbox.Instance.GetGlobalComponent("PlayerData", PlayerData);
//         Debug.Log(playerData.CurrentLevel);
//     }
// }
