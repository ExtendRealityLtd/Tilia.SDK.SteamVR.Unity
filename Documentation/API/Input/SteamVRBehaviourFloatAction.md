# Class SteamVRBehaviourFloatAction

Listens for the linked single behavior and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [AxisValue]
  * [LinkedSingleBehaviour]
* [Methods]
  * [ClearLinkedSingleBehaviour()]
  * [Listener(SteamVR\_Behaviour\_Single, SteamVR\_Input\_Sources, Single, Single)]
  * [OnAfterLinkedSingleBehaviourChange()]
  * [OnBeforeLinkedSingleBehaviourChange()]
  * [OnDisable()]
  * [OnEnable()]
  * [RegisterListeners()]
  * [UnregisterListeners()]

## Details

##### Inheritance

* System.Object
* SteamVRBehaviourFloatAction

##### Namespace

* [Tilia.SDK.SteamVR.Input]

##### Syntax

```
public class SteamVRBehaviourFloatAction : FloatAction
```

### Properties

#### AxisValue

The value to receive from the axis data.

##### Declaration

```
public SteamVRBehaviourFloatAction.ValueType AxisValue { get; set; }
```

#### LinkedSingleBehaviour

The SteamVR Single Behavior to link this action to.

##### Declaration

```
public SteamVR_Behaviour_Single LinkedSingleBehaviour { get; set; }
```

### Methods

#### ClearLinkedSingleBehaviour()

Clears [LinkedSingleBehaviour].

##### Declaration

```
public virtual void ClearLinkedSingleBehaviour()
```

#### Listener(SteamVR\_Behaviour\_Single, SteamVR\_Input\_Sources, Single, Single)

Processes the event and re-emits the data via the FloatAction.

##### Declaration

```
protected virtual void Listener(SteamVR_Behaviour_Single action, SteamVR_Input_Sources source, float value, float delta)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SteamVR\_Behaviour\_Single | action | The action raising the event. |
| SteamVR\_Input\_Sources | source | The source of the input. |
| System.Single | value | The value of the raised event. |
| System.Single | delta | The delta value between now and the previous raised event. |

#### OnAfterLinkedSingleBehaviourChange()

Called after [LinkedSingleBehaviour] has been changed.

##### Declaration

```
protected virtual void OnAfterLinkedSingleBehaviourChange()
```

#### OnBeforeLinkedSingleBehaviourChange()

Called before [LinkedSingleBehaviour] has been changed.

##### Declaration

```
protected virtual void OnBeforeLinkedSingleBehaviourChange()
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

Registers the listeners against the [LinkedSingleBehaviour].

##### Declaration

```
protected virtual void RegisterListeners()
```

#### UnregisterListeners()

Unregisters the listeners against the [LinkedSingleBehaviour].

##### Declaration

```
protected virtual void UnregisterListeners()
```

[Tilia.SDK.SteamVR.Input]: README.md
[SteamVRBehaviourFloatAction.ValueType]: SteamVRBehaviourFloatAction.ValueType.md
[LinkedSingleBehaviour]: SteamVRBehaviourFloatAction.md#LinkedSingleBehaviour
[LinkedSingleBehaviour]: SteamVRBehaviourFloatAction.md#LinkedSingleBehaviour
[LinkedSingleBehaviour]: SteamVRBehaviourFloatAction.md#LinkedSingleBehaviour
[LinkedSingleBehaviour]: SteamVRBehaviourFloatAction.md#LinkedSingleBehaviour
[LinkedSingleBehaviour]: SteamVRBehaviourFloatAction.md#LinkedSingleBehaviour
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[AxisValue]: #AxisValue
[LinkedSingleBehaviour]: #LinkedSingleBehaviour
[Methods]: #Methods
[ClearLinkedSingleBehaviour()]: #ClearLinkedSingleBehaviour
[Listener(SteamVR\_Behaviour\_Single, SteamVR\_Input\_Sources, Single, Single)]: #ListenerSteamVR\_Behaviour\_Single-SteamVR\_Input\_Sources-Single-Single
[OnAfterLinkedSingleBehaviourChange()]: #OnAfterLinkedSingleBehaviourChange
[OnBeforeLinkedSingleBehaviourChange()]: #OnBeforeLinkedSingleBehaviourChange
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[RegisterListeners()]: #RegisterListeners
[UnregisterListeners()]: #UnregisterListeners
