# Class SteamVRBehaviourVector2Action

Listens for the linked Vector2 behavior and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [AxisValue]
  * [LinkedVector2Behaviour]
* [Methods]
  * [ClearLinkedVector2Behaviour()]
  * [Listener(SteamVR\_Behaviour\_Vector2, SteamVR\_Input\_Sources, Vector2, Vector2)]
  * [OnAfterLinkedVector2BehaviourChange()]
  * [OnBeforeLinkedVector2BehaviourChange()]
  * [OnDisable()]
  * [OnEnable()]
  * [RegisterListeners()]
  * [UnregisterListeners()]

## Details

##### Inheritance

* System.Object
* SteamVRBehaviourVector2Action

##### Namespace

* [Tilia.SDK.SteamVR.Input]

##### Syntax

```
public class SteamVRBehaviourVector2Action : Vector2Action
```

### Properties

#### AxisValue

The value to receive from the axis data.

##### Declaration

```
public SteamVRBehaviourVector2Action.ValueType AxisValue { get; set; }
```

#### LinkedVector2Behaviour

The SteamVR Vector2 Behavior to link this action to.

##### Declaration

```
public SteamVR_Behaviour_Vector2 LinkedVector2Behaviour { get; set; }
```

### Methods

#### ClearLinkedVector2Behaviour()

Clears [LinkedVector2Behaviour].

##### Declaration

```
public virtual void ClearLinkedVector2Behaviour()
```

#### Listener(SteamVR\_Behaviour\_Vector2, SteamVR\_Input\_Sources, Vector2, Vector2)

Processes the event and re-emits the data via the Vector2Action.

##### Declaration

```
protected virtual void Listener(SteamVR_Behaviour_Vector2 action, SteamVR_Input_Sources source, Vector2 value, Vector2 delta)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SteamVR\_Behaviour\_Vector2 | action | The action raising the event. |
| SteamVR\_Input\_Sources | source | The source of the input. |
| Vector2 | value | The value of the raised event. |
| Vector2 | delta | The delta value between now and the previous raised event. |

#### OnAfterLinkedVector2BehaviourChange()

Called after [LinkedVector2Behaviour] has been changed.

##### Declaration

```
protected virtual void OnAfterLinkedVector2BehaviourChange()
```

#### OnBeforeLinkedVector2BehaviourChange()

Called before [LinkedVector2Behaviour] has been changed.

##### Declaration

```
protected virtual void OnBeforeLinkedVector2BehaviourChange()
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

Registers the listeners against the [LinkedVector2Behaviour].

##### Declaration

```
protected virtual void RegisterListeners()
```

#### UnregisterListeners()

Unregisters the listeners against the [LinkedVector2Behaviour].

##### Declaration

```
protected virtual void UnregisterListeners()
```

[Tilia.SDK.SteamVR.Input]: README.md
[SteamVRBehaviourVector2Action.ValueType]: SteamVRBehaviourVector2Action.ValueType.md
[LinkedVector2Behaviour]: SteamVRBehaviourVector2Action.md#LinkedVector2Behaviour
[LinkedVector2Behaviour]: SteamVRBehaviourVector2Action.md#LinkedVector2Behaviour
[LinkedVector2Behaviour]: SteamVRBehaviourVector2Action.md#LinkedVector2Behaviour
[LinkedVector2Behaviour]: SteamVRBehaviourVector2Action.md#LinkedVector2Behaviour
[LinkedVector2Behaviour]: SteamVRBehaviourVector2Action.md#LinkedVector2Behaviour
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[AxisValue]: #AxisValue
[LinkedVector2Behaviour]: #LinkedVector2Behaviour
[Methods]: #Methods
[ClearLinkedVector2Behaviour()]: #ClearLinkedVector2Behaviour
[Listener(SteamVR\_Behaviour\_Vector2, SteamVR\_Input\_Sources, Vector2, Vector2)]: #ListenerSteamVR\_Behaviour\_Vector2-SteamVR\_Input\_Sources-Vector2-Vector2
[OnAfterLinkedVector2BehaviourChange()]: #OnAfterLinkedVector2BehaviourChange
[OnBeforeLinkedVector2BehaviourChange()]: #OnBeforeLinkedVector2BehaviourChange
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[RegisterListeners()]: #RegisterListeners
[UnregisterListeners()]: #UnregisterListeners
