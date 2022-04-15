# Class SteamVRBehaviourBooleanAction

Listens for the linked boolean behavior and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [LinkedBooleanBehaviour]
* [Methods]
  * [ClearLinkedBooleanBehaviour()]
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

### Properties

#### LinkedBooleanBehaviour

The SteamVR Boolean Behavior to link this action to.

##### Declaration

```
public SteamVR_Behaviour_Boolean LinkedBooleanBehaviour { get; set; }
```

### Methods

#### ClearLinkedBooleanBehaviour()

Clears [LinkedBooleanBehaviour].

##### Declaration

```
public virtual void ClearLinkedBooleanBehaviour()
```

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

Called after [LinkedBooleanBehaviour] has been changed.

##### Declaration

```
protected virtual void OnAfterLinkedBooleanBehaviourChange()
```

#### OnBeforeLinkedBooleanBehaviourChange()

Called before [LinkedBooleanBehaviour] has been changed.

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

Registers the listeners against the [LinkedBooleanBehaviour].

##### Declaration

```
protected virtual void RegisterListeners()
```

#### UnregisterListeners()

Unregisters the listeners against the [LinkedBooleanBehaviour].

##### Declaration

```
protected virtual void UnregisterListeners()
```

[Tilia.SDK.SteamVR.Input]: README.md
[LinkedBooleanBehaviour]: SteamVRBehaviourBooleanAction.md#LinkedBooleanBehaviour
[LinkedBooleanBehaviour]: SteamVRBehaviourBooleanAction.md#LinkedBooleanBehaviour
[LinkedBooleanBehaviour]: SteamVRBehaviourBooleanAction.md#LinkedBooleanBehaviour
[LinkedBooleanBehaviour]: SteamVRBehaviourBooleanAction.md#LinkedBooleanBehaviour
[LinkedBooleanBehaviour]: SteamVRBehaviourBooleanAction.md#LinkedBooleanBehaviour
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[LinkedBooleanBehaviour]: #LinkedBooleanBehaviour
[Methods]: #Methods
[ClearLinkedBooleanBehaviour()]: #ClearLinkedBooleanBehaviour
[Listener(SteamVR\_Behaviour\_Boolean, SteamVR\_Input\_Sources, Boolean)]: #ListenerSteamVR\_Behaviour\_Boolean-SteamVR\_Input\_Sources-Boolean
[OnAfterLinkedBooleanBehaviourChange()]: #OnAfterLinkedBooleanBehaviourChange
[OnBeforeLinkedBooleanBehaviourChange()]: #OnBeforeLinkedBooleanBehaviourChange
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[RegisterListeners()]: #RegisterListeners
[UnregisterListeners()]: #UnregisterListeners
