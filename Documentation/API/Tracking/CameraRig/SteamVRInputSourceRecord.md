# Class SteamVRInputSourceRecord

Provides the description for a SteamVR Input Source element. TODO: This is a very basic implementation that doesn't use any of the SteamVR library and relies on the Unity libraries. It needs updating to use the SteamVR mechanisms where possible.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [InputSource]
  * [Priority]
  * [XRNodeType]
* [Methods]
  * [ConvertFromInputSource(SteamVR\_Input\_Sources)]
  * [SetInputSourceType(Int32)]

## Details

##### Inheritance

* System.Object
* SteamVRInputSourceRecord

##### Namespace

* [Tilia.SDK.SteamVR.Tracking.CameraRig]

##### Syntax

```
public class SteamVRInputSourceRecord : BaseDeviceDetailsRecord
```

### Properties

#### InputSource

The SteamVR Input Source.

##### Declaration

```
public SteamVR_Input_Sources InputSource { get; set; }
```

#### Priority

##### Declaration

```
public override int Priority { get; protected set; }
```

#### XRNodeType

##### Declaration

```
public override XRNode XRNodeType { get; protected set; }
```

### Methods

#### ConvertFromInputSource(SteamVR\_Input\_Sources)

Converts an SteamVR\_Input\_Sources type to a Unity XRNode type.

##### Declaration

```
protected virtual XRNode ConvertFromInputSource(SteamVR_Input_Sources inputSource)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SteamVR\_Input\_Sources | inputSource | The input source type to convert. |

##### Returns

| Type | Description |
| --- | --- |
| XRNode | The converted type. |

#### SetInputSourceType(Int32)

Sets the [InputSource].

##### Declaration

```
public virtual void SetInputSourceType(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the SteamVR\_Input\_Sources. |

[Tilia.SDK.SteamVR.Tracking.CameraRig]: README.md
[InputSource]: SteamVRInputSourceRecord.md#InputSource
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[InputSource]: #InputSource
[Priority]: #Priority
[XRNodeType]: #XRNodeType
[Methods]: #Methods
[ConvertFromInputSource(SteamVR\_Input\_Sources)]: #ConvertFromInputSourceSteamVR\_Input\_Sources
[SetInputSourceType(Int32)]: #SetInputSourceTypeInt32
