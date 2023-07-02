using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedJoystick : Joystick
{
    public static implicit operator FixedJoystick(Vector2 v)
    {
        throw new NotImplementedException();
    }
}