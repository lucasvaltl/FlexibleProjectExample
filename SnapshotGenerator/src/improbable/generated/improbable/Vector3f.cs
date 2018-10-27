// Generated by SpatialOS codegen. DO NOT EDIT!
// source: improbable.Vector3f in improbable/vector3.schema.

namespace Improbable
{

public partial struct Vector3f : global::System.IEquatable<Vector3f>, global::Improbable.Collections.IDeepCopyable<Vector3f>
{
  /// <summary>
  /// Field x = 1.
  /// </summary>
  public float x;
  /// <summary>
  /// Field y = 2.
  /// </summary>
  public float y;
  /// <summary>
  /// Field z = 3.
  /// </summary>
  public float z;

  public Vector3f(
      float x,
      float y,
      float z)
  {
    this.x = x;
    this.y = y;
    this.z = z;
  }

  public static Vector3f Create()
  {
    var _result = new Vector3f();
    return _result;
  }

  public Vector3f DeepCopy()
  {
    var _result = new Vector3f();
    _result.x = x;
    _result.y = y;
    _result.z = z;
    return _result;

  }

  public override bool Equals(object _obj)
  {
    return _obj is Vector3f && Equals((Vector3f) _obj);
  }

  public static bool operator==(Vector3f a, Vector3f b)
  {
    return a.Equals(b);
  }

  public static bool operator!=(Vector3f a, Vector3f b)
  {
    return !a.Equals(b);
  }

  public bool Equals(Vector3f _obj)
  {
    return
        x == _obj.x &&
        y == _obj.y &&
        z == _obj.z;
  }

  public override int GetHashCode()
  {
    int _result = 1327;
    _result = (_result * 977) + x.GetHashCode();
    _result = (_result * 977) + y.GetHashCode();
    _result = (_result * 977) + z.GetHashCode();
    return _result;
  }
}

public static class Vector3f_Internal
{
  public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                  Vector3f _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
  {
    {
      global::Improbable.Worker.Internal.Pbio.AddFloat(_obj, 1, _data.x);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddFloat(_obj, 2, _data.y);
    }
    {
      global::Improbable.Worker.Internal.Pbio.AddFloat(_obj, 3, _data.z);
    }
  }

  public static unsafe Vector3f Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
  {
    Vector3f _data;
    {
      _data.x = global::Improbable.Worker.Internal.Pbio.GetFloat(_obj, 1);
    }
    {
      _data.y = global::Improbable.Worker.Internal.Pbio.GetFloat(_obj, 2);
    }
    {
      _data.z = global::Improbable.Worker.Internal.Pbio.GetFloat(_obj, 3);
    }
    return _data;
  }
}

}