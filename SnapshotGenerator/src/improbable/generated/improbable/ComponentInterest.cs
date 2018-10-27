// Generated by SpatialOS codegen. DO NOT EDIT!
// source: improbable.ComponentInterest in improbable/standard_library.schema.

namespace Improbable
{

public partial struct ComponentInterest : global::System.IEquatable<ComponentInterest>, global::Improbable.Collections.IDeepCopyable<ComponentInterest>
{
  /// <summary>
  /// Field queries = 1.
  /// </summary>
  public global::Improbable.Collections.List<global::Improbable.ComponentInterest.Query> queries;

  public ComponentInterest(global::Improbable.Collections.List<global::Improbable.ComponentInterest.Query> queries)
  {
    this.queries = queries;
  }

  public static ComponentInterest Create()
  {
    var _result = new ComponentInterest();
    _result.queries = new global::Improbable.Collections.List<global::Improbable.ComponentInterest.Query>();
    return _result;
  }

  public ComponentInterest DeepCopy()
  {
    var _result = new ComponentInterest();
    _result.queries = queries.DeepCopy();
    return _result;

  }

  public override bool Equals(object _obj)
  {
    return _obj is ComponentInterest && Equals((ComponentInterest) _obj);
  }

  public static bool operator==(ComponentInterest a, ComponentInterest b)
  {
    return a.Equals(b);
  }

  public static bool operator!=(ComponentInterest a, ComponentInterest b)
  {
    return !a.Equals(b);
  }

  public bool Equals(ComponentInterest _obj)
  {
    return
        queries == _obj.queries;
  }

  public override int GetHashCode()
  {
    int _result = 1327;
    _result = (_result * 977) + (queries == null ? 0 : queries.GetHashCode());
    return _result;
  }

  public partial struct Query : global::System.IEquatable<Query>, global::Improbable.Collections.IDeepCopyable<Query>
  {
    /// <summary>
    /// Field constraint = 1.
    /// </summary>
    public global::Improbable.ComponentInterest.QueryConstraint constraint;
    /// <summary>
    /// Field full_snapshot_result = 2.
    /// </summary>
    public global::Improbable.Collections.Option<bool> fullSnapshotResult;
    /// <summary>
    /// Field result_component_id = 3.
    /// </summary>
    public global::Improbable.Collections.List<uint> resultComponentId;
    /// <summary>
    /// Field frequency = 4.
    /// </summary>
    public global::Improbable.Collections.Option<float> frequency;

    public Query(
        global::Improbable.ComponentInterest.QueryConstraint constraint,
        global::Improbable.Collections.Option<bool> fullSnapshotResult,
        global::Improbable.Collections.List<uint> resultComponentId,
        global::Improbable.Collections.Option<float> frequency)
    {
      this.constraint = constraint;
      this.fullSnapshotResult = fullSnapshotResult;
      this.resultComponentId = resultComponentId;
      this.frequency = frequency;
    }

    public static Query Create()
    {
      var _result = new Query();
      _result.constraint = global::Improbable.ComponentInterest.QueryConstraint.Create();
      _result.resultComponentId = new global::Improbable.Collections.List<uint>();
      return _result;
    }

    public Query DeepCopy()
    {
      var _result = new Query();
      _result.constraint = constraint.DeepCopy();
      _result.fullSnapshotResult = fullSnapshotResult.DeepCopy();
      _result.resultComponentId = resultComponentId.DeepCopy();
      _result.frequency = frequency.DeepCopy();
      return _result;

    }

    public override bool Equals(object _obj)
    {
      return _obj is Query && Equals((Query) _obj);
    }

    public static bool operator==(Query a, Query b)
    {
      return a.Equals(b);
    }

    public static bool operator!=(Query a, Query b)
    {
      return !a.Equals(b);
    }

    public bool Equals(Query _obj)
    {
      return
          constraint == _obj.constraint &&
          fullSnapshotResult == _obj.fullSnapshotResult &&
          resultComponentId == _obj.resultComponentId &&
          frequency == _obj.frequency;
    }

    public override int GetHashCode()
    {
      int _result = 1327;
      _result = (_result * 977) + constraint.GetHashCode();
      _result = (_result * 977) + fullSnapshotResult.GetHashCode();
      _result = (_result * 977) + (resultComponentId == null ? 0 : resultComponentId.GetHashCode());
      _result = (_result * 977) + frequency.GetHashCode();
      return _result;
    }
  }

  public static class Query_Internal
  {
    public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                    Query _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      {
        global::Improbable.ComponentInterest.QueryConstraint_Internal.Write(_pool, _data.constraint, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 1));
      }
      if (_data.fullSnapshotResult.HasValue)
      {
        global::Improbable.Worker.Internal.Pbio.AddBool(_obj, 2, (byte) (_data.fullSnapshotResult.Value ? 1 : 0));
      }
      if (_data.resultComponentId != null)
      {
        for (int _i = 0; _i < _data.resultComponentId.Count; ++_i)
        {
          global::Improbable.Worker.Internal.Pbio.AddUint32(_obj, 3, _data.resultComponentId[_i]);
        }
      }
      if (_data.frequency.HasValue)
      {
        global::Improbable.Worker.Internal.Pbio.AddFloat(_obj, 4, _data.frequency.Value);
      }
    }

    public static unsafe Query Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      Query _data;
      {
        _data.constraint = global::Improbable.ComponentInterest.QueryConstraint_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 1));
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetBoolCount(_obj, 2);
        if (_count > 0)
        {
          _data.fullSnapshotResult = new global::Improbable.Collections.Option<bool>(global::Improbable.Worker.Internal.Pbio.GetBool(_obj, 2) != 0);
        }
        else
        {
          _data.fullSnapshotResult = new global::Improbable.Collections.Option<bool>();
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetUint32Count(_obj, 3);
        _data.resultComponentId = new global::Improbable.Collections.List<uint>((int) _count);
        for (uint _i = 0; _i < _count; ++_i)
        {
          _data.resultComponentId.Add(global::Improbable.Worker.Internal.Pbio.IndexUint32(_obj, 3, _i));
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetFloatCount(_obj, 4);
        if (_count > 0)
        {
          _data.frequency = new global::Improbable.Collections.Option<float>(global::Improbable.Worker.Internal.Pbio.GetFloat(_obj, 4));
        }
        else
        {
          _data.frequency = new global::Improbable.Collections.Option<float>();
        }
      }
      return _data;
    }
  }


  public partial struct QueryConstraint : global::System.IEquatable<QueryConstraint>, global::Improbable.Collections.IDeepCopyable<QueryConstraint>
  {
    /// <summary>
    /// Field sphere_constraint = 1.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.ComponentInterest.SphereConstraint> sphereConstraint;
    /// <summary>
    /// Field cylinder_constraint = 2.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.ComponentInterest.CylinderConstraint> cylinderConstraint;
    /// <summary>
    /// Field box_constraint = 3.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.ComponentInterest.BoxConstraint> boxConstraint;
    /// <summary>
    /// Field relative_sphere_constraint = 4.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeSphereConstraint> relativeSphereConstraint;
    /// <summary>
    /// Field relative_cylinder_constraint = 5.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeCylinderConstraint> relativeCylinderConstraint;
    /// <summary>
    /// Field relative_box_constraint = 6.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeBoxConstraint> relativeBoxConstraint;
    /// <summary>
    /// Field entity_id_constraint = 7.
    /// </summary>
    public global::Improbable.Collections.Option<long> entityIdConstraint;
    /// <summary>
    /// Field component_constraint = 8.
    /// </summary>
    public global::Improbable.Collections.Option<uint> componentConstraint;
    /// <summary>
    /// Field and_constraint = 9.
    /// </summary>
    public global::Improbable.Collections.List<global::Improbable.ComponentInterest.QueryConstraint> andConstraint;
    /// <summary>
    /// Field or_constraint = 10.
    /// </summary>
    public global::Improbable.Collections.List<global::Improbable.ComponentInterest.QueryConstraint> orConstraint;

    public QueryConstraint(
        global::Improbable.Collections.Option<global::Improbable.ComponentInterest.SphereConstraint> sphereConstraint,
        global::Improbable.Collections.Option<global::Improbable.ComponentInterest.CylinderConstraint> cylinderConstraint,
        global::Improbable.Collections.Option<global::Improbable.ComponentInterest.BoxConstraint> boxConstraint,
        global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeSphereConstraint> relativeSphereConstraint,
        global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeCylinderConstraint> relativeCylinderConstraint,
        global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeBoxConstraint> relativeBoxConstraint,
        global::Improbable.Collections.Option<long> entityIdConstraint,
        global::Improbable.Collections.Option<uint> componentConstraint,
        global::Improbable.Collections.List<global::Improbable.ComponentInterest.QueryConstraint> andConstraint,
        global::Improbable.Collections.List<global::Improbable.ComponentInterest.QueryConstraint> orConstraint)
    {
      this.sphereConstraint = sphereConstraint;
      this.cylinderConstraint = cylinderConstraint;
      this.boxConstraint = boxConstraint;
      this.relativeSphereConstraint = relativeSphereConstraint;
      this.relativeCylinderConstraint = relativeCylinderConstraint;
      this.relativeBoxConstraint = relativeBoxConstraint;
      this.entityIdConstraint = entityIdConstraint;
      this.componentConstraint = componentConstraint;
      this.andConstraint = andConstraint;
      this.orConstraint = orConstraint;
    }

    public static QueryConstraint Create()
    {
      var _result = new QueryConstraint();
      _result.andConstraint = new global::Improbable.Collections.List<global::Improbable.ComponentInterest.QueryConstraint>();
      _result.orConstraint = new global::Improbable.Collections.List<global::Improbable.ComponentInterest.QueryConstraint>();
      return _result;
    }

    public QueryConstraint DeepCopy()
    {
      var _result = new QueryConstraint();
      _result.sphereConstraint = sphereConstraint.DeepCopy();
      _result.cylinderConstraint = cylinderConstraint.DeepCopy();
      _result.boxConstraint = boxConstraint.DeepCopy();
      _result.relativeSphereConstraint = relativeSphereConstraint.DeepCopy();
      _result.relativeCylinderConstraint = relativeCylinderConstraint.DeepCopy();
      _result.relativeBoxConstraint = relativeBoxConstraint.DeepCopy();
      _result.entityIdConstraint = entityIdConstraint.DeepCopy();
      _result.componentConstraint = componentConstraint.DeepCopy();
      _result.andConstraint = andConstraint.DeepCopy();
      _result.orConstraint = orConstraint.DeepCopy();
      return _result;

    }

    public override bool Equals(object _obj)
    {
      return _obj is QueryConstraint && Equals((QueryConstraint) _obj);
    }

    public static bool operator==(QueryConstraint a, QueryConstraint b)
    {
      return a.Equals(b);
    }

    public static bool operator!=(QueryConstraint a, QueryConstraint b)
    {
      return !a.Equals(b);
    }

    public bool Equals(QueryConstraint _obj)
    {
      return
          sphereConstraint == _obj.sphereConstraint &&
          cylinderConstraint == _obj.cylinderConstraint &&
          boxConstraint == _obj.boxConstraint &&
          relativeSphereConstraint == _obj.relativeSphereConstraint &&
          relativeCylinderConstraint == _obj.relativeCylinderConstraint &&
          relativeBoxConstraint == _obj.relativeBoxConstraint &&
          entityIdConstraint == _obj.entityIdConstraint &&
          componentConstraint == _obj.componentConstraint &&
          andConstraint == _obj.andConstraint &&
          orConstraint == _obj.orConstraint;
    }

    public override int GetHashCode()
    {
      int _result = 1327;
      _result = (_result * 977) + sphereConstraint.GetHashCode();
      _result = (_result * 977) + cylinderConstraint.GetHashCode();
      _result = (_result * 977) + boxConstraint.GetHashCode();
      _result = (_result * 977) + relativeSphereConstraint.GetHashCode();
      _result = (_result * 977) + relativeCylinderConstraint.GetHashCode();
      _result = (_result * 977) + relativeBoxConstraint.GetHashCode();
      _result = (_result * 977) + entityIdConstraint.GetHashCode();
      _result = (_result * 977) + componentConstraint.GetHashCode();
      _result = (_result * 977) + (andConstraint == null ? 0 : andConstraint.GetHashCode());
      _result = (_result * 977) + (orConstraint == null ? 0 : orConstraint.GetHashCode());
      return _result;
    }
  }

  public static class QueryConstraint_Internal
  {
    public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                    QueryConstraint _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      if (_data.sphereConstraint.HasValue)
      {
        global::Improbable.ComponentInterest.SphereConstraint_Internal.Write(_pool, _data.sphereConstraint.Value, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 1));
      }
      if (_data.cylinderConstraint.HasValue)
      {
        global::Improbable.ComponentInterest.CylinderConstraint_Internal.Write(_pool, _data.cylinderConstraint.Value, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 2));
      }
      if (_data.boxConstraint.HasValue)
      {
        global::Improbable.ComponentInterest.BoxConstraint_Internal.Write(_pool, _data.boxConstraint.Value, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 3));
      }
      if (_data.relativeSphereConstraint.HasValue)
      {
        global::Improbable.ComponentInterest.RelativeSphereConstraint_Internal.Write(_pool, _data.relativeSphereConstraint.Value, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 4));
      }
      if (_data.relativeCylinderConstraint.HasValue)
      {
        global::Improbable.ComponentInterest.RelativeCylinderConstraint_Internal.Write(_pool, _data.relativeCylinderConstraint.Value, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 5));
      }
      if (_data.relativeBoxConstraint.HasValue)
      {
        global::Improbable.ComponentInterest.RelativeBoxConstraint_Internal.Write(_pool, _data.relativeBoxConstraint.Value, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 6));
      }
      if (_data.entityIdConstraint.HasValue)
      {
        global::Improbable.Worker.Internal.Pbio.AddInt64(_obj, 7, _data.entityIdConstraint.Value);
      }
      if (_data.componentConstraint.HasValue)
      {
        global::Improbable.Worker.Internal.Pbio.AddUint32(_obj, 8, _data.componentConstraint.Value);
      }
      if (_data.andConstraint != null)
      {
        for (int _i = 0; _i < _data.andConstraint.Count; ++_i)
        {
          global::Improbable.ComponentInterest.QueryConstraint_Internal.Write(_pool, _data.andConstraint[_i], global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 9));
        }
      }
      if (_data.orConstraint != null)
      {
        for (int _i = 0; _i < _data.orConstraint.Count; ++_i)
        {
          global::Improbable.ComponentInterest.QueryConstraint_Internal.Write(_pool, _data.orConstraint[_i], global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 10));
        }
      }
    }

    public static unsafe QueryConstraint Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      QueryConstraint _data;
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(_obj, 1);
        if (_count > 0)
        {
          _data.sphereConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.SphereConstraint>(global::Improbable.ComponentInterest.SphereConstraint_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 1)));
        }
        else
        {
          _data.sphereConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.SphereConstraint>();
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(_obj, 2);
        if (_count > 0)
        {
          _data.cylinderConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.CylinderConstraint>(global::Improbable.ComponentInterest.CylinderConstraint_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 2)));
        }
        else
        {
          _data.cylinderConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.CylinderConstraint>();
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(_obj, 3);
        if (_count > 0)
        {
          _data.boxConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.BoxConstraint>(global::Improbable.ComponentInterest.BoxConstraint_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 3)));
        }
        else
        {
          _data.boxConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.BoxConstraint>();
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(_obj, 4);
        if (_count > 0)
        {
          _data.relativeSphereConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeSphereConstraint>(global::Improbable.ComponentInterest.RelativeSphereConstraint_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 4)));
        }
        else
        {
          _data.relativeSphereConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeSphereConstraint>();
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(_obj, 5);
        if (_count > 0)
        {
          _data.relativeCylinderConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeCylinderConstraint>(global::Improbable.ComponentInterest.RelativeCylinderConstraint_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 5)));
        }
        else
        {
          _data.relativeCylinderConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeCylinderConstraint>();
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(_obj, 6);
        if (_count > 0)
        {
          _data.relativeBoxConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeBoxConstraint>(global::Improbable.ComponentInterest.RelativeBoxConstraint_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 6)));
        }
        else
        {
          _data.relativeBoxConstraint = new global::Improbable.Collections.Option<global::Improbable.ComponentInterest.RelativeBoxConstraint>();
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetInt64Count(_obj, 7);
        if (_count > 0)
        {
          _data.entityIdConstraint = new global::Improbable.Collections.Option<long>(global::Improbable.Worker.Internal.Pbio.GetInt64(_obj, 7));
        }
        else
        {
          _data.entityIdConstraint = new global::Improbable.Collections.Option<long>();
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetUint32Count(_obj, 8);
        if (_count > 0)
        {
          _data.componentConstraint = new global::Improbable.Collections.Option<uint>(global::Improbable.Worker.Internal.Pbio.GetUint32(_obj, 8));
        }
        else
        {
          _data.componentConstraint = new global::Improbable.Collections.Option<uint>();
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(_obj, 9);
        _data.andConstraint = new global::Improbable.Collections.List<global::Improbable.ComponentInterest.QueryConstraint>((int) _count);
        for (uint _i = 0; _i < _count; ++_i)
        {
          _data.andConstraint.Add(global::Improbable.ComponentInterest.QueryConstraint_Internal.Read(global::Improbable.Worker.Internal.Pbio.IndexObject(_obj, 9, _i)));
        }
      }
      {
        var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(_obj, 10);
        _data.orConstraint = new global::Improbable.Collections.List<global::Improbable.ComponentInterest.QueryConstraint>((int) _count);
        for (uint _i = 0; _i < _count; ++_i)
        {
          _data.orConstraint.Add(global::Improbable.ComponentInterest.QueryConstraint_Internal.Read(global::Improbable.Worker.Internal.Pbio.IndexObject(_obj, 10, _i)));
        }
      }
      return _data;
    }
  }


  public partial struct SphereConstraint : global::System.IEquatable<SphereConstraint>, global::Improbable.Collections.IDeepCopyable<SphereConstraint>
  {
    /// <summary>
    /// Field center = 1.
    /// </summary>
    public global::Improbable.Coordinates center;
    /// <summary>
    /// Field radius = 2.
    /// </summary>
    public double radius;

    public SphereConstraint(
        global::Improbable.Coordinates center,
        double radius)
    {
      this.center = center;
      this.radius = radius;
    }

    public static SphereConstraint Create()
    {
      var _result = new SphereConstraint();
      _result.center = global::Improbable.Coordinates.Create();
      return _result;
    }

    public SphereConstraint DeepCopy()
    {
      var _result = new SphereConstraint();
      _result.center = center.DeepCopy();
      _result.radius = radius;
      return _result;

    }

    public override bool Equals(object _obj)
    {
      return _obj is SphereConstraint && Equals((SphereConstraint) _obj);
    }

    public static bool operator==(SphereConstraint a, SphereConstraint b)
    {
      return a.Equals(b);
    }

    public static bool operator!=(SphereConstraint a, SphereConstraint b)
    {
      return !a.Equals(b);
    }

    public bool Equals(SphereConstraint _obj)
    {
      return
          center == _obj.center &&
          radius == _obj.radius;
    }

    public override int GetHashCode()
    {
      int _result = 1327;
      _result = (_result * 977) + center.GetHashCode();
      _result = (_result * 977) + radius.GetHashCode();
      return _result;
    }
  }

  public static class SphereConstraint_Internal
  {
    public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                    SphereConstraint _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      {
        global::Improbable.Coordinates_Internal.Write(_pool, _data.center, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 1));
      }
      {
        global::Improbable.Worker.Internal.Pbio.AddDouble(_obj, 2, _data.radius);
      }
    }

    public static unsafe SphereConstraint Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      SphereConstraint _data;
      {
        _data.center = global::Improbable.Coordinates_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 1));
      }
      {
        _data.radius = global::Improbable.Worker.Internal.Pbio.GetDouble(_obj, 2);
      }
      return _data;
    }
  }


  public partial struct CylinderConstraint : global::System.IEquatable<CylinderConstraint>, global::Improbable.Collections.IDeepCopyable<CylinderConstraint>
  {
    /// <summary>
    /// Field center = 1.
    /// </summary>
    public global::Improbable.Coordinates center;
    /// <summary>
    /// Field radius = 2.
    /// </summary>
    public double radius;

    public CylinderConstraint(
        global::Improbable.Coordinates center,
        double radius)
    {
      this.center = center;
      this.radius = radius;
    }

    public static CylinderConstraint Create()
    {
      var _result = new CylinderConstraint();
      _result.center = global::Improbable.Coordinates.Create();
      return _result;
    }

    public CylinderConstraint DeepCopy()
    {
      var _result = new CylinderConstraint();
      _result.center = center.DeepCopy();
      _result.radius = radius;
      return _result;

    }

    public override bool Equals(object _obj)
    {
      return _obj is CylinderConstraint && Equals((CylinderConstraint) _obj);
    }

    public static bool operator==(CylinderConstraint a, CylinderConstraint b)
    {
      return a.Equals(b);
    }

    public static bool operator!=(CylinderConstraint a, CylinderConstraint b)
    {
      return !a.Equals(b);
    }

    public bool Equals(CylinderConstraint _obj)
    {
      return
          center == _obj.center &&
          radius == _obj.radius;
    }

    public override int GetHashCode()
    {
      int _result = 1327;
      _result = (_result * 977) + center.GetHashCode();
      _result = (_result * 977) + radius.GetHashCode();
      return _result;
    }
  }

  public static class CylinderConstraint_Internal
  {
    public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                    CylinderConstraint _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      {
        global::Improbable.Coordinates_Internal.Write(_pool, _data.center, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 1));
      }
      {
        global::Improbable.Worker.Internal.Pbio.AddDouble(_obj, 2, _data.radius);
      }
    }

    public static unsafe CylinderConstraint Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      CylinderConstraint _data;
      {
        _data.center = global::Improbable.Coordinates_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 1));
      }
      {
        _data.radius = global::Improbable.Worker.Internal.Pbio.GetDouble(_obj, 2);
      }
      return _data;
    }
  }


  public partial struct BoxConstraint : global::System.IEquatable<BoxConstraint>, global::Improbable.Collections.IDeepCopyable<BoxConstraint>
  {
    /// <summary>
    /// Field center = 1.
    /// </summary>
    public global::Improbable.Coordinates center;
    /// <summary>
    /// Field edge_length = 2.
    /// </summary>
    public global::Improbable.EdgeLength edgeLength;

    public BoxConstraint(
        global::Improbable.Coordinates center,
        global::Improbable.EdgeLength edgeLength)
    {
      this.center = center;
      this.edgeLength = edgeLength;
    }

    public static BoxConstraint Create()
    {
      var _result = new BoxConstraint();
      _result.center = global::Improbable.Coordinates.Create();
      _result.edgeLength = global::Improbable.EdgeLength.Create();
      return _result;
    }

    public BoxConstraint DeepCopy()
    {
      var _result = new BoxConstraint();
      _result.center = center.DeepCopy();
      _result.edgeLength = edgeLength.DeepCopy();
      return _result;

    }

    public override bool Equals(object _obj)
    {
      return _obj is BoxConstraint && Equals((BoxConstraint) _obj);
    }

    public static bool operator==(BoxConstraint a, BoxConstraint b)
    {
      return a.Equals(b);
    }

    public static bool operator!=(BoxConstraint a, BoxConstraint b)
    {
      return !a.Equals(b);
    }

    public bool Equals(BoxConstraint _obj)
    {
      return
          center == _obj.center &&
          edgeLength == _obj.edgeLength;
    }

    public override int GetHashCode()
    {
      int _result = 1327;
      _result = (_result * 977) + center.GetHashCode();
      _result = (_result * 977) + edgeLength.GetHashCode();
      return _result;
    }
  }

  public static class BoxConstraint_Internal
  {
    public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                    BoxConstraint _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      {
        global::Improbable.Coordinates_Internal.Write(_pool, _data.center, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 1));
      }
      {
        global::Improbable.EdgeLength_Internal.Write(_pool, _data.edgeLength, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 2));
      }
    }

    public static unsafe BoxConstraint Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      BoxConstraint _data;
      {
        _data.center = global::Improbable.Coordinates_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 1));
      }
      {
        _data.edgeLength = global::Improbable.EdgeLength_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 2));
      }
      return _data;
    }
  }


  public partial struct RelativeSphereConstraint : global::System.IEquatable<RelativeSphereConstraint>, global::Improbable.Collections.IDeepCopyable<RelativeSphereConstraint>
  {
    /// <summary>
    /// Field radius = 1.
    /// </summary>
    public double radius;

    public RelativeSphereConstraint(double radius)
    {
      this.radius = radius;
    }

    public static RelativeSphereConstraint Create()
    {
      var _result = new RelativeSphereConstraint();
      return _result;
    }

    public RelativeSphereConstraint DeepCopy()
    {
      var _result = new RelativeSphereConstraint();
      _result.radius = radius;
      return _result;

    }

    public override bool Equals(object _obj)
    {
      return _obj is RelativeSphereConstraint && Equals((RelativeSphereConstraint) _obj);
    }

    public static bool operator==(RelativeSphereConstraint a, RelativeSphereConstraint b)
    {
      return a.Equals(b);
    }

    public static bool operator!=(RelativeSphereConstraint a, RelativeSphereConstraint b)
    {
      return !a.Equals(b);
    }

    public bool Equals(RelativeSphereConstraint _obj)
    {
      return
          radius == _obj.radius;
    }

    public override int GetHashCode()
    {
      int _result = 1327;
      _result = (_result * 977) + radius.GetHashCode();
      return _result;
    }
  }

  public static class RelativeSphereConstraint_Internal
  {
    public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                    RelativeSphereConstraint _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      {
        global::Improbable.Worker.Internal.Pbio.AddDouble(_obj, 1, _data.radius);
      }
    }

    public static unsafe RelativeSphereConstraint Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      RelativeSphereConstraint _data;
      {
        _data.radius = global::Improbable.Worker.Internal.Pbio.GetDouble(_obj, 1);
      }
      return _data;
    }
  }


  public partial struct RelativeCylinderConstraint : global::System.IEquatable<RelativeCylinderConstraint>, global::Improbable.Collections.IDeepCopyable<RelativeCylinderConstraint>
  {
    /// <summary>
    /// Field radius = 1.
    /// </summary>
    public double radius;

    public RelativeCylinderConstraint(double radius)
    {
      this.radius = radius;
    }

    public static RelativeCylinderConstraint Create()
    {
      var _result = new RelativeCylinderConstraint();
      return _result;
    }

    public RelativeCylinderConstraint DeepCopy()
    {
      var _result = new RelativeCylinderConstraint();
      _result.radius = radius;
      return _result;

    }

    public override bool Equals(object _obj)
    {
      return _obj is RelativeCylinderConstraint && Equals((RelativeCylinderConstraint) _obj);
    }

    public static bool operator==(RelativeCylinderConstraint a, RelativeCylinderConstraint b)
    {
      return a.Equals(b);
    }

    public static bool operator!=(RelativeCylinderConstraint a, RelativeCylinderConstraint b)
    {
      return !a.Equals(b);
    }

    public bool Equals(RelativeCylinderConstraint _obj)
    {
      return
          radius == _obj.radius;
    }

    public override int GetHashCode()
    {
      int _result = 1327;
      _result = (_result * 977) + radius.GetHashCode();
      return _result;
    }
  }

  public static class RelativeCylinderConstraint_Internal
  {
    public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                    RelativeCylinderConstraint _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      {
        global::Improbable.Worker.Internal.Pbio.AddDouble(_obj, 1, _data.radius);
      }
    }

    public static unsafe RelativeCylinderConstraint Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      RelativeCylinderConstraint _data;
      {
        _data.radius = global::Improbable.Worker.Internal.Pbio.GetDouble(_obj, 1);
      }
      return _data;
    }
  }


  public partial struct RelativeBoxConstraint : global::System.IEquatable<RelativeBoxConstraint>, global::Improbable.Collections.IDeepCopyable<RelativeBoxConstraint>
  {
    /// <summary>
    /// Field edge_length = 1.
    /// </summary>
    public global::Improbable.EdgeLength edgeLength;

    public RelativeBoxConstraint(global::Improbable.EdgeLength edgeLength)
    {
      this.edgeLength = edgeLength;
    }

    public static RelativeBoxConstraint Create()
    {
      var _result = new RelativeBoxConstraint();
      _result.edgeLength = global::Improbable.EdgeLength.Create();
      return _result;
    }

    public RelativeBoxConstraint DeepCopy()
    {
      var _result = new RelativeBoxConstraint();
      _result.edgeLength = edgeLength.DeepCopy();
      return _result;

    }

    public override bool Equals(object _obj)
    {
      return _obj is RelativeBoxConstraint && Equals((RelativeBoxConstraint) _obj);
    }

    public static bool operator==(RelativeBoxConstraint a, RelativeBoxConstraint b)
    {
      return a.Equals(b);
    }

    public static bool operator!=(RelativeBoxConstraint a, RelativeBoxConstraint b)
    {
      return !a.Equals(b);
    }

    public bool Equals(RelativeBoxConstraint _obj)
    {
      return
          edgeLength == _obj.edgeLength;
    }

    public override int GetHashCode()
    {
      int _result = 1327;
      _result = (_result * 977) + edgeLength.GetHashCode();
      return _result;
    }
  }

  public static class RelativeBoxConstraint_Internal
  {
    public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                    RelativeBoxConstraint _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      {
        global::Improbable.EdgeLength_Internal.Write(_pool, _data.edgeLength, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 1));
      }
    }

    public static unsafe RelativeBoxConstraint Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      RelativeBoxConstraint _data;
      {
        _data.edgeLength = global::Improbable.EdgeLength_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 1));
      }
      return _data;
    }
  }

}

public static class ComponentInterest_Internal
{
  public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                  ComponentInterest _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
  {
    if (_data.queries != null)
    {
      for (int _i = 0; _i < _data.queries.Count; ++_i)
      {
        global::Improbable.ComponentInterest.Query_Internal.Write(_pool, _data.queries[_i], global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 1));
      }
    }
  }

  public static unsafe ComponentInterest Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
  {
    ComponentInterest _data;
    {
      var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(_obj, 1);
      _data.queries = new global::Improbable.Collections.List<global::Improbable.ComponentInterest.Query>((int) _count);
      for (uint _i = 0; _i < _count; ++_i)
      {
        _data.queries.Add(global::Improbable.ComponentInterest.Query_Internal.Read(global::Improbable.Worker.Internal.Pbio.IndexObject(_obj, 1, _i)));
      }
    }
    return _data;
  }
}

}
