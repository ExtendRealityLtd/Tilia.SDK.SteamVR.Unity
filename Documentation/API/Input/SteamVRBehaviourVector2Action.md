# Class SteamVRBehaviourVector2Action

Listens for the linked Vector2 behavior and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
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

### Methods

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

Called after Tilia.SDK.SteamVR.Input.SteamVRBehaviourVector2Action.LinkedVector2Behaviour has been changed.

##### Declaration

```
protected virtual void OnAfterLinkedVector2BehaviourChange()
```

#### OnBeforeLinkedVector2BehaviourChange()

Called before Tilia.SDK.SteamVR.Input.SteamVRBehaviourVector2Action.LinkedVector2Behaviour has been changed.

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

Registers the listeners against the Tilia.SDK.SteamVR.Input.SteamVRBehaviourVector2Action.LinkedVector2Behaviour.

##### Declaration

```
protected virtual void RegisterListeners()
```

#### UnregisterListeners()

Unregisters the listeners against the Tilia.SDK.SteamVR.Input.SteamVRBehaviourVector2Action.LinkedVector2Behaviour.

##### Declaration

```
protected virtual void UnregisterListeners()
```

[Tilia.SDK.SteamVR.Input]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Listener(SteamVR\_Behaviour\_Vector2, SteamVR\_Input\_Sources, Vector2, Vector2)]: #ListenerSteamVR\_Behaviour\_Vector2-SteamVR\_Input\_Sources-Vector2-Vector2
[OnAfterLinkedVector2BehaviourChange()]: #OnAfterLinkedVector2BehaviourChange
[OnBeforeLinkedVector2BehaviourChange()]: #OnBeforeLinkedVector2BehaviourChange
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[RegisterListeners()]: #RegisterListeners
[UnregisterListeners()]: #UnregisterListeners
