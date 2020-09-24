# Class SteamVRBehaviourVelocityEstimator

Retrieves the velocity and angular velocity from the specific SteamVR\_Behaviour\_Pose.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [RelativeTo]
  * [VelocitySource]
* [Methods]
  * [DoGetAngularVelocity()]
  * [DoGetVelocity()]
  * [IsActive()]

## Details

##### Inheritance

* System.Object
* SteamVRBehaviourVelocityEstimator

##### Namespace

* [Tilia.SDK.SteamVR.Tracking.Velocity]

##### Syntax

```
public class SteamVRBehaviourVelocityEstimator : VelocityTracker
```

### Properties

#### RelativeTo

An optional GameObject to consider the source relative to when retrieving velocities.

##### Declaration

```
public GameObject RelativeTo { get; set; }
```

#### VelocitySource

The SteamVR\_Behaviour\_Pose to track velocity for.

##### Declaration

```
public SteamVR_Behaviour_Pose VelocitySource { get; set; }
```

### Methods

#### DoGetAngularVelocity()

##### Declaration

```
protected override Vector3 DoGetAngularVelocity()
```

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | n/a |

#### DoGetVelocity()

##### Declaration

```
protected override Vector3 DoGetVelocity()
```

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | n/a |

#### IsActive()

##### Declaration

```
public override bool IsActive()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

[Tilia.SDK.SteamVR.Tracking.Velocity]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[RelativeTo]: #RelativeTo
[VelocitySource]: #VelocitySource
[Methods]: #Methods
[DoGetAngularVelocity()]: #DoGetAngularVelocity
[DoGetVelocity()]: #DoGetVelocity
[IsActive()]: #IsActive
