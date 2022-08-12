// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class Sphere : SceneEntity
{
    [SerializeField] private Vector3 center;
    [SerializeField] private float radius;
    
    public Vector3 Center => this.center;
    public float Radius => this.radius;
    
    public override RaycastHit? Intersect(Ray ray)
    {
        // By default we use the Unity engine for ray-entity collisions.
        // See the parent 'SceneEntity' class definition for details.
        // Task: Replace with your own intersection computations.
        // return base.Intersect(ray);

        
    }
}
