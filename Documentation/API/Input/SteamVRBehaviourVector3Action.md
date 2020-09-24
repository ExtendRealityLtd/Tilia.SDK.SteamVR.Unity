# Class SteamVRBehaviourVector3Action

Listens for the linked Vector3 behavior and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
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

### Methods

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

Called after Tilia.SDK.SteamVR.Input.SteamVRBehaviourVector3Action.LinkedVector3Behaviour has been changed.

##### Declaration

```
protected virtual void OnAfterLinkedVector3BehaviourChange()
```

#### OnBeforeLinkedVector3BehaviourChange()

Called before Tilia.SDK.SteamVR.Input.SteamVRBehaviourVector3Action.LinkedVector3Behaviour has been changed.

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

Registers the listeners against the Tilia.SDK.SteamVR.Input.SteamVRBehaviourVector3Action.LinkedVector3Behaviour.

##### Declaration

```
protected virtual void RegisterListeners()
```

#### UnregisterListeners()

Unregisters the listeners against the Tilia.SDK.SteamVR.Input.SteamVRBehaviourVector3Action.LinkedVector3Behaviour.

##### Declaration

```
protected virtual void UnregisterListeners()
```

[Tilia.SDK.SteamVR.Input]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Listener(SteamVR\_Behaviour\_Vector3, SteamVR\_Input\_Sources, Vector3, Vector3)]: #ListenerSteamVR\_Behaviour\_Vector3-SteamVR\_Input\_Sources-Vector3-Vector3
[OnAfterLinkedVector3BehaviourChange()]: #OnAfterLinkedVector3BehaviourChange
[OnBeforeLinkedVector3BehaviourChange()]: #OnBeforeLinkedVector3BehaviourChange
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[RegisterListeners()]: #RegisterListeners
[UnregisterListeners()]: #UnregisterListeners
