# Class SteamVRBehaviourVector3Action

Listens for the linked Vector3 behavior and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [AxisValue]
  * [LinkedVector3Behaviour]
* [Methods]
  * [ClearLinkedVector3Behaviour()]
  * [Listener(SteamVR\_Behaviour\_Vector3, SteamVR\_Input\_Sources, Vector3, Vector3)]
  * [OnAfterLinkedVector3BehaviourChange()]
  * [OnBeforeLinkedVector3BehaviourChange()]
  * [OnDisable()]
  * [OnEnable()]
  * [RegisterListeners()]
  * [UnregisterListeners()]

## Details

##### Inheritance

* System.Object
* SteamVRBehaviourVector3Action

##### Namespace

* [Tilia.SDK.SteamVR.Input]

##### Syntax

```
public class SteamVRBehaviourVector3Action : Vector3Action
```

### Properties

#### AxisValue

The value to receive from the axis data.

##### Declaration

```
public SteamVRBehaviourVector3Action.ValueType AxisValue { get; set; }
```

#### LinkedVector3Behaviour

The SteamVR Vector3 Behavior to link this action to.

##### Declaration

```
public SteamVR_Behaviour_Vector3 LinkedVector3Behaviour { get; set; }
```

### Methods

#### ClearLinkedVector3Behaviour()

Clears [LinkedVector3Behaviour].

##### Declaration

```
public virtual void ClearLinkedVector3Behaviour()
```

#### Listener(SteamVR\_Behaviour\_Vector3, SteamVR\_Input\_Sources, Vector3, Vector3)

Processes the event and re-emits the data via the Vector3Action.

##### Declaration

```
protected virtual void Listener(SteamVR_Behaviour_Vector3 action, SteamVR_Input_Sources source, Vector3 value, Vector3 delta)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SteamVR\_Behaviour\_Vector3 | action | The action raising the event. |
| SteamVR\_Input\_Sources | source | The source of the input. |
| Vector3 | value | The value of the raised event. |
| Vector3 | delta | The delta value between now and the previous raised event. |

#### OnAfterLinkedVector3BehaviourChange()

Called after [LinkedVector3Behaviour] has been changed.

##### Declaration

```
protected virtual void OnAfterLinkedVector3BehaviourChange()
```

#### OnBeforeLinkedVector3BehaviourChange()

Called before [LinkedVector3Behaviour] has been changed.

##### Declaration

```
protected virtual void OnBeforeLinkedVector3BehaviourChange()
```

#### OnDisable()

##### Declaration

```
protected override void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected override void OnEnable()
```

#### RegisterListeners()

Registers the listeners against the [LinkedVector3Behaviour].

##### Declaration

```
protected virtual void RegisterListeners()
```

#### UnregisterListeners()

Unregisters the listeners against the [LinkedVector3Behaviour].

##### Declaration

```
protected virtual void UnregisterListeners()
```

[Tilia.SDK.SteamVR.Input]: README.md
[SteamVRBehaviourVector3Action.ValueType]: SteamVRBehaviourVector3Action.ValueType.md
[LinkedVector3Behaviour]: SteamVRBehaviourVector3Action.md#LinkedVector3Behaviour
[LinkedVector3Behaviour]: SteamVRBehaviourVector3Action.md#LinkedVector3Behaviour
[LinkedVector3Behaviour]: SteamVRBehaviourVector3Action.md#LinkedVector3Behaviour
[LinkedVector3Behaviour]: SteamVRBehaviourVector3Action.md#LinkedVector3Behaviour
[LinkedVector3Behaviour]: SteamVRBehaviourVector3Action.md#LinkedVector3Behaviour
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[AxisValue]: #AxisValue
[LinkedVector3Behaviour]: #LinkedVector3Behaviour
[Methods]: #Methods
[ClearLinkedVector3Behaviour()]: #ClearLinkedVector3Behaviour
[Listener(SteamVR\_Behaviour\_Vector3, SteamVR\_Input\_Sources, Vector3, Vector3)]: #ListenerSteamVR\_Behaviour\_Vector3-SteamVR\_Input\_Sources-Vector3-Vector3
[OnAfterLinkedVector3BehaviourChange()]: #OnAfterLinkedVector3BehaviourChange
[OnBeforeLinkedVector3BehaviourChange()]: #OnBeforeLinkedVector3BehaviourChange
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[RegisterListeners()]: #RegisterListeners
[UnregisterListeners()]: #UnregisterListeners
