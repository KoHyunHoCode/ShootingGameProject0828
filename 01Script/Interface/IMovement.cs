using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement
{
    void Move(Vector2 direction);

    void SetEnable(bool newEnable);
}
