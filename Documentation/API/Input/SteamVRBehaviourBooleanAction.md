# Class SteamVRBehaviourBooleanAction

Listens for the linked boolean behavior and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [Listener(SteamVR\_Behaviour\_Boolean, SteamVR\_Input\_Sources, Boolean)]
  * [OnAfterLinkedBooleanBehaviourChange()]
  * [OnBeforeLinkedBooleanBehaviourChange()]
  * [OnDisable()]
  * [OnEnable()]
  * [RegisterListeners()]
  * [UnregisterListeners()]

## Details

##### Inheritance

* System.Object
* SteamVRBehaviourBooleanAction

##### Namespace

* [Tilia.SDK.SteamVR.Input]

##### Syntax

```
public class SteamVRBehaviourBooleanAction : BooleanAction
```

### Methods

#### Listener(SteamVR\_Behaviour\_Boolean, SteamVR\_Input\_Sources, Boolean)

Processes the event and re-emits the data via the BooleanAction.

##### Declaration

```
protected virtual void Listener(SteamVR_Behaviour_Boolean action, SteamVR_Input_Sources source, bool value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SteamVR\_Behaviour\_Boolean | action | The action raising the event. |
| SteamVR\_Input\_Sources | source | The source of the input. |
| System.Boolean | value | The value of the raised event. |

#### OnAfterLinkedBooleanBehaviourChange()

Called after Tilia.SDK.SteamVR.Input.SteamVRBehaviourBooleanAction.LinkedBooleanBehaviour has been changed.

##### Declaration

```
protected virtual void OnAfterLinkedBooleanBehaviourChange()
```

#### OnBeforeLinkedBooleanBehaviourChange()

Called before Tilia.SDK.SteamVR.Input.SteamVRBehaviourBooleanAction.LinkedBooleanBehaviour has been changed.

##### Declaration

```
protected virtual void OnBeforeLinkedBooleanBehaviourChange()
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

Registers the listeners against the Tilia.SDK.SteamVR.Input.SteamVRBehaviourBooleanAction.LinkedBooleanBehaviour.

##### Declaration

```
protected virtual void RegisterListeners()
```

#### UnregisterListeners()

Unregisters the listeners against the Tilia.SDK.SteamVR.Input.SteamVRBehaviourBooleanAction.LinkedBooleanBehaviour.

##### Declaration

```
protected virtual void UnregisterListeners()
```

[Tilia.SDK.SteamVR.Input]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Listener(SteamVR\_Behaviour\_Boolean, SteamVR\_Input\_Sources, Boolean)]: #ListenerSteamVR\_Behaviour\_Boolean-SteamVR\_Input\_Sources-Boolean
[OnAfterLinkedBooleanBehaviourChange()]: #OnAfterLinkedBooleanBehaviourChange
[OnBeforeLinkedBooleanBehaviourChange()]: #OnBeforeLinkedBooleanBehaviourChange
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[RegisterListeners()]: #RegisterListeners
[UnregisterListeners()]: #UnregisterListeners
