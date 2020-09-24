# Class SteamVRActionHapticPulser

Creates a single haptic pulse on a SteamVR\_Input\_Sources supported haptic device.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Controller]
  * [Duration]
  * [Frequency]
  * [StartDelay]
  * [VibrationAction]
* [Methods]
  * [DoBegin()]
  * [DoCancel()]

## Details

##### Inheritance

* System.Object
* SteamVRActionHapticPulser

##### Namespace

* [Tilia.SDK.SteamVR.Haptics]

##### Syntax

```
public class SteamVRActionHapticPulser : HapticPulser
```

### Properties

#### Controller

The controller to pulse.

##### Declaration

```
public SteamVR_Input_Sources Controller { get; set; }
```

#### Duration

The duration to pulse [Controller] for.

##### Declaration

```
public float Duration { get; set; }
```

#### Frequency

The frequency between each pulse.

##### Declaration

```
public float Frequency { get; set; }
```

#### StartDelay

The duration to wait before starting the pulse.

##### Declaration

```
public float StartDelay { get; set; }
```

#### VibrationAction

The vibration action to activate.

##### Declaration

```
public SteamVR_Action_Vibration VibrationAction { get; set; }
```

### Methods

#### DoBegin()

##### Declaration

```
protected override void DoBegin()
```

#### DoCancel()

##### Declaration

```
protected override void DoCancel()
```

[Tilia.SDK.SteamVR.Haptics]: README.md
[Controller]: SteamVRActionHapticPulser.md#Controller
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Controller]: #Controller
[Duration]: #Duration
[Frequency]: #Frequency
[StartDelay]: #StartDelay
[VibrationAction]: #VibrationAction
[Methods]: #Methods
[DoBegin()]: #DoBegin
[DoCancel()]: #DoCancel
