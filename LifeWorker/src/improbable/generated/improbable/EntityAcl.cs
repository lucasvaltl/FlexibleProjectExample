// Generated by SpatialOS codegen. DO NOT EDIT!
// source: EntityAcl in improbable/standard_library.schema.

namespace Improbable
{

public static class EntityAcl_Extensions
{
  public static EntityAcl.Data Get(this global::Improbable.Worker.IComponentData<EntityAcl> data)
  {
    return (EntityAcl.Data) data;
  }

  public static EntityAcl.Update Get(this global::Improbable.Worker.IComponentUpdate<EntityAcl> update)
  {
    return (EntityAcl.Update) update;
  }
}

public partial class EntityAcl : global::Improbable.Worker.IComponentMetaclass
{
  public const uint ComponentId = 50;

  uint global::Improbable.Worker.IComponentMetaclass.ComponentId
  {
    get { return ComponentId; }
  }

  /// <summary>
  /// Concrete data type for the EntityAcl component.
  /// </summary>
  public class Data : global::Improbable.Worker.IComponentData<EntityAcl>, global::Improbable.Collections.IDeepCopyable<Data>
  {
    public global::Improbable.EntityAclData Value;

    public Data(global::Improbable.EntityAclData value)
    {
      Value = value;
    }

    public Data(
        global::Improbable.WorkerRequirementSet readAcl,
        global::Improbable.Collections.Map<uint, global::Improbable.WorkerRequirementSet> componentWriteAcl)
    {
      Value = new global::Improbable.EntityAclData(
          readAcl,
          componentWriteAcl);
    }

    public Data DeepCopy()
    {
      return new Data(Value.DeepCopy());
    }

    public global::Improbable.Worker.IComponentUpdate<EntityAcl> ToUpdate()
    {
      var update = new Update();
      update.SetReadAcl(Value.readAcl);
      update.SetComponentWriteAcl(Value.componentWriteAcl);
      return update;
    }
  }

  /// <summary>
  /// Concrete update type for the EntityAcl component.
  /// </summary>
  public class Update : global::Improbable.Worker.IComponentUpdate<EntityAcl>, global::Improbable.Collections.IDeepCopyable<Update>
  {
    /// <summary>
    /// Field read_acl = 1.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.WorkerRequirementSet> readAcl;
    public Update SetReadAcl(global::Improbable.WorkerRequirementSet _value)
    {
      readAcl.Set(_value);
      return this;
    }

    /// <summary>
    /// Field component_write_acl = 2.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.Map<uint, global::Improbable.WorkerRequirementSet>> componentWriteAcl;
    public Update SetComponentWriteAcl(global::Improbable.Collections.Map<uint, global::Improbable.WorkerRequirementSet> _value)
    {
      if (_value == null)
      {
        throw new System.ArgumentNullException(null, "Attempt to send update with null value.");
      }
      componentWriteAcl.Set(_value);
      return this;
    }

    public Update DeepCopy()
    {
      var _result = new Update();
      if (readAcl.HasValue)
      {
        global::Improbable.WorkerRequirementSet field;
        field = readAcl.Value.DeepCopy();
        _result.readAcl.Set(field);
      }
      if (componentWriteAcl.HasValue)
      {
        global::Improbable.Collections.Map<uint, global::Improbable.WorkerRequirementSet> field;
        field = componentWriteAcl.Value.DeepCopy();
        _result.componentWriteAcl.Set(field);
      }
      return _result;
    }

    public global::Improbable.Worker.IComponentData<EntityAcl> ToInitialData()
    {
      return new Data(new global::Improbable.EntityAclData(
          readAcl.Value,
          componentWriteAcl.Value));
    }

    public void ApplyTo(global::Improbable.Worker.IComponentData<EntityAcl> _data)
    {
      var _concrete = _data.Get();
      if (readAcl.HasValue)
      {
        _concrete.Value.readAcl = readAcl.Value;
      }
      if (componentWriteAcl.HasValue)
      {
        _concrete.Value.componentWriteAcl = componentWriteAcl.Value;
      }
    }
  }

  public partial class Commands
  {
  }

  // Implementation details below here.
  //----------------------------------------------------------------

  public global::Improbable.Worker.Internal.ComponentProtocol.ComponentVtable Vtable {
    get {
      global::Improbable.Worker.Internal.ComponentProtocol.ComponentVtable vtable;
      vtable.ComponentId = ComponentId;
      unsafe { vtable.UserData = null; }
      vtable.Free = global::System.Runtime.InteropServices.Marshal
          .GetFunctionPointerForDelegate(global::Improbable.Worker.Internal.ClientHandles.ClientFree);
      vtable.Copy = global::System.Runtime.InteropServices.Marshal
          .GetFunctionPointerForDelegate(global::Improbable.Worker.Internal.ClientHandles.ClientCopy);
      vtable.Deserialize = global::System.Runtime.InteropServices.Marshal
          .GetFunctionPointerForDelegate(clientDeserialize);
      vtable.Serialize = global::System.Runtime.InteropServices.Marshal
          .GetFunctionPointerForDelegate(clientSerialize);
      return vtable;
    }
  }

  public void InvokeHandler(global::Improbable.Worker.Dynamic.Handler handler)
  {
    handler.Accept<EntityAcl>(this);
  }

  private static unsafe readonly global::Improbable.Worker.Internal.ComponentProtocol.ClientDeserialize
      clientDeserialize = ClientDeserialize;
  private static unsafe readonly global::Improbable.Worker.Internal.ComponentProtocol.ClientSerialize
      clientSerialize = ClientSerialize;

  [global::Improbable.Worker.Internal.MonoPInvokeCallback(typeof(global::Improbable.Worker.Internal.ComponentProtocol.ClientDeserialize))]
  private static unsafe global::System.Byte
  ClientDeserialize(global::System.UInt32 componentId,
                    void* userData,
                    global::System.Byte handleType,
                    global::Improbable.Worker.Internal.Pbio.Object* root,
                    global::Improbable.Worker.Internal.ComponentProtocol.ClientHandle** handleOut)
  {
    *handleOut = null;
    try
    {
      *handleOut = global::Improbable.Worker.Internal.ClientHandles.HandleAlloc();
      if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Update) {
        var data = new Update();
        var fieldsToClear = new global::System.Collections.Generic.HashSet<uint>();
        var fieldsToClearCount = global::Improbable.Worker.Internal.Pbio.GetUint32Count(root, /* fields to clear */ 1);
        for (uint i = 0; i < fieldsToClearCount; ++i)
        {
           fieldsToClear.Add(global::Improbable.Worker.Internal.Pbio.IndexUint32(root, /* fields to clear */ 1, i));
        }
        var stateObject = global::Improbable.Worker.Internal.Pbio.GetObject(
            global::Improbable.Worker.Internal.Pbio.GetObject(root, /* entity_state */ 2), 50);
        if (global::Improbable.Worker.Internal.Pbio.GetObjectCount(stateObject, 1) > 0)
        {
          global::Improbable.WorkerRequirementSet field;
          {
            field = global::Improbable.WorkerRequirementSet_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(stateObject, 1));
          }
          data.readAcl.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetObjectCount(stateObject, 2) > 0 || fieldsToClear.Contains(2))
        {
          global::Improbable.Collections.Map<uint, global::Improbable.WorkerRequirementSet> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(stateObject, 2);
            field = new global::Improbable.Collections.Map<uint, global::Improbable.WorkerRequirementSet>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              var _pair = global::Improbable.Worker.Internal.Pbio.IndexObject(stateObject, 2, _i);
              field.Add(global::Improbable.Worker.Internal.Pbio.GetUint32(_pair, 1), global::Improbable.WorkerRequirementSet_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_pair, 2)));
            }
          }
          data.componentWriteAcl.Set(field);
        }
        **handleOut = global::Improbable.Worker.Internal.ClientHandles.Instance.CreateHandle(data);
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Snapshot)
      {
        var data = new Data(global::Improbable.EntityAclData_Internal.Read(
            global::Improbable.Worker.Internal.Pbio.GetObject(root, 50)));
        **handleOut = global::Improbable.Worker.Internal.ClientHandles.Instance.CreateHandle(data);
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Request)
      {
        var data = new global::Improbable.Worker.Internal.GenericCommandObject();
        **handleOut = global::Improbable.Worker.Internal.ClientHandles.Instance.CreateHandle(data);
        return 0;
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Response)
      {
        var data = new global::Improbable.Worker.Internal.GenericCommandObject();
        **handleOut = global::Improbable.Worker.Internal.ClientHandles.Instance.CreateHandle(data);
        return 0;
      }
    }
    catch (global::System.Exception e)
    {
      global::Improbable.Worker.ClientError.LogClientException(e);
      return 0;
    }
    return 1;
  }

  [global::Improbable.Worker.Internal.MonoPInvokeCallback(typeof(global::Improbable.Worker.Internal.ComponentProtocol.ClientSerialize))]
  private static unsafe void
  ClientSerialize(global::System.UInt32 componentId,
                  void* userData,
                  global::System.Byte handleType,
                  global::Improbable.Worker.Internal.ComponentProtocol.ClientHandle* handle,
                  global::Improbable.Worker.Internal.Pbio.Object* root)
  {
    try
    {
      var _pool = global::Improbable.Worker.Internal.ClientHandles.Instance.GetGcHandlePool(*handle);
      if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Update) {
        var data = (Update) global::Improbable.Worker.Internal.ClientHandles.Instance.Dereference(*handle);
        var stateObject = global::Improbable.Worker.Internal.Pbio.AddObject(
            global::Improbable.Worker.Internal.Pbio.AddObject(root, /* entity_state */ 2), 50);
        if (data.readAcl.HasValue)
        {
          {
            global::Improbable.WorkerRequirementSet_Internal.Write(_pool, data.readAcl.Value, global::Improbable.Worker.Internal.Pbio.AddObject(stateObject, 1));
          }
        }
        if (data.componentWriteAcl.HasValue)
        {
          if (data.componentWriteAcl.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 2);
          }
          if (data.componentWriteAcl.Value != null)
          {
            for (var _node = data.componentWriteAcl.Value.First; _node != null; _node = _node.Next)
            {
              var _pair = global::Improbable.Worker.Internal.Pbio.AddObject(stateObject, 2);
              {
                global::Improbable.Worker.Internal.Pbio.AddUint32(_pair, 1, _node.Value.Key);
              }
              {
                global::Improbable.WorkerRequirementSet_Internal.Write(_pool, _node.Value.Value, global::Improbable.Worker.Internal.Pbio.AddObject(_pair, 2));
              }
            }
          }
        }
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Snapshot) {
        var data = (Data) global::Improbable.Worker.Internal.ClientHandles.Instance.Dereference(*handle);
        global::Improbable.EntityAclData_Internal.Write(_pool, data.Value, global::Improbable.Worker.Internal.Pbio.AddObject(root, 50));
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Request)
      {
        global::Improbable.Worker.Internal.Pbio.AddObject(root, 50);
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Response)
      {
        global::Improbable.Worker.Internal.Pbio.AddObject(root, 50);
      }
    }
    catch (global::System.Exception e)
    {
      global::Improbable.Worker.ClientError.LogClientException(e);
    }
  }
}

}